using Jackyfei.Framework.Contract.Util;

namespace Jackyfei.Framework.Contract.Contracts
{
    /// <summary>
    /// 查询商品库存信息契约
    /// </summary>
    public class SearchProductStockRequestContract : ContractBase
    {
        public string PCode { get; set; }

        /// <summary>
        /// 实现前置条件查询器
        /// </summary>
        /// <returns></returns>
        protected override bool ImplementFirstValidator()
        {
            var validator = PCode.BeginValidator().IsNullOrEmpty().StartsWith("P").EndValidator();
            return validator.IsTrue();
        }

       
    }
}