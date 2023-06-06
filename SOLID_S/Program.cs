class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        c.Apellido = "Suarez";
        c.Nombre = "Damian";
        Factura f = new Factura(2132,c);

        Item i1 = new Item(new Producto("Arroz", 10),5);
        Item i2 = new Item(new Producto("Cocina", 90),1);
        Item i3 = new Item(new Producto("Cocina", 70),2);

        f.Items.Add(i1);
        f.Items.Add(i2);
        f.Items.Add(i3);

        Console.WriteLine(f.Total());

        Console.ReadKey();
    }
}
