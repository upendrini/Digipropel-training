using System;

namespace june27
{
    class Program
    {
        static void main()
        {}
        
            enum days { Sun, Mon, Tue, Wed, Thur, Fri, Sat }
        
        
        public void Enumprogram()
        {
            int Weekdaystart = (int)days.Mon;
            int Weekdayend = (int)days.Sat;

            Console.WriteLine("Mon:{0}", Weekdaystart);
            Console.WriteLine("Sat:{0}", Weekdayend);

        }
        
    }
}
