using System;


namespace Uppgift3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara med J för ja och N för nej");
            string gymnasiet = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            string gammal = Console.ReadLine();
            int ålder = int.Parse(gammal);
            if (ålder <= 21 && gymnasiet == "j") 
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }

        }
    } }