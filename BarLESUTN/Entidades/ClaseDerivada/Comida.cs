using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida : Producto
    {
        public enum EPorcion
        {
            Individual, ParaCompartir
        }
        private EPorcion tipoPorcion;

        public Comida(string descripcion, decimal precio, EPorcion tipoPorcion) : base(descripcion, precio)
        {
            this.tipoPorcion = tipoPorcion;
        }
    }
}
