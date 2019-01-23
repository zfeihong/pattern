using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JackyFei.Config.ManagerConfig
{
    public class GeneralConfigurationHandler : IConfigurationSectionHandler
    {
        // 这里的section结点为 Web.Config中的 配置的根结点
        public object Create(object parent, object configContext, XmlNode section)
        {
            // 获取结点type属性的值
            Type t = Type.GetType(section.Attributes["type"].Value);

            // 直接将section进行传递
            object[] parameters = { section };

            // 将要创建的类型实例
            object obj = null;

            try
            {
                obj = Activator.CreateInstance(t, parameters); // 使用有参数的构造函数
            }
            catch (Exception ex)
            {
                return null;
            }
            // obj为结点的 type属性中定义的对象 
            return obj;
        }
    }
}
