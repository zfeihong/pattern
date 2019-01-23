namespace Jackyfei.Framework.PipeLine
{
    /// <summary>
    /// 这里使用工厂创建类型的目的：因为我们的类型是字符串型的
    /// 这样可以防止人为错误的发生，这是一个很好的设计方式。
    /// </summary>
    public class RequestClientTypeFactory
    {
        public static RequestClientType CreateClientTypeForApp()
        {
            return new RequestClientType(){ Type = RequestClientType.App};
        }

        public static RequestClientType CreaRequestClientTypeForNet2()
        {
            return new RequestClientType(){Type = RequestClientType.NetClient};
        }
    }
}