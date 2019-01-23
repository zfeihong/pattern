using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Jackyfei.Framework.AsyncMessage;
using Jackyfei.Framework.BusMessageRouting;
using Jackyfei.Framework.BusMessageRouting.Entity;
using Jackyfei.Framework.Context;
using Jackyfei.Framework.Contract;
using Jackyfei.Framework.Contract.Contracts;
using Jackyfei.Framework.Contract.Interface;
using Jackyfei.Framework.Fluent;
using Jackyfei.Framework.Metadata.RepositoryDesign;
using Jackyfei.Framework.Passivation;
using Jackyfei.Framework.Passivation.Entity;
using Jackyfei.Framework.SpecificationOutsideHitch;
using Jackyfei.Framework.SpecificationOutsideHitch.Entity;
using Jackyfei.Framework.Provider;
using Message = Jackyfei.Framework.AsyncMessage.Entity.Message;
using Order = Jackyfei.Framework.Passivation.Entity.Order;
using OrderService = Jackyfei.Framework.AsyncMessage.OrderService;

namespace Jackyfei.Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            //==============================1.Provider程序提供模式==============================

            //LogEntity entity=new LogEntity();
            ////这里可以使用抽象工厂
            ////LogEntityFactory.CreateLogEntity("","","");

            //entity.Content =new LogContent();
            //entity.Content.Message = "Log Message";
            //LogSaveLocalProvider localProvider=new LogSaveLocalProvider();//这里可以使用IOC
            //localProvider.SaveLog(entity);


            //==============================2.Fluent链式编程模式==============================
            //RequestConfigManager.GlobalConfig.SetGlobalRequestSize(100)
            //    .SetGlobalRequestProtocol(new RequestProtocol(RequestProtocol.Soap))
            //    .SetGlobalRequestFormatJson()
            //    .SetGlobalRequestFormatXml();//利用非扩展方法实现的设置

            //RequestConfigManager.GlobalConfig.SetGlobalRequestSize(100)
            //   .SetGlobalRequestProtocol(new RequestProtocol(RequestProtocol.Soap))
            //   .SetGlobalRequestFormatBinary();//利用扩展方法实现的设置

            ////利用委托把框架不能确定的事交给框架使用者决定，使得框架避免变得臃肿
            //RequestConfigManager.GlobalConfig.SetGlobalRequestSafetyCheckLogic(
            //    req => req.Size < RequestConfigContext.ConfigContext.Size);


            //==============================3.Pipeline管道模式==============================
            //Request request=new Request()
            //{
            //    Content = new RequestContent() { Content = "Query order method"},
            //    Head = new StringBuilder(),
            //    ClientType = RequestClientTypeFactory.CreateClientTypeForApp()
            //};

            ////客户端管道对象
            //ClientPipelineObject pipe =new ClientPipelineObject();
            ////添加管道模型
            //pipe.AddModule(ClientPipelineModules.CheckRequestContent);
            //pipe.AddModule(ClientPipelineModules.AddRequestHead);
            //pipe.AddModule(ClientPipelineModules.TransfeRequestForamt);
            //pipe.AddModule(ClientPipelineModules.ReduceRequest);
            ////执行管道
            //pipe.RunPipeline(request);

            ////执行特定类型客户端的管道处理
            //IBuildOperationLogicPipelineObject clientType = OperationLogicPipelineObjectFactory.Create(request.ClientType);
            //OperationLogicPipelineObject pipeline = clientType.BuildOperationPipeline(request);
            //pipeline.RunPipeline(request);


            //==============================4.Context上下文模式==============================
            //ServiceProxy serviceProxy=new ServiceProxy();
            //using (SOAServiceCallContext soaContext=new SOAServiceCallContext(true,true))
            //{
            //    soaContext.BeginRecordLogTrackEvent += soaContext_BeginRecordLogTrackEvent;
            //    soaContext.TransactionEndEvent += soaContext_TransactionEndEvent;

            //    serviceProxy.SetTicketPrice("292339",350);
            //    serviceProxy.UpdateTicketCache("292339",150);
            //}

            //==============================5.钝化模式==============================
            //Order order = new Order()
            //{
            //    Items = new List<OrderItem>(),
            //    Customer = new CustomerInfo() {Email = "jack@qq.com", Name = "jacky", Phone = "18769211231"}
            //};

            //order.Items.Add(new OrderItem() {Number = 10, Product = new Product() {Name = "小米MAX", Price = 1499}});
            //order.Items.Add(new OrderItem() {Number = 20, Product = new Product() {Name = "小米5", Price = 1999}});

            ////序列化
            //OrderExamineManager manager = new OrderExamineManager();

            //Stream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "orderChecks.xml", FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, manager);
            //stream.Close();
            //stream.Dispose();

            ////反序列化
            //Stream stream1 = File.Open(AppDomain.CurrentDomain.BaseDirectory + "orderChecks.xml", FileMode.Open);
            //BinaryFormatter formatter1 = new BinaryFormatter();
            //OrderExamineManager examine = formatter1.Deserialize(stream1) as OrderExamineManager;
            //if (examine != null)
            //    examine.RunFlows(order);

            //stream1.Close();
            //stream1.Dispose();

            ////审核后再序列化到文件中
            //Stream stream2 = File.Open(AppDomain.CurrentDomain.BaseDirectory + "orderChecks.xml", FileMode.Create);
            //BinaryFormatter formatter2 = new BinaryFormatter();
            //if (examine != null)
            //    formatter2.Serialize(stream2, examine);

            //stream2.Close();
            //stream2.Dispose();


            //==============================6.规则外观模式==============================
            //var specManager = OrderSpecificationManagerFactory.CreateNewOrderSpecificationManager();
            //var orderList = new List<SpecificationOutsideHitch.Entity.Order>()
            //{
            //    new SpecificationOutsideHitch.Entity.Order(){ Customer = new Customer(){ CustomerType = CustomerType.Vip}},
            //    new SpecificationOutsideHitch.Entity.Order(){ Customer = new Customer(){ CustomerType = CustomerType.Normal}}

            //};

            //OrderBusiness business = new OrderBusiness(specManager);
            //using (specManager)
            //{
            //    orderList.ForEach(o => business.SubmitOrder(o));
            //}

            //var specManager2 = OrderSpecificationManagerFactory.ReBuildOrderSpecificationManager();

            //==============================7.契约模式==============================
            //var contract=new ProductStockServiceContract()
            //{
            //    Contract = new SearchProductStockRequestContract()
            //    {
            //        PCode = "P0101"
            //    }
            //};

            //contract.Contract.FirstValidator();
            ////IProductStockService service = ServiceFactory.Create<IProductStockService>();
            //ProductStockService service = new ProductStockService();
            //service.SearchProductStockNumberByPcode(contract);

            //==============================8.异步消息事件驱动模式==============================
            //OrderService service =new OrderService();

            //MessageQueue.GlobalQueue.MessageNotifyEvent += service.SubmitOrder;

            //var orders = new List<AsyncMessage.Entity.Order>()
            //{
            //    new AsyncMessage.Entity.Order(){ OrderCode = "P001"},
            //    new AsyncMessage.Entity.Order(){ OrderCode = "P002"},
            //    new AsyncMessage.Entity.Order(){ OrderCode = "B003"}
            //};

            //OrderServiceProxy proxy=new OrderServiceProxy();
            //orders.ForEach(order => proxy.SubmitOrder(new Message() { Body = order }));

            ////Console.ReadLine();
            //Thread.Sleep(2000);

            ////打印三条订单的处理状态
            //foreach (var key in MessageOperationStateDictionary.GlobalDictionary.Keys)
            //{
            //    Console.WriteLine("消息号：{0}", MessageOperationStateDictionary.GlobalDictionary[key].MessageKey);
            //    if (MessageOperationStateDictionary.GlobalDictionary[key].Exception != null)
            //    {
            //        Console.WriteLine("异常信息：{0}", MessageOperationStateDictionary.GlobalDictionary[key].Exception.Message);
            //    }
            //    Console.WriteLine("消息状态：{0}", MessageOperationStateDictionary.GlobalDictionary[key].State);

            //}

            //==============================9.总线消息路由模式==============================
            //ServiceBase orderService = new BusMessageRouting.OrderService();
            //orderService.Register();

            ////消息对象
            //var message=new BusMessageRouting.Entity.Message()
            //{
            //    Body = new BusMessageRouting.Entity.Order()
            //    {
            //        OrderId = "P001",
            //        SubmitTime = DateTime.Now
            //    },
            //    Header = new MessageHeader()
            //    {
            //        MessageKey = Guid.NewGuid().ToString(),
            //        RequestKey = "OrderService.SubmitOrder"
            //    }
            //};

            //bool isOk = MessageBus.SendBusAndAction<bool>(message);
            //if (isOk)
            //{
            //    Console.WriteLine("订单提交成功！");
            //}

            //==============================10.元数据和元数据缓存池模式==============================
            new ItemRepositroyDesign().BeginAddItem();
            new OrderRepositroyDesign().BeginAddItem();



            Console.ReadLine();

        }
         

        static void soaContext_TransactionEndEvent(TransactionActionInfo arg)
        {
            //查看事务处理信息
            //throw new NotImplementedException();
        }

        static void soaContext_BeginRecordLogTrackEvent(LogTracklocation arg)
        {
            //查看日志跟踪信息
            //throw new NotImplementedException();
        }
    }
}
