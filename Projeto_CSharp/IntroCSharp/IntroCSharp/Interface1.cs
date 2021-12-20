namespace Interface    
{
    interface IAnimal   
    {
        void Nome(string nome);
        void Dono (string nomeDono);
        void Especie(string Especie);
    }

    class Animal : IAnimal
    {
        public string nome { get; set; }
        public string Dono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.Dono = nomeDono;
        }

        void IAnimal.Especie(string Especie)
        {
            this.Especie = Especie;
        }
    }
}
