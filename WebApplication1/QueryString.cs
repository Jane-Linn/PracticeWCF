using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service1
{
    public static class QueryString
    {
        public static string SearchByStockId { get; set; } = $@"SELECT  [RecordID]
                                                          ,[日期]
                                                          ,[股票代號]
                                                          ,[股票名稱]
                                                          ,[參考價]
                                                          ,[開盤價]
                                                          ,[最高價]
                                                          ,[最低價]
                                                          ,[收盤價]
                                                      FROM[StockDb].[dbo].[日收盤] Where 股票代號 = @Input ";
        public static string SearchByDate { get; set; } = $@"SELECT  [RecordID]
                                                          ,[日期]
                                                          ,[股票代號]
                                                          ,[股票名稱]
                                                          ,[參考價]
                                                          ,[開盤價]
                                                          ,[最高價]
                                                          ,[最低價]
                                                          ,[收盤價]
                                                      FROM[StockDb].[dbo].[日收盤] Where 日期 = @Input ";
    }
}