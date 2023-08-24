using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAuto
{
    class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;

        public void Acelerar(int cantidad)
        {
            velocidad = velocidad + cantidad;
            Console.WriteLine(modelo + " acelero a " + velocidad + " km/h de velocidad");

            gasolina = gasolina - cantidad / 10f;
            if(gasolina < 0)
            {
                Console.WriteLine(modelo + " se ha quedado sin gasolina ");
            
            }

        }

        public void Frenar(float cantidad)
        {
            velocidad = 0;
            Console.WriteLine(modelo + " freno a " + velocidad + " km/h de velocidad");


        }


        public void PonerGas(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(modelo + " tiene " + gasolina + " de gas.");

        }

        public void Arrancar() 
        {
            if (gasolina > 0)
            {
                gasolina = gasolina - 0.01f;  //consume .01 litros cada que arranca 
                Console.WriteLine("Arancando " + modelo + " le quedan " + gasolina + " de gas.");
            }
            else
            {
                Console.WriteLine("No se puede arrancar " + modelo + " sin gasolina.");
            }

        }


    }
}
