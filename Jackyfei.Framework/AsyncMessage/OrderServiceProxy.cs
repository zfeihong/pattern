using Jackyfei.Framework.AsyncMessage.Entity;
using Jackyfei.Framework.AsyncMessage.Interface;

namespace Jackyfei.Framework.AsyncMessage
{
    public class OrderServiceProxy:IOrderService
    {

        public void SubmitOrder(Message message)
        {
            MessageQueue.GlobalQueue.Enqueue(message);
        }
    }
}