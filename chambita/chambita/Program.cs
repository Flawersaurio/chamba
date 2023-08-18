using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chambita
{
    class Program
    {
        //este es el metodo main, sirve como punto de entrada para el programa (inicia desde aqui)
        static void Main(string[] args)
        {
            //Esto es una instancia de mochila
            mochila mochilaAna = new mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vinyl";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumDeLlaveros = 0;
            mochilaAna.Precio = 500.00f;
            mochilaAna.color = new color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Azul = 20;
            mochilaAna.color.Verde = 33;


            mochila mochilaBeto = new mochila();
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.Material = "Piel";
            mochilaBeto.NumDeBolsas = 3;
            mochilaBeto.NumDeLlaveros = 3;
            mochilaBeto.Precio = 179.00f;
            mochilaBeto.color = new color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Azul = 128;
            mochilaBeto.color.Verde = 210;


            mochila mochilaPablo = new mochila();
            mochilaPablo.Disenio = "Ferrari";
            mochilaPablo.Material = "Lona";
            mochilaPablo.NumDeBolsas = 5;
            mochilaPablo.NumDeLlaveros = 2;
            mochilaPablo.Precio = 800.00f;
            mochilaPablo.color = new color();
            mochilaPablo.color.Rojo = 200;
            mochilaPablo.color.Azul = 0;
            mochilaPablo.color.Verde = 0;


            smartphone smartphoneDavid = new smartphone();
        //Network
            smartphoneDavid.technology = "LTE";
        //Launch
            smartphoneDavid.announced = 2021;
            smartphoneDavid.status = "Availiable";
        //Body
            smartphoneDavid.dimensionsH = 164;
            smartphoneDavid.dimensionsW = 76.5f;
            smartphoneDavid.dimensionsD = 8.1f;
            smartphoneDavid.weight = 193;
            smartphoneDavid.build = "Gorilla Glass 5";
            smartphoneDavid.SIM = "Dual SIM";
        //Display
            smartphoneDavid.type = "AMOLED 120 HZ";
            smartphoneDavid.size = 107.4f;
            smartphoneDavid.resolution = "1080 x 2400";
            smartphoneDavid.protection = "Corning Gorilla Glass 5";
        //Plataform
            smartphoneDavid.OS = "MIUI 14";
            smartphoneDavid.chipset = "Qualcomm SM7150 Snapdragon 732G";
            smartphoneDavid.CPU = "Octa-core";
            smartphoneDavid.GPU = "Adreno 618";
        //Memory
            smartphoneDavid.cardslot = "microSDXC";
            smartphoneDavid.ROM = 128;
            smartphoneDavid.RAM = 8;
        //Main Camera
            smartphoneDavid.maincamera1 = 108;
            smartphoneDavid.maincamera2 = 8;
            smartphoneDavid.maincamera3 = 5;
            smartphoneDavid.maincamera4 = 2;
            smartphoneDavid.mainfeatures = "LED flash, HDR";
            smartphoneDavid.mainvideo = "4K 30fps, 1080p 60fps";
        //Front Camera
            smartphoneDavid.frontcamera = 16;
            smartphoneDavid.frontfeatures = "Panorama";
            smartphoneDavid.frontvideo = "1080p 30fps, 720p 120fps";
        //Sound
            smartphoneDavid.loudspeaker = "Stereo speakers";
            smartphoneDavid.headphonesjack = true;
        //Comms
            smartphoneDavid.WLAN = "Wi-Fi 8";
            smartphoneDavid.bluetooth = 5.1f;
            smartphoneDavid.possitioning "GPS";
            smartphoneDavid.NFC = true;
            smartphoneDavid.infrarredport = true;
            smartphoneDavid.radio = "FM radio";
            smartphoneDavid.USB = "Type C 2.0";
        //Features
            smartphoneDavid.sensors = "fingerprint, accelerometer, gyro, compass, virtual proximity";
        //Battery
            smartphoneDavid.batterytype = 5020;
            smartphoneDavid.charging = 33;
        //Misc
            smartphoneDavid.color = "Onyx Gray";
            smartphoneDavid.model = "M2101K6R";
            smartphoneDavid.SARH = 1.09f;
            smartphoneDavid.SARB = 1.06f;
            smartphoneDavid.SARHEU = 0.60f;
            smartphoneDavid.SARBEU = 0.99f;
            smartphoneDavid.price = 214.39f;



        }
    }
}
