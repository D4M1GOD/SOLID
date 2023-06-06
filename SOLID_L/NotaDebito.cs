public class NotaDebito : DocContable
{
        public NotaDebito(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "NB";
        }
}