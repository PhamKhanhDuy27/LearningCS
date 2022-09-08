﻿namespace LearningCS;
class Program
{
    static void Main(string[] args)
    {
        for (int number = 2; number <= 20; number++)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine($"{number} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so hoan hao");
            }
        }
    }
}
