using Jackyfei.Framework.AsyncMessage.Entity;

namespace Jackyfei.Framework.AsyncMessage.Interface
{
    public interface IOrderService
    {
        /// <summary>
        /// 提交订单
        /// </summary>
        /// <param name="message"></param>
        void SubmitOrder(Message message);
    }
}