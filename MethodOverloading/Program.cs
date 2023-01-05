namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(8, 4));

            //Console.WriteLine($"Decimal verson: {Add(4.3m, 9.7m)}");

            Console.WriteLine(Add(15, 12, false));

            Console.WriteLine(Add(15, 12, true));

            Console.WriteLine(Add(1, 0, true));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
