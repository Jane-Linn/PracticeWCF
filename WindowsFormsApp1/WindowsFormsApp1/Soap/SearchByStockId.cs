using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.LocalServer;
using WindowsFormsApp1.RemoteServer;
using StockInfo = WindowsFormsApp1.LocalServer.StockInfo;

namespace WindowsFormsApp1
{
    class SearchByStockId: ISearch
    {
        private TextBox StockId;
        private TextBox TimeConsume;
        public SearchByStockId(TextBox stockId, TextBox timeConsume)
        {
            StockId = stockId;
            TimeConsume = timeConsume;
        }
        public List<StockInfo> LocalSearchJson(Stopwatch stopwatch, LocalServer.ServiceClient client)
        {
            stopwatch.Restart();
            StockInfo[] stockInfo = client.SearchByStockIdJson(StockId.Text);

            //計時結束
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            string strTime = time.ToString(@"hh\:mm\:ss\.fff");
            TimeConsume.AppendText("耗時" + strTime + "\r\n");
            return stockInfo.ToList();
        }
        //public List<StockInfo> RemoteSearchJson(Stopwatch stopwatch, RemoteServer.ServiceClient client)
        //{
        //    //計時開始
        //    stopwatch.Restart();
        //    StockInfo[] stockInfo = client.SearchByStockIdJson(StockId.Text);

        //    //計時結束
        //    stopwatch.Stop();
        //    TimeSpan time = stopwatch.Elapsed;
        //    string strTime = time.ToString(@"hh\:mm\:ss\.fff");
        //    TimeConsume.AppendText("耗時" + strTime + "\r\n");
        //    return stockInfo.ToList();
        //}

        //public DataSet RemoteSearch(Stopwatch stopwatch)
        //{
        //    Console.WriteLine("輸入" + StockId);
        //    stopwatch.Restart();
        //    RemoteServer.ServiceClient client = new RemoteServer.ServiceClient("RemoteTcpEndpoint");
        //    DataSet dataSet = client.SearchByStockId(StockId.Text);
        //    stopwatch.Stop();
        //    TimeSpan time = stopwatch.Elapsed;
        //    string strTime = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds);
        //    Console.WriteLine("耗時" + strTime + "\r\n");
        //    return dataSet;
        //}

        //public DataSet LocalSearch(Stopwatch stopwatch)
        //{
        //    Console.WriteLine("輸入"+StockId);
        //    stopwatch.Restart();
        //    LocalServer.ServiceClient client = new LocalServer.ServiceClient("LocalTcpEndpoint");
        //    DataSet dataSet= client.SearchByStockId(StockId.Text);
        //    stopwatch.Stop();
        //    TimeSpan time = stopwatch.Elapsed;
        //    string strTime = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds);
        //    Console.WriteLine("耗時" + strTime + "\r\n");
        //    return dataSet;
        //}

    }
}
