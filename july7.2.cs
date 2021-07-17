using System;

namespace july7._2
{
    
    
     public abstract class Animal 
{
    private string Name;

    public void SetName(string name)
    {
        Name=name;
    }
    public string GetName()
    {
        return Name ;
    }
    public abstract void Eat();
}


public class Dog : Animal
{
    public override  void Eat()
        {
            Console.WriteLine("The Dog is Eating ");
        }
}


public class AbstractClass
{
    public static void Main()
    {
        Dog obj1 = new Dog();
        Console.WriteLine("Please enter the name of the dog ");
        obj1.SetName("Dog's name is : "+Console.ReadLine());
        Console.WriteLine (obj1.GetName());
        obj1.Eat();

    }
}

    
}
        
    


        
    

