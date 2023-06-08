public class Impresora
{
    public void Imprimir(Factura factura)
    {
        Console.WriteLine($"Imprimiendo factura {factura.Numero} del {factura.Fecha} por un importe de {factura.Importe} ");
    }
    public void Imprimir(NotaCredito notaCredito)
    {
        Console.WriteLine($"Imprimiendo nota de credito {notaCredito.Numero} por un importe de {notaCredito.Importe} ");
    }
    public void Imprimir(Remito remito)
    {
        Console.WriteLine($"Imprimiendo remito {remito.Numero} con un total de  {remito.CantBultos} bultos ");
    }
    public void Imprimir(FacturaLuz facturaLuz)
    {
        Console.WriteLine($"Imprimiendo factura de luz codigo de pago {facturaLuz.CodigoPago} por un importe de {facturaLuz.Importe} ");
    }
    public void Imprimir(Municipal municipal){
        Console.WriteLine($"Imprimiendo impuesto municipal de partida {municipal.Partida} por un importe de {municipal.Importe} ");
    }
}