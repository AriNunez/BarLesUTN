using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public enum EMedioDePago
        {
            Debito, Credito, Efectivo
        }
        private DateTime horaIngreso;
        private DateTime horaEgreso;
        private bool conEstacionamiento;
        private EMedioDePago medioDePago;
        private List<Producto> pedido;

    }
}
