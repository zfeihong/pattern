using System;
using Jackyfei.Framework.Passivation.Entity;

namespace Jackyfei.Framework.Passivation
{
    public delegate bool OrderExamineManagerHandler(Order order, ref OrderExamineManagerHandler manager);

    [Serializable]
    public class OrderExamineManager
    {
        /// <summary>
        /// 流程索引
        /// </summary>
        public OrderExamineManagerHandler Flows;

        /// <summary>
        /// 创建订单审批流程
        /// </summary>
        /// <returns></returns>
        public static OrderExamineManager CreateFlows()
        {
            OrderExamineManager manager=new OrderExamineManager();

            //绑定信息员审批流程
            Informationer informationer=new Informationer();
            manager.Flows += informationer.CheckPrice;
            manager.Flows += informationer.CheckNumber;

            //绑定业务经理审批流程
            BusinessManager businessManager = new BusinessManager();
            manager.Flows += businessManager.CheckPhoneConfirm;
            manager.Flows += businessManager.SendEmailNotice;

            //绑定总经理审批流程
            GeneralManager generalManager = new GeneralManager();
            manager.Flows += generalManager.FinalConfirm;
            manager.Flows += generalManager.SignAndRecord;

            return manager;
        }

        /// <summary>
        /// 开始审批流程
        /// </summary>
        /// <param name="order"></param>
        public void RunFlows(Order order)
        {
            this.Flows(order, ref this.Flows);
        }

    }
}