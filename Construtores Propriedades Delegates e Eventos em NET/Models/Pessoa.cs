using System;

namespace Construtores_Propriedades_Delegates_e_Eventos_em_NET.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor da Classe Pessoa...");
        }
        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}!");
        }
    }

    public class Aluno : Pessoa
    {
        private string disciplina;
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            this.disciplina = disciplina;
            Console.WriteLine("Construtor da Classe Aluno...");
        }
    }
}