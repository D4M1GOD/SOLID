public abstract class DocContable
{
    public DocContable(int numero)
    {
        Numero = numero;
    }
    public DateTime Fecha { get; set; }
    public double Importe { get; set; }
    public int Numero { get; set; }
    public abstract string Descripcion();
}