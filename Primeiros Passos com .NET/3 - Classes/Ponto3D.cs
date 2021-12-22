namespace Classes.Valores
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }

    public class Distancias 
    {
        double dist;
        public double CalcularDistancia (Ponto a, Ponto b) 
        {
            dist = Math.Sqrt(Math.Pow((a.x)-(b.x), 2) + Math.Pow((a.y) - (b.y), 2));
            return dist;
        }
    }
}