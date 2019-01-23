using System;
using Jackyfei.Framework.Contract.Util;

namespace Jackyfei.Framework.Contract.Contracts
{
    /// <summary>
    /// 查询商品库存信息返回契约
    /// </summary>
    [Serializable]
    public class SearchProductStockResponseContract : ContractBase
    {
        public string PCode { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public int StockNumber { get; set; }


        [NonSerialized]
        public SearchProductStockRequestContract Reuqest;

        /// <summary>
        /// 实现后置条件检查器逻辑
        /// </summary>
        /// <returns></returns>
        protected override bool ImplementAfterValidator()
        {
            var validator = PCode.BeginValidator().IsNullOrEmpty().StartsWith("P").EndValidator();
            return ProductStockLocalMember.LocalStockMember.ContainsKey(PCode) //检查是否存在该商品的库存
                && validator.IsTrue();//检查各项返回的属性是否正确
        }
    }
}