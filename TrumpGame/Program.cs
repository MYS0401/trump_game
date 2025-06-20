using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] card = new int [4];

            for (int i = 0; i < 4; i++)
            {
               
               for(; ; )
                {
                    Console.Write($"[{i + 1}]枚目の数値を入力->");
                    //card [i] = int.Parse(Console.ReadLine());
                    bool result = int.TryParse(Console.ReadLine(), out int num);
                    if (result == false || num != 1 && num != 2 && num != 3 && num != 4)
                    {
                        Console.WriteLine("1～4の範囲内の値を入力してください");
                    }
                    else
                    {
                        card[i] = num;
                        break;
                    }
                }
                
            }

            for (int i = 0;i < 4;i++)
            {
                Console.WriteLine($"{i + 1}枚目 : " + card [i]);
            }

            Console.ReadLine();
        }
    }
}
