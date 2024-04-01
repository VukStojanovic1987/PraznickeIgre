using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraznickeIgre
{
    public partial class frmIndex : Form
    {
        private string igra = "";

        public frmIndex()
        {
            InitializeComponent();
        }

        private void lblCestitka_Click(object sender, EventArgs e)
        {
            if (igra == "Cestitka")
            {
                igra = "";

                lblCestitka.ForeColor = Color.Gray;

                panKontekst.Controls.Clear();
            }
            else
            {
                Cestitka();

                igra = "Cestitka";

                lblCestitka.ForeColor = Color.FromArgb(64, 64, 64);
                lblKarte.ForeColor = Color.Gray;
                lblXo.ForeColor = Color.Gray;
            }
        }

        private void lblKarte_Click(object sender, EventArgs e)
        {
            if (igra == "Karte")
            {
                igra = "";

                lblKarte.ForeColor = Color.Gray;

                panKontekst.Controls.Clear();
            }
            else
            {
                Karte();

                igra = "Karte";

                lblCestitka.ForeColor = Color.Gray;
                lblKarte.ForeColor = Color.FromArgb(64, 64, 64);
                lblXo.ForeColor = Color.Gray;
            }
        }

        private void lblXo_Click(object sender, EventArgs e)
        {
            if (igra == "XO")
            {
                igra = "";

                lblXo.ForeColor = Color.Gray;

                panKontekst.Controls.Clear();
            }
            else
            {
                Xo();

                igra = "XO";

                lblCestitka.ForeColor = Color.Gray;
                lblKarte.ForeColor = Color.Gray;
                lblXo.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void lblCestitka_MouseEnter(object sender, EventArgs e)
        {
            if (igra == "Cestitka") { return; }

            lblCestitka.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblKarte_MouseEnter(object sender, EventArgs e)
        {
            if (igra == "Karte") { return; }

            lblKarte.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblXo_MouseEnter(object sender, EventArgs e)
        {
            if (igra == "XO") { return; }

            lblXo.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void lblCestitka_MouseLeave(object sender, EventArgs e)
        {
            if (igra == "Cestitka") { return; }

            lblCestitka.ForeColor = Color.Gray;
        }

        private void lblKarte_MouseLeave(object sender, EventArgs e)
        {
            if (igra == "Karte") { return; }

            lblKarte.ForeColor = Color.Gray;
        }

        private void lblXo_MouseLeave(object sender, EventArgs e)
        {
            if (igra == "XO") { return; }

            lblXo.ForeColor = Color.Gray;
        }

        private void Cestitka()
        {
            panKontekst.Controls.Clear();

            Cestitka.frmCestitka Frm = new Cestitka.frmCestitka();
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panKontekst.Controls.Add(Frm);
        }

        private void Karte()
        {
            panKontekst.Controls.Clear();

            Karte.frmKarte Frm = new Karte.frmKarte();
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panKontekst.Controls.Add(Frm);
        }

        private void Xo()
        {
            panKontekst.Controls.Clear();

            XO.frmXo Frm = new XO.frmXo();
            Frm.TopLevel = false;
            Frm.Visible = true;
            Frm.Dock = DockStyle.Fill;
            panKontekst.Controls.Add(Frm);
        }
    }
}
