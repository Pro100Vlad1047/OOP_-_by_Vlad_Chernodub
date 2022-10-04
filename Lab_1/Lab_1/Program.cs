using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAB_1


            double v1;
            double t1;
            double v2;
            double t2;
            double sumt;

            Console.Write("Write amount of water in 1:");
            string strv1 = Console.ReadLine();
            v1 = double.Parse(strv1);

            Console.Write("Write temperature of water in 1:");
            string strt1 = Console.ReadLine();
            t1 = double.Parse(strt1);

            Console.Write("Write amount of water in 2:");
            string strv2 = Console.ReadLine();
            v2 = double.Parse(strv2);

            Console.Write("Write temperature of water in 2:");
            string strt2 = Console.ReadLine();
            t2 = double.Parse(strt2);

            sumt = (v1*t1+v2*t2) / (v1+v2);

            Console.Write($"The avarage temperature of water we have:{sumt} degrees\n\n");
        }
    }
}
