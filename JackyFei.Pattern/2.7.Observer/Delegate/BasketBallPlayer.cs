using System;
using System.Threading;

namespace Jacky.Pattern
{ 
    public class BasketBallPlayer
    {
        public int Score { get; set; }

        /// <summary>
        /// 遵循.net命名规范：Handler后缀
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 尽管并非必需，但是我们发现很多的委托定义返回值都为void，为什么呢？
        /// 这是因为委托变量可以供多个订阅者注册，如果定义了返回值，那么多个订阅者的方法都会向发布者返回数值，
        /// 结果就是后面一个返回的方法值将前面的返回值覆盖掉了，因此，实际上只能获得最后一个方法调用的返回值
        public delegate void ScoredEventHandler(object sender, ScoreEventArgs e);

        /// <summary>
        /// 事件声明-使用事件向外部提供方法注册，而不是直接使用委托变量的原因。主要是从封装性和易用性上去考虑
        /// </summary>
        //public event ScoredEventHandler Scored;

        //定义事件访问器来封装委托，可以实现只允许一个客户订阅
        private ScoredEventHandler scored;
        public event ScoredEventHandler Scored{
            add { scored = value; }
            remove { scored -= value; }
        }

        /// <summary>
        /// 投篮
        /// </summary>
        public void Shoot()
        { 
            //for (int i = 1; i < 100; i++)
            //{
            //    Score = i;
            //    if (Score>95)
            //    {
                    OnShoot(new ScoreEventArgs(10));
            //    }
            //}
        }

        /// <summary>
        /// 可以供继承者进行重写，以便继承类拒绝其他对象对他的监视
        /// </summary>
        /// <param name="e"></param>
        public virtual void OnShoot(ScoreEventArgs e)
        {
            if (scored != null)
            {
                //调用注册对象的方法
                //this指代BasketBallPlayer
                scored(this, e);
            }
        }
    }

    public class ScoreEventArgs
    {
        public int Score { get; set; }

        public ScoreEventArgs(int score)
        {
            this.Score = score;
        }
    }
}