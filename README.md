# PPLaboII
Primer Parcial de Laboratorio II - Bar LES UTN

__ Pre-entrega 17/05/2021 __
¿Que funciona?
  El programa inicia con un login, el cual hasta el momento tiene dos usuarios cargados (un admin y un empleado), encontrará los botones de autocompletado
en la misma ventana.

  Una vez ingresado al programa, ingresará en el Menu Principal y este discriminara si se ingresa con un admin/empleado, habilitando y deshabilitando ciertos botones dependiendo del
usuario logueado.
  -Empleado: podrá visualizar el inventario sin poder modificarlo, y podrá gestionar las mesas.
  -Admin: ademas de poder hacer lo mismo que el empleado, tambien podrá gestionar el inventario agregando,quitando o modificando la cantidad de los
  productos. Deberia poder agregar/quitar/visualizar empleados pero no está desarrollado el proceso. (Botón "Empleados" en Menu principal no funciona)
  
  El botón "Historial Clientes" no está implementado todavia, pero la idea es conectarlo con la lista de clientes "listaClientes" de la clase Bar para poder mostrar
 un historial de los clientes que pasaron por el bar, mostrando al menos la hora de entrada y salida, y el costo de su pedido.
  
  El botón "Inventario" muestra los productos disponibles que presenta el bar, los cuales pueden ser Comida o Bebida. Se podrán agregar/quitar/modificar productos.
 Tambien cuenta con un ComboBox para poder filtrar los productos.-->(La opción de filtrar no lográ eliminar los espacios en blanco, no pude resolverlo).
 
  En el Menu Principal podremos visualizar las Mesas y Barras y si se encuentran disponibles u ocupadas. Si hacemos click en una mesa/barra desocupada, podremos
 asignarle un cliente. Una vez asignado el cliente, podremos gestionar su pedido. De momento lo unico que se puede hacer es agregar bebidas o comidas (por medio 
 de otro formulario), elegir el metodo de pago y si incluye estacionamiento (el precio del estacionamiento es de $100 y si la forma de pago es "Credito" se le hará
 un recargo del %10 al pedido -sin incluir el estacionamiento-). Dentro de la ventana de Venta de la mesa, podremos Cerrar la cuenta de la mesa o podremos Continuar
 sin cerrar la cuenta de la mesa. Si queremos agregar dos veces el mismo producto a la mesa, estás se acumularán. La cantidad del producto que quiera agregar se 
 encontrará limitada a lo que haya disponible en Inventario.
 
 La aplicación permitira cerrar o abrir sesiones cuantas veces quiera, manteniendo los datos de las mesas y del inventario. Recuerde que si cierra la ventana del
 Login, se restableceran los valores a los hardcodeados.
 
 Temas:
 -Herencia: encontrará una clase base Producto con dos clases derivadas llamadas Comida y Bebida.
 -Sobrecarga de constructores: encontrará ejemplos de esto en FormVenta o FormProductoEnInventario.
 -Propiedades: encontrará ejemplos de esto en las clases Mesa o Cliente.
 -Colecciones: encontrará en la clase Bar 2 listas genericas (se utiliza una sola por ahora), un array y un diccionario, entre otras en otras clases.
 -Enumerados: encontrará en la clase Cliente un enumerado de medios de pago, y en las clases Bebida y Comida enumerados de formato del producto.
 -Formularios: el programa cuenta de momento con 6 formularios.
 -Clase estatica: la clase Bar es de tipo estatico, y se utiliza como manejador de la app en general, donde almacenaremos la gran mayoria de datos.
 -Polimorfismo: la clase Producto cuenta con una propiedad abstracta, las cuales se sobreescriben en las clases derivadas.
 
 La unica informacion hardcodeada con la que cuenta el programa son 2 usuarios y 4 productos distintos.
 
 Los formularios de Venta e Inventario se pueden mover por la pantallas ya que pueden abrirse en simultaneo.
 
 Puntos extras por investigación:
 El unico punto que pude desarrollar es el de cambiar el color en base al rol del usuario logueado.
  
__ Entrega final 24/05/2021 __

Agregué al Form Venta la funcionalidad al boton de Quitar Producto. Tambien agregue un nuevo Form Ticket, que se muestra al momento de cerrar una mesa.
En dicho ticket se detalla los gastos del pedido del cliente, si utiliza el estacionamiento (y su costo) y en caso de pagar con credito un recargo.

El boton Empleados del Form MenuPrincipal ahora abre un nuevo form donde podremos visualizar a los usuarios dados de alta, ademas de cierta informacion vinculada
a ellos. Tambien podremos dar de alta un nuevo usuario, detallando la informacion de este nuevo usuario en un nuevo form de alta. 
En caso de querer borrar el usuario con el cual se este logueado no va a poder.

El boton Historial Clientes del Form MenuPrincipal ahora abre un nuevo form donde podremos visualizar a los clientes que hayan sido atendidos y cobrados,
permitiendonos visualizar algo de informacion con respecto al cliente.
 
