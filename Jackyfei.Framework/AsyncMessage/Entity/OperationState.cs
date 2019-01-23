using System;

namespace Jackyfei.Framework.AsyncMessage.Entity
{
    [Serializable]
    public class OperationState
    {
        public const string Finished = "OK";
        public const string Exception = "Error";
    }
}