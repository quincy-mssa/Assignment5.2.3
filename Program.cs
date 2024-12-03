using static System.Net.Mime.MediaTypeNames;

namespace Assignment5._2._3
{
    internal class Program
    {
        //Write a program in C# Sharp to print numbers from n to 1 using recursion.
        //Test Data :
        //How many numbers to print : 10
        //Expected Output :
        //10 9 8 7 6 5 4 3 2 1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            CountNumber(num);

        }

        static void CountNumber(int num)
        {

            if (num > 0)
            {
                Console.Write($"{num} ");

                CountNumber(num - 1);


            }
        }





    }
}
