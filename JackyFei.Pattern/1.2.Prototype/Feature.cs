namespace JackyFei.Pattern._2.Prototype
{
    public class Feature
    {
        public string Sex{ get; set; }
        public int Age{ get; set; }

        public Feature(){}

        public Feature(string sex,int age)
        {
            Sex = sex;
            Age = age;
        }
    }
}