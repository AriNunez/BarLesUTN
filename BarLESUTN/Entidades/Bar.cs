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
        private static Dictionary<Producto,int> listaProductos;
        private static List<Usuario> listaUsuarios;
        public static Mesa[] listaMesas;

        static Bar()
        {
            listaClientes = new List<Cliente>();
            listaProductos = new Dictionary<Producto, int> { };
            listaUsuarios = new List<Usuario>();
            listaMesas = new Mesa[20];

            CargarUsuarios();
            CargarMesasYBarras();
            CargarProductos();
        }

        private static void CargarUsuarios()
        {
            listaUsuarios.Add(new Usuario("admin","admin",0,"admin","admin",true));
            listaUsuarios.Add(new Usuario("Ariel","Nunez",41450812,"arielnunez","123123",false));
        }
        private static void CargarMesasYBarras()
        {
            for (int i = 0; i < listaMesas.Length; i++)
            {
                if (i < 15)
                {
                    listaMesas[i] = new Mesa((i+1),false,false);
                }
                else
                {
                    listaMesas[i] = new Mesa((i+1),false,true);
                }
            }
        }

        private static void CargarProductos()
        {
            listaProductos.Add(new Comida("Hamburguesa con cheddar y panceta",500.00M,Comida.EPorcion.Individual),100);
            listaProductos.Add(new Bebida("Cervesa Artenasal IPA Blest",250.00M,Bebida.EEnvase.Lata),50);
        }

        public static Usuario LoginUsuario(string usuario,string password)
        {
            if(usuario is not null && password is not null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if(item.CheckUsuario(usuario) && item.CheckPassword(password))
                    {

                        return item;
                    }
                }
            }   
            return null;
        }

        public static Dictionary<int,bool> EstadoMesas()
        {
            Dictionary<int,bool> estadoMesas = new Dictionary<int,bool>();

            for (int i = 0; i < listaMesas.Length; i++)
            {
                estadoMesas.Add(i + 1, listaMesas[i].Ocupada);
            }

            return estadoMesas;
        }
    }
}
