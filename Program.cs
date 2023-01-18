using System.Runtime.CompilerServices;

public class calc
{
    public static void Main(string[] args)
    {



        void additionmethod()
        {
            Console.WriteLine("Enter the first Number");
            int numba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int numba2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of adding " + (numba1) + " and " + (numba2) + " is: " + (numba2 + numba1));
            Console.WriteLine(" ");
        }

        void subtractionmethod()
        {
            Console.WriteLine("Enter a Number to subtract from: ");
            int numba3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Number to subtract from: " + (numba3));
            int numba4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of subtracting " + (numba4) + " from " + (numba3) + " is: " + (numba3 - numba4));
            Console.WriteLine(" ");
        }

        void divisionmethod()
        {
            Console.WriteLine("Enter a Number to divide from: ");
            int numba3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Number to divide from: " + (numba3));
            int numba4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of dividing " + (numba3) + " by " + (numba4) + " is: " + (numba3 / numba4));
            Console.WriteLine(" ");
        }

        void multimethod()
        {
            Console.WriteLine("Enter the first Number to multiply: ");
            int numba3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number to multiply: " + (numba3));
            int numba4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of Multiplying " + (numba3) + " and " + (numba4) + " is: " + (numba3 * numba4));
            Console.WriteLine(" ");
        }


        if (true)
        {
            Console.WriteLine("What operation would you like to perform?");
            Console.WriteLine(" ");
            Console.WriteLine("1: Division ");
            Console.WriteLine("2: Multiplication ");
            Console.WriteLine("3: Addition ");
            Console.WriteLine("4: Subtraction ");
            Console.WriteLine("5: EXIT ");
            Console.WriteLine(" ");

        }
        string operation = Console.ReadLine();
        string operation1 = Convert.ToString(operation);
        string lowerop = operation1.ToLower();

        {




            if (operation == "5" | lowerop == "exit")
            {
                Console.WriteLine("Goodbye! ");
                Console.WriteLine(" ");
                Console.WriteLine("5");
                Console.WriteLine(" ");
                Thread.Sleep(1000);
                Console.WriteLine("4");
                Console.WriteLine(" ");
                Thread.Sleep(1000);
                Console.WriteLine("3");
                Console.WriteLine(" ");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Console.WriteLine(" ");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);


                Environment.Exit(0);

            }




            else if (lowerop == "addition" | operation == "3")

            {

                additionmethod();
            }




            else if (operation == "4" | lowerop == "subtraction")

            {
                subtractionmethod();
            }



            else if (lowerop == "division" | operation == "1")
            {
                divisionmethod();
            }






            else if (lowerop == "multiplication" || operation == "2")
            {
                multimethod();
            }



        }
    }
}


