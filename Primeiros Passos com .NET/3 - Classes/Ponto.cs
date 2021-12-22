namespace Classes.Valores
{
    public class Ponto
    {
        public int x, y;
        private double distancia;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected double CalcularDistancia(Ponto a, Ponto b)
        {
            distancia = Math.Sqrt(Math.Pow((a.x)-(b.x), 2) + Math.Pow((a.y) - (b.y), 2));
          
            return distancia;
        }
        public double MetodoPublico(Ponto a, Ponto b)
        {
            distancia = Math.Sqrt(Math.Pow((a.x)-(b.x), 2) + Math.Pow((a.y) - (b.y), 2));
          
            return distancia;
        }
    }
}