using System;

namespace Jacky.Pattern
{
    /// <summary>
    /// 显示屏
    /// </summary>
    public class Screen:IObserver
    {

        public void Update()
        {
            Console.WriteLine("Screen".PadRight(7)+":水开了。");
        }
    }
}