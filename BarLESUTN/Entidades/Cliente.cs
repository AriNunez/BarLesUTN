using System;
using System.Collections.Generic;

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
        private EMedioDePago medioDePago;
        private bool conEstacionamineto;
        private Dictionary<Producto, int> pedido;
        private string nombreEmpleado;

        #region Propiedades
        public Dictionary<Producto, int> Pedido
        {
            get { return pedido; }
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
        public string HoraEgreso
        {
            get { return horaEgreso.ToString(); }
        }

        public string HoraIngreso
        {
            get { return horaIngreso.ToString(); }
        }

        public EMedioDePago MedioDePago
        {
            get { return medioDePago; }
            set { medioDePago = value; }
        }

        public bool ConEstacionamineto
        {
            get { return conEstacionamineto; }
            set { conEstacionamineto = value; }
        }

        public string NombreEmpleadoACargo
        {
            get { return nombreEmpleado; }
        }

        #endregion

        #region Constructores
        private Cliente()
        {
            this.horaIngreso = DateTime.Now;
            pedido = new Dictionary<Producto, int>();
        }
        public Cliente(string empleadoACargo) : this()
        {
            this.nombreEmpleado = empleadoACargo;
        }

        #endregion

        /// <summary>
        /// Carga un producto y una cantidad al pedido en caso de que el pedido no tenga el producto cargado. Si el producto ya se encuentra en el
        /// pedido, acumula las cantidades.
        /// </summary>
        /// <param name="productoACargar"></param>
        /// <param name="cantidad"></param>
        public void CargarProductoEnPedido(Producto productoACargar, int cantidad)
        {
            if (productoACargar != null && cantidad > 0)
            {
                if (!pedido.ContainsKey(productoACargar))
                {
                    pedido.Add(productoACargar, cantidad);
                }
                else
                {
                    pedido[productoACargar] += cantidad;
                }
            }
        }

        /// <summary>
        /// Quita un producto del pedido.
        /// </summary>
        /// <param name="productoARemover"></param>
        public void QuitarProductoDePedido(Producto productoARemover)
        {
            if (productoARemover != null)
            {
                pedido.Remove(productoARemover);
            }
        }

        /// <summary>
        /// Establece una hora de egreso
        /// </summary>
        public void EstablecerHoraDeEgreso()
        {
            this.horaEgreso = DateTime.Now;
        }

    }
}
