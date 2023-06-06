public class NotaCredito : DocContable
{
        public NotaCredito(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "NC";
        }
}