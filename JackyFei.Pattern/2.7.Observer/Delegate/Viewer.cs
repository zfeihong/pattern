using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jacky.Pattern;

namespace JackyFei.Pattern
{
    /// <summary>
    /// 观众-观察者1
    /// </summary>
    public class Viewer
    {
        public static void Cheer(Object sender, ScoreEventArgs e)
        {
            BasketBallPlayer player = (BasketBallPlayer)sender;
            //访问 sender 中的公共字段
            Console.WriteLine(player.Score + "分进账!");
            Console.WriteLine("观众欢呼MVP.\n");
            Console.WriteLine();
        }
    }
}
