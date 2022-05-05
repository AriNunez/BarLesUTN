using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        private Cliente cliente;
        private bool ocupada;
        private bool esBarra;

        public Mesa(bool ocupada,bool esBarra)
        {
            this.cliente = null;
            this.ocupada = ocupada;
            this.esBarra = esBarra;
        }
    }
}
