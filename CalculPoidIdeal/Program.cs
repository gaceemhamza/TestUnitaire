using System;

namespace CalculPoidIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculePoid poid = new CalculePoid()
            {
                Taille = 180,
                Sexe = 'm'
            };

            double PoidIdeal = poid.GetPoidIdeal();

            Console.WriteLine($"le poid ideat est:{ PoidIdeal}");


            if( PoidIdeal == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("test reussi");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("test echouer");
            }

            poid.Sexe = 'f';
            PoidIdeal = poid.GetPoidIdeal();
            if (PoidIdeal == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("test reussi");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("test echouer");
            }



        }

    }
}
