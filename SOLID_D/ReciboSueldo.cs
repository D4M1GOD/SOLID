public class ReciboSueldo
{
    public ReciboSueldo(int legajo, double total)
    {
        Legajo = legajo;
        Total = total;
    }
    public int Legajo { get; set; }
    public double Total { get; set; }
}