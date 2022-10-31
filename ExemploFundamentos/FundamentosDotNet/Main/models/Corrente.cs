namespace Main.models
{
    public class Corrente:Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor; 
        }
    }
}