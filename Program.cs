using System;

namespace june_25
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Hello World!");
            Program pr = new Program();
            pr.mul();
            pr.add();
            pr.avg();
            pr.SumTripleIntegers();
            pr.checkintegers();
            
        }
        public void mul()
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
        public void add()
        {
            Console.WriteLine("enter  a number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b number");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+num2);
            Console.WriteLine(num1-num2);
            Console.WriteLine(num1*num2);
            Console.WriteLine(num1%num2);
        }
        public void avg()
        {
            int u=1,p=2,e=3,n=4;
            Console.WriteLine("enter the calculate & average values:");
            Console.WriteLine("enter the value of u;",u);
            u=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of p;",p);
            p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of e:",e);
            e=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of n:",n);
            n=Convert.ToInt32(Console.ReadLine());
            int avg=(u+p+e+n)/4;
            Console.WriteLine("average number:" +avg);
            Console.ReadLine();
        
        }

        bool checkintegers()
        {
            
            int a=2,b=3;
            Console.WriteLine("enter the positive value and negative value");
            Console.WriteLine("enter the value of a:",a);
            a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b:",b);
            b=Convert.ToInt32(Console.ReadLine());
            
            if((a>0&&b<0))
            {
                Console.WriteLine(" true");
                Console.ReadLine();
                return true;
            
                
            }
            else 
            {
                Console.WriteLine(" false");
                Console.ReadLine();
                return false;
            }
        }
        public void SumTripleIntegers()
        {
            int x=1,y=2;
            Console.WriteLine("enter the sum of values:");
            Console.WriteLine("enter the value of x:",x);
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y:",y);
            y=Convert.ToInt32(Console.ReadLine());
            if(x==y)
            {
                int z=(x+y)*(x+y)*(x+y);
                Console.WriteLine("sum of triple integers:" +z);
                Console.ReadLine();
            }
        }

        
    }
}


