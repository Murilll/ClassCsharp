public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public float Salário { get; set; } = 1000;
    public int Faltas { get; set; } = 0;

    public Funcionario(string nome, string cPF, int salário, int faltas)
    {
        Nome = nome;
        CPF = cPF;
        Salário = salário;
        this.Faltas = faltas;
    }

    public void GetBonificacao(float boni)
    {
        this.Salário = this.Salário + boni;
    }

    public void AumentarSalario(float aumento)
    {
        this.Salário = this.Salário + aumento;
    }

    public int Faltou()
    {
        return this.Faltas;
    }

    public void GetFaltas(int faltou)
    {
        this.Faltas = this.Faltas + faltou;
    }
}