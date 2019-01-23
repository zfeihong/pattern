using System;
using System.Collections.Generic;
using Jackyfei.Framework.AsyncMessage.Entity;

namespace Jackyfei.Framework.AsyncMessage
{
    public class MessageOperationStateDictionary : Dictionary<String,MessageOperationState>
    {
         public static MessageOperationStateDictionary GlobalDictionary =new MessageOperationStateDictionary();

        public MessageOperationState SearchState(string messageKey)
        {
            if (this.ContainsKey(messageKey))
            {
                return this[messageKey];
            }
            return null;
        }
    }
}