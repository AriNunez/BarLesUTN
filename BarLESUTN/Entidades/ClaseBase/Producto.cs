using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private static int idAutoincremental;
        private int id;
        private string descripcion;
        private decimal precio;

        protected int Id { get { return id; } }
        protected string Descripcion { get { return descripcion; } }
        protected decimal Precio { get { return precio; } }

        static Producto()
        {
            idAutoincremental = 0;
        }

        private Producto()
        {
            this.id = GenerarID();
        }
        protected Producto(string descripcion, decimal precio):this()
        {
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public void ModificarPrecio(decimal precio)
        {
            if (precio > 0)
            {
                this.precio = precio;
            }
        }

        private static int GenerarID()
        {
            return idAutoincremental++;
        }
    }
}
