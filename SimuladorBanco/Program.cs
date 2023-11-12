// See https://aka.ms/new-console-template for more information
using SimuladorBanco;

Console.Clear();

ContaBancaria cb = new ContaBancaria();

cb.Nome = "Milton Tomé da Silva";
cb.NumeroConta = 12345;
cb.SaldoInicial = 100;

if(cb.CriarConta(cb.Nome,cb.NumeroConta,cb.SaldoInicial))
{
    cb.Depositar(cb, 100);
    cb.Sacar(cb, 100);
    cb.MostrarSaldo(cb,cb.NumeroConta);
}

