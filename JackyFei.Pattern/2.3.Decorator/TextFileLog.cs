using System;

namespace JackyFei.Pattern
{
    public class TextFileLog : Log
    {
        public override void Write(string log)
        {
            Console.WriteLine("记录到文本文件中");
            //......记录到文本文件中
        }
    }
}