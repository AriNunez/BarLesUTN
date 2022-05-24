namespace Entidades
{
    public abstract class Producto
    {
        private static int idAutoincremental;
        protected int id;
        protected string descripcion;
        protected decimal precioUnitario;

        public int Id { get { return id; } }
        public string Descripcion { get { return descripcion; } }
        public decimal PrecioUnitario { get { return precioUnitario; } }

        public abstract string Formato { get; }

        static Producto()
        {
            idAutoincremental = 1;
        }

        private Producto()
        {
            this.id = GenerarID();
        }
        protected Producto(string descripcion, decimal precio) : this()
        {
            this.descripcion = descripcion;
            this.precioUnitario = precio;
        }

        public void ModificarPrecio(decimal precio)
        {
            if (precio > 0)
            {
                this.precioUnitario = precio;
            }
        }

        private static int GenerarID()
        {
            return idAutoincremental++;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                if (p1.Id == p2.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
