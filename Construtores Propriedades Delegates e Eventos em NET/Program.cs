using System;
using Construtores_Propriedades_Delegates_e_Eventos_em_NET.Models;

namespace Construtores_Propriedades_Delegates_e_Eventos_em_NET
{
    class Program
    {
        static void Main (string[] args)
        {
           Data data = new Data();
           //data.GetMes();
           //data.SetMes(12);
           data.Mes = 120;
           data.Apresentar();
           
           
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa("Danilo", "Domingues Quirino");
            p2.apresentar();

            Log log1 = Log.Instancia();
            log1.PropriedadeLog = "Teste de Instancia.";

            Log log2 = Log.Instancia();
            Console.WriteLine(log2.PropriedadeLog);

            Console.WriteLine();
            Aluno aluno1 = new Aluno ("Danilo", "Domingues Quirino", "AP2C2");


        }
    }
}