using System;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAB_3
            int a;

            for (; ; )
            {
                Console.Write("Write int number:");
                string stra = Console.ReadLine();
                a = int.Parse(stra);
                if (a / 100 >= 1 && a / 100 < 10)
                {
                    if (a % 2 != 0)
                    {
                        Console.Write("All requirements are successfull\n");
                    }
                    else
                    {
                        Console.Write("This number is not pair, try one more time\n");
                    }

                }
                else
                {
                    Console.Write("This number is does not have 3 number, try one more time\n");
                }
            }
        }
    }
}
