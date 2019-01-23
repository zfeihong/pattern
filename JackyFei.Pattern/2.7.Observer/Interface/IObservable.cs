namespace Jacky.Pattern
{
    /// <summary>
    /// 被观察者
    /// </summary>
    public interface IObservable
    {
        void Register(IObserver obj);
        void UnRegister(IObserver obj);
    }
}