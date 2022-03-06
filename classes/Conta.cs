namespace POO.classes.models
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string NomeConta { get; set; }
        public Titular Titular { get; set; }

        public decimal Saldo { get; set; }

        public decimal VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine($"Saque de {valor} reais não pode ser realizado pois não há saldo suficiente!!!");
            }
        }


    }
}