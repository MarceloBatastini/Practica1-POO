using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Telefono telefono1 = new Telefono("Novel", "LG");
            telefono1.NumeroTelefonico = "1520334265";
            telefono1.CodigoOperador = 1;

            Telefono telefono2 = new Telefono("K9", "Samsung");
            telefono2.CodigoOperador = 3;
            telefono2.NumeroTelefonico = "1532205945";

            Telefono telefono3 = new Telefono("A3", "Motorola");
            telefono3.CodigoOperador = 5;
            telefono3.NumeroTelefonico = "034662288";

            Console.WriteLine("El modelo es " + telefono1.Modelo + " y la marca es: " + telefono1.Marca);
            Console.WriteLine("El numero de telefono es: " + telefono1.NumeroTelefonico + " y su codigo de area es: "+ telefono1.CodigoOperador);
            

            Console.WriteLine("El numero de telefono es: " + telefono2.NumeroTelefonico + " y su codigo de area es: " + telefono2.CodigoOperador);
            Console.WriteLine("El numero de telefono es: " + telefono3.NumeroTelefonico + " y su codigo de area es: " + telefono3.CodigoOperador);

            Console.WriteLine(telefono1.Llamar());


            Console.WriteLine(telefono3.Llamar("Juan Jose Lopez"));

            Console.ReadLine();



        }
    }
}
