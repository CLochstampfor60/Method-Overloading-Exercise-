using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a +  b;
            }

        public static string Add(int a, int b, bool check)
        {
            var sum = a + b;

            if (check == true && sum > 1)
            {
                return $"{sum} dollars";
            } 
            else if (check == false && sum == 1)
            {
                return $"{sum} dollar.";
            } 
            else if (check == true && sum < 1)
            {
                return $"{sum} dollars.";
            }
            else 
            {
                return sum.ToString();
             }

        }

        static void Main(string[] args)
        {
            var bulletOne = Add(5, 6);
            var bulletTwo = Add(1.3m, 2.6m);
            var bulletThree = Add(2, 4, true);

            Console.WriteLine(bulletOne);
            Console.WriteLine($"{bulletOne}, {bulletTwo}");
            Console.WriteLine(bulletThree);
        }
    }
}
