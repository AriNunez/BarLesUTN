namespace Entidades
{
    public class Bebida : Producto
    {
        public enum EFormato
        {
            Lata, Botella, Pinta
        }

        private EFormato tipoFormato;

        public Bebida(string descripcion, decimal precio, EFormato tipoFormato) : base(descripcion, precio)
        {
            this.tipoFormato = tipoFormato;
        }

        public override string Formato { get { return tipoFormato.ToString(); } }
    }
}
