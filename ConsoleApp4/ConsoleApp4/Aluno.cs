public class Alunos
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string DataNascimento { get; set; }
    public int Faltas { get; set; }
    public float Nota1 { get; set; }
    public float Nota2 { get; set; }
    public bool Recuperaçao { get; set; }

    public Alunos(string nome, string CPF, string datanascimento, int faltas, float nota1, float nota2)
    {
        this.Nome = nome;
        this.CPF = CPF;
        this.DataNascimento = datanascimento;
        this.Faltas = faltas;
        this.Nota1 = nota1;
        this.Nota2 = nota2;
    }

    public void Faltou()
    {
        Faltas++;
    }

    public int GetFaltas()
    {
        return this.Faltas;
    }

    public void SetNotas1(float nota)
    {
        this.Nota1 = this.Nota1 + nota;
    }

    public void SetNotas2(float nota)
    {
        this.Nota2 = this.Nota2 + nota;
    }

    public float MediaNotas()
    {
        float media = (this.Nota1 + this.Nota2) / 2;
        return media;
    }

    public bool Aprovado()
    {
        if (MediaNotas() >= 70)
        {
            return true;
        }
        else
            return false;
    }
}