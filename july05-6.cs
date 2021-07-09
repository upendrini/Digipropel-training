using System;

namespace july7
{
    class july057
    {
        static void Main(string[] args)
        {
          
          Console.WriteLine("Enter date in format (yyyy,mm,dd)");
            DateTime date1 = new DateTime();
            date1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter date in format (yyyy,mm,dd)");
            DateTime date2 = new DateTime();
            date2 = Convert.ToDateTime(Console.ReadLine());

            if(date1<date2)
            {
                Console.WriteLine("{0} comes before{1}", date1,date2);
            }
            else
            {
                Console.WriteLine("{0} comes before{1}", date1,date2);
            }

        }
    }
}

/*enter the date1 05-12-2021*/
/*enter the date2 06-12-2021*/
/*output*/
/*05-12-2021 00:00:00 comes before06-12-2022 00:00:00*/


