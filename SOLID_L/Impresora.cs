public class Impresora
{
    public void ImprimirRemito(Remito unRemito)
    {
        Console.WriteLine(unRemito.Imprimir());
    }
    public void Imprimir(DocContable documento)
    {
        Console.WriteLine(documento.Imprimir());
    }

}