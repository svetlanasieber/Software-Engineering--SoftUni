using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());
        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
    }
}
