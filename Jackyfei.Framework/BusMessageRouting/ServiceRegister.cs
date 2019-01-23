using System.Collections.Generic;

namespace Jackyfei.Framework.BusMessageRouting
{

    public delegate void ServiceOperationHandler(object parameter,ref object result);

    /// <summary>
    /// 服务注册器，用来在总线中注册服务并且保存了所有已经注册过的服务
    /// </summary>
    public class ServiceRegister:Dictionary<string,ServiceOperationHandler>
    {
        public static  ServiceRegister GlobalRegister=new ServiceRegister();

        public void Register(string registerKey, ServiceOperationHandler handler)
        {
            if (this.ContainsKey(registerKey))
            {
                this[registerKey] = handler;
            }
            else
            {
                this.Add(registerKey,handler);
            }
        }

        public ServiceOperationHandler GetOperationHandler(string requestKey)
        {
            if (this.ContainsKey(requestKey))
            {
                return this[requestKey];
            }
            return null;
        }


    }
}