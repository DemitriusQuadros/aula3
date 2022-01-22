using System;
using POO.Classes;

namespace POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cidade objeto = new Cidade("Fernando");

            Console.WriteLine(objeto.LerPrefeito());
            objeto.Nome = "Ascurra";
            objeto.Extensao = 111.672;
            objeto.Relevo = "planas, onduladas e montanhas/serras cristalinas";
            objeto.Populacao = 7978;
            objeto.AumentarTemperatura(50);
            objeto.Eleicao("Marcelao da massa");
            objeto.UF = "SC";
            objeto.Pais = "Brasil";

            Console.WriteLine($@"
                A cidade { objeto.LerNome() } com extensao de { objeto.Extensao }
                e relevo de { objeto.Relevo } e populacao de { objeto.Populacao }
                com temperatura atual de { objeto.Temperatura } graus.
            ");

            objeto.AumentarTemperatura(8);


            Console.WriteLine($@"
                Temperatura atual em { objeto.LerNome() } é de { objeto.Temperatura }
            ");

            objeto.DiminuirTemperatura(12);

            Console.WriteLine($@"
                Temperatura atual em { objeto.LerNome() } é de { objeto.Temperatura }
            ");
        }
    }
}
