public abstract class Veiculos
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int NumeroPassageiros { get; set; }
    public int Cilindradas { get; set; }
    public int Capacidade { get; set; }
    public int Velocidade { get; set; }

    public static List<Carro> TodosCarros = new List<Carro>();

    public abstract void Acelerar(int acelerando);

    public abstract void Frear(int freiando);
}

public class Carro : Veiculos
{
    public Carro(string marca, string modelo, int numeroPassageiros, int velocidade)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.NumeroPassageiros = numeroPassageiros;
        this.Velocidade = velocidade;
        TodosCarros.Add(this);
    }

    public override void Acelerar(int acelerando)
    {
        this.Velocidade = this.Velocidade + acelerando;
    }

    public override void Frear(int freiando)
    {
        this.Velocidade = this.Velocidade - freiando;
    }

    public static void ShowAllCar()
    {
        foreach (Carro car in TodosCarros)
        {
            Console.WriteLine($"Marca: {car.Marca}\nModelo: {car.Modelo}" +
                $"\nNúmero De Passageiros: {car.NumeroPassageiros} \nVelocidade: {car.Velocidade}");
        }
    }
}

public class Moto : Veiculos
{
    public Moto(string marca, string modelo, int cilindradas, int velocidade)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Cilindradas = cilindradas;
        this.Velocidade = velocidade;
    }

    public override void Acelerar(int acelerando)
    {
        this.Velocidade = this.Velocidade + acelerando;
    }

    public override void Frear(int freiando)
    {
        this.Velocidade = this.Velocidade - freiando;
    }
}

public class Caminhao : Veiculos
{
    public Caminhao(string marca, string modelo, int capacidade, int velocidade)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Capacidade = capacidade;
        this.Velocidade = velocidade;
    }

    public override void Acelerar(int acelerando)
    {
        this.Velocidade = this.Velocidade + acelerando;
    }

    public override void Frear(int freiando)
    {
        this.Velocidade = this.Velocidade - freiando;
    }
}