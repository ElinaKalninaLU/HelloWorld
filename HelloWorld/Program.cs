// See https://aka.ms/new-console-template for more information
using HelloWorld;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter name");
string n = "";
string s = "";
n= Console.ReadLine();
Console.WriteLine("Enter surname");
s= Console.ReadLine();

Customer c = new Customer(s, n);
Console.WriteLine("Full name: " + c.FullName);
Console.ReadLine();

//namespace MyProject;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}