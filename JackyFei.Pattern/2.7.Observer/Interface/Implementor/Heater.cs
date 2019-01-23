namespace Jacky.Pattern
{
    /// <summary>
    /// 热水器
    /// </summary>
    public class Heater:SubjectBase
    {
        private string type;
        private string area;
        private int temprature;

        public Heater(string type,string area)
        {
            this.type = type;
            this.area = area;
            temprature = 0;
        }

        public Heater() : this("RealFire 001","China Xian")
        {
        }

        public string Type {
            get { return type; }
        }
        public string Area
        {
            get { return area; }
        }

        //供子类覆盖，以便子类拒绝被通知，或添加额外行为
        protected virtual void OnBoiled()
        {
            base.Notify();
        }

        //烧水
        public void BoilWater()
        {
            for (int i = 0; i <= 99; i++)
            {
                temprature = i + 1;
                if (temprature>97)
                {
                    OnBoiled();
                }
            }
        }

    }
}