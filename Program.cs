using System.Diagnostics.Metrics;
using System;

namespace sontopiw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 1;
            int num1;
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            // Console.WriteLine(num); // random sonni topish 
            Console.Write("1 dan 100 gacha izlanayotgan sonni kiriting --> ");
            kirit:
            num1 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num)
            {
                if(num1 > 100)
                {
                    Console.WriteLine("Siz faqat 1 va 100 oraliqda kirita olasiz; ");
                    count1++;
                    goto kirit:
                }
                else
                {
                    Console.Write("kichikroq kiritng : ");
                    count1++;
                    goto kirit;
                }
            }
            else if(num1 < num)
            {
                if(num1 < 0)
                {
                    Console.Write("Siz faqat 1 va 100 oraliqda kirita olasiz; ");
                    count1++;
                    goto kirit;
                }
                else
                {
                    Console.Write("kattaroq kiriting : ");
                    count1++;
                    goto kirit;
                }
            }
            else
            {
                Console.WriteLine("siz " + count1 + " ta urunishda topdingiz");
                
            }
            /*
            int num, count1 = 1, num2;
            Random rnd = new Random();
            num = rnd.Next(1, 100);
            Console.WriteLine(num); // --> random sonni chiqarish;
            Console.WriteLine("1 dan 100 gacha izlanayotgan sonni kiriting: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num != num2)
            {
                if (num2 < num)
                {
                    if (num2 > 0 && num2 < 100)
                    {
                        Console.WriteLine("Kattaroq son kiritng : ");
                    }
                    else Console.WriteLine("1 va 100 oraliqda son kiritng!");
                    count1++;
                }
                else if (num2 > num)
                {
                    if (num2 > 0 && num2 <= 100)
                    {
                        Console.WriteLine("Kichikroq son kiritng : ");
                    }
                    else Console.WriteLine("1 va 100 oraliqda son kiritng!");
                    //Console.WriteLine("Kichikroq son kiriitng : "); 
                    count1++;
                }
                else
                {
                    Console.WriteLine("Siz " + count1 + " ta urunishda topdingiz;");
                    break;
                }

            }
            */
        }
    }
}