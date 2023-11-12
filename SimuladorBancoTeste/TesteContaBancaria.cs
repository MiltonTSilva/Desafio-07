using SimuladorBanco;

namespace SimuladorBancoTestes;

public class TesteContaBancaria : IAsyncLifetime
{
    static List<ContaBancaria> contas = new List<ContaBancaria>();

    private ContaBancaria conta = new()
    {
        Nome = "Milton Tomé da Silva",
        NumeroConta = 12345
    };

    [Fact]
    public void ContaDeveSerCriadaComSucesso()
    {
        // Arrange
        conta.SaldoInicial = 100;

        // Act
        var resultado = conta.CriarConta(conta.Nome, conta.NumeroConta, conta.SaldoInicial);
        contas.Add(conta);

        // Assert
        Assert.True(resultado);

    }

    [Fact]
    public void ContaDeveExistir()
    {
        // Arrange
        conta.NumeroConta = 12345;

        // Act
        var resultado = conta.ConsultarConta(contas, conta.NumeroConta);

        // Assert
        Assert.True(resultado);

    }

    [Fact]
    public void DepositarValorEfetuadoComSucesso()
    {
        // Arrange
        conta.Valor = 100;

        // Act
        var resultado = conta.Depositar(conta, conta.Valor);
        Console.WriteLine(conta.Saldo);

        // Assert
        Assert.True(resultado);

    }

    [Fact]
    public void SacarValorEfetuadoComSucesso()
    {
        // Arrange
        conta.Valor = 150;

        // Act
        var resultado = conta.Sacar(conta, conta.Valor);

        // Assert
        Assert.True(resultado);

    }

    [Fact]
    public void MostraSaldoEfetuadoComSucesso()
    {
        // Arrange
        conta.NumeroConta = 12345;

        // Act
        var resultado = conta.MostrarSaldo(conta, conta.Valor);

        // Assert
        Assert.True(resultado);

    }
    public async Task InitializeAsync()
    {
        ContaDeveSerCriadaComSucesso();

    }

    public async Task DisposeAsync()
    {
        contas.Clear();
    }
}
