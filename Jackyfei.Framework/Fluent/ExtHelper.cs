using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Fluent
{
    /// <summary>
    /// 扩展方法使您能够向现有类型“添加”方法，而无需创建新的派生类型、重新编译或以其他方式修改原始类型。
    /// msdn是这样规定扩展方法的：“扩展方法被定义为静态方法，但它们是通过实例方法语法进行调用的。 
    /// 它们的第一个参数指定该方法作用于哪个类型，并且该参数以 this 修饰符为前缀。”
    /// </summary>
    public static class ExtHelper
    {
        public static RequestConfigManager SetGlobalRequestFormatBinary(this RequestConfigManager manager)
        {
            if (string.IsNullOrEmpty(RequestConfigContext.ConfigContext.Format))
                RequestConfigContext.ConfigContext.Format = "Binary";
            return manager;
        }

        public static RequestConfigManager SetGlobalRequestSafetyCheckLogic(this RequestConfigManager manager,Func<RequestContext,bool> func)
        {
            RequestConfigContext.ConfigContext.SaftyCheck += func;
            return manager;
        }
    }

}
