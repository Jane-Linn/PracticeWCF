using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    [ServiceContract]
    public interface IService
    {
        //DataSet
        //[OperationContract]
        //DataSet SearchByStockId(string stockId);
        //[OperationContract]
        //DataSet SearchByDate(string date);
        //TCP Json
        [OperationContract]
        Task<StockInfo[]> SearchByStockIdJson(string stockId);
        [OperationContract]
        Task<StockInfo[]> SearchByDateJson(string date);

    }

   
}

