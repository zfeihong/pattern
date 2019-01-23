using System.Collections.Generic;
using System.Linq;

namespace Jacky.Pattern
{
    /// <summary>
    /// 被观察者主题基类
    /// </summary>
    public abstract class SubjectBase:IObservable
    {
        private readonly List<IObserver> _container = new List<IObserver>();

         public void Register(IObserver obj)
         {
             _container.Add(obj);
         }

         public void UnRegister(IObserver obj)
         {
             _container.Remove(obj);
         }

        protected virtual void Notify()
        {
            if (!_container.Any()) return;
            foreach (IObserver observer in _container)
            {
                observer.Update();
            }
        }
    }
}