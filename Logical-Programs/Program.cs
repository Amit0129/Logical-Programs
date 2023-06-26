namespace Logical_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 Fobonacci Serise");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.GetFibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Enter a Valid choice");
                    break;
            }
        }
    }
}