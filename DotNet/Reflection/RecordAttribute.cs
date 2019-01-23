using System;
using System.Runtime.InteropServices;

namespace DotNet.Reflection
{
    [ComVisible(true)]
    [Serializable]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class RecordAttribute:Attribute
    {
        private string recordType;
        private string author;
        private DateTime date;
        private string memo;

        public RecordAttribute(string recordType, string author, string date)
        {
            this.recordType = recordType;
            this.author = author;
            this.date = Convert.ToDateTime(date);
        }

        public string RecordType { get { return recordType; } }
        public string Author { get { return author; } }
        public DateTime Date { get { return date; } }
        public string Memo { get { return memo; }set { memo = value; }}
    }
}