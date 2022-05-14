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
    }
}
