namespace LearningCS;
class Program
{
    static void Main(string[] args)
    {
        for (int number = 2; number <= 20; number++)
        {
            int divisorCount = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    divisorCount++;
                }
            }

            if (divisorCount == 0)
            {
                Console.WriteLine($"{number} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so nguyen to");
            }
        }
    }
}
