using System;

namespace Jackyfei.Framework.AsyncMessage.Entity
{
    [Serializable]
    public class MessageOperationState
    {
        public string MessageKey{ get; set; }

        public string State{ get; set; }

        public Exception Exception{ get; set; }
    }
}