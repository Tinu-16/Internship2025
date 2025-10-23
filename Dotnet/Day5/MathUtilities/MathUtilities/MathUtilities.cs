namespace MathUtilities
{
    public class MathUtilities
    {
        public bool IsEven(int num)
        {
            return (num % 2 == 0);
        }
        public bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        int factorial = 1;
        public int Factorial(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                 factorial = factorial * i;
            }
            return factorial;
        }
    }
}
