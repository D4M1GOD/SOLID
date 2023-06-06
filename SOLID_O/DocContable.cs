public class DocContable
{
    public DocContable(TipoDocContable tipo, int numero)
    {
        Tipo = tipo;
        Numero = numero;
    }
    public DateTime Fecha { get; set; }
    public double Importe { get; set; }
    public int Numero { get; set; }
    public TipoDocContable Tipo { get; set; }
    public string Descripcion()
    {
        switch (Tipo)
        {
            case TipoDocContable.Factura:
                return $"FC-{Numero}";
            case TipoDocContable.NotaCredito:
                return $"NC-{Numero}";
            default: 
                return "N/D";
        }
    }
    
}