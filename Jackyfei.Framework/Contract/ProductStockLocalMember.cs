using System;
using System.Collections.Generic;

namespace Jackyfei.Framework.Contract
{
    /// <summary>
    /// 商品库存在本地的缓存
    /// </summary>
    public class ProductStockLocalMember:Dictionary<string,int>
    {
        /// <summary>
        /// 全局的商品库存缓存
        /// </summary>
        private static readonly ProductStockLocalMember member = new ProductStockLocalMember();

        /// <summary>
        /// 构造测试数据
        /// </summary>
        static ProductStockLocalMember()
        {
            member.Add("P001", 10);
            member.Add("P002", 20);
            member.Add("P003", 30);
        }

        /// <summary>
        /// 获取本地库存缓存
        /// </summary>
        public static ProductStockLocalMember LocalStockMember
        {
            get { return member; }
        }

    }
}