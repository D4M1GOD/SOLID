public class FacturaElectronica : Documento
{
    public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha){}
    public string CAE { get; set; }
    public override void EnviarPorEmail()
    {
        Console.WriteLine($"Imprimiendo por email la factura electronica {Numero} del dia {Fecha.ToShortDateString()}");
    }
     public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo por email la factura electronica {Numero} del dia {Fecha.ToShortDateString()}");
    }
}