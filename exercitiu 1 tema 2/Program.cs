
using System;

namespace MyFirstProgram2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;


            while (n != 0)
            {

                int cifra = n % 10;
                sum = sum + cifra;
                n = n / 10;



            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }//Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura.


}
