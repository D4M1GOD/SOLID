﻿class program
{
    static void Main(string[] args)
    {
        Impresora impresora = new Impresora();
        Factura factura = new Factura(1234, DateTime.Now,303);
        NotaCredito notaCredito = new NotaCredito(344,DateTime.Now,400);
        Remito remito = new Remito(5551,DateTime.Now,5);
        FacturaLuz facturaLuz = new FacturaLuz(441,"444545");
        Municipal municipal = new Municipal(1221,"555556662");

        impresora.Imprimir(factura);
        impresora.Imprimir(notaCredito);
        impresora.Imprimir(remito);
        impresora.Imprimir(facturaLuz);
        impresora.Imprimir(municipal);

        Console.ReadKey();
    }
}