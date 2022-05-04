using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Bar
    {
        private static List<Cliente> listaClientes;
        private static List<Producto> listaProductos;
        private static List<Usuario> listaUsuarios;
        private static Mesa[] listaMesas;

        static Bar()
        {
            listaClientes = new List<Cliente>();
            listaProductos = new List<Producto>();
            listaUsuarios = new List<Usuario>();
            listaMesas = new Mesa[20];
        }
    }
}
