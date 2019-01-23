using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using DotNet.Delegate;
using DotNet.Delegate.Event;
using DotNet.Net;
using DotNet.Reflection;
using Oncefly.StrongName.Common;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //=============================observable模式里的委托===============================//
            //BasketBallPlayer player = new BasketBallPlayer();
            ////player.Scored += Viewer.Cheer;       //此处也可以用匿名方法,如下所示
            //player.Scored += (obj, e) =>
            //{
            //    Console.WriteLine(e.Score + "分进账!");
            //    Console.WriteLine("又涨分了\n");
            //    Console.WriteLine();
            //};

            //player.Scored += Counter.Counting;

            ////事件应该由事件发布者触发，而不应该由客户端（客户程序）来触发，这样才是事件的本意，事件的封装才会更好
            //player.Shoot();


            //Publisher pub=new Publisher();
            //Subscriber1 subscriber1=new Subscriber1();
            //Subscriber2 subscriber2 = new Subscriber2();

            ////pub.NumberChanged -= subscriber1.OnNumberChanged;
            //pub.NumberChanged += subscriber2.OnNumberChanged;
            //pub.NumberChanged += subscriber1.OnNumberChanged;

            //pub.DoSomething();

            //Publisher pub = new Publisher();
            //Subscriber1 subscriber1 = new Subscriber1();
            //Subscriber2 subscriber2 = new Subscriber2();
            //Subscriber3 subscriber3 = new Subscriber3();

            //pub.NumberChanged2 += subscriber1.OnNumberChanged;
            //pub.NumberChanged2 += subscriber2.OnNumberChanged;
            //pub.NumberChanged2 += subscriber3.OnNumberChanged;

            //List<string> list = pub.DoSomething2();
            //foreach (var str in list)
            //{
            //    Console.WriteLine(str);
            //}

            //=============================强名称程序集===============================//
            //Oncefly.StrongName.Common.TestClass test=new TestClass();
            //Console.WriteLine(test.GetWord());
            //TcpClass.RunTcpListener();

            //=============================反射枚举+泛型===============================//
            //EnumManager<BookingStatus>.SetDropDownList(ddlBookingStatus);
            //EnumManager<TIcketStatus>.SetDropDownList(rblTicketStatus);

            //=============================反射特性===============================//
            //Type t = typeof(Calculator);
            //object[] records = t.GetCustomAttributes(typeof (RecordAttribute), false);

            //foreach (RecordAttribute record in records)
            //{
            //    Console.WriteLine("{0}", record);
            //    Console.WriteLine(" 类型：{0}", record.RecordType);
            //    Console.WriteLine(" 作者：{0}", record.Author);
            //    Console.WriteLine(" 日期：{0}", record.Date.ToShortDateString());
            //    Console.WriteLine(" 备注：{0}", record.Memo);
            //}

            //使用无参构造函数创造对象
            //1创建对象一
            //Assembly am = Assembly.GetExecutingAssembly();
            //Calculator calculator= am.CreateInstance("DotNet.Reflection.Calculator", true) as Calculator;
            //Console.WriteLine(calculator.GetStr());
            ////2创建对象二
            ////第一个参数是程序集的名称，null表示当前程序集；
            //ObjectHandle handler = Activator.CreateInstance(null, "DotNet.Reflection.Calculator");
            //handler.Unwrap();

            ////使用有参构造函数创造对象
            //Assembly am2 = Assembly.GetExecutingAssembly();
            //Object[] parameters=new object[2];
            //parameters[0] = 3;
            //parameters[1] = 5;

            //am2.CreateInstance("DotNet.Reflection.Calculator", true, BindingFlags.Default, null, parameters, null, null);

            Type t = typeof (Calculator);
            Calculator c=new Calculator(3,5);
            //int rst =(int)t.InvokeMember("Add", BindingFlags.InvokeMethod, null, c, null);
            //Console.WriteLine("x+y={0}", rst);

            //object[] p = {6, 7};
            //int rst2 = (int)t.InvokeMember("Add", BindingFlags.InvokeMethod, null, t, p);
            //Console.WriteLine("x+y={0}", rst2);

            MethodInfo mi = t.GetMethod("Add", BindingFlags.Instance | BindingFlags.Public);
            int rst = (int)mi.Invoke(c, null);
            Console.WriteLine("x+y={0}", rst);

            object[] p = { 6, 9 };
            MethodInfo mi2 = t.GetMethod("Add", BindingFlags.Static | BindingFlags.Public);
            int rst2 = (int)mi2.Invoke(null, p);
            Console.WriteLine("x+y={0}", rst2);

            Console.Read(); 
        }
    }
}
