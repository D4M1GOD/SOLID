public class Factura : DocContable
{
        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "FC";
        }
}