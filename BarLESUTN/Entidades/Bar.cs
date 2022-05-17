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
        private static Mesa[] listaMesas;

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
            listaProductos.Add(new Comida("Hamburguesa con cheddar y panceta",500.00M,Comida.EFormato.Individual),100);
            listaProductos.Add(new Bebida("Cervesa Artenasal IPA Blest",250.00M,Bebida.EFormato.Lata),50);            
            listaProductos.Add(new Comida("Pizza con jamon",1000.00M,Comida.EFormato.ParaCompartir),100);
            listaProductos.Add(new Bebida("Gaseosa Pepsi",100.00M,Bebida.EFormato.Botella),50);
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

        public static bool MesaEsBarra(int numeroMesa)
        {
            if(numeroMesa > 0 && numeroMesa <= listaMesas.Length)
            {
                return listaMesas[numeroMesa - 1].EsBarra;
            }

            return false;
        }

        public static bool MesaEstaOcupada(int numeroMesa)
        {
            if (numeroMesa > 0 && numeroMesa <= listaMesas.Length)
            {
                return listaMesas[numeroMesa - 1].Ocupada;
            }

            return false;
        }

        public static void AsignarClienteAMesa(int numeroMesa,string nombreEmpleado)
        {
            if(MesaEstaOcupada(numeroMesa) == false)
            {
                listaMesas[numeroMesa - 1].AsignarCliente(new Cliente(nombreEmpleado));
                listaMesas[numeroMesa - 1].Ocupada = true;
            }
        }

        public static void CerrarMesa(int numeroMesa)
        {
            if(MesaEstaOcupada(numeroMesa))
            {
                listaClientes.Add(listaMesas[numeroMesa-1].Cliente);
                listaMesas[numeroMesa - 1].QuitarCliente();
            }
        }

        public static Dictionary<Producto, int> ObtenerPedidoDeMesa(int numeroMesa)
        {
            if(numeroMesa > 0)
            {
                return listaMesas[numeroMesa - 1].Pedido;
            }
            return null;
        }

        public static decimal ObtenerCostoTotalDeMesa(int numeroMesa)
        {
            return listaMesas[numeroMesa - 1].CostoTotalDeMesa;
        }

        public static void AgregarProductoAPedido(int numeroMesa, int idProducto,int cantidad)
        {
            Producto producto;
            if(numeroMesa > 0 && idProducto > 0 && cantidad > 0)
            {
                producto = BuscarProductoPorID(idProducto);
                listaMesas[numeroMesa - 1].AgregarProductoAPedido(producto, cantidad);
                listaProductos[producto] -= cantidad;
                
            }
        }


        public static int ObtenerCantidadDeProducto(int idProducto)
        {
            if (idProducto > 0)
            {
                foreach (KeyValuePair<Producto, int> item in listaProductos)
                {
                    if (item.Key.Id == idProducto)
                    {
                        return item.Value;
                    }
                }
            }
            return 0;
        }

        public static Dictionary<Producto,int> ObtenerListaProductos()
        {
            return listaProductos;
        }

        public static void QuitarProductoDeLista(int idProducto)
        {
            if (idProducto > 0)
            {
                listaProductos.Remove(BuscarProductoPorID(idProducto));
            }
        }

        public static Producto BuscarProductoPorID(int idProducto)
        {
            if (idProducto > 0)
            {
                foreach (KeyValuePair<Producto, int> item in listaProductos)
                {
                    if (item.Key.Id == idProducto)
                    {
                        return item.Key;
                    }
                }
            }
            return null;
        }

        public static void AgregarComidaEnLista(string descripcion, decimal precio, Comida.EFormato formato,int cantidad)
        {
            if(!string.IsNullOrEmpty(descripcion) && precio > 0 && cantidad > 0)
            {
                listaProductos.Add(new Comida(descripcion,precio,formato),cantidad);
            }
        }        
        public static void AgregarBebidaEnLista(string descripcion, decimal precio, Bebida.EFormato formato,int cantidad)
        {
            if(!string.IsNullOrEmpty(descripcion) && precio > 0 && cantidad > 0)
            {
                listaProductos.Add(new Bebida(descripcion,precio,formato),cantidad);
            }
        }

        public static void ModificarCantidadDeProducto(int idProducto,int cantidad)
        {
            if(idProducto > 0 && cantidad >= 0)
            {
                Producto producto = BuscarProductoPorID(idProducto);
                listaProductos[producto] = cantidad;
            }
        }


    }
}
