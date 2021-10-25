using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace /*palabra reservada*/ PrimerPractica //Identificador
                        
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion de texto a numero.../parse
            //De numero a texto : ToString

          

            Console.WriteLine("Ingrese un numero : " );
            string primernumero=Console.ReadLine();

            Console.WriteLine("Ingrese segundo numero: ");
            string segundonumero = Console.ReadLine();

            int primernumeroconvertido=int.Parse(primernumero);
            int segundonumeroconvertido = int.Parse(segundonumero);

            int suma = primernumeroconvertido + segundonumeroconvertido;

            Console.WriteLine("La suma es : " + suma);
            Console.ReadLine();
        
            

        }
    }
}
