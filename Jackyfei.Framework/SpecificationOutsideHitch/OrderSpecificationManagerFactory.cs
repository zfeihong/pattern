using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Jackyfei.Framework.SpecificationOutsideHitch.Entity;

namespace Jackyfei.Framework.SpecificationOutsideHitch
{
    public class OrderSpecificationManagerFactory
    {
        public const string SpecificationFileName = "OrderSubmitSpec.xml";

        /// <summary>
        /// 创建一个用来检查提交订单相关的规则管理器
        /// </summary>
        /// <returns></returns>
        public static OrderSpecificationManager CreateNewOrderSpecificationManager()
        {
            OrderSpecificationManager result = new OrderSpecificationManager()
            {
                Specifcation = new Dictionary<CustomerType, OrderSpecifcationIndex>()
            };

            SubmitOrderSpecification specification=new SubmitOrderSpecification();
            result.Specifcation.Add(CustomerType.Vip, specification.CheckSubmitVipOrder);
            result.Specifcation.Add(CustomerType.Normal, specification.CheckSubmitNormalOrder);

            return result;
        }

        /// <summary>
        /// 重建现有的规则管理器对象【反序列化】
        /// </summary>
        /// <returns></returns>
        public static OrderSpecificationManager ReBuildOrderSpecificationManager()
        {
            using (Stream stream = File.Open(SpecificationFileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream) as OrderSpecificationManager;
            }
        }

        /// <summary>
        /// 冻结规则管理器对象【序列化】
        /// </summary>
        /// <param name="manager"></param>
        public static void FreezeOrderSpecificationManager(OrderSpecificationManager manager)
        {
            using (Stream stream = File.Open(SpecificationFileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, manager);
            }
        }



    }
}