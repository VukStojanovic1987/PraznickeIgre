using System;
using System.Drawing;
using System.Windows.Forms;

namespace PraznickeIgre.Cestitka
{
    public partial class frmCestitka : Form
    {
        public frmCestitka()
        {
            InitializeComponent();
        }

        private void frmCestitka_Load(object sender, EventArgs e)
        {
            Godine(cmbGodina);

            cmbGodina_SelectedIndexChanged(this, new EventArgs());
            btnSilver_Click(this, new EventArgs());
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            BojaPozadine(btnSilver);
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            BojaPozadine(btnGold);
        }

        private void btnMediumPurple_Click(object sender, EventArgs e)
        {
            BojaPozadine(btnMediumPurple);
        }

        private void btnRoyalBlue_Click(object sender, EventArgs e)
        {
            BojaPozadine(btnRoyalBlue);
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCestitkaGodina.Text = cmbGodina.Text;
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "PNG - Portable Network Graphics|*.png|BMP - Windows Bitmap|*.bmp|GIF - CompuServe Bitmap|*.gif|JPG - JPEG Bitmaps|*.jpeg";
            dialog.AddExtension = true;
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Title = "Snimi čestitku";
            dialog.FileName = "Čestitka " + cmbGodina.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SnimiDatoteku(panCestitka, dialog.FileName);
            }
        }

        //PROCEDURE
        private void SnimiDatoteku(Control kontrola, string nazivDatoteke)
        {
            Graphics grp = kontrola.CreateGraphics();
            Bitmap bmp = new Bitmap(kontrola.Width, kontrola.Height);
            kontrola.DrawToBitmap(bmp, new Rectangle(0, 0, kontrola.Width, kontrola.Height));
            bmp.Save(nazivDatoteke);
        }

        private void BojaPozadine(Button btn)
        {
            panRadniList.BackColor = btn.BackColor;
            panCestitka.BackColor = btn.BackColor;
        }

        private void Godine(ComboBox cmb)
        {
            for (int i = 2011; i <= DateTime.Now.Year + 1; i++)
            {
                cmb.Items.Add(i);
            }

            cmb.Text = Convert.ToString(DateTime.Now.Year + 1);
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
