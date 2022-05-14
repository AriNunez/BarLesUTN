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
        private Dictionary<Producto,int> pedido;
        private string nombreEmpleado;

        private Cliente()
        {
            this.horaIngreso = DateTime.Now;
            pedido = new Dictionary<Producto,int>();
        }

        public Cliente(bool conEstacionamiento,EMedioDePago medioDePago,string empleadoACargo)
        {
            this.conEstacionamiento = conEstacionamiento;
            this.medioDePago = medioDePago;
            this.nombreEmpleado = empleadoACargo;
        }


    }
}
