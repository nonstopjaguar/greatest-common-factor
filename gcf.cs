using System;

public class Program
{
    static int GCF(int a, int b)
    {
        int Remainder;
    
        while( b != 0 )
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
      
        return a;
    }

    static int Main(string[] args)
    {
        int x, y;
      
        Console.WriteLine("This program allows calculating the Greatest Common Factor! :>");
        Console.WriteLine("");
        Console.Write("Enter the 1st Number: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter the 2nd Number: ");
        y = int.Parse(Console.ReadLine());

        Console.Write("\nThe Greatest Common Factor of ");
        Console.WriteLine("{0} and {1} is {2}", x, y, GCF(x, y));
 
        return 0;
    }
}
