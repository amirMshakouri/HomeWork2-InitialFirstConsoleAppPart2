using HomeWork2.task1;
using HomeWork2.task2;
using HomeWork2.task3;
using HomeWork2.task4;



namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1 
            Student student = new Student("Amir Mohammad Shakouri", 22);
            student.Introduce();


            Console.WriteLine("-----------------task 2-----------------");

            //task 2
            BankAccount account = new BankAccount();
            account.Deposite(1000000);
            account.withdraw(999999);
            account.ShowBalance();


            Console.WriteLine("-----------------task 3-----------------");

            //task3

            Statistics statistics = new Statistics();

            Console.Write("enter the first number ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("enter the second number ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("enter the third number ");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInitial values:");
            Console.WriteLine($"first number {number1}");
            Console.WriteLine($"second number: {number2}");
            Console.WriteLine($"third number {number3}");

            statistics.AnalyzeNumbers(number1, ref number2, out number3);

            Console.WriteLine("\nInitial values affter the operation ");
            Console.WriteLine($"first number : {number1}");
            Console.WriteLine($"second number : {number2}");
            Console.WriteLine($"third number : {number3}");


            Console.WriteLine("-----------------task 4-----------------");


            //task4

            ArrayAnalyzer analyzer = new ArrayAnalyzer();

            Console.Write("enter the array elements ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($" eenter the {i + 1} element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            double average;

            analyzer.AnalyzeArray(numbers, ref max, out average);

            Console.WriteLine("\n results:");
            Console.WriteLine($"maximim : {max}");
            Console.WriteLine($"average: {average}");




        }
    }
}
