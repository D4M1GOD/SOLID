class Program
{
    static void Main(string[] args)
    {
        DocContable Fac1 = new DocContable(TipoDocContable.Factura,14312);
        Console.WriteLine(Fac1.Descripcion());
        Console.ReadKey();
    }
}
