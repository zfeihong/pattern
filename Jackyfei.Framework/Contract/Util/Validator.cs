using System;

namespace Jackyfei.Framework.Contract.Util
{
    /// <summary>
    /// 验证对象
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// 验证委托
        /// </summary>
        public Func<object, bool> Validat { get; set; }

        /// <summary>
        /// 验证容器
        /// </summary>
        public ValidatorContainer Container{ get;internal set; }

        /// <summary>
        /// 开始验证
        /// </summary>
        /// <returns></returns>
        public bool IsTrue()
        {
            if (Validat!=null)
            {
                return this.Validat(Container.ValidatorObj);
            }
            return true;
        }

    } 
}