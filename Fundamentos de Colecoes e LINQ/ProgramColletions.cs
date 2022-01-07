using System.Collections.Generic;
using Fundamentos_de_Colecoes_e_LINQ.Models;
namespace Fundamentos_de_Colecoes_e_LINQ
{
    class Program_Colletions
    {
        static void Main_(string[] args)
        {
            // Aula de Listas
            List<string> estados = new List<string>() { "Mato Grosso do Sul", "Mato Grosso", "Goiás" };
            OperacoesLista opList = new OperacoesLista();
            string[] estadosArray = new string[3] { "Paraná", "Santa Catarina", "Rio Grande do Sul" };
            estados.Add("São Paulo");
            estados.Add("Minas Gerais");
            estados.Add("Rio de Janeiro");
            estados.Add("Espírito Santo");

            opList.ImprimirListaString(estados);

            opList.RemoverElemento(estados, "Rio de Janeiro");
            opList.ImprimirListaString(estados);

            opList.RemoverElementoIndice(estados, 1);
            opList.ImprimirListaString(estados);

            opList.AdicionarPartirString(estados, estadosArray);
            opList.ImprimirListaString(estados);

            opList.AdicionarPorIndice(estados, 0, "Distrito Federal");
            opList.ImprimirListaString(estados);

        }
    }
}