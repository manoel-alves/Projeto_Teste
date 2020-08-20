using System;

namespace Projeto_Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá Mundo,");

            DateTime now = DateTime.Now;
            int horas = now.Hour;

            if (horas >= 18 && horas < 24)
            {
                Console.WriteLine("Boa Noite!");
            }
            else if (horas > 12)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                Console.WriteLine("Bom dia!");
            }


            Console.ReadLine();

        }
    }
}
