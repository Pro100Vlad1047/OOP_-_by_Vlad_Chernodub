using System;

namespace LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int qt=0;
            Console.WriteLine("Write number of row before which you want to add row of zero`s(1-5)");
            string strk=Console.ReadLine();
            k = int.Parse(strk);

            Random rnd = new Random();//Randomizer
            
            int[] nums = new int[25];
            for(int i=0; i<21 ;++i)
            {
                if (i%5==0)
                {
                    qt++;
                    Console.Write("\n");
                    if (k == qt)
                    {
                        for(int q=0;q<5;++q)
                        {
                            Console.Write(0);
                            Console.Write("\t");
                        }
                        Console.Write("\n");
                    }
                }
                if (i != 20)
                {
                    nums[i] = rnd.Next(0, 20);
                    Console.Write(nums[i]);
                    Console.Write("\t");
                }
            }
        }
    }
}
