using System;
using System.Collections;

namespace AppSistemaVentas
{
    internal class cAlmacen
    {
        // Atributos
        private ArrayList aAlmacen;

        // Constructores
        public cAlmacen()
        {
            aAlmacen = new ArrayList();
        }

        // Set y get
        public void setAlmacen(ArrayList pAlmacen)
        {
            aAlmacen = pAlmacen;
        }

        public ArrayList getAlmacen()
        {
            return aAlmacen;
        }

        // Otros métodos
        public void agregarProducto(cProducto producto)
        {
            aAlmacen.Add(producto);
            Console.WriteLine($"Producto '{producto.getNombre()}' agregado al almacén.");
        }

        public void eliminarProducto(string codigo)
        {
            foreach (cProducto producto in aAlmacen)
            {
                if (producto.getCodigo() == codigo)
                {
                    aAlmacen.Remove(producto);
                    Console.WriteLine($"Producto con código '{codigo}' eliminado del almacén.");
                    return;
                }
            }
            Console.WriteLine($"Producto con código '{codigo}' no encontrado.");
        }

        public void mostrarAlmacen()
        {
            Console.WriteLine("========================");
            Console.WriteLine("INVENTARIO DEL ALMACÉN");
            Console.WriteLine("========================");

            if (aAlmacen.Count == 0)
            {
                Console.WriteLine("El almacén está vacío.");
                return;
            }

            foreach (cProducto producto in aAlmacen)
            {
                producto.mostrar();
                Console.WriteLine("------------------------");
            }
        }

        public cProducto buscarProducto(string codigo)
        {
            foreach (cProducto producto in aAlmacen)
            {
                if (producto.getCodigo() == codigo)
                {
                    return producto;
                }
            }

            Console.WriteLine($"Producto con código '{codigo}' no encontrado.");
            return null;
        }
    }
}
