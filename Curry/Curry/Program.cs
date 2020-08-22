using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curry
{
    class Program
    {
        static void Main(string[] args)
        {
            //引数チェック
            //じゃがいも
            if(Int32.Parse(args[0]) < 0 || Int32.Parse(args[0]) > 50)
            {
                Console.WriteLine("じゃがいもの数は0～50の間で指定してね");
                Console.WriteLine("Press Any Key To End");
                Console.ReadLine();
                return;
            }

            //にんじん
            if (Int32.Parse(args[1]) < 0 || Int32.Parse(args[1]) > 50)
            {
                Console.WriteLine("にんじんの数は0～50の間で指定してね");
                Console.WriteLine("Press Any Key To End");
                Console.ReadLine();
                return;
            }

            //たまねぎ
            if (Int32.Parse(args[2]) < 0 || Int32.Parse(args[2]) > 50)
            {
                Console.WriteLine("たまねぎの数は0～50の間で指定してね");
                Console.WriteLine("Press Any Key To End");
                Console.ReadLine();
                return;
            }

            string yasainame = "";
            Int32 fusoku = 0;

            for(int i = 0 ; args.Length > i; i++)
            {
                if (i == 0) { yasainame = "じゃがいも"; };
                if (i == 1) { yasainame = "にんじん"; };
                if (i == 2) { yasainame = "たまねぎ";  };

                fusoku = (i + 1) - Int32.Parse(args[i]);
                if (fusoku <= 0)
                {
                    Console.WriteLine(yasainame + "：足りてるよ");
                }
                else
                {
                    Console.WriteLine(yasainame + "：" + fusoku  + "個足りないよ");
                }
            }

            Console.WriteLine("Press Any Key To End");
            Console.ReadLine();

        }
    }
}
