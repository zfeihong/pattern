using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Pattern._2.Prototype
{
    public class Student : ICloneable
    {
        public string Sno { get; set; }
        public string Name { get; set; }

        public Student(){}

        public Student(string sno, string name)
        {
            this.Sno = sno;
            this.Name = name;
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
        //MemberwiseClone属于浅复制，相当于
        //public Object Clone()
        //{
        //    Student obj = new Student();
        //    obj.Sno = this.Sno;
        //    obj.Name = this.Name;
        //    return obj;
        //}        


        public void Print()
        {
            Console.WriteLine("{0} {1} ", Sno, Name);
        }
    }
}
