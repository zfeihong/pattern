using System;

namespace DotNet.Reflection
{
    [Record("更新", "jackyfei", "2016-08-24")]
    [Record("创建", "张飞洪", "2016-08-14", Memo = "这个类是演示用的")]
    public class Calculator
    {
        private int x;
        private int y;

        public Calculator()
        {
            x = 0;
            y = 0;
            Console.WriteLine("x:{0},y:{1}", x, y);
        }

        public Calculator(int x,int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("x:{0},y:{1}",x,y);
        }

        public string GetStr()
        {
            return "hello,jackyfei";
        }

        public int Add()
        {
            int total = 0;
            total = x + y;
            return total;
        }

        public static int Add(int x,int y)
        {
            int total = x + y;
            return total;
        }

    }
}