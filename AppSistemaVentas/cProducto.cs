using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaVentas
{
    public class cProducto
    {
        //Atributos
        private string aCod;
        private string aNombre;
        private string aPrecio;

        //Metodos
        //Construcutores
        public cProducto()
        {
            aCod = "";
            aNombre = "";
            aPrecio = "";
        }

        public cProducto(string pCod, string pNombre, string pPrecio)
        {
            aCod = pCod;
            aNombre = pNombre;
            aPrecio = pPrecio;
        }

        //Set y get
        public void setCodigo(string pCod)
        {
            aCod = pCod;
        }

        public string getCodigo()
        {
            return aCod;
        }

        public void setNombre(string pNombre)
        {
            aNombre = pNombre;
        }

        public string getNombre()
        {
            return aNombre;
        }

        public void setPrecio(string pPrecio)
        {
            aPrecio = pPrecio;
        }

        public string getPrecio()
        {
            return aPrecio;
        }

        //Otros metodos
        public virtual void mostrar()
        {
            Console.WriteLine("========================");
            Console.WriteLine("INFORMACION DEL PRODUCTO");
            Console.WriteLine("========================");
            Console.WriteLine($"Codigo : {aCod}");
            Console.WriteLine($"Nombre : {aNombre}");
            Console.WriteLine($"Precio : {aPrecio}");
        }
    }
}
