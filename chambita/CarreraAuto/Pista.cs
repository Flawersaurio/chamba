using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAuto
{
    class Pista
    {
        public string Nombre;
        public float Logngitud;

        public void Competir(AutoCarreras auto1, AutoCarreras auto2)

        {
            Console.WriteLine("iniciando carrera entre " + auto1.modelo + " y " + auto2.modelo);

            if(auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("Gano " + auto1.modelo);
            }
            else if(auto2.velocidad > auto1.velocidad)
            {
                Console.WriteLine("Gano " + auto2.modelo);
            }
            else//tienen la misma velocidad
            {
                Console.WriteLine("Hubo empate");
            }



        }


    }
}
