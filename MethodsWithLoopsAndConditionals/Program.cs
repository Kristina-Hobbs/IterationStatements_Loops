using System;

namespace MethodsWithLoopsAndConditionals
//Write a method that will print to the console all numbers 1000 through -1000.
{
    class Program
    {
        static void Main(string[] args)
         {
        PrintThousand();
         }

        public static void PrintThousand()
         {
        for (int i = 1000; i >= -1000; i--)
          {
        Console.WriteLine(i);
          }
         }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        static void Main(string[] args)
        {
         ByThrees();
        }


        public static void ByThrees()
        {
        for (int k = 3; k <= 999; k += 3)
        {
         Console.WriteLine(k);
        }
        }


        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Write a method to check whether a given number is even or odd.

        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered number is an Odd Number");
            }
        }



        //Write a method to check whether a given number is positive or negative.
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number ; ");
            n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                Console.WriteLine(n + " is a positive number.");
            }
            if(n < 0)
            {
                Console.WriteLine(n + " is a negative number.");
            }
        }


        Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        static void Main(string[] args)
        {
            int voterAge;
            Console.WriteLine("What is your age?");
            voterAge = int.Parse(Console.ReadLine());

            if(voterAge >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote.");
            }
        }



        Write a method to check if an integer (from the user) is in the range -10 to 10.
        static void Main(String[] args)
        {
            int number;
            Console.WriteLine("Give me a number between -10 and 10.");
            number = int.Parse(Console.ReadLine());
        
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine("That is correct!");
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }



        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void Main()
        {
            int j,n;
            Console.Write("\n\n");
            Console.Write("Display the multiplication table:\n");
            Console.Write("---------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number (Table to be calculated) : ");
            n= Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for(j=1;j<=10;j++)
            {
                Console.Write("{0} x {1} = {2} \n", n,j,n*j);
            }
        }
    }
}
