using System;
using Jackyfei.Framework.AsyncMessage.Entity;
using Jackyfei.Framework.AsyncMessage.Interface;

namespace Jackyfei.Framework.AsyncMessage
{
    public class OrderService:IOrderService
    {
        public const string OrderCodePrefix = "P";
        
        public void SubmitOrder(Message message)
        {
            Order order = message.Body as Order;
            if (!order.OrderCode.StartsWith("P"))
            {
                //将消息状态存入消息状态表，这部分可以在基类中完成
                MessageOperationStateDictionary.GlobalDictionary.Add(message.MessageKey,new MessageOperationState()
                {
                    Exception = new Exception(string.Format("订单处理错误，订单编号:{0}格式不对",order.OrderCode)),
                    State = OperationState.Exception,
                    MessageKey = message.MessageKey
                });
            }
            else
            {
                //订单处理逻辑，这部分可以在基类中完成
                MessageOperationStateDictionary.GlobalDictionary.Add(message.MessageKey, new MessageOperationState()
                {
                    State = OperationState.Finished,
                    MessageKey = message.MessageKey
                });
            }

          

        }
         
    }
}