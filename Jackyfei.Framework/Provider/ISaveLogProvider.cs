namespace Jackyfei.Framework.Provider
{
    /// <summary>
    /// 该接口仅仅在内部使用，编写提供程序者无需知道细节
    /// 我们不能提供一个接口让框架使用者自己去实现所有的东西，一些基础性的功能，我们有必要在框架内完成。
    /// 带有部分实现功能的抽象类再合适不过了。
    /// </summary>
    public interface ISaveLogProvider
    {
        bool SaveLog(LogEntity entity);
    }
}