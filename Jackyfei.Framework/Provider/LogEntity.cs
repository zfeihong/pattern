using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Provider
{
    /// <summary>
    /// LogEntity聚合根极其成员
    /// </summary>
    public class LogEntity
    {
        /// <summary>
        /// 对日志类别的处理，这里放到LogType当中，这也是领域驱动设计强调的：尽量让类模型贴近领域模型
        /// </summary>
        public LogType Type { get; set; }
        public LogLevel Level { get; set; }
        public LogContent Content { get; set; }
    }

    public class LogType
    {
        public const string Exception = "Error";

        public const string Track = "Track";
    }

    public class LogLevel
    {
        /// <summary>
        /// 警告
        /// </summary>
        public const string Warning = "Warning";
        /// <summary>
        /// 严重
        /// </summary>
        public const string Graveness = "Graveness";
    }

    public class LogContent
    {
        public string LogTrackInfo { get; set; }

        public string Message{ get; set; }
    }
}
