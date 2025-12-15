using System;
class Program
{
    static void Main(string[] args)
    {
        int randomInt = RandomHelper.randint(1, 10);
        double randomDouble = RandomHelper.randdouble(1, 10);
        Console.WriteLine("Random Integer (1 to 10): " + randomInt);
        Console.WriteLine("Random Double (1 <= x < 10): " + randomDouble);
    }
}
