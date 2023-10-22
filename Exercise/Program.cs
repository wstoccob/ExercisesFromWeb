// See https://aka.ms/new-console-template for more information

internal class Exercise
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();

            Console.WriteLine(SumOfTwo(input));
        }
        
    }

    public static int SumOfTwo(string expression)
    {
        int sum, numberOne, numberTwo;
        int num = expression.IndexOf(",");

        numberOne = Convert.ToInt32(expression.Substring(0, num));
        numberTwo = Convert.ToInt32(expression.Substring(num+2, expression.Length - num - 2));
        
        
        return numberOne == numberTwo ? 3 * (numberOne + numberTwo): numberOne + numberTwo;
    }
}