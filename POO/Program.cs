using System;
using POO.Classes;

namespace POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cidade objeto = new Cidade();
            objeto.Nome = "Ascurra";
            objeto.Extensao = 111.672;
            objeto.Relevo = "planas, onduladas e montanhas/serras cristalinas";
            objeto.Populacao = 7978;
            objeto.Temperatura = 32;
            objeto.UF = "SC";
            objeto.Pais = "Brasil";

            Console.WriteLine($@"
                A cidade { objeto.Nome } com extensao de { objeto.Extensao }
                e relevo de { objeto.Relevo } e populacao de { objeto.Populacao }
                com temperatura atual de { objeto.Temperatura } graus.
            ");

            objeto.AumentarTemperatura(8);


            Console.WriteLine($@"
                Temperatura atual em { objeto.Nome } é de { objeto.Temperatura }
            ");

            objeto.DiminuirTemperatura(12);

            Console.WriteLine($@"
                Temperatura atual em { objeto.Nome } é de { objeto.Temperatura }
            ");
        }
    }
}
