// See https://aka.ms/new-console-template for more

using System;
using Banque;



public class Program
{
    public static void Main(string[] args)
    {
        var person1 = new Person("Jean-Marie", "Beya", new DateTime(2000 / 6 /10));
        Console.WriteLine(person1);

       
    }
}