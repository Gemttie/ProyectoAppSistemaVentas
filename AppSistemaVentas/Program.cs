using System;
using static cProducto;

namespace AppSistemaVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            cAlmacen almacen = new cAlmacen();
            cVenta venta = new cVenta();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("========================");
                Console.WriteLine("SISTEMA DE VENTAS");
                Console.WriteLine("========================");
                Console.WriteLine("1. Agregar Producto.");
                Console.WriteLine("2. Eliminar Producto.");
                Console.WriteLine("3. Buscar Producto.");
                Console.WriteLine("4. Listar Productos.");
                Console.WriteLine("5. Listar Productos por Tipo.");
                Console.WriteLine("6. VENDER.");
                Console.WriteLine("7. Mostrar Inventario.");
                Console.WriteLine("8. Mostrar Historial de Ventas.");
                Console.WriteLine("9. Cargar Productos.");
                Console.WriteLine("10. Salir.");
                Console.Write("Ingrese opción -> ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Agregar producto
                        Console.Write("Ingrese código: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Ingrese nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese precio: ");
                        string precio = Console.ReadLine();

                        Console.WriteLine("Seleccione el tipo de producto:");
                        Console.WriteLine("0. Bicicleta");
                        Console.WriteLine("1. Coche");
                        Console.WriteLine("2. Moto");
                        Console.WriteLine("3. Scooter");
                        Console.Write("Ingrese el número del tipo de producto: ");

                        if (int.TryParse(Console.ReadLine(), out int tipoSeleccionado) &&
                            Enum.IsDefined(typeof(TipoProducto), tipoSeleccionado))
                        {
                            TipoProducto tipo = (TipoProducto)tipoSeleccionado; //convertir a TipoProducto
                            cProducto nuevoProducto;

                            switch (tipo)
                            {
                                case TipoProducto.Bicicleta:
                                    Console.Write("Ingrese tipo de freno: ");
                                    string tipoFreno = Console.ReadLine();
                                    Console.Write("¿Tiene ruedas de apoyo? (true/false): ");
                                    bool ruedaApoyo = bool.Parse(Console.ReadLine());
                                    nuevoProducto = new cBicicleta(codigo, nombre, precio, tipoFreno, ruedaApoyo);
                                    break;
                                case TipoProducto.Coche:
                                    Console.Write("Ingrese tipo de silla: ");
                                    string tipoSilla = Console.ReadLine();
                                    Console.Write("Ingrese capacidad de carga (kg): ");
                                    int carga = int.Parse(Console.ReadLine());
                                    nuevoProducto = new cCoche(codigo, nombre, precio, tipoSilla, carga);
                                    break;
                                case TipoProducto.Moto:
                                    Console.Write("Ingrese número de ruedas: ");
                                    int nroRuedas = int.Parse(Console.ReadLine());
                                    Console.Write("Ingrese tipo de batería: ");
                                    string tipoBateria = Console.ReadLine();
                                    nuevoProducto = new cMoto(codigo, nombre, precio, nroRuedas, tipoBateria);
                                    break;
                                case TipoProducto.Scooter:
                                    Console.Write("Ingrese modelo: ");
                                    string modelo = Console.ReadLine();
                                    Console.Write("Ingrese tipo de rueda: ");
                                    string tipoRueda = Console.ReadLine();
                                    nuevoProducto = new cScooter(codigo, nombre, precio, modelo, tipoRueda);
                                    break;
                                default:
                                    nuevoProducto = new cProducto(codigo, nombre, precio, tipo);
                                    break;
                            }

                            //agrega producto al almacén
                            almacen.AgregarProducto(nuevoProducto);
                            Console.WriteLine($"Producto agregado: {nuevoProducto.getNombre()} de tipo {nuevoProducto.mostrarTipo()}");
                        }
                        else
                        {
                            Console.WriteLine("Tipo de producto no valido.");
                        }
                        break;

                    case "2":
                        //eliminar producto
                        Console.Write("Ingrese código del producto a eliminar: ");
                        string codEliminar = Console.ReadLine();
                        almacen.EliminarProducto(codEliminar);
                        break;

                    case "3":
                        //buscar producto
                        Console.Write("Ingrese código del producto a buscar: ");
                        string codBuscar = Console.ReadLine();
                        cProducto productoEncontrado = almacen.BuscarProducto(codBuscar);
                        if (productoEncontrado != null)
                        {
                            productoEncontrado.mostrar();
                        }
                        break;

                    case "4":
                        //listar productos
                        almacen.ListarProductos();
                        break;


                    case "5":
                        //listar productos por tipo
                        Console.WriteLine("Seleccione el tipo de producto a listar:");
                        Console.WriteLine("0. Bicicleta");
                        Console.WriteLine("1. Coche");
                        Console.WriteLine("2. Moto");
                        Console.WriteLine("3. Scooter");
                        Console.Write("Ingrese el numero del tipo de producto: ");

                        //leer el numero ingresado y validar que corresponde a un tipo valido del enum

                        if (int.TryParse(Console.ReadLine(), out int tipoSeleccionadoFiltro) &&
                            Enum.IsDefined(typeof(TipoProducto), tipoSeleccionadoFiltro))
                        {
                            //convertir el valor numerico del enum a su nombre correspondiente
                            TipoProducto tipoFiltro = (TipoProducto)tipoSeleccionadoFiltro;
                            string tipoString = tipoFiltro.ToString(); 

                            almacen.ListarProductosPorTipo(tipoString);
                        }
                        else
                        {
                            Console.WriteLine("Tipo de producto no valido.");
                        }
                        break;




                    case "6":
                        //vender producto
                        Console.Write("Ingrese código del producto a vender: ");
                        string codVender = Console.ReadLine();
                        cProducto productoAVender = almacen.BuscarProducto(codVender);
                        if (productoAVender != null)
                        {
                            venta.AgregarProducto(productoAVender);
                            //despues que se vente se borra de inv
                            almacen.EliminarProducto(codVender); 
                            Console.WriteLine($"Producto '{productoAVender.getNombre()}' vendido.");
                        }
                        break;

                    case "7":
                        //mostrar inventario
                        almacen.ListarProductos();
                        break;

                    case "8":
                        //mostrar historial de ventas
                        venta.Mostrar();
                        break;

                    case "9":
                        almacen.ListarProductosHorizontal();
                        break;

                    case "10":
                        //salir
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Intene denuevo");
                        break;
                }
            }

            Console.WriteLine("Saliendo...");
        }
    }
}
