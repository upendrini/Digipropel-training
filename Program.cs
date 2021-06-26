using System;

namespace _1q
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1,b=2,c=3;
            Console.WriteLine("enter a,b,c values");
            Console.WriteLine("enter the value of a:",a);
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b:",b);
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of c:",c);
            c=Convert.ToInt32(Console.ReadLine());
            int d=a*b*c;
            Console.WriteLine("multiplication of three numbers:" +d);
            Console.ReadLine();
        }
    }
}
