using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NdpÖdev
{
    class Program
    {

        static void Main(string[] args)
        {
            //string değişkenleri tanımladık.
            string[] bilgi;
            string isim;
            string soyisim;
            string numara;

            //Double değişkenleri tanımldık.
            double odev1;
            double odev2;
            double vize;
            double final;
            double odev1yuzde;
            double odev2yuzde;
            double vizeyuzde;
            double finalyuzde;
            double genelnot;
            double ffsayi = 0;
            double fdsayi = 0;
            double ddsayi = 0;
            double dcsayi = 0;
            double ccsayi = 0;
            double cbsayi = 0;
            double bbsayi = 0;
            double basayi = 0;
            double aasayi = 0;
            double ffyuzde;
            double fdyuzde;
            double ddyuzde;
            double dcyuzde;
            double ccyuzde;
            double cbyuzde;
            double bbyuzde;
            double bayuzde;
            double aayuzde;

            //Verilerin alındığı text dosyasını adresini yazıyoruz.
            string dosyaYolu = @"C:\Users\pc dell\source\repos\NdpÖdev\NdpÖdev\TextFile2.txt";
            string[] satir = System.IO.File.ReadAllLines(dosyaYolu);

            foreach (string s in satir)
            {
                //Split le boşluklara göre ayrılmasını sağlıyoruz.Ayrıca boşluklardaki verilerin tip dönüşümünü yapıyoruz.
                bilgi = s.Split(' ');
                isim = Convert.ToString(bilgi[0]);
                soyisim = Convert.ToString(bilgi[1]);
                numara = Convert.ToString(bilgi[2]);
                odev1 = Convert.ToDouble(bilgi[3]);
                odev2 = Convert.ToDouble(bilgi[4]);
                vize = Convert.ToDouble(bilgi[5]);
                final = Convert.ToDouble(bilgi[6]);
                odev1yuzde = Convert.ToDouble(bilgi[7]);
                odev2yuzde = Convert.ToDouble(bilgi[8]);
                vizeyuzde = Convert.ToDouble(bilgi[9]);
                finalyuzde = Convert.ToDouble(bilgi[10]);
                genelnot = (odev1 * odev1yuzde) + (odev2 * odev2yuzde) + (vize * vizeyuzde) + (final * finalyuzde);
               
                //Notları harflere göre sınıflandırıp saymasını sağlıyoruz.
                if (genelnot <= 39.99)
                {
                    ffsayi++;
                }
                else if (genelnot <= 49.99)
                {
                    fdsayi++;
                }
                else if (genelnot <= 57.99)
                {
                    ddsayi++;
                }
                else if (genelnot <= 64.99)
                {
                    dcsayi++;
                }
                else if (genelnot <= 74.99)
                {
                    ccsayi++;
                }
                else if (genelnot <= 79.99)
                {
                    cbsayi++;
                }
                else if (genelnot <= 84.99)
                {
                    bbsayi++;
                }
                else if (genelnot <= 89.99)
                {
                    basayi++;
                }
                else
                {
                    aasayi++;
                }
            }
            //Notların yüzdelerini bulmak için tek tek hesaplamaları yazıyoruz.
            aayuzde = (aasayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            bayuzde = (basayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            bbyuzde = (bbsayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            cbyuzde = (cbsayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            ccyuzde = (ccsayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            dcyuzde = (dcsayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            ddyuzde = (ddsayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            fdyuzde = (fdsayi / (ffsayi + fdsayi + ddsayi + dcsayi + ccsayi + cbsayi + bbsayi + basayi + aasayi)) * 100;
            ffyuzde = (ffsayi / (ffsayi+ fdsayi+ ddsayi + dcsayi+ ccsayi+ cbsayi+ bbsayi + basayi + aasayi))* 100;
                

            //Bilgileri cümle haline getiriyoruz.
            string aciklama = "AA sayısı=" + aasayi + " Yüzde:" + aayuzde+
            "\nBA sayısı=" + basayi + " Yüzde:" + bayuzde +
            "\nBB sayısı=" + bbsayi + " Yüzde:" + bbyuzde +
            "\nCB sayısı=" + cbsayi + " Yüzde:" + cbyuzde +
            "\nCC sayısı=" + ccsayi + " Yüzde:" + ccyuzde +
            "\nDC sayısı=" + dcsayi + " Yüzde:" + dcyuzde +
            "\nDD sayısı=" + ddsayi + " Yüzde:" + ddyuzde +
            "\nFD sayısı=" + fdsayi + " Yüzde:" + fdyuzde +
            "\nFF sayısı=" + ffsayi + " Yüzde:" + ffyuzde + "";
             
            //Text1 dosyasında istenilen bilgileri yazdırıyoruz.
            System.IO.File.WriteAllText(@"C: \Users\pc dell\source\repos\NdpÖdev\NdpÖdev\TextFile1.txt", aciklama);
             Console.ReadKey();
        }

    }
}


