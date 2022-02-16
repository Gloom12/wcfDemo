using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WCFPublic.Interface
{
    /// <summary>
    /// wcf接口
    /// </summary>
    [ServiceContract(Name = "WCFDemo")]
    public interface InterfaceDemo
    {
        [OperationContract]
        string SendMassege(string massege);
        [OperationContract]
        string ReadMassege(string massege);
        
    }
}
