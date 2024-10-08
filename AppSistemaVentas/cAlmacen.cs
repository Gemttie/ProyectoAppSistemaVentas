using System;
using System.Collections;

namespace AppSistemaVentas
{
    internal class cAlmacen
    {
        //Atributos
        private ArrayList aAlmacen;

        //Constructores
        public cAlmacen()
        {
            aAlmacen = new ArrayList();
        }

        //agregar producto
        public void AgregarProducto(cProducto producto)
        {
            aAlmacen.Add(producto);
            Console.WriteLine($"Producto '{producto.getNombre()}' agregado al almacen.");
        }

        //eliminar un producto
        public void EliminarProducto(string codigo)
        {
            foreach (cProducto producto in aAlmacen)
            {
                if (producto. getCodigo() == codigo)
                {
                    aAlmacen.Remove(producto);
                    Console.WriteLine($"Producto con codigo '{codigo}' eliminado del almacen.");
                    return;
                }
            }
            Console.WriteLine($"Producto con código '{codigo}' no encontrado.");
        }

        //buscar un producto por código
        public cProducto BuscarProducto(string codigo)
        {
            foreach (cProducto producto in aAlmacen)
            {
                if (producto.getCodigo() == codigo)
                {
                    return producto;
                }
            }
            Console.WriteLine($"Producto con codigo '{codigo}' no encontrado.");
            return null;
        }

        //listar todos los productos
        public void ListarProductos()
        {
            Console.WriteLine("========================");
            Console.WriteLine("INVENTARIO DEL ALMACEN");
            Console.WriteLine("========================");

            if (aAlmacen.Count == 0)
            {
                Console.WriteLine("El almacen esta vacio.");
                return;
            }

            foreach (cProducto producto in aAlmacen)
            {
                producto.mostrar();
                Console.WriteLine("------------------------");
            }
        }

        //listar productos por tipo
        public void ListarProductosPorTipo(string tipo)
        {
            Console.WriteLine("========================");
            Console.WriteLine($"PRODUCTOS DE TIPO '{tipo.ToUpper()}'");
            Console.WriteLine("========================");

            bool encontrado = false;

            foreach (cProducto producto in aAlmacen)
            {
                //comparar tipo
                if (producto is cBicicleta && tipo.Equals("Bicicleta", StringComparison.OrdinalIgnoreCase) ||
                    producto is cCoche && tipo.Equals("Coche", StringComparison.OrdinalIgnoreCase) ||
                    producto is cMoto && tipo.Equals("Moto", StringComparison.OrdinalIgnoreCase) ||
                    producto is cScooter && tipo.Equals("Scooter", StringComparison.OrdinalIgnoreCase))
                {
                    producto.mostrar();
                    Console.WriteLine("------------------------");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontraron productos de tipo '{tipo}'.");
            }
        }

        public void ListarProductosHorizontal()
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("Código de Producto       Nombre       Precio      Tipo");
            Console.WriteLine("=========================================================");

            if (aAlmacen.Count == 0)
            {
                Console.WriteLine("El almacén esta vacíio");
            }
            else
            {
                foreach (cProducto producto in aAlmacen)
                {
                    
                    Console.WriteLine($"{producto.getCodigo().PadRight(25)} {producto.getNombre().PadRight(15)} {producto.getPrecio().PadRight(10)} {producto.mostrarTipo()}");
                }
            }

            Console.WriteLine("=========================================================");
        }


    }
}
