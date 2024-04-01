using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraznickeIgre.XO
{
    public partial class frmXo : Form
    {
        //DOGAĐAJI
        private bool naReduJe = false;
        private Image x = Properties.Resources.poledjina;
        private Image o = Properties.Resources.pahuljica2;
        private bool krajIgre = false;

        //KONSTRUKTOR
        public frmXo()
        {
            InitializeComponent();
        }

        //DOGAĐAJI
        private void frmXo_Load(object sender, EventArgs e)
        {
            RestartujIgru();
        }

        private void btnRestartujPartiju_Click(object sender, EventArgs e)
        {
            RestartujPartiju();
        }

        private void btnRestartujIgru_Click(object sender, EventArgs e)
        {
            if(lblKucicaRezultat.Text != "0" || lblPahuljicaRezultat.Text != "0")
            {
                if(MessageBox.Show("Želite li da restartujete igru?", "OX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RestartujIgru();
                }
            }
        }

        private void btnPolje1_Click(object sender, EventArgs e)
        {
            if(krajIgre == true) { return; }

            PritisniDugme(btnPolje1);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje2_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje2);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje3_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje3);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje4_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje4);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje5_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje5);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje6_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje6);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje7_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje7);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje8_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje8);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        private void btnPolje9_Click(object sender, EventArgs e)
        {
            if (krajIgre == true) { return; }

            PritisniDugme(btnPolje9);
            Pobeda(x, lblKucicaRezultat);
            Pobeda(o, lblPahuljicaRezultat);
        }

        //PROCEDURE
        private void PritisniDugme(Button btn)
        {
            if (btn.Image == null)
            {
                if (naReduJe == false)
                {
                    btn.Image = x;
                    naReduJe = true;
                }
                else if(naReduJe == true)
                {
                    btn.Image = o;
                    naReduJe = false;
                }
            }
        }

        private void Pobeda(Image XO, Label lbl)
        {
            if(btnPolje1.Image == XO & btnPolje2.Image == XO & btnPolje3.Image == XO)
            {
                btnPolje1.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje2.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje3.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje4.Image == XO & btnPolje5.Image == XO & btnPolje6.Image == XO)
            {
                btnPolje4.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje5.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje6.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje7.Image == XO & btnPolje8.Image == XO & btnPolje9.Image == XO)
            {
                btnPolje7.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje8.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje9.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje1.Image == XO & btnPolje4.Image == XO & btnPolje7.Image == XO)
            {
                btnPolje1.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje4.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje7.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje2.Image == XO & btnPolje5.Image == XO & btnPolje8.Image == XO)
            {
                btnPolje2.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje5.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje8.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje3.Image == XO & btnPolje6.Image == XO & btnPolje9.Image == XO)
            {
                btnPolje3.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje6.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje9.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje1.Image == XO & btnPolje5.Image == XO & btnPolje9.Image == XO)
            {
                btnPolje1.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje5.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje9.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
            else if (btnPolje3.Image == XO & btnPolje5.Image == XO & btnPolje7.Image == XO)
            {
                btnPolje3.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje5.BackColor = Color.FromArgb(64, 64, 64);
                btnPolje7.BackColor = Color.FromArgb(64, 64, 64);
                Bodovanje(lbl);
                krajIgre = true;
            }
        }

        private void Bodovanje(Label lbl)
        {
            if(lbl.Text == "99")
            {
                MessageBox.Show("Maksimalni broj pobeda je 99, restartujte igru.");
                return;
            }

            lbl.Text = Convert.ToString(Convert.ToInt64(lbl.Text) + 1);
        }

        private void RestartujIgru()
        {
            RestartujPartiju();

            lblKucicaRezultat.Text = "0";
            lblPahuljicaRezultat.Text = "0";
        }

        private void RestartujPartiju()
        {
            naReduJe = false;
            krajIgre = false;

            btnPolje1.Image = null;
            btnPolje2.Image = null;
            btnPolje3.Image = null;
            btnPolje4.Image = null;
            btnPolje5.Image = null;
            btnPolje6.Image = null;
            btnPolje7.Image = null;
            btnPolje8.Image = null;
            btnPolje9.Image = null;

            btnPolje1.BackColor = Color.Silver;
            btnPolje2.BackColor = Color.Silver;
            btnPolje3.BackColor = Color.Silver;
            btnPolje4.BackColor = Color.Silver;
            btnPolje5.BackColor = Color.Silver;
            btnPolje6.BackColor = Color.Silver;
            btnPolje7.BackColor = Color.Silver;
            btnPolje8.BackColor = Color.Silver;
            btnPolje9.BackColor = Color.Silver;
        }
    }
}
