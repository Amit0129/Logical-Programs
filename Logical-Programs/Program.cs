namespace Logical_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 Fobonacci Serise");
            Console.WriteLine("Enter 2 for Perfect Number");
            Console.WriteLine("Enter 3 for Prime Number");
            Console.WriteLine("Enter 4 for Reverse a Number");
            Console.WriteLine("Enter 5 for Ramdom Coupon Number");
            Console.WriteLine("Enter 6 for Stopwatch time that elapses between the start and end");
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
                case 4:
                    ReverseANumber reverseANumber = new ReverseANumber();
                    reverseANumber.ReverseAN0();
                    break;
                case 5:
                    CouponNumber couponNumber = new CouponNumber();
                    couponNumber.GetUniqueCooponNo();
                    break;
                case 6:
                    SimulateStopwatch simulateStopwatch = new SimulateStopwatch();
                    simulateStopwatch.GetTimeElapses();
                    break;
                default:
                    Console.WriteLine("Enter a Valid choice");
                    break;
            }
        }
    }
}