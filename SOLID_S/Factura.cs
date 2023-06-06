
public class Factura
{
    public Factura(int numero, string apellido, string nombre)
    {
        Numero = numero;
        Apellido = apellido;
        Nombre = nombre;
        Items = new List<Item>();
    }

    public int Numero { get; set; }
    public DateTime fecha { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public List<Item> Items { get; set; }

    public double Total()
    {
        double total = 0;
        foreach (var Item in Items)
            {
                 total += Item.Cantidad + Item.Producto.Precio;
            }
            return total;
    }

}