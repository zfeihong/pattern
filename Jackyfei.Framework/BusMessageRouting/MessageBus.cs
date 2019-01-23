using Jackyfei.Framework.BusMessageRouting.Entity;

namespace Jackyfei.Framework.BusMessageRouting
{
    /// <summary>
    /// 消息总线对象
    /// </summary>
    public class MessageBus
    {
        public static TResult SendBusAndAction<TResult>(Message message)
        {
            //根据请求KEY，获取对应的服务处理句柄
            ServiceOperationHandler handler =
                ServiceRouting.GlobalRouting.GetRequestOperationHandler(message.Header.RequestKey);

            object result = null;

            //执行远程服务
            handler(message.Body, ref result);

            //泛型编程中 default(TResult)
            //就是返回TResult的默认值。
            //比如TResult的类型是int类型的，那么这个default(TResult)的值就是0的
            //引用类型会得到Null
            if (result == null)
                return default(TResult);

            return (TResult) result;

        }
    }
}