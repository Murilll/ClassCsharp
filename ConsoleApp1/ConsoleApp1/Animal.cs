public abstract class Animal
{
    public string Name { get; set; }
    public string Raça { get; set; }
    public int QuantidadeDeVidas { get; set; } = 1;
    public string Dono { get; set; }
    public bool Domestico { get; set; }
    public string Habitat { get; set; }
    public string Textura { get; set; }
    public int Pata_nadadeira { get; set; }
    public string Som { get; set; }
    public bool Agua { get; set; }
    public bool Voa { get; set; }
    public string Power { get; set; }
    public int Velocidade { get; set; }
}

public class Cachorro : Animal
{
    public Cachorro(string name, string raça, string dono, bool domestico, string som, int velocidade, string textura, bool voa)
    {
        this.Name = name;
        this.Raça = raça;
        this.Dono = dono;
        this.Domestico = domestico;
        this.Som = som;
        this.Velocidade = velocidade;
        this.Textura = textura;
        this.Voa = voa;
    }

    public void MudarDono(string novoDono)
    {
        this.Name = novoDono;
    }

    public void Acelerou(int acelerar)
    {
        this.Velocidade = this.Velocidade + acelerar;
    }

    public void Freiou(int freio)
    {
        this.Velocidade = this.Velocidade - freio;
    }
}

public class Gato : Animal
{
    public Gato(string name, string raça, int quantidadedevidas, string dono, bool domestico, string som, int velocidade, string textura, bool voa)
    {
        this.Name = name;
        this.Raça = raça;
        this.QuantidadeDeVidas = quantidadedevidas;
        this.Dono = dono;
        this.Domestico = domestico;
        this.Som = som;
        this.Velocidade = velocidade;
        this.Textura = textura;
        this.Voa = voa;
    }

    public void Morreu()
    {
        this.QuantidadeDeVidas = this.QuantidadeDeVidas - 1;
    }

    public void Acelerou(int acelerar)
    {
        this.Velocidade = this.Velocidade + acelerar;
    }

    public void Freiou(int freio)
    {
        this.Velocidade = this.Velocidade - freio;
    }
}

public class Dragao : Animal
{
    public Dragao(string name, string raça, int quantidadedevidas, string dono, bool domestico, string som, int velocidade, string textura, bool voa, string habitat, int pata_nadadeira, bool agua, string power)
    {
        this.Name = name;
        this.Raça = raça;
        this.QuantidadeDeVidas = quantidadedevidas;
        this.Dono = dono;
        this.Domestico = domestico;
        this.Som = som;
        this.Velocidade = velocidade;
        this.Textura = textura;
        this.Voa = voa;
        this.Habitat = habitat;
        this.Pata_nadadeira = pata_nadadeira;
        this.Agua = agua;
        this.Power = power;
    }

    public void Morreu()
    {
        this.QuantidadeDeVidas = this.QuantidadeDeVidas - 1;
    }

    public void MudarDono(string novoDono)
    {
        this.Name = novoDono;
    }

    public void Bravo()
    {
        if (this.Domestico == true)
            this.Domestico = false;

        else
            this.Domestico = true;
    }

    public void Mudança(string mudou)
    {
        this.Habitat = mudou;
    }

    public void Acelerou(int acelerar)
    {
        this.Velocidade = this.Velocidade + acelerar;
    }

    public void Freiou(int freio)
    {
        this.Velocidade = this.Velocidade - freio;
    }
}