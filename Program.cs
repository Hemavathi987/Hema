using System;

namespace Program
{
    class Demo
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Enter your age");
        String name = Console.ReadLine();
    Console.WriteLine("Enter Your DOB");
        int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your Address");
        String add = Console.ReadLine();
    Console.WriteLine("My name=" + name);
        Console.WriteLine("My age=" + age);
        Console.WriteLine("My address=" + add);
            
            String SUBString = add.Substring(add.IndexOf("a"));
            Console.WriteLine("Final SubString====="+SUBString);

        }
    }
}
















    

