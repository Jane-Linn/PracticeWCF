using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.LocalServer;
using WindowsFormsApp1.RemoteServer;
using StockInfo = WindowsFormsApp1.LocalServer.StockInfo;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private RemoteServer.ServiceClient RemoteClient;
        private LocalServer.ServiceClient LocalClient;
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            RemoteClient = new RemoteServer.ServiceClient("RemoteTcpEndpoint");
            LocalClient = new LocalServer.ServiceClient("LocalTcpEndpoint");
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //ISearch search = (ISearch)button.Tag;
            //DataSet dataSet = search.LocalSearch(stopwatch);
            //dataGridView1.DataSource = dataSet.Tables["stockTable"];

            //Button button = (Button)sender;
            //ISearch search = (ISearch)button.Tag;
            //List<StockInfo> stockInfos = new List<StockInfo>();
            //stockInfos = search.RemoteSearchJson(stopwatch, RemoteClient);
            //dataGridView1.DataSource = stockInfos;

            Button button = (Button)sender;
            ISearch search = (ISearch)button.Tag;
            List<StockInfo> stockInfos = new List<StockInfo>();
            stockInfos = search.LocalSearchJson(stopwatch, LocalClient);
            dataGridView1.DataSource = stockInfos;

        }


    }
}
