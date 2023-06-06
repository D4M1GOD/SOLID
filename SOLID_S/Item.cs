public class Item
{
    public Item(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }
    public int Cantidad { get; set; }
    public Producto Producto { get; set; }

    public double Subtotal()
    {
        return Cantidad * Producto.Precio;
    }
}