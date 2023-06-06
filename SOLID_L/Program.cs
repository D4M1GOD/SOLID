class Program
{
    static void Main(string[] args)
    {
        Impresora impresora = new Impresora();

        Remito rto = new Remito(3333, DateTime.Now, 10);
        DocContable fc = new Factura(66423, DateTime.Now);
        DocContable nc = new NotaCredito(441, DateTime.Now);
        DocContable nb = new NotaDebito(442, DateTime.Now);

        impresora.ImprimirRemito(rto);
        impresora.Imprimir(fc);
        impresora.Imprimir(nc);
        impresora.Imprimir(nb);

        Console.ReadKey();
    }
}