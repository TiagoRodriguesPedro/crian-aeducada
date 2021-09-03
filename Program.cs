using System;

namespace crian_aeducada
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavracensurada = "#@$%*!&";
            string frasedigitada,frasecensurada;
            
            Console.WriteLine("Digite uma frase");
            frasedigitada = Console.ReadLine();

            frasecensurada = frasedigitada
            .Replace("chato",palavracensurada)
            .Replace("Besta",palavracensurada)
            .Replace("feio",palavracensurada)
            .Replace("feia",palavracensurada)
            .Replace("boboca",palavracensurada)
            .Replace("boco",palavracensurada)
            .Replace("tonta",palavracensurada)
            .Replace("tonto",palavracensurada)
            .Replace("palerma",palavracensurada)
            .Replace("paspalho",palavracensurada)
            .Replace("tantã",palavracensurada)
            .Replace("burro",palavracensurada)
            .Replace("besta",palavracensurada);
            

            Console.WriteLine(frasecensurada);
        }
    }
}
