using System;

namespace Jackyfei.Framework.Contract.Contracts
{
    /// <summary>
    /// 契约基类
    /// </summary>
    [Serializable]
    public abstract class ContractBase
    {
        /// <summary>
        /// 前置条件检测器开始检查
        /// </summary>
        /// <returns></returns>
        public ContractBase FirstValidator()
        {
            if (this.ImplementFirstValidator()) return this;

            throw new ContractValidatorException("前置条件检查器检查失败",this);
        }

        /// <summary>
        /// 后置条件检测器开始检查
        /// </summary>
        /// <returns></returns>
        public ContractBase AfterValidator()
        {
            if (this.ImplementAfterValidator()) return this;

            throw new ContractValidatorException("后置条件检查器检查失败", this);
        }

        /// <summary>
        /// 继承类实现具体的前置条件检查逻辑
        /// </summary>
        /// <returns></returns>
        protected virtual bool ImplementFirstValidator()
        {
            return true;
        }

        /// <summary>
        /// 继承类实现具体的后置条件检查逻辑
        /// </summary>
        /// <returns></returns>
        protected virtual bool ImplementAfterValidator()
        {
            return true;
        }


    }
     
}