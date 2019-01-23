namespace Jacky.Pattern.Singleton
{
    /// <summary>
    /// 单例模式:一个类只能有一个实例化对象
    /// 使用场景:定时器，计数器 或者一个项目只要一个共享访问点和共享数据；创建对象消耗资源比较多，如IO操作和数据库读取 
    /// sealed修饰确保该类不被继承，不被派生
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _singleton = null;
        //确保线程安全
        private static readonly object Object = new object();

        //确保不能在外部被实例化
        private Singleton(){}

        //确保内部实例化
        public static Singleton GetInstance()
        {
            lock (Object)
            {
                _singleton = _singleton ?? new Singleton();
                return _singleton;
            }
        }
    }
}