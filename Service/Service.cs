using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace Service1
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "Service"。
    public class Service : IService
    {
        public string GetData(string value)
        {
            return String.Format("you input {0}", value);
        }
    }

}
