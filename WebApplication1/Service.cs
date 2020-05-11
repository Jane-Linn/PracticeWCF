using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Service : IService
    {
        private string ConnenctionString = "Persist Security Info = False; User ID = sa; Password = 7319; Initial Catalog = AdventureWorks; database=StockDb;Server = CMONEYTEST99 ";
        private int CallCount = 0;
        private int SqlCount = 0;
        private MemoryCache Cache = MemoryCache.Default;


        private CacheItemPolicy CacheItemPolicy = new CacheItemPolicy()
        {
            SlidingExpiration = new TimeSpan(0, 0, 30)
        };

        public async Task<StockInfo[]> SearchByDateJson(string date)
        {
            return await GetFromCache(date, QueryString.SearchByDate);
        }

        public async Task<StockInfo[]> SearchByStockIdJson(string stockId)
        {
            return await GetFromCache(stockId, QueryString.SearchByStockId);
        }

        public async Task<StockInfo[]> GetFromCache(string input, string queryString)
        {
            CallCount = Interlocked.Increment(ref CallCount);
            Console.WriteLine($"服務被呼叫次數: { CallCount}  時間: {DateTime.Now}");
            Lazy<Task<StockInfo[]>> stockInfoTaskLazy = new Lazy<Task<StockInfo[]>>(() => SearchDatabaseJson(input, queryString));
            var old = Cache.AddOrGetExisting(input, stockInfoTaskLazy, CacheItemPolicy);
            if (old == null)
            {
                Console.WriteLine("建立快取");
                return await stockInfoTaskLazy.Value;
            }
            else
            {
                Console.WriteLine("拿快取");
                return await (old as Lazy<Task<StockInfo[]>>).Value;
            }



            //if (Cache[input].GetType().Equals(typeof(Lazy<Task>)))
            //{
            //    await ((Lazy<Task>)Cache[input]).Value;
            //}

            //Console.WriteLine("服務Done");
            //return Cache.Get(input) as StockInfo[];
        }

        //public async Task<StockInfo> RefreshCacheAsync(string input, string queryString)
        //{

        //    StockInfo[] stockInfos = await SearchDatabaseJson(input, queryString);
        //    return stockInfos;
        //        //Cache[input] = stockInfos;
        //}

        private async Task<StockInfo[]> SearchDatabaseJson(string searchString, string queryString)
        {
            SqlCount = Interlocked.Increment(ref SqlCount);
            Console.WriteLine("查sql次數: " + SqlCount);
            await Task.Delay(10000);
            return DoSql().ToArray();
            //區域方法
            IEnumerable<StockInfo> DoSql()
            {

                using (SqlConnection sqlConnection = new SqlConnection(ConnenctionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Input", searchString);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    StockInfo stockInfo = new StockInfo();
                                    stockInfo.RecordId = reader.IsDBNull(0) ? "NULL" : reader.GetInt64(0).ToString();
                                    stockInfo.Date = reader.GetString(1);
                                    stockInfo.StockId = reader.GetString(2);
                                    stockInfo.StockName = reader.IsDBNull(3) ? "NULL" : reader.GetString(3);
                                    stockInfo.RefPrice = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                                    stockInfo.OpenPrice = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                                    stockInfo.HighestPrice = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                                    stockInfo.LowestPrice = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
                                    stockInfo.ClosePrice = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
                                    yield return stockInfo;
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}
