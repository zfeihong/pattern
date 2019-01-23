using System;

namespace JackyFei.Pattern
{
    public class DatabaseLog : Log
    {
        public override void Write(string log)
        {
            Console.WriteLine("记录到数据库中");
            //......记录到数据库中
        }

    }
}