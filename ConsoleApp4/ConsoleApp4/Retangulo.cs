public class Retangulo
{
    public int A { get; set; }
    public int B { get; set; }

    public Retangulo(int a, int b)
    {
        this.A = a;
        this.B = b;
    }

    public float Area()
    {
        float area = this.A * this.B;
        return area;
    }

    public float Perimetro()
    {
        float perim = 2 * (this.A + this.B);
        return perim;
    }
}