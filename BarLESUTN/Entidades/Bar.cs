using System.Collections.Generic;


namespace Entidades
{
    public static class Bar
    {
        private static List<Cliente> listaClientes;
        private static Dictionary<Producto, int> listaProductos;
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

        #region Hardcodeo
        private static void CargarUsuarios()
        {
            listaUsuarios.Add(new Usuario("ADMIN", "ADMIN", 0, "admin", "admin", true));
            listaUsuarios.Add(new Usuario("ARIEL", "NUNEZ", 41450812, "arielnunez", "123123", false));
        }
        private static void CargarMesasYBarras()
        {
            for (int i = 0; i < listaMesas.Length; i++)
            {
                if (i < 15)
                {
                    listaMesas[i] = new Mesa((i + 1), false, false);
                }
                else
                {
                    listaMesas[i] = new Mesa((i + 1), false, true);
                }
            }
        }

        private static void CargarProductos()
        {
            listaProductos.Add(new Comida("Hamburguesa con cheddar y panceta", 500.00M, Comida.EFormato.Individual), 100);
            listaProductos.Add(new Bebida("Cervesa Artenasal IPA Blest", 250.00M, Bebida.EFormato.Lata), 50);
            listaProductos.Add(new Comida("Pizza con jamon", 1000.00M, Comida.EFormato.ParaCompartir), 100);
            listaProductos.Add(new Bebida("Gaseosa Pepsi", 100.00M, Bebida.EFormato.Botella), 50);
        }
        #endregion

        #region Metodos Usuario

        /// <summary>
        /// Evalua si hay algun usuario con el usuario y password recibidos por parametros.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>En caso de encontrar un usuario que coincida, lo retorna. En caso contrario, retorna null</returns>
        public static Usuario LoginUsuario(string usuario, string password)
        {
            if (usuario is not null && password is not null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.ComprobarUsuario(usuario) && item.ComprobarPassword(password))
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Valida todos los parametros recibidos necesarios para poder crear un nuevo usuario. Si los parametros son correctos, crea un nuevo usuario
        /// con los datos proporcionados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <param name="esAdmin"></param>
        /// <returns>Retorna true en caso de poder crear un usuario, o false en caso contrario</returns>
        public static bool CrearUsuario(string nombre, string apellido, int dni, string usuario, string password, bool esAdmin)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password) && dni > 0)
            {
                if (Usuario.EsNombreValido(nombre) && Usuario.EsNombreValido(apellido) && Usuario.EsUsuarioValido(usuario) && Usuario.EsUsuarioValido(password)
                    && Usuario.NombreUsuarioExistente(usuario, listaUsuarios) == false && Usuario.EsDniValido(dni, listaUsuarios))
                {
                    listaUsuarios.Add(new Usuario(nombre, apellido, dni, usuario, password, esAdmin));
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Busca en la lista de usuarios si hay coincidencias entre dni´s. En caso de encontrar un usuario con el que coincida el dni, lo
        /// elimina de la lista.
        /// </summary>
        /// <param name="dni"></param>
        public static void QuitarUsuario(int dni)
        {
            List<Usuario> listaAux = ClonarListaUsuarios(listaUsuarios);

            foreach (Usuario item in listaAux)
            {
                if (item.Dni == dni)
                {
                    listaUsuarios.Remove(item);
                }
            }
        }

        /// <summary>
        /// Clona la lista de usuarios para poder manipularla mientras se itera.
        /// </summary>
        /// <param name="listaUsuario"></param>
        /// <returns>Retorna una lista de usuarios clonada</returns>
        private static List<Usuario> ClonarListaUsuarios(List<Usuario> listaUsuario)
        {
            List<Usuario> listaAux = new List<Usuario>();
            foreach (Usuario item in listaUsuarios)
            {
                listaAux.Add(item);
            }

            return listaAux;
        }

        /// <summary>
        /// Retorna una lista de usuarios
        /// </summary>
        /// <returns>Retorna una lista de usuarios</returns>
        public static List<Usuario> ObtenerListaUsuarios()
        {
            return listaUsuarios;
        }

        #endregion

        #region Metodos de Mesa y Cliente

        /// <summary>
        /// Retorna una lista de clientes.
        /// </summary>
        /// <returns>Retorna una lista de clientes.</returns>
        public static List<Cliente> ObtenerListaClientes()
        {
            return listaClientes;
        }

        /// <summary>
        /// Retorna un diccionario con el numero de mesa y su disponibilidad
        /// </summary>
        /// <returns>Retorna un diccionario con el numero de mesa y su disponibilidad</returns>
        public static Dictionary<int, bool> EstadoMesas()
        {
            Dictionary<int, bool> estadoMesas = new Dictionary<int, bool>();

            for (int i = 0; i < listaMesas.Length; i++)
            {
                estadoMesas.Add(i + 1, listaMesas[i].Ocupada);
            }

            return estadoMesas;
        }

        /// <summary>
        /// Evalua si una mesa de la lista de mesas es mesa o barra
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <returns>Retorna true en caso de que la mesa sea barra, y false en caso contrario</returns>
        public static bool MesaEsBarra(int numeroMesa)
        {
            if (numeroMesa > 0 && numeroMesa <= listaMesas.Length)
            {
                return listaMesas[numeroMesa - 1].EsBarra;
            }

            return false;
        }

        /// <summary>
        /// Evalua si una mesa/barra de la lista de mesas se encuentra ocupada o no
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <returns>Retorna true en caso de que la mesa se encuentre ocupada, o false en caso contrario</returns>
        public static bool MesaEstaOcupada(int numeroMesa)
        {
            if (numeroMesa > 0 && numeroMesa <= listaMesas.Length)
            {
                return listaMesas[numeroMesa - 1].Ocupada;
            }

            return false;
        }

        /// <summary>
        /// Instancia un nuevo cliente y lo asigna a una mesa. Ademas modifica la mesa a un estado ocupado.
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <param name="nombreEmpleado"></param>
        public static void AsignarClienteAMesa(int numeroMesa, string nombreEmpleado)
        {
            if (MesaEstaOcupada(numeroMesa) == false)
            {
                listaMesas[numeroMesa - 1].AsignarCliente(new Cliente(nombreEmpleado));
                listaMesas[numeroMesa - 1].Ocupada = true;
            }
        }

        /// <summary>
        /// Cierra una mesa, desvincula al cliente de la mesa y lo agrega al historial de clientes. Tambien establece la hora de egreso del cliente del bar.
        /// </summary>
        /// <param name="numeroMesa"></param>
        public static void CerrarMesa(int numeroMesa)
        {
            if (MesaEstaOcupada(numeroMesa))
            {
                listaClientes.Add(listaMesas[numeroMesa - 1].Cliente);
                listaMesas[numeroMesa - 1].Cliente.EstablecerHoraDeEgreso();
                listaMesas[numeroMesa - 1].QuitarCliente();
            }
        }

        /// <summary>
        /// Retorna un diccionario que contiene productos con sus cantidades que hacen referencia al pedido
        /// del cliente de una mesa determinada.
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <returns>Retorna un diccionario que contiene productos con sus cantidades que hacen referencia al pedido del cliente de una mesa determinada.</returns>
        public static Dictionary<Producto, int> ObtenerPedidoDeMesa(int numeroMesa)
        {
            if (numeroMesa > 0)
            {
                return listaMesas[numeroMesa - 1].Cliente.Pedido;
            }
            return null;
        }

        /// <summary>
        /// Retorna el costo del pedido de una mesa determinada.
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <returns>Retorna el costo del pedido de una mesa determinada.</returns>
        public static decimal ObtenerCostoTotalDeMesa(int numeroMesa)
        {
            if(numeroMesa > 0)
            {
                return listaMesas[numeroMesa - 1].Cliente.CostoTotal;
            }
            return 0;
        }

        /// <summary>
        /// Agrega un producto, en caso de existir, al pedido de un cliente de una mesa determinada, ademas de la cantidad
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <param name="idProducto"></param>
        /// <param name="cantidad"></param>
        public static void AgregarProductoAPedido(int numeroMesa, int idProducto, int cantidad)
        {
            Producto producto;
            if (numeroMesa > 0 && idProducto > 0 && cantidad > 0)
            {
                producto = BuscarProductoPorID(idProducto);
                listaMesas[numeroMesa - 1].Cliente.CargarProductoEnPedido(producto, cantidad);
                listaProductos[producto] -= cantidad;

            }
        }

        /// <summary>
        /// Quita un producto, en caso de existir, al pedido de un cliente de una mesa determinada.Ademas suma la cantidad eliminada del pedido al stock
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <param name="idProducto"></param>
        /// <param name="cantidad"></param>
        public static void QuitarProductoDePedido(int numeroMesa, int idProducto, int cantidad)
        {
            Producto producto;

            if (numeroMesa > 0 && idProducto > 0 && cantidad > 0)
            {
                producto = BuscarProductoPorID(idProducto);
                listaProductos[producto] += cantidad;
                listaMesas[numeroMesa - 1].Cliente.QuitarProductoDePedido(producto);
            }
        }

        /// <summary>
        /// Actualiza el medio de pago de un cliente de una mesa determinada
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <param name="medioDePago"></param>
        public static void ActualizarMedioDePago(int numeroMesa, Cliente.EMedioDePago medioDePago)
        {
            if (numeroMesa > 0 && listaMesas[numeroMesa - 1].Cliente is not null)
            {
                listaMesas[numeroMesa - 1].Cliente.MedioDePago = medioDePago;
            }
        }

        /// <summary>
        /// Actualiza el estado del estacionamiento de un cliente de una mesa determinada
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <param name="conEstacionamiento"></param>
        public static void ActualizarEstadoEstacionamiento(int numeroMesa, bool conEstacionamiento)
        {
            if (numeroMesa > 0 && listaMesas[numeroMesa - 1].Cliente is not null)
            {
                listaMesas[numeroMesa - 1].Cliente.ConEstacionamineto = conEstacionamiento;
            }
        }
        #endregion

        #region Metodos de Inventario y Producto

        /// <summary>
        /// Agrega una nueva comida con las cantidades disponibles al stock
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="formato"></param>
        /// <param name="cantidad"></param>
        public static void AgregarComidaEnInventario(string descripcion, decimal precio, Comida.EFormato formato, int cantidad)
        {
            if (!string.IsNullOrEmpty(descripcion) && precio > 0 && cantidad > 0)
            {
                listaProductos.Add(new Comida(descripcion, precio, formato), cantidad);
            }
        }

        /// <summary>
        /// Agrega una nueva bebida con las cantidades disponibles al stock
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="formato"></param>
        /// <param name="cantidad"></param>
        public static void AgregarBebidaEnInventario(string descripcion, decimal precio, Bebida.EFormato formato, int cantidad)
        {
            if (!string.IsNullOrEmpty(descripcion) && precio > 0 && cantidad > 0)
            {
                listaProductos.Add(new Bebida(descripcion, precio, formato), cantidad);
            }
        }

        /// <summary>
        /// Modifica la cantidad de un producto existente del stock
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="cantidad"></param>
        public static void ModificarCantidadDeProductoEnInventario(int idProducto, int cantidad)
        {
            if (idProducto > 0 && cantidad >= 0)
            {
                Producto producto = BuscarProductoPorID(idProducto);
                listaProductos[producto] = cantidad;
            }
        }

        /// <summary>
        /// Retorna la cantidad disponible de un producto existente en el stock
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Retorna la cantidad disponible de un producto existente en el stock</returns>
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

        /// <summary>
        /// Retorna un diccionario de productos y sus cantidades disponibles en stock.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<Producto, int> ObtenerListaProductos()
        {
            return listaProductos;
        }

        /// <summary>
        /// Quita un producto del stock
        /// </summary>
        /// <param name="idProducto"></param>
        public static void QuitarProductoDeLista(int idProducto)
        {
            if (idProducto > 0)
            {
                listaProductos.Remove(BuscarProductoPorID(idProducto));
            }
        }

        /// <summary>
        /// Busca por id un producto en la lista de productos que representa el stock
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Retorna el producto en caso de encontrarlo, o null en caso contrario</returns>
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
        #endregion

    }
}
