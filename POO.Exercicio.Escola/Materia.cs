using System;
namespace POO.Exercicio.Escola
{
    public class Materia
    {
        public string Nome { get; set; }
        public string Metodologia { get; private set; }

        public Materia(string nome, string metodologia)
        {
            Nome = nome;
            CadastrarMetodologia(metodologia);
        }

        private void CadastrarMetodologia(string metodologia)
        {
            if (metodologia == "presencial" || metodologia == "ead")
                Metodologia = metodologia;
            else
                throw new Exception("Metodologia invalidad, so pode aceitar presencial e ead");
        }
    }
}
