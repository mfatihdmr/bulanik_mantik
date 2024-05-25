using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BulanikMantik bulanik;

        private void tbHassas_ValueChanged(object sender, EventArgs e)
        {
            trackandlabel(tbhassaslik, lblHassas);
        }
        private void tbMiktar_ValueChanged(object sender, EventArgs e)
        {
            trackandlabel(tbmiktar, lblMiktar);
        }

        private void tbKirli_ValueChanged(object sender, EventArgs e)
        {
            trackandlabel(tbkirlilik, lblKirli);
        }

        private void trackandlabel(TrackBar track, Label lbl)
        {
            if (track.Value < 10)
            {
                lbl.Text = "0," + track.Value.ToString();
            }
            else if (track.Value > 10 && track.Value < 100)
            {
                lbl.Text = track.Value.ToString().Substring(0, 1) + "," + track.Value.ToString().Substring(1);
            }
            else if (track.Value == 100)
            {
                lbl.Text = "10,0";
            }

            Durum();
        }



        void Durum()
        {
            bulanik = new BulanikMantik(Convert.ToDouble(lblHassas.Text), Convert.ToDouble(lblMiktar.Text), Convert.ToDouble(lblKirli.Text));
            lbhassaslýk.Text = bulanik.Durum()[0];
            lMiktar.Text = bulanik.Durum()[1];
            lKirlilik.Text = bulanik.Durum()[2];
        }


        void Listgoster()
        {
            double x = 1;
            listgoster.Columns.Clear();
            listgoster.Columns.Add("Sýra", (int)(50), HorizontalAlignment.Center);
            listgoster.Columns.Add("Hassaslýk", (int)(90), HorizontalAlignment.Center);
            listgoster.Columns.Add("Miktar", (int)(70), HorizontalAlignment.Center);
            listgoster.Columns.Add("Kirlilik", (int)(70), HorizontalAlignment.Center);
            listgoster.Columns.Add("DönüþHýzý", (int)(130), HorizontalAlignment.Center);
            listgoster.Columns.Add("Süre", (int)(120), HorizontalAlignment.Center);
            listgoster.Columns.Add("Deterjan", (int)(90), HorizontalAlignment.Center);
            listgoster.View = View.Details;
        }
        void KurallariDoldur()
        {
            listgoster.Items.Clear();

            for (int i = 0; i < 27; i++)
            {
                ListViewItem satir = new ListViewItem((i + 1).ToString());
                for (int j = 0; j < 6; j++)
                {
                    satir.SubItems.Add(Kural.clastablomuz[i, j]);
                }
                listgoster.Items.Add(satir);
            }
        }

        void tablorenk_ata()
        {
            int sira = 0;
            int[] tablodanGelenler = new int[8];

            string[,] kural = Kural.clastablomuz;
            for (int i = 0; i < 27; i++)
            {
                if (
                    bulanik.hassaslik.IndexOf(kural[i, 0]) != -1 &&
                    bulanik.miktarý.IndexOf(kural[i, 1]) != -1 &&
                    bulanik.kirlilik.IndexOf(kural[i, 2]) != -1
                    )
                {
                    listgoster.Items[i].Selected = true;
                    listgoster.Items[i].ForeColor = Color.WhiteSmoke;
                    listgoster.Items[i].BackColor = Color.DarkBlue;
                    tablodanGelenler[sira] = i;
                    sira++;
                }
            }
            label1.Text = bulanik.hassasdegeri[1].ToString() + "    " + bulanik.miktardegeri[0].ToString() + "    " + bulanik.kirlilikdegeri[0].ToString();
            label2.Text = bulanik.hassasdegeri[1].ToString() + "    " + bulanik.miktardegeri[0].ToString() + "    " + bulanik.kirlilikdegeri[1].ToString();
            label3.Text = bulanik.hassasdegeri[1].ToString() + "    " + bulanik.miktardegeri[1].ToString() + "    " + bulanik.kirlilikdegeri[0].ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackandlabel(tbhassaslik, lblHassas);
            trackandlabel(tbmiktar, lblMiktar);
            trackandlabel(tbkirlilik, lblKirli);
            Listgoster();
            Durum();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lKirlilik.Text != "---")
            {
                KurallariDoldur();
                tablorenk_ata();
                return;
            }
            MessageBox.Show("Deðerler girilmemiþ!!!");
            tablorenk_ata();
        }
    }
}
