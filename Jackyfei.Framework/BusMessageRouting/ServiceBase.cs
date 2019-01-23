namespace Jackyfei.Framework.BusMessageRouting
{
    /// <summary>
    /// 服务基类：对所有需要实现的服务进行统一注册约定
    /// </summary>
    public abstract class ServiceBase
    {
        public void Register()
        {
            this.RegisterServiceRequest(ServiceRegister.GlobalRegister);
        }


        /// <summary>
        /// 所有的服务必须实现此方法，用来添加处理请求
        /// </summary>
        /// <param name="register"></param>
        protected abstract void RegisterServiceRequest(ServiceRegister register);

    }
}