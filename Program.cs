using System;

namespace june31
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i=0;
            Console.Write("\n find the length of a string:\n");
            Console.Write("input the string:");
            str=Console.ReadLine();
            foreach(char chr in str)
            {
               i+=1; 
            }

            Console.Write("length of the string is:{0}\n\n",i);
        }

        
    }
}
