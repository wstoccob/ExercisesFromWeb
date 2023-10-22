// See https://aka.ms/new-console-template for more information

internal class Exercise
{
    public static void Main(string[] args)
    {
        // int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Test(103));
        Console.WriteLine(Test(90));
        Console.WriteLine(Test(89));
        Console.ReadLine();
    }

    public static bool Test(int num)
    {
        return (Math.Abs(num - 100) <= 10) || (Math.Abs(num - 200) <= 10);
    }
}