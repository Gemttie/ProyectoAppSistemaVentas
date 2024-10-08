using System;

namespace AppSistemaVentas
{
    internal class cScooter : cProducto
    {
        //Atributos
        private string aModelo; // mini, razor, yvolution
        private string aTipoRueda; // sólida, inflable

        //Constructores
        public cScooter() : base()
        {
            aModelo = "";
            aTipoRueda = "";
        }

        public cScooter(string pCod, string pNombre, string pPrecio, string pModelo, string pTipoRueda)
            : base(pCod, pNombre, pPrecio)
        {
            aModelo = pModelo;
            aTipoRueda = pTipoRueda;
        }

        //set y get
        public void setModelo(string pModelo)
        {
            aModelo = pModelo;
        }

        public string getModelo()
        {
            return aModelo;
        }

        public void setTipoRueda(string pTipoRueda)
        {
            aTipoRueda = pTipoRueda;
        }

        public string getTipoRueda()
        {
            return aTipoRueda;
        }

        //Otros métodos
        public override void mostrar()
        {
            base.mostrar();

            Console.WriteLine("========================");
            Console.WriteLine("INFORMACIÓN DEL SCOOTER");
            Console.WriteLine("========================");
            Console.WriteLine($"Modelo: {aModelo}");
            Console.WriteLine($"Tipo de Rueda: {aTipoRueda}");
        }
    }
}
