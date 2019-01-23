namespace Jackyfei.Framework.Contract.Entity
{
    /// <summary>
    /// 商品库存领域对象
    /// </summary>
    public class ProductStock
    {
        public int GetStock(string pcode)
        {
            lock (ProductStockLocalMember.LocalStockMember)
            {
                if (ProductStockLocalMember.LocalStockMember.ContainsKey(pcode))
                {
                    return ProductStockLocalMember.LocalStockMember[pcode];
                }
            }

            return 0;
        }
    }
}