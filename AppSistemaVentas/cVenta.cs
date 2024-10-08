using System;
using System.Collections;

namespace AppSistemaVentas
{
    internal class cVenta
    {
        //Atributos
        private ArrayList aVenta;

        //Constructores
        public cVenta()
        {
            aVenta = new ArrayList();
        }

        //agregar un producto a la venta
        public void AgregarProducto(cProducto producto)
        {
            aVenta.Add(producto);
        }

        //detalle de la venta
        public void Mostrar()
        {
            Console.WriteLine("========================");
            Console.WriteLine("DETALLE DE LA VENTA");
            Console.WriteLine("========================");

            foreach (cProducto producto in aVenta)
            {
                producto.mostrar();
                Console.WriteLine("------------------------");
            }
        }

        //calcular el total de la venta
        public double CalcularTotal()
        {
            double total = 0;

            foreach (cProducto producto in aVenta)
            {
                if (double.TryParse(producto.getPrecio(), out double precio))
                {
                    total += precio;
                }
            }

            return total;
        }
    }
}
