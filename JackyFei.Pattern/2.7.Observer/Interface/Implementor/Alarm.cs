using System;

namespace Jacky.Pattern
{
    /// <summary>
    /// 警报
    /// </summary>
    public class Alarm : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Alarm".PadRight(7) + ":嘟嘟嘟,水开了。");
        }
    }
}