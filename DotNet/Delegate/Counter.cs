using System;

namespace DotNet.Delegate
{
    /// <summary>
    /// 记分牌-观察者2
    /// </summary>
    public class Counter
    {
        public static void Counting(Object sender, ScoreEventArgs e)
        {
            BasketBallPlayer player = (BasketBallPlayer)sender;
            //访问 sender 中的公共字段
            Console.WriteLine(player.Score + "分进账!");
            Console.WriteLine("又涨分了\n");
            Console.WriteLine();
        }
    }
}