using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        int testNumber = 17;
        Console.WriteLine($"Число {testNumber} является простым: {IsPrime(testNumber)}");
    }
}
