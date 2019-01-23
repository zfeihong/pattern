using System.Drawing;

namespace Jacky.Pattern
{
    public abstract class PersonBuilder
    {
        protected Graphics Graphics;
        protected Pen Pen { get; set; }
        protected PersonBuilder(Graphics g, Pen p)
        {
            this.Graphics = g;
            this.Pen = p;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildOther();

    } 

}