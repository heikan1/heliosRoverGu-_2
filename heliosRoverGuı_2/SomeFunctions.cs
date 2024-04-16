using Newtonsoft.Json.Linq;
using Plasmoid.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heliosRoverGuı_2
{
    static class SomeFunctions
    {
        static int hizVeriSayisi = 0;
        static int lastMaxHizData = 0;
        static double lastHizOrtData = 0;

        static int temperatureVeriSayisi = 0;
        static int lastMaxTemperatureData = 0;
        static double lastTemperatureOrtData = 0;

        static int moistureVeriSayisi = 0;
        static int lastMaxMoistureeData = 0;
        static double lastMoistureOrtData = 0;


        public static double MoistureOrtHesaplama(int mois)
        {
            if (moistureVeriSayisi == 0)
            {
                lastMoistureOrtData = mois;
                moistureVeriSayisi++;
                return mois;
            }
            else
            {
                double sonuc = (lastMoistureOrtData * moistureVeriSayisi + mois) / (moistureVeriSayisi + 1);
                moistureVeriSayisi++;
                lastMoistureOrtData = sonuc;
                return sonuc;
            }
        }
        public static int MoistureMaxHesaplama(int mois)
        {
            if (mois > lastMaxMoistureeData)
            {
                lastMaxMoistureeData = mois;
                return mois;
            }
            else
                return lastMaxMoistureeData;

        }
        public static double TemperatureOrtHesaplama(int temp)
        {
            if (temperatureVeriSayisi == 0)
            {
                lastTemperatureOrtData = temp;
                temperatureVeriSayisi++;
                return temp;
            }
            else
            {
                double sonuc = (lastTemperatureOrtData * temperatureVeriSayisi + temp) / (temperatureVeriSayisi + 1);
                temperatureVeriSayisi++;
                lastTemperatureOrtData = sonuc;
                return sonuc;
            }
        }
        public static int TemperatureMaxHesaplama(int temp)
        {
            if (temp > lastMaxTemperatureData)
            {
                lastMaxTemperatureData = temp;
                return temp;
            }
            else
                return lastMaxTemperatureData;

        }
        public static double HizOrtHesaplama(int hiz) {
            if (hizVeriSayisi == 0)
            {
                lastHizOrtData = hiz;
                hizVeriSayisi++;
                return hiz;
            }
            else
            {
                double sonuc = (lastHizOrtData * hizVeriSayisi + hiz) / (hizVeriSayisi + 1);
                hizVeriSayisi++;
                lastHizOrtData = sonuc;
                return sonuc;
            }
        }
        public static int HizMaxHesaplama(int hiz)
        {
            if (hiz > lastMaxHizData)
            {
                lastMaxHizData = hiz;
                return hiz;
            }
            else
                return lastMaxHizData;

        }
        virtual ListViewVirtualItemsSelectionRangeChangedEventArgs     +e
        // Menüdeki Rounded Rectangleları paneller boyutunda otomatik yapmamızı sağlayan fonksiyon
        public static void RoundedLookingPanel(PaintEventArgs e,Panel pnl,int radius,Color clr)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(clr), 0, 0, pnl.Width, pnl.Height, radius);
            SolidBrush brush = new SolidBrush(clr);
        }

        public static void LogDosyasıYoksaOlusturma()
        {
            string folderPath = @"logs";

            try
            {
                if (Directory.Exists(folderPath))
                {
                    //bi şey yapma
                    return;
                }
                //dosyayi olustur
                DirectoryInfo di = Directory.CreateDirectory(folderPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { }
        }

        public static string TarihliLoguOlusturma()
        {
            string currentTime = DateTime.Now.ToString("yyyy") + "_" + DateTime.Now.ToString("MM") + "_" + DateTime.Now.ToString("dd") + "-" + DateTime.Now.ToString("HH") + "_" + DateTime.Now.ToString("mm") + "_" + DateTime.Now.ToString("ss");
            string filepath = @"logs\" + currentTime.ToString() + ".txt";
            FileStream fs = File.Create(filepath);
            return filepath;
        }

        public static string RandomDataGenerator()
        {
            string wildPlantCoordinateDate = "";
            string coordinateData = "";
            Random random = new Random();
            string sformat = "";
            sformat += "~"; //baslangic karakteri  0
            sformat += "|"; //ara karakter
            sformat += random.Next(0, 101).ToString(); //hız verisi 1
            sformat += "|";
            sformat += random.Next(0, 101).ToString(); //estimated runtime in battery 2
            sformat += "|"; //aynı kısım ile alakalı gelen iki veriyi ayırmak için, belki kaldırıp direkt | kullanabiliriz idk
            sformat += random.Next(0, 18001).ToString(); // kalan mah 3
            sformat += "|";
            sformat += random.Next(0, 101).ToString(); //sıcaklık 4
            sformat += "|";
            sformat += random.Next(0, 101).ToString(); //nem 5
            sformat += "|";
            sformat += random.Next(0, 361).ToString(); //direction 6
            sformat += "|";
            switch (random.Next(0, 4))
            {
                case 0:
                    coordinateData += "40.743087634167544|30.32934744870489"; //lat,long data 7-8
                    break;
                case 1:
                    coordinateData += "40.7473143901652|30.358186559516245";
                    break;
                case 2:
                    coordinateData += "40.76597393186875|30.356212453716655";
                    break;
                case 3:
                    coordinateData += "40.74373792180566|30.37827094025986";
                    break;
            }
            sformat += coordinateData; //4 kordinattan birini rastgele koydu
            sformat += "|";
            switch (random.Next(0, 5))
            {
                case 0:
                    wildPlantCoordinateDate += "40.743087634167544|30.32934744870489"; //lat,long data 9-10
                    break;
                case 1:
                    wildPlantCoordinateDate += "40.7473143901652|30.358186559516245";
                    break;
                case 2:
                    wildPlantCoordinateDate += "40.76597393186875|30.356212453716655";
                    break;
                case 3:
                    wildPlantCoordinateDate += "40.74373792180566|30.37827094025986";
                    break;
                case 4:
                    wildPlantCoordinateDate += "0|0"; //bulunamadı değeri
                    break;
            }
            sformat += wildPlantCoordinateDate;
            sformat += "|";

            return sformat;
        }

        
    }
}
