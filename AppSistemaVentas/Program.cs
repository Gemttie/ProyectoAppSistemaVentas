using System;
using System.Collections;

namespace AppSistemaVentas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear productos individuales de diferentes tipos
            cProducto prod1 = new cProducto("001", "Botella de Agua", "2.5");
            cBicicleta bici1 = new cBicicleta("B001", "Bicicleta de Montaña", "120.0", "Disco", false);
            cCoche coche1 = new cCoche("C001", "Coche de Juguete", "45.5", "Paseo", 10);
            cScooter scooter1 = new cScooter("S001", "Scooter Eléctrico", "300.0", "Razor", "Goma Inflable");

            // Crear almacén y agregar productos
            cAlmacen almacen = new cAlmacen();
            almacen.agregarProducto(prod1);
            almacen.agregarProducto(bici1);
            almacen.agregarProducto(coche1);
            almacen.agregarProducto(scooter1);

            // Mostrar inventario del almacén
            Console.WriteLine("\n--- Inventario del Almacén ---");
            almacen.mostrarAlmacen();

            // Buscar un producto en el almacén
            Console.WriteLine("\n--- Buscando Producto B001 en el Almacén ---");
            cProducto productoBuscado = almacen.buscarProducto("B001");
            if (productoBuscado != null)
            {
                Console.WriteLine("Producto encontrado:");
                productoBuscado.mostrar();
            }

            // Eliminar un producto del almacén
            Console.WriteLine("\n--- Eliminando Producto C001 del Almacén ---");
            almacen.eliminarProducto("C001");

            // Mostrar inventario actualizado del almacén
            Console.WriteLine("\n--- Inventario Actualizado del Almacén ---");
            almacen.mostrarAlmacen();

            // Crear una venta y agregar productos
            cVenta venta = new cVenta();
            venta.agregarProducto(prod1);
            venta.agregarProducto(bici1);

            // Mostrar detalle de la venta
            Console.WriteLine("\n--- Detalle de la Venta ---");
            venta.mostrar();

            // Calcular y mostrar el total de la venta
            double totalVenta = venta.calcularTotal();
            Console.WriteLine($"Total de la Venta: ${totalVenta}");

            // Fin de la prueba
            Console.WriteLine("\n--- Fin de la Prueba ---");
        }
    }
}
