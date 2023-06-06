public class Remito
{
        public Remito(int numero, DateTime fecha, int bultos)
        {
            Numero = numero;
            Fecha = fecha;
            CantBultos = bultos;
        }
        public int CantBultos{ get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }
        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }
}