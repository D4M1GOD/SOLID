public class Factura : Documento
{
    public Factura(int numero, DateTime fecha) : base(numero, fecha) {}
    public string CAI { get; set; }
    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo por email la factura {Numero} del dia {Fecha.ToShortDateString()}");
    }
}
