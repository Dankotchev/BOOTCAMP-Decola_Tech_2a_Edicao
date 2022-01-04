using System;
using System.IO;
using POOcomCSharp.Models;
using POOcomCSharp.Escola;
using POOcomCSharp.Banco;
using POOcomCSharp.Interfaces;

namespace POOcomCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Criando uma classe - Conceito de Abstração
            Pessoa p1 = new Pessoa();
            p1.Nome = "Danilo";
            p1.Idade = 25;
            p1.Apresentar();

            /// Conceito de Herança e Polimorfismo
            Aluno a1 = new Aluno();
            a1.Nome = "Daniele";
            a1.Idade = 22;
            a1.Nota = 8;
            a1.Apresentar();

            Professor pr1 = new Professor();
            pr1.Nome = "Tereza";
            pr1.Idade = 57;
            pr1.Salario = 2566.58;
            pr1.Apresentar();

            /// Metodos Selados
            Diretor d1 = new Diretor();
            d1.Nome = "Lucas";
            d1.Idade = 56;
            d1.Salario = 3100;
            d1.Apresentar();

            /// Conceito de Encapsulamento
            Retangulo r = new Retangulo();
            r.DefineMedidas(27, 36);
            Console.WriteLine($"A Area é: {r.ObterArea()}");

            /// Polimorfismo por tempo de Compilação
            Calculadora cal1 = new Calculadora();
            Console.WriteLine();
            Console.WriteLine($"Resultado da Primeira soma: 10 + 10 = {cal1.Somar(10, 10)}");
            Console.WriteLine($"Resultado da Segunda soma: 10 + 10 + 15  = {cal1.Somar(10, 10, 15)}");
            Console.WriteLine();
            /// Interfaces
            ICalculadora cal2 = new Calculadora();
            Console.WriteLine($"Resultado da Subtração: 38 - 17 = {cal2.Subtrair(38, 17)}");
            Console.WriteLine($"Resultado da Multiplicação: 45 * 19 = {cal2.Multiplicar(45,19)}");
            Console.WriteLine($"Resultado da Divisão: 45 / 5 = {cal2.Dividir(45,5)}");
            Console.WriteLine();

            /// Conceito de Classes Abstratas
            Corrente cc1 = new Corrente();
            cc1.Creditar(250);
            cc1.ExibirSaldo();

            /// Classe Object
            Console.WriteLine();
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(pr1.ToString());
            Computador pc = new Computador();
            Console.WriteLine(pc.ToString());

            /// Arquivos e Diretorios
            //Diretórios
            var caminho = "C:\\TrabalhandoComArquivos";
            AjudaArquivos help = new AjudaArquivos();
            help.ListarDiretorios(caminho);
            // Arquivos
            help.ListarArquivos(caminho);
            // Criar Diretorios
            var caminhoPathCombine = Path.Combine(caminho, "Pasta_Teste_03", "SubPasta_Teste_03");
            Console.WriteLine("Criando um Diretório: " + caminhoPathCombine);
            help.CriarDiretorio(caminhoPathCombine);
            // Apagar Diretórios
            help.ApagarDiretorio(Path.Combine(caminho, "Pasta_Teste_03"),true);
            Console.WriteLine();
            // Criar Arquivo
            var caminhoArquivo = Path.Combine(caminho,"Arquivo-teste.txt");
            help.CriarArquivoTexto(caminhoArquivo, "Olá Mundo! Teste de Criação de Arquivos");
            // Criar Arquivo texto Stream
            var listaString = new List<string> {"Linha 1","Linha 2", "Linha 3", "Linha 4"};
            var caminhoArquivoStrem = Path.Combine(caminho, "Arquivo-textoStrem.txt");
            help.CriarArquivoTextoStream(caminhoArquivoStrem, listaString);
            Console.WriteLine();
        }
    }
}
