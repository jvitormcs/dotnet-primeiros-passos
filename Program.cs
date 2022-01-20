using System;

namespace Revisao {

    class Program {

        static void Main (String[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "4")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        break;

                    case "2":
                        //TODO: Listar Aluno
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




