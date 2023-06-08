public class NotaCredito : DocContable
{
    public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
    {
        _sigla = "NC";
    }
    public override double Total()
    {
        return Importe* 1.21 * -1; //EJEMPLO
    }
    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo nota de credito {Numero} por un importe de {Importe} ");
    }
}