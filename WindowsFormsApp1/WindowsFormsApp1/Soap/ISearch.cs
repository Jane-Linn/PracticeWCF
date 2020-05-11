using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.LocalServer;
using WindowsFormsApp1.RemoteServer;
using StockInfo = WindowsFormsApp1.LocalServer.StockInfo;

namespace WindowsFormsApp1
{
    interface ISearch
    {
        //DataSet LocalSearch(Stopwatch stopwatch);
        List<StockInfo> LocalSearchJson(Stopwatch stopwatch, LocalServer.ServiceClient client);
        //DataSet RemoteSearch(Stopwatch stopwatch);
        //List<StockInfo> RemoteSearchJson(Stopwatch stopwatch, RemoteServer.ServiceClient client);
    }
}
