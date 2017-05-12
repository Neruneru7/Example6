using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の宣言
            int score;
            double pai;
            string name;

            //変数への値の代入
            score = (int)25.0;
            pai = 3.1415;
            name = "TARO";

            //変数に格納された値を画面に表示
            Console.WriteLine("SCORE = {0}",score);
            Console.WriteLine("AVE = {0}",pai);
            Console.WriteLine("NAME = {0}",name);

        }
    }
}
