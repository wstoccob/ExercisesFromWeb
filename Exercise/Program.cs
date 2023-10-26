// See https://aka.ms/new-console-template for more information

internal class Exercise
{
    public static void Main(string[] args)
    {
        Fibonachi(40);
    }

    public static void Fibonachi(int num)
    {
        int first = 1, second = 1;
        int third;
        for (int i = 0; i < num; i++)
        {
            third = first + second;
            Console.WriteLine($"{third} and a ratio is {(decimal) third / second}");
            first = second;
            second = third;
        }
    }
}