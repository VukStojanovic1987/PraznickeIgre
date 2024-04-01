using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraznickeIgre.Karte
{
    public partial class frmKarte : Form
    {
        private List<Image> izmesaneKarte;

        private bool prvaKartaOtvorena = false;
        private bool drugaKartaOtvorena = false;

        private Button prvaKarta = null;
        private Button drugaKarta = null;

        private int potezi = 0;

        public frmKarte()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmIndex_Load(object sender, EventArgs e)
        {
            PodesiKarte();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            PodesiKarte();
        }

        private void btnKarta1_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta1, 0);
        }

        private void btnKarta2_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta2, 1);
        }

        private void btnKarta3_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta3, 2);
        }

        private void btnKarta4_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta4, 3);
        }

        private void btnKarta5_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta5, 4);
        }

        private void btnKarta6_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta6, 5);
        }

        private void btnKarta7_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta7, 6);
        }

        private void btnKarta8_Click(object sender, EventArgs e)
        {
            OtvoriKartu(btnKarta8, 7);
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            if(tim.Interval == 500)
            {
                if (prvaKarta.Image == drugaKarta.Image)
                {
                    prvaKarta.Visible = false;
                    drugaKarta.Visible = false;
                }
                else
                {
                    prvaKarta.Image = Properties.Resources.poledjina;
                    drugaKarta.Image = Properties.Resources.poledjina;
                }

                prvaKartaOtvorena = false;
                drugaKartaOtvorena = false;
                prvaKarta = null;
                drugaKarta = null;
                
                if(GotovaPartija() == true)
                {
                    lblCestitamo.Visible = true;
                }

                tim.Stop();
            }
        }

        //PROCEDURE
        private void PodesiKarte()
        {
            potezi = 0;
            lblPotezi.Text = "0";

            lblCestitamo.Visible = false;

            btnKarta1.Image = Properties.Resources.poledjina;
            btnKarta2.Image = Properties.Resources.poledjina;
            btnKarta3.Image = Properties.Resources.poledjina;
            btnKarta4.Image = Properties.Resources.poledjina;
            btnKarta5.Image = Properties.Resources.poledjina;
            btnKarta6.Image = Properties.Resources.poledjina;
            btnKarta7.Image = Properties.Resources.poledjina;
            btnKarta8.Image = Properties.Resources.poledjina;

            btnKarta1.Visible = true;
            btnKarta2.Visible = true;
            btnKarta3.Visible = true;
            btnKarta4.Visible = true;
            btnKarta5.Visible = true;
            btnKarta6.Visible = true;
            btnKarta7.Visible = true;
            btnKarta8.Visible = true;

            Image jelka = Properties.Resources.jelka;
            Image ukras = Properties.Resources.ukras;
            Image poklon = Properties.Resources.poklon;
            Image pahuljica = Properties.Resources.pahuljica;

            List<Image> karte = new List<Image>();
            karte.Add(jelka);
            karte.Add(jelka);
            karte.Add(ukras);
            karte.Add(ukras);
            karte.Add(poklon);
            karte.Add(poklon);
            karte.Add(pahuljica);
            karte.Add(pahuljica);

            izmesaneKarte = IzmesajListu(karte);
        }

        private void OtvoriKartu(Button btn, int indexSlike)
        {
            if(prvaKarta == btn)
            {
                return;
            }

            if (drugaKarta == btn)
            {
                return;
            }

            if (prvaKartaOtvorena == false)
            {
                btn.Image = izmesaneKarte[indexSlike];
                prvaKarta = btn;
                prvaKartaOtvorena = true;
                return;
            }

            if (drugaKartaOtvorena == false)
            {
                btn.Image = izmesaneKarte[indexSlike];
                drugaKarta = btn;
                drugaKartaOtvorena = true;
            }

            if (prvaKartaOtvorena == true & drugaKartaOtvorena == true)
            {
                potezi = potezi + 1;
                lblPotezi.Text = Convert.ToString(potezi);
                tim.Interval = 500;
                tim.Start();
                return;
            }
        }

        //FUNKCIJE
        private List<E> IzmesajListu<E>(List<E> inputList)
        {
            List<E> randomLista = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomLista.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomLista;
        }

        private bool GotovaPartija()
        {
            foreach (Control con in panRadniList.Controls)
            {
                if (con is Button)
                {
                    if (con.Visible == true)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
