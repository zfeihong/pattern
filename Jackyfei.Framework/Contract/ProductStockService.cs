using Jackyfei.Framework.Contract.Contracts;
using Jackyfei.Framework.Contract.Entity;
using Jackyfei.Framework.Contract.Interface;
namespace Jackyfei.Framework.Contract
{
    public class ProductStockService:IProductStockService
    {
        public ProductStockServiceContract SearchProductStockNumberByPcode(ProductStockServiceContract requestContract)
        {
            ProductStock stock=new ProductStock();
            var stockNumber = stock.GetStock(requestContract.RequestContract.PCode);

            //创建返回契约
            var result = new ProductStockServiceContract(){
                Contract = new SearchProductStockResponseContract()
                            {
                                PCode = requestContract.RequestContract.PCode,
                                Reuqest = requestContract.RequestContract,
                                StockNumber = stockNumber
                            }
            };

            //返回时启动后置条件检查器
            result.Contract.AfterValidator();
            return result;

        }
    }
}