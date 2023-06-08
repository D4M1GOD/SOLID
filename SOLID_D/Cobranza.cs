public class Cobranza : Iimprimible
{
    public double Importe { get; set; }
    public int Numero { get; set; }

    public void Imprimir(){
        Console.WriteLine($"Imprimiendo cobranza {Numero} con un importe de {Importe} ");
    }
}