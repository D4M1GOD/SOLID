public class FacturaLuz : Impuesto
{
    public FacturaLuz(double importe, string codigoPago) : base(importe)
    {
        CodigoPago = codigoPago;
    }
    public string CodigoPago { get; set; }
    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo factura de luz codigo de pago {CodigoPago} por un importe de {Importe} ");
    }
}