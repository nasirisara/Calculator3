using System;

namespace Calculator3
{
    class Program
    {
        static void Main(string[] args)

        {
            string strnum1, opera, strnum2;
           strnum1= Console.ReadLine();
            opera = Console.ReadLine();
            strnum2 = Console.ReadLine();
            double num1, num2;
            num1 = double.Parse(strnum1);
            num2 = double.Parse(strnum2);

            switch (opera)
            {
                case "+": Console.WriteLine(num1 + num2);
                    break;

                case "-": Console.WriteLine(num1 - num2);
                    break;

                case "/": Console.WriteLine(num1 / num2);
                    break;

                case "*": Console.WriteLine(num1 * num2);
                    break;
                    
            }


            Console.ReadKey();



           
        }
    }
}
