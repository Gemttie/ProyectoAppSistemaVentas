using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaVentas
{
    internal class cBicicleta : cProducto
    {
        //Atributos
        private string aTipoFreno; // Manual, pedal, disco
        private bool aRuedaApoyo;

        //Metodos
        //Constructores
        public cBicicleta() : base() // Llama al constructor por defecto de la clase base
        {
            aTipoFreno = "";
            aRuedaApoyo = false;
        }

        public cBicicleta(string pCod, string pNombre, string pPrecio, string pTipoFreno, bool pRuedaApoyo)
            : base(pCod, pNombre, pPrecio) 
        {
            aTipoFreno = pTipoFreno;
            aRuedaApoyo = pRuedaApoyo;
        }


        //Set y get
        public void setTipoFreno(string pTipoFreno)
        {
            aTipoFreno = pTipoFreno;
        }

        public string getTipoFreno()
        {
            return aTipoFreno;
        }

        public void setRuedaApoyo(bool pRuedaApoyo)
        {
            aRuedaApoyo = pRuedaApoyo;
        }

        public bool getRuedaApoyo()
        {
            return aRuedaApoyo;
        }

        //Otros metodos
        public override void mostrar()
        {
            base.mostrar();

            Console.WriteLine("========================");
            Console.WriteLine("INFORMACIÓN DE LA BICICLETA");
            Console.WriteLine("========================");
            Console.WriteLine($"Tipo de Freno: {aTipoFreno}");
            Console.WriteLine($"¿Tiene Ruedas de Apoyo?: {(aRuedaApoyo ? "Sí" : "No")}");
        }
    }
}
