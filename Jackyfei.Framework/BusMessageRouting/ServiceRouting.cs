namespace Jackyfei.Framework.BusMessageRouting
{
    /// <summary>
    /// 服务路由：提供对服务注册器的访问
    /// </summary>
    public class ServiceRouting
    {
        public static  ServiceRouting GlobalRouting=new ServiceRouting();
        
        /// <summary>
        /// 获取请求处理句柄，也就是相对应的处理服务
        /// </summary>
        /// <param name="requestKey"></param>
        /// <returns></returns>
        public ServiceOperationHandler GetRequestOperationHandler(string requestKey)
        {
            return ServiceRegister.GlobalRegister.GetOperationHandler(requestKey);
        }
    }
}