using System;

namespace Jacky.Pattern.Proxy
{
    public class Proxy : Subject
    {
        // Fields
        private RealSubject realSubject;

        // Methods
        override public void Request()
        {
            // Uses "lazy initialization"
            if (realSubject == null)
                realSubject = new RealSubject();

            preRequest();
            realSubject.Request();
            postRequest();
        }

        public void preRequest()
        { Console.WriteLine("PreRequest."); }

        public void postRequest()
        { Console.WriteLine("PostRequest."); }
    }
}