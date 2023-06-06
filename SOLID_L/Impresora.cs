public class Impresora
{
    public void ImprimirRemito(Remito unRemito)
    {
        Console.WriteLine(unRemito.Imprimir());
    }
    public void ImprimirFactura(Factura unaFactura)
    {
        Console.WriteLine(unaFactura.Imprimir());
    }
    public void ImprimirNotaCredito(NotaCredito unaNotaCredito)
    {
        Console.WriteLine(unaNotaCredito.Imprimir());
    }
}