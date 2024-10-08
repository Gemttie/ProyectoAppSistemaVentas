using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaVentas
{
    internal class cCoche : cProducto
    {
        //Atributos
        private string aTipoSilla; // convertible, paseo, doble, viaje
        private int aCarga;
        //Metodos
        //Constructores
        public cCoche() : base()
        {
            aTipoSilla = "";
            aCarga = 0;
        }

        public cCoche(string pCod, string pNombre, string pPrecio, string pTipoSilla, int pCarga)
            : base(pCod, pNombre, pPrecio) 
        {
            aTipoSilla = pTipoSilla;
            aCarga = pCarga;
        }

        //Set y get
        public void setTipoSilla(string pTipoSilla)
        {
            aTipoSilla = pTipoSilla;
        }

        public string getTipoSilla()
        {
            return aTipoSilla;
        }

        public void setCarga(int pCarga)
        {
            aCarga = pCarga;
        }

        public int getCarga()
        {
            return aCarga;
        }

        //Otros metodos
        public override void mostrar()
        {
            
            base.mostrar();

            Console.WriteLine("========================");
            Console.WriteLine("INFORMACIÓN DEL COCHE");
            Console.WriteLine("========================");
            Console.WriteLine($"Tipo de Silla: {aTipoSilla}");
            Console.WriteLine($"Capacidad de Carga: {aCarga} kg");
        }
    }
}
