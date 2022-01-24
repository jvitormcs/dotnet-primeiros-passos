using System;

namespace Revisao {

    class Program {

        static void Main (String[] args)
        {

            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "5")
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
                        Console.WriteLine();
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
                        Console.WriteLine("Nome a ser procurado");
                        var nome = Console.ReadLine();
                        foreach (var alunoCadastrado in alunos)
                        {   if(!string.IsNullOrEmpty(alunoCadastrado.Nome)){

                            if(nome == alunoCadastrado.Nome){
                                Console.WriteLine($"O aluno {nome}, foi encontrado");
                            }
                            else{
                                Console.WriteLine("Aluno não existente");
                            }
                            Console.WriteLine();

                         }
                        }
                           

                        break;

                    case "4":
                        decimal notaTotal = 0;
                        var alunosTotal = 0;
                        for (int i = 0; i < alunos.Length; i++) {

                        if(!string.IsNullOrEmpty(alunos[i].Nome)){
                            
                            notaTotal = notaTotal + alunos[i].Nota;
                            alunosTotal++;
                        }

                        }
                        
                        var mediaGeral = notaTotal/alunosTotal;
                        Conceito conceitoGeral;

                        if (mediaGeral <= 2) {
                            
                            conceitoGeral = Conceito.E;

                        }
                        else if (mediaGeral <= 4) {
                             conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral <= 6) {
                             conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral <= 8) {
                             conceitoGeral = Conceito.B;
                        }
                        else{
                             conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"A Média Geral: {mediaGeral}, Conceito: {conceitoGeral} ");
                        Console.WriteLine();

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
            Console.WriteLine("3- Achar Alunos");
            Console.WriteLine("4- Calcular Média Geral");
            Console.WriteLine("5- Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}




