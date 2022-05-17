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
        //private EMedioDePago medioDePago; Proximo a utilizar
        private Dictionary<Producto,int> pedido;
        private string nombreEmpleado; // proximo a utilizar para llevar las cuentas del bar

        public Dictionary<Producto, int> Pedido
        {
            get { return pedido; }
        }

        private Cliente()
        {
            this.horaIngreso = DateTime.Now;
            pedido = new Dictionary<Producto,int>();
        }

        public decimal CostoTotal
        {
            get
            {
                decimal costoTotal = 0;
                foreach (KeyValuePair<Producto, int> item in pedido)
                {
                    costoTotal += item.Key.PrecioUnitario * item.Value;
                }
                return costoTotal;
            }
        }

        public Cliente(string empleadoACargo):this()
        {
            this.nombreEmpleado = empleadoACargo;
        }

        public void CargarProductoEnPedido(Producto productoACargar,int cantidad)
        {
            if(productoACargar != null && cantidad > 0)
            {
                if(!pedido.ContainsKey(productoACargar))
                {
                    pedido.Add(productoACargar, cantidad);
                }
                else
                {
                    pedido[productoACargar] += cantidad;
                }
            }
        }

        public void RemoverProductoDePedido(Producto productoARemover)
        {
            if (productoARemover != null)
            {
                pedido.Remove(productoARemover);
            }
        }

        public void ModificarCantidadDeProducto(Producto productoAModificar,int cantidad)
        {
            if (productoAModificar != null && cantidad > 0)
            {
                pedido[productoAModificar] = cantidad;
            }
        }

    }
}
