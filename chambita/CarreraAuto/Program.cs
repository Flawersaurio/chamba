using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAuto
{
    public class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras Ferrari = new AutoCarreras();
            Ferrari.modelo = "Ferrari F150";
            Ferrari.peso = 1.3f;
            Ferrari.velocidad = 230;

            AutoCarreras McLaren = new AutoCarreras();
            McLaren.modelo = "McLaren A45S";
            McLaren.peso = 0.98f;
            McLaren.velocidad = 280;

            AutoCarreras Porsche = new AutoCarreras();
            Porsche.modelo = "Porsche GT4RS";
            Porsche.peso = 1.1f;
            Porsche.velocidad = 250;




            Pista hnsRodriguez = new Pista();
            hnsRodriguez.Nombre = "Autodromo Hermanos Rodriguez";
            hnsRodriguez.Logngitud = 5.6f; //en km

            //mando a correr a los krriyos
            hnsRodriguez.Competir(Ferrari, Porsche);

            //esta instrucion espera a que des enter para continuar
            Console.ReadLine();


        }
    }
}
