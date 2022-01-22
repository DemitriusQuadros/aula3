using System;
using System.Collections.Generic;

namespace POO.Exercicio.Escola
{
    public class Professor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public List<Materia> Materias { get; private set; }

        public Professor()
        {
            Materias = new List<Materia>();
        }

       
    }
}
