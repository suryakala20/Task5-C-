using System;
public class RandomHelper
{
    private static Random random = new Random();
    public static int randint(int min, int max)
    {
        return random.Next(min, max + 1);
    }
    public static double randdouble(int min, int max)
    {
        return min + random.NextDouble() * (max - min);
    }
}
