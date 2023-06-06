class Program
{
    static void Main(string[] args)
    {
        DocContable Fac1 = new Factura(14312);
        Console.WriteLine(Fac1.Descripcion());
        DocContable Fac2 = new NotaCredito(14312);
        Console.WriteLine(Fac2.Descripcion());
        DocContable Fac3 = new NotaDebito(14312);
        Console.WriteLine(Fac3.Descripcion());
        Console.ReadKey();
    }
}
