using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JackyFei.Config.Config;
using JackyFei.Config.Config.DynamicConfig;
using JackyFei.Config.CustomConfig;
using JackyFei.Config.ManagerConfig;
using JackyFei.Config.Strategy;

namespace JackyFei.Config
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------1内置节点-----------------------");
            var val = ConfigurationManager.AppSettings["MailServer"];
            var user = ConfigurationManager.AppSettings["MailUser"];
            var pwd = ConfigurationManager.AppSettings["MailPassword"];
            Console.WriteLine("MailServer:" + val);
            Console.WriteLine("MailUser:" + user);
            Console.WriteLine("MailPassword:" + pwd);
            Console.WriteLine("\r");

            Console.WriteLine("----------------------2自定义节点,内置处理程序-----------------------");
            Hashtable mailServer = (Hashtable)ConfigurationManager.GetSection("mailServer");
            Console.WriteLine("address:" + mailServer["address"].ToString());
            Console.WriteLine("userName:" + mailServer["userName"].ToString());
            Console.WriteLine("password:" + mailServer["password"].ToString());
            Console.WriteLine("\r");


            Console.WriteLine("-----------3自定义节点,自定义处理程序 IConfigurationSectionHandler--------------");
            MailServerConfig mailConfig = (MailServerConfig)ConfigurationManager.GetSection("mailServerGroup");
            Console.WriteLine("provider:" + mailConfig.Provider);
            Console.WriteLine("\r");

            Console.WriteLine("client1:" + mailConfig[0].Client);
            Console.WriteLine("address1:" + mailConfig[0].Address);
            Console.WriteLine("userName1:" + mailConfig[0].UserName);
            Console.WriteLine("password1:" + mailConfig[0].Password);
            Console.WriteLine("\r");

            Console.WriteLine("client2:" + mailConfig[1].Client);
            Console.WriteLine("address2:" + mailConfig[1].Address);
            Console.WriteLine("userName2:" + mailConfig[1].UserName);
            Console.WriteLine("password2:" + mailConfig[1].Password);
            Console.WriteLine("\r");

            Console.WriteLine("----------3自定义节点,自定义处理程序 ConfigurationSection------------");
            MailServerSection mailSection = (MailServerSection)ConfigurationManager.GetSection("mailServerGroup2");
            Console.WriteLine("provider:" + mailSection.Provider);
            Console.WriteLine("\r");

            Console.WriteLine("client1:" + mailSection.MailServers[0].Client);
            Console.WriteLine("address1:" + mailSection.MailServers[0].Address);
            Console.WriteLine("userName1:" + mailSection.MailServers[0].UserName);
            Console.WriteLine("password1:" + mailSection.MailServers[0].Password);
            Console.WriteLine("\r");

            Console.WriteLine("client2:" + mailSection.MailServers[1].Client);
            Console.WriteLine("address2:" + mailSection.MailServers[1].Address);
            Console.WriteLine("userName2:" + mailSection.MailServers[1].UserName);
            Console.WriteLine("password2:" + mailSection.MailServers[1].Password);

            Console.WriteLine("\r");

            Console.WriteLine("----------4存储对象------------");

            //IGreetingStrategy greetingStrategy = new ChineseGreeting();
            //GeneralClass generalObj = new GeneralClass(greetingStrategy);
            //if (generalObj != null)
            //    generalObj.SayHello();


            //string strategy = ConfigurationManager.AppSettings["GreetingLanguage"];
            //IGreetingStrategy greetingStrategy = null;
            //GeneralClass generalObj = null;

            //if (strategy == "Chinese")
            //    greetingStrategy = new ChineseGreeting();
            //else if (strategy == "English")
            //    greetingStrategy = new EnglishGreeting();

            //if (greetingStrategy != null)
            //    generalObj = new GeneralClass(greetingStrategy);

            //if (generalObj != null)
            //    generalObj.SayHello();

            IGreetingStrategy greetingStrategy = (IGreetingStrategy)ConfigurationManager.GetSection("greetingStrategy");

            GeneralClass generalObj = null;
            if (greetingStrategy != null)
                generalObj = new GeneralClass(greetingStrategy);

            if (generalObj != null)
                generalObj.SayHello();


            //Console.WriteLine("----------5统一结点配置管理------------");

            ConfigManager config = (ConfigManager)ConfigurationManager.GetSection("traceFact");
            Console.WriteLine("Name:" + config.ForumConfig.Name);
            Console.WriteLine("OfflineTime:" + config.ForumConfig.OfflineTime.ToString());
            Console.WriteLine("PageSize:" + config.ForumConfig.PageSize.ToString());
            Console.WriteLine("ReplyCount:" + config.ForumConfig.ReplyCount.ToString());
            Console.WriteLine("RootUrl:" + config.ForumConfig.RootUrl.ToString());


            //var ordre_info = new List<string>() { "1", "2", "3", "4", "5" };

            //while (ordre_info.Count() > 3)
            //{
            //    var li_ = ordre_info.Take(3).ToList();
            //    ordre_info.RemoveRange(0, 3);
            //}

            Console.WriteLine("----------Xsd第三方元数据验证------------");
            Console.WriteLine("\r");

            XsdHelper.XmlValidationByXsd("", "", "http://www.oncefly.com");

            Console.WriteLine("----------配置分类读取------------");
            Console.WriteLine("\r");

            //JackyFei.Config.Config.Configuration.ConfigurationManager.ProductConfig.Promotions.ForEach(promotion =>
            //{
            //    Console.WriteLine(promotion.DomainModelPath.Path);
            //});

            //JackyFei.Config.Config.Configuration.ConfigurationManager.ServiceConfig.Services.ForEach(service =>
            //{
            //    Console.WriteLine("Address:{0};Timeout:{1}", service.Address, service.Timeout);
            //});

            //var distributeTime = JackyFei.Config.Config.Configuration.ConfigurationManager.OrderConfig.DistributeTime;
            //Console.WriteLine("StartTime:{0};StartTime:{1};DistributeType:{2}", distributeTime.StartTime, distributeTime.EndTime, distributeTime.DistributeType);
            //var distributeArea = JackyFei.Config.Config.Configuration.ConfigurationManager.OrderConfig.DistributeArea;
            //Console.WriteLine("BeginArea:{0};EndArea:{1}", distributeArea.BeginArea, distributeArea.EndArea);

            Order order = new Order(){Id="001",State = OrderState.BeginDistribute};
            SendEmailHelper.SendEmail(order);

            Console.ReadLine();
        }
    } 
}
