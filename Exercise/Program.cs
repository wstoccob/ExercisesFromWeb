// See https://aka.ms/new-console-template for more information

internal class Exercise
{
    public static void Main(string[] args)
    {
        while (true)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(AbsDif(input));
        }
    }

    public static int AbsDif(int num)
    {
        return (num > 51) ? 3 * (num - 51) : 51 - num;
    }
}