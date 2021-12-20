using System;
using System.Collections.Generic;
using System.Text;
using InfoPessoas;
using Interface;
using Enum;





namespace CSharp
{
    class Pessoa {

        static void Main(string[], args)
        {
            personX = (Pessoas)0; // Chamando item 0 do Enum
            Pessoa personY = Pessoas.Gustavo; // Chamando um item do enum

            Pessoa person1 = new Pessoa();

            person1.Nome = "Danilo ";
            person1.Sombrenome = "D. Quirino ";
            person1.Idade = 25;
            person1.Estado = "SP";

            var person2 = new Pessoa();
            person2.Nome = "Daniele ";
            person2.Sombrenome = "D. Quirino ";
            person2.Idade = 22;
            person2.Estado = "SP";


            Animal animal = new Animal();
            animal.Nome = "Lucinha";
            animal.nomeDono = "Daniele";
            animal.Especie = "Cadela";
        }
    }
}
