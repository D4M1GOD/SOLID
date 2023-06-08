class Program
{
    static void Main(string[] args)
    {
        Factura factura = new Factura(12344, DateTime.Now);
        factura.CAI = "234324423";

        FacturaElectronica facturaElectronica = new FacturaElectronica(12345, DateTime.Now);
        facturaElectronica.CAE = "234324444";

        facturaElectronica.Imprimir();
        factura.Imprimir();
        facturaElectronica.EnviarPorEmail();
        factura.EnviarPorEmail();

        Console.ReadKey();
    }
}