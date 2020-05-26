using System;

namespace Password
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;
            string password = "2002";

            while (true)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine("Senha Correta. Favor, fechar aplicativo.");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }

            }
        }
    }
}
