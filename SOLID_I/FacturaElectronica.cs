public class FacturaElectronica : Documento, IEmaileable
{
    public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha){}
    public string CAE { get; set; }
     public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo por email la factura electronica {Numero} del dia {Fecha.ToShortDateString()}");
    }
    public void EnviarPorEmail()
    {
        Console.WriteLine($"Enviando por email la factura electronica {Numero} del dia {Fecha.ToShortDateString()}");
    }
}