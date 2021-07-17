using System;

namespace july7._3
{
    public class Person
{
        int age;
    public void greet()
    {
        Console.WriteLine("Hello!");
    }
    public void SetAge(int n)
    {
        age = n;
    }
}
    public class Student : Person
    {

        public void study()
        {
            Console.WriteLine("I'm studying on the screen");
        }
        public void ShowAge()
        {
        Console.WriteLine("My age is: 23 years old on the screen");
        }
    }
    public class Teacher : Person
    {
        public void explain()
        {
            Console.WriteLine("I'm explaining on the screen");
        }
    }
    public class StudentProfessorTest
    {
        public static void Main()
        {
            Person obj1 =new Person();
            obj1.greet();


            Student obj2 =new Student();
            obj2.greet();
            obj2.SetAge(25);
            obj2.ShowAge();
            obj2.study();

            Teacher obj3 =new Teacher();
            obj3.explain();
            obj3.SetAge(34);
            obj3.greet();
        }
    }
        
    
}
