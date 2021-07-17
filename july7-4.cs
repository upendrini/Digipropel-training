using System;

namespace july7._4
{
    class july74
    {
        

    public class Student1
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
		private static double servicetax = 12.3;

        public Student1(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "c#" ? 2000 : 3000;
				// service tax
                 total = total + total * servicetax / 100;
                return (int) total;

            }


        }
		public static double  ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
    }

    public class UseStudent
    {

        public static void Main()
        {

            Student1 obj1 = new Student1(11, "jaya", "c#");

            obj1.Payment(100);
            obj1.Print();
            Console.WriteLine(obj1.DueAmount);
            Student1 obj2 =new Student1(12, "sushma", "java");
            obj2.Payment(100);
            obj2.Print();
     Console.WriteLine(obj2.DueAmount);
        }
    }
	}
}  
        
    
}
