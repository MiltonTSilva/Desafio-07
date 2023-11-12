namespace SimuladorBanco;

public class ContaBancaria
{
    public string? Nome { get; set; }
    public int NumeroConta { get; set; }
    public double SaldoInicial { get; set; }
    public double Valor { get; set; }
    public double Saldo { get; private set; }


    public bool CriarConta(string? nome, int numeroConta, double saldoInicial)
    {
        try
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldoInicial;

            Console.WriteLine($"Conta de {Nome} criada dom sucesso com saldo inicial de {Saldo.ToString("C")}, número da conta: {NumeroConta}.");


            return true;
        }
        catch (System.Exception e)
        {

            throw new Exception(e.Message);

        }

    }

    public bool ConsultarConta(List<ContaBancaria> cb, double numeroConta)
    {
        bool contaEncontrada = false;

        foreach (var conta in cb)
        {
            if (conta.NumeroConta == numeroConta)
            {
                Console.WriteLine($"Conta {numeroConta} encontrada. Saldo atual: {conta.Saldo}");
                contaEncontrada = true;
                break;
            }
        }
        return contaEncontrada;
    }

    public bool Depositar(ContaBancaria cb, double valor)
    {
        try
        {
            cb.Saldo += valor;
            Console.WriteLine($"Depósito de {valor.ToString("C")} realizado com sucesso. Novo saldo: {cb.Saldo.ToString("C")}");
            return true;
        }
        catch (System.Exception e)
        {

            throw new Exception(e.Message);

        }

    }

    public bool Sacar(ContaBancaria cb, double valor)
    {
        try
        {
            bool sacou = false;

            if (valor > cb.Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                sacou = true;
            }
            else
            {
                cb.Saldo -= valor;
                Console.WriteLine($"Saque de {valor.ToString("C")} realizado com sucesso. Novo saldo: {cb.Saldo.ToString("C")}");

            }
            return sacou;
        }
        catch (System.Exception e)
        {

            throw new Exception(e.Message);

        }

    }

    public bool MostrarSaldo(ContaBancaria cb, double numeroConta)
    {
        bool contaEncontrada = false;
        try
        {

            Console.WriteLine($"Saldo atual da conta {NumeroConta}: {Saldo}");
            contaEncontrada = true;
        }
        catch (System.Exception)
        {

            throw;
        }

        return contaEncontrada;

    }
}
