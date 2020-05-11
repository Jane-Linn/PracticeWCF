using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Service1
{
    [DataContract]
    public class StockInfo
    {
        [DataMember]
        public string RecordId { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string StockId { get; set; }
        [DataMember]
        public string StockName { get; set; }
        [DataMember]
        public decimal RefPrice { get; set; }
        [DataMember]
        public decimal OpenPrice { get; set; }
        [DataMember]
        public decimal HighestPrice { get; set; }
        [DataMember]
        public decimal LowestPrice { get; set; }
        [DataMember]
        public decimal ClosePrice { get; set; }
    }
}