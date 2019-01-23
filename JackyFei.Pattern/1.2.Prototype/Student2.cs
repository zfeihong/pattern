using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Pattern._2.Prototype
{
    public class Student2 : ICloneable
    {
        public string Sno { get; set; }
        public string Name { get; set; }
        public Feature Feature { get; set; }

        public Student2()
        {
            this.Feature = new Feature();
        }

        public Student2(string sno, string name)
        {
            this.Sno = sno;
            this.Name = name;
            this.Feature=new Feature();
        }
        public void SetFeature(string sex, int age)
        {
            Feature.Sex = sex;
            Feature.Age = age;
        }

        public Object Clone()
        {
            Student2 obj = new Student2();
            obj.Sno = this.Sno;
            obj.Name = this.Name;
            obj.Feature.Age = this.Feature.Age;
            obj.Feature.Sex = this.Feature.Sex;
            return obj;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1}", Sno, Name);
            Console.WriteLine("{0} {1}", Feature.Sex, Feature.Age);
        }
    }
}
