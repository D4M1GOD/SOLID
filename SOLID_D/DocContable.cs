public abstract class DocContable: Iimprimible
{
    protected string _sigla;
    public DocContable(int numero, DateTime fecha, double importe){
        Numero = numero;
        fecha = fecha;
        Importe = importe;
    }
    public int Numero { get; set; }
    public DateTime Fecha { get; set; }
    public double Importe { get; set; }

    public abstract void Imprimir();

    public abstract double Total();
}