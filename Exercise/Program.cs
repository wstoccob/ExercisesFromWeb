// See https://aka.ms/new-console-template for more information

internal class Exercise
{
    public static void Main(string[] args)
    {
        // int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Check(30, 0));
        Console.WriteLine(Check(25, 5));
        Console.WriteLine(Check(20, 30));
        Console.WriteLine(Check(20, 25));
    }

    public static bool Check(int num1, int num2)
    {
        return (num1 == 30 || num2 == 30 || num1 + num2 == 30);
    }
}