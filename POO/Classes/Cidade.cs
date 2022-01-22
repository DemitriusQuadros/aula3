using System;
using System.Collections.Generic;

namespace POO.Classes
{
    public class Cidade
    {
        //Atributos (propriedades)
        public double Extensao { get; set; }
        public decimal Populacao { get; set; }
        public string Nome { private get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public decimal Temperatura { get; private set; }
        public string Relevo { get; set; }
        public List<String> Normas { get; set; }

        private string Prefeito { get; set; }

        //comportamentos (metodos)
        public void CriarNormas(string novaNorma)
        {
            if (Normas == null)
                Normas = new List<string>();

            Normas.Add(novaNorma);
        }

        //Construtor
        public Cidade(string nomePrefeito)
        {
            Prefeito = nomePrefeito;
        }

        public string LerPrefeito()
        {
            return Prefeito;
        }

        public string LerNome()
        {
            return $"{ Prefeito } - { Nome }";
        }
        public void AumentarTemperatura(decimal aumentar)
        {
            if (aumentar > 50)
                throw new Exception("Temperatura nao pode aumentar mais de 50 graus por vez");
            Temperatura += aumentar;
        }

        public void DiminuirTemperatura(decimal diminuir)
        {
            Temperatura -= diminuir;
        }

        public void Eleicao(string prefeito)
        {
            Prefeito = prefeito;
        }
    }
}
