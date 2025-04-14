namespace problemSolving__Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First problem
            //1-write a C# program that take you name and put it in welcome statement
            //2-write a C# program that take two inputs then return the sum of them

            // Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            // Console.WriteLine($"hello {name},Nice to meet you");


            // Console.WriteLine("Enter the first number");
            //int x=int.Parse( Console.ReadLine());

            // Console.WriteLine("Enter the second number");
            // int y =Convert.ToInt32( Console.ReadLine());

            // Console.WriteLine($"The Result is : {x+y}"); 
            #endregion

            #region Second Problem
            //write a C# calc that do simple math operations +,-,*,/

            //Console.WriteLine(  "Enter the first item:");
            //var x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second item:");

            //var y = Convert.ToInt32(Console.ReadLine());

            //var opt = 'z';
            //while (opt !='e' || opt != 'E')
            //{

            //Console.WriteLine("Enter the opt type ... where \n + A means Add \t\t \t - S means subtract \n * M means Multply \t\t / D means divide \n\t\t\t\t E means Exit");
            // opt = Convert.ToChar(Console.ReadLine());
            //    if (opt == 'a' || opt == 'A')
            //        Console.WriteLine($"the Result is : {x + y}");
            //    if (opt == 's' || opt == 'S')
            //        Console.WriteLine($"the Result is : {x - y}");
            //    if (opt == 'm' || opt == 'M')
            //        Console.WriteLine($"the Result is : {x * y}");
            //    if (opt == 'd' || opt == 'D')
            //        Console.WriteLine($"the Result is : {x / y}");
            //    Console.WriteLine(  "-------------------------------------\n"); 
            #endregion


            //write a program to swap two numbers
            Console.WriteLine(  "Enter the first number: ");
            int x = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter the second number: ");
            int y = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine($"items berfor swap : \n x = {x} \t y = {y}");

            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"items After swap : \n x = {x} \t y = {y}");

        }



    }
    
}
