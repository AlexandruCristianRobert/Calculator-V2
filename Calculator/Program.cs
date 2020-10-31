using System;

namespace Calculator
{
    class Calculator
    {
        public static Double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;//valoarea de start e Non-numar ce va fi folosita in situatii in care da eroare.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    //verificare pentru impartire la 0 
                    if (num2 != 0)
                    {
                        result = num1 / num2;

                    }
                    break;
                default:
                    break;

            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Calculator in C# /n");
            Console.WriteLine("----------/n");

            while (!endApp)
            {
                string numInput1 = " ";
                string numInput2 = " ";
                double result = 0;

                //introducerea primului nr
                Console.WriteLine("Introdu primul numar si apasa Enter ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("Nu e un input valid, introdu un  numar");
                    numInput1 = Console.ReadLine();

                }
                //introducerea celui de-al doilea nr
                Console.WriteLine("Introdu primul numar si apasa Enter ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("Nu e un input valid, introdu un  numar");
                    numInput2 = Console.ReadLine();

                }
                Console.WriteLine("Alege optiunea de calcul");
                Console.WriteLine("\ta - Adunare");
                Console.WriteLine("\ts - Scadere");
                Console.WriteLine("\tm - Inmultire");
                Console.WriteLine("\td - Impartire");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Aceasta operatia va rezulta intr-o eroare");

                    }
                    else
                        Console.WriteLine("Rezultatul tau este: {0:0.##}\n", result);

                }
                catch (Exception e)
                {
                    Console.WriteLine("O nu , ai prins exceptia " + e.Message);
                }
                Console.WriteLine("----------\n");
                Console.WriteLine("Apasa tasta 'n' pentru a inchide programul sau apasa orice alta tasta pentru a face alt calcul");
                if (Console.ReadLine() == "n")
                    endApp = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
