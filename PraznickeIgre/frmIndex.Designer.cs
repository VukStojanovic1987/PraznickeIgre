namespace PraznickeIgre
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.panSadrzaj = new System.Windows.Forms.Panel();
            this.lblXo = new System.Windows.Forms.Label();
            this.lblKarte = new System.Windows.Forms.Label();
            this.lblCestitka = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.tipIndex = new System.Windows.Forms.ToolTip(this.components);
            this.lblKuki = new System.Windows.Forms.Label();
            this.panKontekst = new System.Windows.Forms.Panel();
            this.panSadrzaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSadrzaj
            // 
            this.panSadrzaj.BackColor = System.Drawing.Color.White;
            this.panSadrzaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panSadrzaj.Controls.Add(this.lblKuki);
            this.panSadrzaj.Controls.Add(this.lblXo);
            this.panSadrzaj.Controls.Add(this.lblKarte);
            this.panSadrzaj.Controls.Add(this.lblCestitka);
            this.panSadrzaj.Controls.Add(this.lblNaslov);
            this.panSadrzaj.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSadrzaj.Location = new System.Drawing.Point(0, 0);
            this.panSadrzaj.Margin = new System.Windows.Forms.Padding(0);
            this.panSadrzaj.Name = "panSadrzaj";
            this.panSadrzaj.Size = new System.Drawing.Size(252, 681);
            this.panSadrzaj.TabIndex = 0;
            // 
            // lblXo
            // 
            this.lblXo.AutoSize = true;
            this.lblXo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXo.ForeColor = System.Drawing.Color.Gray;
            this.lblXo.Location = new System.Drawing.Point(25, 151);
            this.lblXo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblXo.Name = "lblXo";
            this.lblXo.Size = new System.Drawing.Size(29, 17);
            this.lblXo.TabIndex = 4;
            this.lblXo.Text = "XO";
            this.lblXo.Click += new System.EventHandler(this.lblXo_Click);
            this.lblXo.MouseEnter += new System.EventHandler(this.lblXo_MouseEnter);
            this.lblXo.MouseLeave += new System.EventHandler(this.lblXo_MouseLeave);
            // 
            // lblKarte
            // 
            this.lblKarte.AutoSize = true;
            this.lblKarte.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKarte.ForeColor = System.Drawing.Color.Gray;
            this.lblKarte.Location = new System.Drawing.Point(25, 124);
            this.lblKarte.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblKarte.Name = "lblKarte";
            this.lblKarte.Size = new System.Drawing.Size(43, 17);
            this.lblKarte.TabIndex = 3;
            this.lblKarte.Text = "Karte";
            this.lblKarte.Click += new System.EventHandler(this.lblKarte_Click);
            this.lblKarte.MouseEnter += new System.EventHandler(this.lblKarte_MouseEnter);
            this.lblKarte.MouseLeave += new System.EventHandler(this.lblKarte_MouseLeave);
            // 
            // lblCestitka
            // 
            this.lblCestitka.AutoSize = true;
            this.lblCestitka.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCestitka.ForeColor = System.Drawing.Color.Gray;
            this.lblCestitka.Location = new System.Drawing.Point(25, 97);
            this.lblCestitka.Margin = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lblCestitka.Name = "lblCestitka";
            this.lblCestitka.Size = new System.Drawing.Size(61, 17);
            this.lblCestitka.TabIndex = 2;
            this.lblCestitka.Text = "Čestitka";
            this.lblCestitka.Click += new System.EventHandler(this.lblCestitka_Click);
            this.lblCestitka.MouseEnter += new System.EventHandler(this.lblCestitka_MouseEnter);
            this.lblCestitka.MouseLeave += new System.EventHandler(this.lblCestitka_MouseLeave);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Brush Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaslov.Location = new System.Drawing.Point(20, 17);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(20, 17, 20, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(212, 46);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Praznicke igre 1";
            // 
            // lblKuki
            // 
            this.lblKuki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKuki.Image = global::PraznickeIgre.Properties.Resources.kuki_38x;
            this.lblKuki.Location = new System.Drawing.Point(178, 623);
            this.lblKuki.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.lblKuki.Name = "lblKuki";
            this.lblKuki.Size = new System.Drawing.Size(54, 38);
            this.lblKuki.TabIndex = 0;
            this.tipIndex.SetToolTip(this.lblKuki, "Autorska prava © Kuki, 2017. Sva prava su zadržana.");
            // 
            // panKontekst
            // 
            this.panKontekst.BackColor = System.Drawing.Color.Gainsboro;
            this.panKontekst.BackgroundImage = global::PraznickeIgre.Properties.Resources.jelkaKozmetika;
            this.panKontekst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panKontekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panKontekst.Location = new System.Drawing.Point(252, 0);
            this.panKontekst.Margin = new System.Windows.Forms.Padding(0);
            this.panKontekst.Name = "panKontekst";
            this.panKontekst.Size = new System.Drawing.Size(692, 681);
            this.panKontekst.TabIndex = 1;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panKontekst);
            this.Controls.Add(this.panSadrzaj);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prazničke igre 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panSadrzaj.ResumeLayout(false);
            this.panSadrzaj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSadrzaj;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panKontekst;
        private System.Windows.Forms.Label lblCestitka;
        private System.Windows.Forms.Label lblXo;
        private System.Windows.Forms.Label lblKarte;
        private System.Windows.Forms.Label lblKuki;
        private System.Windows.Forms.ToolTip tipIndex;
    }
}

