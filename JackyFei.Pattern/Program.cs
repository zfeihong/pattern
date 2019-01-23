using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JackyFei.Pattern;
using JackyFei.Pattern._2.Prototype;

namespace Jacky.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //====================1.1.单例模式=======================//
            var singleton = Singleton.Singleton.GetInstance();

            //====================1.2.原型模式=======================//
            //Student s1 = new Student("001", "张三");
            //Student s2 = (Student)s1.Clone();
            //s2.Sno = "002";
            //s2.Name = "李四";
            //s1.Print();
            //s2.Print();

            //Student2 s1 = new Student2("001", "张三");
            //s1.SetFeature("男",18);

            //Student2 s2 = (Student2)s1.Clone();
            //s2.Sno = "002";
            //s2.Name = "李四";
            //s2.SetFeature("男", 30);

            //s1.Print();
            //s2.Print();

            //====================1.2.Builder模式=======================//
            //ThinPerson tp = new ThinPerson(null, new Pen(Color.Red));
            //PersonDirector pd = new PersonDirector(tp);
            //pd.CreatePerson();

            //====================2.7.Observer模式=======================//

            //BasketBallPlayer player = new BasketBallPlayer();
            ////player.Scored += Viewer.Cheer;       //此处也可以用匿名方法,如下所示
            //player.Scored += (obj, e) =>
            //{
            //    Console.WriteLine(e.Score + "分进账!");
            //    Console.WriteLine("观众欢呼MVP\n");
            //    Console.WriteLine();
            //};
            //Console.WriteLine("Client application started! ");

            ////player.Scored += Counter.Counting;

            ////事件应该由事件发布者触发，而不应该由客户端（客户程序）来触发，这样才是事件的本意，事件的封装才会更好
            //player.Shoot();


            //Heater heater = new Heater();
            //Screen screen = new Screen();
            ////Alarm alarm = new Alarm();

            //heater.Register(screen);
            ////heater.Register(alarm);

            //heater.BoilWater();

            //====================2.3.Decorator模式=======================//
            Log log = new DatabaseLog();
            //LogWrapper lew1 = new LogErrorWrapper(log);
            ////扩展了记录错误严重级别
            //lew1.Write("Log Message");

            //LogPriorityWrapper lpw1 = new LogPriorityWrapper(log);
            ////扩展了记录优先级别
            //lpw1.Write("Log Message");
             

            LogWrapper lew2 = new LogErrorWrapper(log);
            LogPriorityWrapper lpw2 = new LogPriorityWrapper(lew2); //这里是lew2
            //同时扩展了错误严重级别和优先级别
            lpw2.Write("Log Message");
            Console.ReadLine();
        }
    }
}
