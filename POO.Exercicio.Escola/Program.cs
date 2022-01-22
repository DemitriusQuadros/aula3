using System;
using System.Collections.Generic;

namespace POO.Exercicio.Escola
{
    class MainClass
    {
        /*
            Exercicio: Criar um projeto com duas classes,
                Professor(Nome, idade, Materias)
                Materia(Nome, Metodologia (presencial ou ead)

        Obs Qualquer valor diferente de presencial e ead nao pode
        ser aceito.

        Objetivo, poder cadastrar uma lista de professores e matérias
        podendo relacionar o professor com a matéria.

        Deve existir uma opçao para imprimir todos os professores e matérias
            
         */
        public static void Main(string[] args)
        {
            List<Professor> professores = new List<Professor>();

            var opcao = "";
            while (opcao != "3")
            {
                Console.Clear();
                ImprimirMenu();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        professores.Add(CadastrarProfessor());
                        break;
                    case "2":
                        ImprimirProfessores(professores);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ImprimirProfessores(List<Professor> professores)
        {
            foreach (var professor in professores)
            {
                Console.WriteLine($"Professor { professor.Nome } com idade de { professor.Idade }");
                foreach (var materia in professor.Materias)
                {
                    Console.WriteLine($" - Materia: {materia.Nome} Metodologia: {materia.Metodologia}");
                }
            }
            Console.ReadKey();
        }

        private static Professor CadastrarProfessor()
        {
            Professor professor = new Professor();
            Console.WriteLine("Informe o nome do professor");
            professor.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade do professor");
            professor.Idade = Convert.ToInt32(Console.ReadLine());

            var nomeMateria = "";
            while (nomeMateria != "sair")
            {
                Console.WriteLine("Informe o nome da materia ou sair para terminar");
                nomeMateria = Console.ReadLine();
                if (nomeMateria != "sair")
                {
                    Console.WriteLine("Informe a metodologia");
                    var metodologia = Console.ReadLine();
                    var materia = new Materia(nomeMateria, metodologia);
                    professor.Materias.Add(materia);
                }
            }
            return professor;
        }

        private static void ImprimirMenu()
        {
            Console.WriteLine("1 - Para Cadastrar Professor");
            Console.WriteLine("2 - Para imprimir professores e materias");
            Console.WriteLine("3 - Para Sair");
        }
    }
}
