using System.Drawing;

namespace Jacky.Pattern
{
    public class ThinPerson : PersonBuilder
    {
        public ThinPerson(Graphics g, Pen p) : base(g, p) { }
        public override void BuildHead() { }
        public override void BuildBody() { }
        public override void BuildOther() { }

    }
}