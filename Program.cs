using POO.classes.models;
namespace POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta Teste";
            conta.NumeroConta = 0612;
            conta.Agencia = 0006;
            conta.Saldo = 1000;

            var Titular = new Titular()
            {
                CPF = "1231231",
                RG = "61212",
                Endereco = "Avenida Paulista",
                Nome = "Matheus"
            };

            System.Console.WriteLine($"O Saldo Atual é: {conta.VerSaldo()}");
            conta.Depositar(100);
            System.Console.WriteLine($"O saldo atual , após deposito é de: {conta.VerSaldo()}");
            conta.Sacar(10000);
            System.Console.WriteLine($"O saldo atual , após o saque é de: {conta.VerSaldo()}");

            Console.ReadLine();
        }
    }
}