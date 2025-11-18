//using System;
//class Studen
//{
//    private string Name;
//    private int Age;
//    private string Address;
//    public Studen (string Name, int Age, string Address)
//    {
//        this.Name = Name;
//        this.Age = Age;
//        this.Address = Address;
//    }
//    public void display()
//    {
//        Console.WriteLine("Name: " + Name);
//        Console.WriteLine("Age: " + Age);
//        Console.WriteLine("Address: " + Address);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Studen s = new Studen("Dat", 19, "Ha Dong");
//        s.display();
//    }
//}



using System;
class Student
{
    private string Name{get;set;}
    private int Age { get;set;}

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Dat", 19);
        Student s2 = new Student("", -5); 

        s1.Display();
        Console.WriteLine();
        s2.Display();
    }
}



