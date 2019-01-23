using System;
using System.IO;
using Commons.Collections;
using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.Runtime;

namespace JackyFei.Config.Config.DynamicConfig
{
    public class SendEmailHelper
    {
        public const string EmailTempleFile = "OrderStateEmailTemple.vm";

        public static void SendEmail(Order order)
        {
            VelocityEngine engine = new VelocityEngine();
            ExtendedProperties props = new ExtendedProperties();
            props.AddProperty(RuntimeConstants.RESOURCE_LOADER,"file");
            props.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, AppDomain.CurrentDomain.BaseDirectory + @"\Config\DynamicConfig");
            props.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "GB2312");
            props.AddProperty(RuntimeConstants.INPUT_ENCODING, "GB2312");

            engine.Init(props);
            Template template = engine.GetTemplate(EmailTempleFile);
            IContext tmpContext = new VelocityContext();
            tmpContext.Put("order", order);

            StringWriter writer=new StringWriter();
            template.Merge(tmpContext, writer);

            Console.WriteLine(writer.ToString());
        }

    }
}