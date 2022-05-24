namespace Entidades
{
    public class Comida : Producto
    {
        public enum EFormato
        {
            Individual, ParaCompartir
        }
        private EFormato tipoFormato;

        public Comida(string descripcion, decimal precio, EFormato tipoFormato) : base(descripcion, precio)
        {
            this.tipoFormato = tipoFormato;
        }

        public override string Formato { get { return tipoFormato.ToString(); } }
    }
}
