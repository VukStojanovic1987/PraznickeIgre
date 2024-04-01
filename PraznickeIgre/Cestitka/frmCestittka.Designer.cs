namespace PraznickeIgre.Cestitka
{
    partial class frmCestitka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCestitka));
            this.panSadrzaj = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnRoyalBlue = new System.Windows.Forms.Button();
            this.lblBoja = new System.Windows.Forms.Label();
            this.btnMediumPurple = new System.Windows.Forms.Button();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.lblGodina = new System.Windows.Forms.Label();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.imgCestitka = new System.Windows.Forms.ImageList(this.components);
            this.panRadniList = new System.Windows.Forms.Panel();
            this.panCestitka = new System.Windows.Forms.Panel();
            this.lblCestitkaGodina = new System.Windows.Forms.Label();
            this.tipCestitka = new System.Windows.Forms.ToolTip(this.components);
            this.panSadrzaj.SuspendLayout();
            this.panRadniList.SuspendLayout();
            this.panCestitka.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSadrzaj
            // 
            this.panSadrzaj.AutoScroll = true;
            this.panSadrzaj.AutoScrollMargin = new System.Drawing.Size(20, 0);
            this.panSadrzaj.Controls.Add(this.lblNaslov);
            this.panSadrzaj.Controls.Add(this.btnRoyalBlue);
            this.panSadrzaj.Controls.Add(this.lblBoja);
            this.panSadrzaj.Controls.Add(this.btnMediumPurple);
            this.panSadrzaj.Controls.Add(this.cmbGodina);
            this.panSadrzaj.Controls.Add(this.lblGodina);
            this.panSadrzaj.Controls.Add(this.btnGold);
            this.panSadrzaj.Controls.Add(this.btnSilver);
            this.panSadrzaj.Controls.Add(this.btnStampaj);
            this.panSadrzaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSadrzaj.Location = new System.Drawing.Point(0, 0);
            this.panSadrzaj.Margin = new System.Windows.Forms.Padding(0);
            this.panSadrzaj.Name = "panSadrzaj";
            this.panSadrzaj.Size = new System.Drawing.Size(944, 80);
            this.panSadrzaj.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Brush Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaslov.Location = new System.Drawing.Point(0, 17);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(132, 46);
            this.lblNaslov.TabIndex = 11;
            this.lblNaslov.Text = ":Cestitka";
            // 
            // btnRoyalBlue
            // 
            this.btnRoyalBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRoyalBlue.FlatAppearance.BorderSize = 0;
            this.btnRoyalBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoyalBlue.Location = new System.Drawing.Point(427, 22);
            this.btnRoyalBlue.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnRoyalBlue.Name = "btnRoyalBlue";
            this.btnRoyalBlue.Size = new System.Drawing.Size(40, 40);
            this.btnRoyalBlue.TabIndex = 10;
            this.tipCestitka.SetToolTip(this.btnRoyalBlue, "Ljubičasta");
            this.btnRoyalBlue.UseVisualStyleBackColor = false;
            this.btnRoyalBlue.Click += new System.EventHandler(this.btnRoyalBlue_Click);
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.ForeColor = System.Drawing.Color.Gray;
            this.lblBoja.Location = new System.Drawing.Point(152, 34);
            this.lblBoja.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(92, 16);
            this.lblBoja.TabIndex = 9;
            this.lblBoja.Text = "boja pozadine:";
            // 
            // btnMediumPurple
            // 
            this.btnMediumPurple.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMediumPurple.FlatAppearance.BorderSize = 0;
            this.btnMediumPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediumPurple.Location = new System.Drawing.Point(367, 22);
            this.btnMediumPurple.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnMediumPurple.Name = "btnMediumPurple";
            this.btnMediumPurple.Size = new System.Drawing.Size(40, 40);
            this.btnMediumPurple.TabIndex = 8;
            this.tipCestitka.SetToolTip(this.btnMediumPurple, "Ljubičasta");
            this.btnMediumPurple.UseVisualStyleBackColor = false;
            this.btnMediumPurple.Click += new System.EventHandler(this.btnMediumPurple_Click);
            // 
            // cmbGodina
            // 
            this.cmbGodina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGodina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(540, 31);
            this.cmbGodina.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(55, 24);
            this.cmbGodina.TabIndex = 7;
            this.cmbGodina.SelectedIndexChanged += new System.EventHandler(this.cmbGodina_SelectedIndexChanged);
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.ForeColor = System.Drawing.Color.Gray;
            this.lblGodina.Location = new System.Drawing.Point(487, 34);
            this.lblGodina.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(50, 16);
            this.lblGodina.TabIndex = 6;
            this.lblGodina.Text = "godina:";
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGold.FlatAppearance.BorderSize = 0;
            this.btnGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGold.Location = new System.Drawing.Point(307, 22);
            this.btnGold.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(40, 40);
            this.btnGold.TabIndex = 4;
            this.tipCestitka.SetToolTip(this.btnGold, "Zlatna");
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnSilver
            // 
            this.btnSilver.BackColor = System.Drawing.Color.Silver;
            this.btnSilver.FlatAppearance.BorderSize = 0;
            this.btnSilver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilver.Location = new System.Drawing.Point(247, 22);
            this.btnSilver.Margin = new System.Windows.Forms.Padding(3, 20, 0, 20);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(40, 40);
            this.btnSilver.TabIndex = 3;
            this.tipCestitka.SetToolTip(this.btnSilver, "Srebrna");
            this.btnSilver.UseVisualStyleBackColor = false;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // btnStampaj
            // 
            this.btnStampaj.BackColor = System.Drawing.Color.White;
            this.btnStampaj.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStampaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStampaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStampaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStampaj.ImageIndex = 0;
            this.btnStampaj.ImageList = this.imgCestitka;
            this.btnStampaj.Location = new System.Drawing.Point(615, 22);
            this.btnStampaj.Margin = new System.Windows.Forms.Padding(20);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnStampaj.Size = new System.Drawing.Size(40, 40);
            this.btnStampaj.TabIndex = 2;
            this.tipCestitka.SetToolTip(this.btnStampaj, "Snimi čestitku");
            this.btnStampaj.UseVisualStyleBackColor = false;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // imgCestitka
            // 
            this.imgCestitka.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCestitka.ImageStream")));
            this.imgCestitka.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCestitka.Images.SetKeyName(0, "Image_32x.png");
            // 
            // panRadniList
            // 
            this.panRadniList.AutoScroll = true;
            this.panRadniList.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panRadniList.BackColor = System.Drawing.Color.Silver;
            this.panRadniList.Controls.Add(this.panCestitka);
            this.panRadniList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRadniList.Location = new System.Drawing.Point(0, 80);
            this.panRadniList.Margin = new System.Windows.Forms.Padding(0);
            this.panRadniList.Name = "panRadniList";
            this.panRadniList.Size = new System.Drawing.Size(944, 601);
            this.panRadniList.TabIndex = 1;
            // 
            // panCestitka
            // 
            this.panCestitka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panCestitka.BackColor = System.Drawing.Color.Silver;
            this.panCestitka.BackgroundImage = global::PraznickeIgre.Properties.Resources.cestitka;
            this.panCestitka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panCestitka.Controls.Add(this.lblCestitkaGodina);
            this.panCestitka.Location = new System.Drawing.Point(141, 20);
            this.panCestitka.Margin = new System.Windows.Forms.Padding(20);
            this.panCestitka.Name = "panCestitka";
            this.panCestitka.Size = new System.Drawing.Size(644, 1227);
            this.panCestitka.TabIndex = 0;
            // 
            // lblCestitkaGodina
            // 
            this.lblCestitkaGodina.AutoSize = true;
            this.lblCestitkaGodina.BackColor = System.Drawing.Color.Transparent;
            this.lblCestitkaGodina.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCestitkaGodina.ForeColor = System.Drawing.Color.White;
            this.lblCestitkaGodina.Location = new System.Drawing.Point(169, 671);
            this.lblCestitkaGodina.Name = "lblCestitkaGodina";
            this.lblCestitkaGodina.Size = new System.Drawing.Size(97, 79);
            this.lblCestitkaGodina.TabIndex = 0;
            this.lblCestitkaGodina.Text = "...";
            // 
            // frmCestitka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panRadniList);
            this.Controls.Add(this.panSadrzaj);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCestitka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Čestitka";
            this.Load += new System.EventHandler(this.frmCestitka_Load);
            this.panSadrzaj.ResumeLayout(false);
            this.panSadrzaj.PerformLayout();
            this.panRadniList.ResumeLayout(false);
            this.panCestitka.ResumeLayout(false);
            this.panCestitka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSadrzaj;
        private System.Windows.Forms.Panel panRadniList;
        private System.Windows.Forms.Panel panCestitka;
        private System.Windows.Forms.Label lblCestitkaGodina;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Button btnMediumPurple;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.ImageList imgCestitka;
        private System.Windows.Forms.ToolTip tipCestitka;
        private System.Windows.Forms.Button btnRoyalBlue;
        private System.Windows.Forms.Label lblNaslov;
    }
}

