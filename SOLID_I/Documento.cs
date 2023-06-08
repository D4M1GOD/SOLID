public abstract class Documento : Iimprimible
{
    public Documento(int numero, DateTime fecha) 
    {
        Numero = numero;
        Fecha = fecha;
    }

    public int Numero { get; set; }
    public DateTime Fecha { get; set; }
    public abstract void Imprimir();
}