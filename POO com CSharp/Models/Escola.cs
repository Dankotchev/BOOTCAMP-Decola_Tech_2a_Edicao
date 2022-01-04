using POOcomCSharp.Models;
namespace POOcomCSharp.Escola
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override  void Apresentar ()
        {
            Console.WriteLine();
            Console.WriteLine($"Olá, sou o Aluno {Nome}, tenho {Idade} anos e sou nota {Nota}!");
        }
    }
        public class Professor : Pessoa
    {
        public double Salario { get; set; } 
        public sealed override void Apresentar()
        {
            Console.WriteLine();
            Console.WriteLine($"Olá, Sou o professor {Nome}, tenho {Idade} anos e meu salário é de {Salario} reais.");
        }
    }

    public class Diretor : Professor
    {

    }
}