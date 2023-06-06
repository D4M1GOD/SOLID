public class NotaDebito : DocContable
{
    public NotaDebito(int numero): base(numero)
    {

    }

    public override string Descripcion()
    {
        return $"NB-{Numero}";
    }
}