namespace Jackyfei.Framework.Contract.Contracts
{
    public class ProductStockServiceContract
    {
        /// <summary>
        /// 服务交互使用的契约
        /// </summary>
        public ContractBase Contract{ get; set; }

        /// <summary>
        /// 获取请求契约
        /// </summary>
        public SearchProductStockRequestContract RequestContract
        {
            get { return Contract as SearchProductStockRequestContract; }
        }

        /// <summary>
        /// 获取响应契约
        /// </summary>
        public SearchProductStockResponseContract ResponseContract
        {
            get { return Contract as SearchProductStockResponseContract; }
        }
         
    }
}