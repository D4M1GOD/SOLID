public class NotaCredito : DocContable
{
    public NotaCredito(int numero): base(numero)
    {

    }

    public override string Descripcion()
    {
        return $"NC-{Numero}";
    }
}