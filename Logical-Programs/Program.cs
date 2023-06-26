namespace Logical_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 Fobonacci Serise");
            Console.WriteLine("Enter  2 for Perfect Number");
            Console.WriteLine("Enter 3 for Prime Number");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.GetFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.getPerfectNumber();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.GetPrimeNumber();
                    break;
                default:
                    Console.WriteLine("Enter a Valid choice");
                    break;
            }
        }
    }
}