using Jackyfei.Framework.Contract.Contracts;

namespace Jackyfei.Framework.Contract.Interface
{
    /// <summary>
    /// 商品库存服务接口
    /// </summary>
    public interface IProductStockService
    {
        /// <summary>
        /// 查询商品库存
        /// </summary>
        /// <param name="requestContract"></param>
        /// <returns></returns>
        ProductStockServiceContract SearchProductStockNumberByPcode(ProductStockServiceContract requestContract);

    }
}