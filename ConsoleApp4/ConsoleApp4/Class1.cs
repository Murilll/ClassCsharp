
public class ContaCorrente
{
    public string NúmeroConta { get; set; }
    public string Nome { get; set; }
    public int Saldo { get; set; }

    public ContaCorrente(string númeroConta, string nome, int saldo)
    {
        this.NúmeroConta = númeroConta;
        this.Nome = nome;
        this.Saldo = saldo;
    }

    public void alterarNome(string nome)
    {
        this.Nome = nome;
    }

    public void deposito(int depositar)
    {
        this.Saldo = this.Saldo + depositar;
    }

    public void saque(int sacar)
    {
        this.Saldo = this.Saldo - sacar;
    }
}