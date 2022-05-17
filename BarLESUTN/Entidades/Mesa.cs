using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        int idMesa;
        private Cliente cliente;
        private bool ocupada;
        private bool esBarra;

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public bool Ocupada
        {
            get { return ocupada; }
            set { ocupada = value; }
        }

        public bool EsBarra
        {
            get { return esBarra; }
        }

        public decimal CostoTotalDeMesa
        {
            get { return cliente.CostoTotal; }
        }

        public Dictionary<Producto, int> Pedido
        {
            get { return cliente.Pedido; }
        }

        public Mesa(int idMesa,bool ocupada,bool esBarra)
        {
            this.idMesa = idMesa;
            this.cliente = null;
            this.ocupada = ocupada;
            this.esBarra = esBarra;
        }
        
        public void AsignarCliente(Cliente cliente)
        {
            if(this.cliente is null && cliente is not null && ocupada == false)
            {
                this.cliente = cliente;
            }
        }

        public void QuitarCliente()
        {
            this.cliente = null;
            this.ocupada = false;
        }

        public void AgregarProductoAPedido(Producto producto,int cantidad)
        {
            if(producto is not null && cantidad > 0)
            {
                cliente.CargarProductoEnPedido(producto, cantidad);
            }
        }
        

    }
}
