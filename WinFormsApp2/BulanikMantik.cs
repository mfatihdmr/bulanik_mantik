using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class Kural
    {
        public static string[,] clastablomuz = {
                             { "Hassas", "Küçük", "Küçük", "Hassas", "Kısa", "Çok Az" },                //1
                             { "Hassas", "Küçük", "Orta", "Normal Hassas", "Kısa", "Az" },              //2
                             { "Hassas", "Küçük", "Büyük", "Orta", "Normal Kısa", "Orta" },             //3
                             { "Hassas", "Orta", "Küçük", "Hassas", "Kısa", "Orta" },                   //4
                             { "Hassas", "Orta", "Orta", "Normal Hassas", "Normal Kısa", "Orta" },      //5
                             { "Hassas", "Orta", "Büyük", "Orta", "Orta", "Fazla" },                    //6
                             { "Hassas", "Büyük", "Küçük", "Normal Hassas", "Normal Kısa", "Orta" },    //7
                             { "Hassas", "Büyük", "Orta", "Normal Hassas", "Orta", "Fazla" },           //8
                             { "Hassas", "Büyük", "Büyük", "Orta", "Normal Uzun", "Fazla" },            //9

                                 { "Orta", "Küçük", "Küçük", "Normal Hassas", "Normal Kısa", "Az" },         //10
                                 { "Orta", "Küçük", "Orta", "Orta", "Kısa", "Orta" },                        //11
                                 { "Orta", "Küçük", "Büyük", "Normal Güçlü", "Orta", "Fazla" },              //12
                                 { "Orta", "Orta", "Küçük", "Normal Hassas", "Normal Kısa", "Orta" },        //13
                                 { "Orta", "Orta", "Orta", "Orta", "Orta", "Orta" },                         //14
                                 { "Orta", "Orta", "Büyük", "Hassas", "Uzun", "Fazla" },                     //15
                                 { "Orta", "Büyük", "Küçük", "Hassas", "Orta", "Orta" },                     //16
                                 { "Orta", "Büyük", "Orta", "Hassas", "Normal Uzun", "Fazla" },              //17
                                 { "Orta", "Büyük", "Büyük", "Hassas", "Uzun", "Çok Fazla" },                //18

                                     { "Sağlam", "Küçük", "Küçük", "Orta", "Orta", "Az" },                          //19
                                     { "Sağlam", "Küçük", "Orta", "Normal Güçlü", "Orta", "Orta" },                 //20
                                     { "Sağlam", "Küçük", "Büyük", "Güçlü", "Normal Uzun", "Fazla" },               //21
                                     { "Sağlam", "Orta", "Küçük", "Orta", "Orta", "Orta" },                         //22
                                     { "Sağlam", "Orta", "Orta", "Normal Güçlü", "Normal Uzun", "Orta" },           //23
                                     { "Sağlam", "Orta", "Büyük", "Güçlü", "Orta", "Çok Fazla" },                   //24
                                     { "Sağlam", "Büyük", "Küçük", "Normal Güçlü", "Normal Uzun", "Fazla" },        //25
                                     { "Sağlam", "Büyük", "Orta", "Normal Güçlü", "Uzun", "Fazla" },                //26
                                     { "Sağlam", "Büyük", "Büyük", "Güçlü", "Uzun", "Çok Fazla" }};                 //27
    }



     class BulanikMantik
    {
        private double hassas;
        private double miktar;
        private double kirli;


        public string hassaslik;
        public string miktarı;
        public string kirlilik;


        public double[] hassasdegeri = new double[3] { 0, 0, 0 };
        public double[] miktardegeri = new double[3] { 0, 0, 0 };
        public double[] kirlilikdegeri = new double[3] { 0, 0, 0 };

        //Fonksiyon değerleri

        double[] hassasAraligiY = { -4, 1.5, 2, 4 };
        double[] hassasAraligiU = { 3, 5, 7 };
        double[] hassasAraligiY2 = { 5.5, 8, 12.5, 14 };

        double[] miktarAraligiY = { -4, 1.5, 2, 4 };
        double[] miktarAraligiU = { 3, 5, 7 };
        double[] miktarAraligiY2 = { 5.5, 8, 12.5, 14 };

        double[] kirliAraligiY = { -4.5, -2.5, 2, 4.5 };
        double[] kirliAraligiU = { 3, 5, 7 };
        double[] kirliAraligiY2 = { 5.5, 8, 12.5, 15 };

        //fonksiyonlara gönderiyoruz
        public BulanikMantik(double hassas, double miktar, double kirli)
        {
            this.hassas = hassas;
            this.miktar = miktar;
            this.kirli = kirli;

            HassaslikKurali();
            MiktarKurali();
            KirlilikKurali();

            Hassaslıkmamdani();
            Miktarmamdani();
            Kirlilikmamdani();
        }
        //Hassaslık değerini alıyor
        private void HassaslikKurali()
        {
            if (hassas >= 0 && hassas < 3) hassaslik = "Sağlam";
            else if (hassas > 4 && hassas < 5.5) hassaslik = "Orta";
            else if (hassas > 7 && hassas <= 10) hassaslik = "Hassas";

            else if (hassas >= 3 && hassas <= 4) hassaslik = "Sağlam-Orta";
            else if (hassas >= 5.5 && hassas <= 7) hassaslik = "Orta-Hassas";

        }
        //Kirlilik değerini alıyor
        private void KirlilikKurali()
        {
            if (kirli >= 0 && kirli < 3) kirlilik = "Küçük";
            else if (kirli > 4 && kirli < 5.5) kirlilik = "Orta";
            else if (kirli > 7 && kirli <= 10) kirlilik = "Büyük";

            else if (kirli >= 3 && kirli <= 4) kirlilik = "Küçük-Orta";
            else if (kirli >= 5.5 && kirli <= 7) kirlilik = "Orta-Büyük";
        }
        //Miktar değerini alıyor
        private void MiktarKurali()
        {
            if (miktar >= 0 && miktar < 3) miktarı = "Küçük";
            else if (miktar > 4 && miktar < 5.5) miktarı = "Orta";
            else if (miktar > 7 && miktar <= 10) miktarı = "Büyük";

            else if (miktar >= 3 && miktar <= 4) miktarı = "Küçük-Orta";
            else if (miktar >= 5.5 && miktar <= 7) miktarı = "Orta-Büyük";

        }

        public string[] Durum()
        {
            string[] bilgiler = { hassaslik, miktarı, kirlilik };
            return bilgiler;
        }
        public double üçgen = 0;
        public void Hassaslıkmamdani()
        {

            if (hassas >= hassasAraligiU[0] && hassas <= hassasAraligiU[1])
            {
                hassasdegeri[1] = (hassas - hassasAraligiU[0]) / (hassasAraligiU[1] - hassasAraligiU[0]);
            }
            else if (hassas >= hassasAraligiU[1] && hassas <= hassasAraligiU[2])
            {
                hassasdegeri[1] = (hassasAraligiU[0] - hassas) / (hassasAraligiU[2] - hassasAraligiU[1]);
            }
            else
            {
                hassasdegeri[1] = 0;
            }


            if (hassas >= hassasAraligiY[0] && hassas <= hassasAraligiY[1])
            {
                hassasdegeri[0] = (hassas - hassasAraligiY[0]) / (hassasAraligiY[1] - hassasAraligiY[0]);
            }
            else if (hassas >= hassasAraligiY[1] && hassas <= hassasAraligiY[2])
            {
                hassasdegeri[0] = 1;
            }
            else if (hassas >= hassasAraligiY[2] && hassas <= hassasAraligiY[3])
            {
                hassasdegeri[0] = (hassasAraligiY[3] - hassas) / (hassasAraligiY[3] - hassasAraligiY[2]);
            }
            else
                hassasdegeri[0] = 0;


            if (hassas >= hassasAraligiY2[0] && hassas <= hassasAraligiY2[1])
            {
                hassasdegeri[2] = (hassas - hassasAraligiY2[0]) / (hassasAraligiY2[1] - hassasAraligiY2[0]);
            }
            else if (hassas >= hassasAraligiY2[1] && hassas <= hassasAraligiY2[2])
            {
                hassasdegeri[2] = 1;
            }
            else if (hassas >= hassasAraligiY2[2] && hassas <= hassasAraligiY2[3])
            {
                hassasdegeri[2] = (hassasAraligiY2[3] - hassas) / (hassasAraligiY2[3] - hassasAraligiY2[2]);
            }
            else
                hassasdegeri[2] = 0;



        }
        public void Miktarmamdani()
        {

            if (miktar >= miktarAraligiU[0] && miktar <= miktarAraligiU[1])
            {
                miktardegeri[1] = (miktar - miktarAraligiU[0]) / (miktarAraligiU[1] - miktarAraligiU[0]);
            }
            else if (miktar >= miktarAraligiU[1] && miktar <= miktarAraligiU[2])
            {
                miktardegeri[1] = (miktarAraligiU[0] - miktar) / (miktarAraligiU[2] - miktarAraligiU[1]);
            }
            else
            {
                miktardegeri[1] = 0;
            }


            if (miktar >= miktarAraligiY[0] && miktar <= miktarAraligiY[1])
            {
                miktardegeri[0] = (miktar - miktarAraligiY[0]) / (miktarAraligiY[1] - miktarAraligiY[0]);
            }
            else if (miktar >= miktarAraligiY[1] && miktar <= miktarAraligiY[2])
            {
                miktardegeri[0] = 1;
            }
            else if (miktar >= miktarAraligiY[2] && miktar <= miktarAraligiY[3])
            {
                miktardegeri[0] = (miktarAraligiY[3] - miktar) / (miktarAraligiY[3] - miktarAraligiY[2]);
            }
            else
                miktardegeri[0] = 0;


            if (miktar >= miktarAraligiY2[0] && miktar <= miktarAraligiY2[1])
            {
                miktardegeri[2] = (miktar - miktarAraligiY2[0]) / (miktarAraligiY2[1] - miktarAraligiY2[0]);
            }
            else if (miktar >= miktarAraligiY2[1] && miktar <= miktarAraligiY2[2])
            {
                miktardegeri[2] = 1;
            }
            else if (miktar >= miktarAraligiY2[2] && miktar <= miktarAraligiY2[3])
            {
                miktardegeri[2] = (miktarAraligiY2[3] - miktar) / (miktarAraligiY2[3] - miktarAraligiY2[2]);
            }
            else
                miktardegeri[2] = 0;

        }
        public void Kirlilikmamdani()
        {
            if (kirli >= kirliAraligiU[0] && kirli <= kirliAraligiU[1])
            {
                kirlilikdegeri[1] = (kirli - kirliAraligiU[0]) / (kirliAraligiU[1] - kirliAraligiU[0]);
            }
            else if (kirli >= kirliAraligiU[1] && kirli <= kirliAraligiU[2])
            {
                kirlilikdegeri[1] = (kirliAraligiU[0] - kirli) / (kirliAraligiU[2] - kirliAraligiU[1]);
            }
            else
            {
                kirlilikdegeri[1] = 0;
            }


            if (miktar >= kirliAraligiY[0] && kirli <= kirliAraligiY[1])
            {
                kirlilikdegeri[0] = (kirli - kirliAraligiY[0]) / (kirliAraligiY[1] - kirliAraligiY[0]);
            }
            else if (kirli >= kirliAraligiY[1] && kirli <= kirliAraligiY[2])
            {
                kirlilikdegeri[0] = 1;
            }
            else if (kirli >= kirliAraligiY[2] && kirli <= kirliAraligiY[3])
            {
                kirlilikdegeri[0] = (kirliAraligiY[3] - kirli) / (kirliAraligiY[3] - kirliAraligiY[2]);
            }
            else
                kirlilikdegeri[0] = 0;

            if (miktar >= kirliAraligiY2[0] && kirli <= kirliAraligiY2[1])
            {
                kirlilikdegeri[2] = (kirli - kirliAraligiY2[0]) / (kirliAraligiY2[1] - kirliAraligiY2[0]);
            }
            else if (kirli >= kirliAraligiY2[1] && kirli <= kirliAraligiY2[2])
            {
                kirlilikdegeri[2] = 1;
            }
            else if (kirli >= kirliAraligiY2[2] && kirli <= kirliAraligiY2[3])
            {
                kirlilikdegeri[2] = (kirliAraligiY2[3] - kirli) / (kirliAraligiY2[3] - kirliAraligiY2[2]);
            }
            else
                kirlilikdegeri[2] = 0;
        }
    }
}
