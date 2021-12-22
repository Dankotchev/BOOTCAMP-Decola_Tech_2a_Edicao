using System;

namespace RevisaoProjetoAluno
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Opcao;
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            do
            {
                Opcao = ObterOpcaoEscolhida();

                if (Opcao != "X")
                {
                    switch (Opcao)
                    {
                        case "1": /// Adiciona Novo Aluno
                            Console.WriteLine("Informe o Nome do Aluno:");
                            var aluno = new Aluno();
                            aluno.Nome = Console.ReadLine();

                            Console.WriteLine("Informe a Nota Obtida: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                            {
                                aluno.Nota = nota;
                            }
                            else
                            {
                                throw new ArgumentException("Valor da nota deve ser um Decimal");
                            }

                            alunos[indiceAluno] = aluno;
                            indiceAluno++;

                            break;

                        case "2": /// Listar Todos Alunos
                            foreach (var item in alunos)
                            {
                                if (!string.IsNullOrEmpty(item.Nome))
                                {
                                    Console.WriteLine($"ALUNO: {item.Nome} - NOTA: {item.Nota}");
                                }

                            }
                            break;

                        case "3": /// Calcular Média Geral
                        decimal notaTotal = 0;
                        var qntAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                qntAlunos ++;
                            }
                        }

                        var mediaGeral = notaTotal / qntAlunos;
                        Console.WriteLine($"Média Geral dos Alunos é {mediaGeral}");

                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Opçao escolida não válida");

                    }
                }
            } while (Opcao != "X");
        }

        private static string ObterOpcaoEscolhida()
        {
            string Opcao;
            Console.WriteLine("Informe a Opção desejada:");
            Console.WriteLine("1 - Inserir novo Aluno;");
            Console.WriteLine("2 - Listar Alunos; ");
            Console.WriteLine("3 - Calcular Média Geral.");
            Console.WriteLine();
            Console.WriteLine("X - Para Encerrar");
            Console.WriteLine();
            Opcao = Console.ReadLine();
            Console.WriteLine();
            Opcao.ToUpper();
            return Opcao;
        }
    }
}

