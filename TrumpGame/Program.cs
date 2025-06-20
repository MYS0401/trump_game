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
            int[] card = new int[4];
            int count;

            for (; ; )
            {
                count = 0;
                for (int i = 0; i < 4; i++)
                {

                    for (; ; )
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

                //役判定
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (card[i] == card[j])
                        {
                            count++;
                        }
                    }
                }

                switch (count)
                {
                    case 4:
                        Console.WriteLine("----------\nノーペア\n----------");
                        break;
                    case 6:
                        Console.WriteLine("----------\nワンペア\n----------");
                        break;
                    case 8:
                        Console.WriteLine("----------\nツーペア\n----------");
                        break;
                    case 10:
                        Console.WriteLine("----------\nスリーカード\n----------");
                        break;
                    case 16:
                        Console.WriteLine("----------\nフォーカード\n----------");
                        break;
                }

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1}枚目 : " + card[i]);
                }

                for (; ; )
                {
                    Console.WriteLine("ゲームを終了しますか 終了: 0 もう一度 :1");
                    bool result = int.TryParse(Console.ReadLine(), out int date);

                    if (result == false || date != 1 && date != 0)
                    {
                        Console.WriteLine("使用できない値です");
                    }
                    else if (date == 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
            }  
        }
    }
}
