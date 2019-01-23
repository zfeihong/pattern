using System;

namespace Jackyfei.Framework.Contract.Contracts
{
    /// <summary>
    /// 契约检查失败异常
    /// </summary>
    public class ContractValidatorException : Exception
    {
        public ContractValidatorException(string msg, ContractBase contractBase)
            : base(msg)
        {
            this.CurrentContract = contractBase;
        }

        /// <summary>
        /// 当前正在检查的契约
        /// </summary>
        public ContractBase CurrentContract { get; set; }
    }
}