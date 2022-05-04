using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida : Producto
    {
        public enum EEnvase
        {
            Lata,BotellaGrande,BotellaChica
        }
        private EEnvase tipoEnvase;
    }
}
