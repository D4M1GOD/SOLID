class Program
{
    static void Main(string[] args)
    {
        Impresora impresora = new Impresora();

        Remito rto = new Remito(3333, DateTime.Now, 10);
        Factura fc = new Factura(66423, DateTime.Now);
        NotaCredito nc = new NotaCredito(441, DateTime.Now);

        impresora.ImprimirRemito(rto);
        impresora.ImprimirFactura(fc);
        impresora.ImprimirNotaCredito(nc);

        Console.ReadKey();
    }
}