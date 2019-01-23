using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Provider
{
    public abstract class SaveLogBaseProvider:ISaveLogProvider
    {
        public bool SaveLog(LogEntity entity)
        {
            if (this.IsSaveLogWithConfig(entity)) return false;
            if (this.ValidatorLogEntity(entity)) return false;
            if (this.ValidatorLogEntity(entity)) return false;

            return DoSaveLog(entity);
        }

        protected virtual bool IsSaveLogWithConfig(LogEntity entity)
        {
            string logType = ConfigurationManager.AppSettings["LogType"];
            if (entity.Type.Equals(logType)) return true;
            return false;
        }

        protected virtual bool ValidatorLogEntity(LogEntity entity)
        {
            if (entity == null || entity.Content == null) return false;
            return true;
        }

        protected virtual void FormatLogContent(LogEntity entity)
        {
            
        }

        /// <summary>
        /// 抽象类的抽象方法，继承者必须实现他
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected abstract bool DoSaveLog(LogEntity entity);


    }
}
