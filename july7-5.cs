using System;

namespace july7._5
{
    class course
    {
        
           abstract class Course
    {
        protected string name;
        protected int duration;
        protected int coursefee;

        public Course(string name, int duration, int coursefee)
        {
            this.name = name;            
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(duration);
            Console.WriteLine(coursefee);
        }

        public abstract int  GetTotalFee(); 
    }

    
    class ParttimeCourse : Course
    {
        private string timings;

        public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name,duration,coursefee)
        {
            this.timings = timings;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            return (int)  (coursefee * 0.90);  
        }

    }

    
    class OnsiteCourse : Course 
    {
        private string company;
        private int noOfStudents;

        public OnsiteCourse(string name, int duration, int coursefee, string company, int noOfStudents)
            : base(name, duration, coursefee) 
        {
            this.company = company;
            this.noOfStudents = noOfStudents;
        }

        public override void Print() 
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(noOfStudents);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);  
        }

    }

       public class TestCourse
    {

        public static void Main() 
        {
            Course oc = new OnsiteCourse("java", 80, 10000, "python", 10);
            oc.Print();
            Console.WriteLine(oc.GetTotalFee());

            Course pc = new ParttimeCourse("C", 30, 8000, "5-7pm");
            pc.Print();
            Console.WriteLine(pc.GetTotalFee());
        }


    }
}
        
    
}
