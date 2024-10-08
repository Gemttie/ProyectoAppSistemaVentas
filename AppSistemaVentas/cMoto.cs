using System;

namespace AppSistemaVentas
{
    internal class cMoto : cProducto
    {
        //Atributos
        private int aNroRuedas;
        private string aTipoBateria; // recargable, desechable

        //Constructores
        public cMoto() : base()
        {
            aNroRuedas = 0;
            aTipoBateria = "";
        }

        public cMoto(string pCod, string pNombre, string pPrecio, int pNroRuedas, string pTipoBateria)
            : base(pCod, pNombre, pPrecio, TipoProducto.Moto)
        {
            aNroRuedas = pNroRuedas;
            aTipoBateria = pTipoBateria;
        }

        //Set y get
        public void setNroRuedas(int pNroRuedas)
        {
            aNroRuedas = pNroRuedas;
        }

        public int getNroRuedas()
        {
            return aNroRuedas;
        }

        public void setTipoBateria(string pTipoBateria)
        {
            aTipoBateria = pTipoBateria;
        }

        public string getTipoBateria()
        {
            return aTipoBateria;
        }

        //Otros métodos
        public override void mostrar()
        {
            base.mostrar();

            Console.WriteLine("========================");
            Console.WriteLine("INFORMACIÓN DE LA MOTO");
            Console.WriteLine("========================");
            Console.WriteLine($"Número de Ruedas: {aNroRuedas}");
            Console.WriteLine($"Tipo de Batería: {aTipoBateria}");
        }

        public override string mostrarTipo()
        {
            return "Moto";
        }
    }
}
