namespace POOcomCSharp.Banco
{
    public abstract class Conta
    {
        protected double Saldo;
        public abstract void Creditar(double valor);

        public void ExibirSaldo ()
        {
            Console.WriteLine($"Seu Saldo Atual é de R$ {Saldo}"); 
        }
    }

    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            this.Saldo =+ valor;
        }
    }
}