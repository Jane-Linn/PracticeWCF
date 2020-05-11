using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace Service1
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IService"。
    [ServiceContract]
    public interface IService
    {
        // TODO: 在此新增您的服務作業
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/input/{value}")]
        string GetData(string value);
    }

    //使用下列範例中所示的資料合約，新增複合型別至服務作業。
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public string InputValue { get; set; }
    }
}

