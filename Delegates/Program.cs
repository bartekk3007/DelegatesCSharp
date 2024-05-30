using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static int Square(int n)
    {
        return n * n;
    }
    static int Cube(int n)
    {
        return n * n * n; 
    }
    static int Factorial(int n)
    {
        int result = 1;
        while(n > 0)
        {
            result *= n;
            n -= 1;
        }
        return result;
    }
    delegate int NumberChange(int n);
    static void Main(string[] args)
    {
        NumberChange nc1 = new NumberChange(Square);
        NumberChange nc2 = new NumberChange(Cube);
        NumberChange nc3 = new NumberChange(Factorial);

        Console.WriteLine(nc1(11));
        Console.WriteLine(nc2(5));
        Console.WriteLine(nc3(5));

        NumberChange ncSum = nc1;
        ncSum += nc2;

        Console.WriteLine(ncSum(5));
    }
}
