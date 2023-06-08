public abstract class Impuesto : Iimprimible
{
    public Impuesto(double importe)
    {
        Importe = importe;
    }
    public double Importe { get; set; }
    public abstract void Imprimir();
}