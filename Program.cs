using System;

namespace Revisao {

    class Program {

        static void Main (String[] args)
        {

            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "4")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)) {

                        aluno.Nota = nota;

                        }
                        else {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }


                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach(var alunoCadastrado in alunos) {
                            
                            if(!string.IsNullOrEmpty(alunoCadastrado.Nome)){

                                Console.WriteLine($"Aluno: {alunoCadastrado.Nome} - Nota: {alunoCadastrado.Nota}");
                                Console.WriteLine();
                            }


                        }

                        break;

                    case "3":
                        //TODO: Calcular média geral
                        break;

                    default:

                        throw new ArgumentOutOfRangeException();
 
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

        }

        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular Média Geral");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}




