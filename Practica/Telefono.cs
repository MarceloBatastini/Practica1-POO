using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Telefono
    {
        
        //private string modelo;
        //private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public string Modelo { get;}
        public string Marca { get;}
        public string NumeroTelefonico { get; set; }

        public int CodigoOperador
        {
            get
            { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
                    }
        }

        public Telefono (string Modelo, string Marca) 
        { 
            this.Modelo = Modelo; 
            this.Marca = Marca; 
        }

       
        public string Llamar ()
           {
               return "Realizando llamada .....";
           }

        
        public string Llamar (string contacto) 
        {
            return "Llamando a " + contacto + numeroTelefonico;
        }

    }

}
