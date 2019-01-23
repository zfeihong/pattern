using System;

namespace DotNet.Delegate.Event
{
    public class Subscriber1
    {
        public string OnNumberChanged()
        {
            Console.WriteLine("Subscriber1 Invoked!");
            return "Subscriber1";
        }

        public string OnNumberChanged(int num)
        {
            Console.WriteLine("Subscriber1 Invoked,number:{0}",num);
            return "[Subscriber1 returned]";
        }
    }

    public class Subscriber2
    {
        public string OnNumberChanged()
        {
            Console.WriteLine("Subscriber2 Invoked!");
            return "Subscriber2";
        }

        public string OnNumberChanged(int num)
        {
            Console.WriteLine("Subscriber2 Invoked,number:{0}", num);
            return "[Subscriber2 returned]";
        }
    }

    public class Subscriber3
    {
        public string OnNumberChanged()
        {
            Console.WriteLine("Subscriber3 Invoked!");
            return "Subscriber3";
        }

        public string OnNumberChanged(int num)
        {
            Console.WriteLine("Subscriber3 Invoked,number:{0}", num);
            return "[Subscriber3 returned]";
        }
    }
}