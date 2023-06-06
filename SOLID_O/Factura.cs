public class Factura : DocContable
{
    public Factura(int numero): base(numero)
    {

    }

    public override string Descripcion()
    {
        return $"FC-{Numero}";
    }
}