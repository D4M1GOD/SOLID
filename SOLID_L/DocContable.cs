public abstract class DocContable
{
    protected string _sigla;
    public DocContable(int numero, DateTime fecha)
    {
        Numero = numero;
        Fecha = fecha;
    }
    public DateTime Fecha { get; set; }
    public int Numero { get; set; }
    public string Imprimir(){
        return $"Imprimiendo {Descripcion()}";
    }

    public virtual string Descripcion()
    {
        return $"{_sigla} nro {Numero} de feca {Fecha.ToShortDateString()}";
    }
}