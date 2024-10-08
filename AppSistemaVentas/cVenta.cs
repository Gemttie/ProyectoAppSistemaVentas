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

        //Set y get
        public void setVenta(ArrayList pVenta)
        {
            aVenta = pVenta;
        }

        public ArrayList getVenta()
        {
            return aVenta;
        }

        //Otros métodos
        public void agregarProducto(cProducto producto)
        {
            aVenta.Add(producto);
        }

        public void mostrar()
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

        public double calcularTotal()
        {
            double total = 0;

            foreach (cProducto producto in aVenta)
            {
                // Intentamos convertir el precio del producto a double
                if (double.TryParse(producto.getPrecio(), out double precio))
                {
                    total += precio;
                }
            }

            return total;
        }
    }
}
