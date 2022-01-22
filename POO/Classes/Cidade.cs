using System;
using System.Collections.Generic;

namespace POO.Classes
{
    public class Cidade
    {
        //Atributos (propriedades)
        public double Extensao { get; set; }
        public decimal Populacao { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public decimal Temperatura { get; set; }
        public string Relevo { get; set; }
        public List<String> Normas { get; set; }


        //comportamentos (metodos)
        public void CriarNormas(string novaNorma)
        {
            if (Normas == null)
                Normas = new List<string>();

            Normas.Add(novaNorma);
        }

        public void AumentarTemperatura(decimal aumentar)
        {
            Temperatura += aumentar;
        }

        public void DiminuirTemperatura(decimal diminuir)
        {
            Temperatura -= diminuir;
        }
    }
}
