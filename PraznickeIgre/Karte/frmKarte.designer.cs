namespace PraznickeIgre.Karte
{
    partial class frmKarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKarte));
            this.panZaglavlje = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRestartujIgru = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPotezi = new System.Windows.Forms.Label();
            this.btnNova = new System.Windows.Forms.Button();
            this.imgIndex = new System.Windows.Forms.ImageList(this.components);
            this.panRadniList = new System.Windows.Forms.Panel();
            this.lblCestitamo = new System.Windows.Forms.Label();
            this.btnKarta8 = new System.Windows.Forms.Button();
            this.btnKarta7 = new System.Windows.Forms.Button();
            this.btnKarta6 = new System.Windows.Forms.Button();
            this.btnKarta5 = new System.Windows.Forms.Button();
            this.btnKarta4 = new System.Windows.Forms.Button();
            this.btnKarta3 = new System.Windows.Forms.Button();
            this.btnKarta2 = new System.Windows.Forms.Button();
            this.btnKarta1 = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.panZaglavlje.SuspendLayout();
            this.panRadniList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panZaglavlje
            // 
            this.panZaglavlje.AutoScroll = true;
            this.panZaglavlje.AutoScrollMargin = new System.Drawing.Size(160, 0);
            this.panZaglavlje.Controls.Add(this.label1);
            this.panZaglavlje.Controls.Add(this.lblRestartujIgru);
            this.panZaglavlje.Controls.Add(this.lblNaslov);
            this.panZaglavlje.Controls.Add(this.lblPotezi);
            this.panZaglavlje.Controls.Add(this.btnNova);
            this.panZaglavlje.Dock = System.Windows.Forms.DockStyle.Top;
            this.panZaglavlje.Location = new System.Drawing.Point(0, 0);
            this.panZaglavlje.Margin = new System.Windows.Forms.Padding(0);
            this.panZaglavlje.Name = "panZaglavlje";
            this.panZaglavlje.Size = new System.Drawing.Size(676, 80);
            this.panZaglavlje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(122, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "broj poteza:";
            // 
            // lblRestartujIgru
            // 
            this.lblRestartujIgru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRestartujIgru.AutoSize = true;
            this.lblRestartujIgru.ForeColor = System.Drawing.Color.Gray;
            this.lblRestartujIgru.Location = new System.Drawing.Point(529, 32);
            this.lblRestartujIgru.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblRestartujIgru.Name = "lblRestartujIgru";
            this.lblRestartujIgru.Size = new System.Drawing.Size(84, 16);
            this.lblRestartujIgru.TabIndex = 21;
            this.lblRestartujIgru.Text = "restartuj igru:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Brush Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaslov.Location = new System.Drawing.Point(0, 17);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(102, 46);
            this.lblNaslov.TabIndex = 12;
            this.lblNaslov.Text = ":Karte";
            // 
            // lblPotezi
            // 
            this.lblPotezi.AutoSize = true;
            this.lblPotezi.Font = new System.Drawing.Font("Brush Script MT", 27.75F, System.Drawing.FontStyle.Italic);
            this.lblPotezi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPotezi.Location = new System.Drawing.Point(201, 17);
            this.lblPotezi.Margin = new System.Windows.Forms.Padding(3, 20, 20, 20);
            this.lblPotezi.Name = "lblPotezi";
            this.lblPotezi.Size = new System.Drawing.Size(36, 46);
            this.lblPotezi.TabIndex = 1;
            this.lblPotezi.Text = "0";
            this.lblPotezi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNova
            // 
            this.btnNova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNova.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNova.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNova.ImageIndex = 0;
            this.btnNova.ImageList = this.imgIndex;
            this.btnNova.Location = new System.Drawing.Point(616, 20);
            this.btnNova.Margin = new System.Windows.Forms.Padding(3, 20, 20, 20);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(40, 40);
            this.btnNova.TabIndex = 0;
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // imgIndex
            // 
            this.imgIndex.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIndex.ImageStream")));
            this.imgIndex.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIndex.Images.SetKeyName(0, "Refresh_grey_16x.png");
            // 
            // panRadniList
            // 
            this.panRadniList.BackColor = System.Drawing.Color.Silver;
            this.panRadniList.Controls.Add(this.lblCestitamo);
            this.panRadniList.Controls.Add(this.btnKarta8);
            this.panRadniList.Controls.Add(this.btnKarta7);
            this.panRadniList.Controls.Add(this.btnKarta6);
            this.panRadniList.Controls.Add(this.btnKarta5);
            this.panRadniList.Controls.Add(this.btnKarta4);
            this.panRadniList.Controls.Add(this.btnKarta3);
            this.panRadniList.Controls.Add(this.btnKarta2);
            this.panRadniList.Controls.Add(this.btnKarta1);
            this.panRadniList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRadniList.Location = new System.Drawing.Point(0, 80);
            this.panRadniList.Margin = new System.Windows.Forms.Padding(0);
            this.panRadniList.Name = "panRadniList";
            this.panRadniList.Size = new System.Drawing.Size(676, 496);
            this.panRadniList.TabIndex = 2;
            // 
            // lblCestitamo
            // 
            this.lblCestitamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCestitamo.AutoSize = true;
            this.lblCestitamo.Font = new System.Drawing.Font("Brush Script MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCestitamo.ForeColor = System.Drawing.Color.White;
            this.lblCestitamo.Location = new System.Drawing.Point(107, 205);
            this.lblCestitamo.Name = "lblCestitamo";
            this.lblCestitamo.Size = new System.Drawing.Size(486, 92);
            this.lblCestitamo.TabIndex = 8;
            this.lblCestitamo.Text = "Cestitamo,\r\nSrecni Novogodisnji i Bozicni praznici.";
            this.lblCestitamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKarta8
            // 
            this.btnKarta8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta8.BackColor = System.Drawing.Color.Silver;
            this.btnKarta8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta8.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta8.Image")));
            this.btnKarta8.Location = new System.Drawing.Point(512, 258);
            this.btnKarta8.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnKarta8.Name = "btnKarta8";
            this.btnKarta8.Size = new System.Drawing.Size(144, 218);
            this.btnKarta8.TabIndex = 7;
            this.btnKarta8.UseVisualStyleBackColor = false;
            this.btnKarta8.Click += new System.EventHandler(this.btnKarta8_Click);
            // 
            // btnKarta7
            // 
            this.btnKarta7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta7.BackColor = System.Drawing.Color.Silver;
            this.btnKarta7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta7.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta7.Image")));
            this.btnKarta7.Location = new System.Drawing.Point(348, 258);
            this.btnKarta7.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnKarta7.Name = "btnKarta7";
            this.btnKarta7.Size = new System.Drawing.Size(144, 218);
            this.btnKarta7.TabIndex = 6;
            this.btnKarta7.UseVisualStyleBackColor = false;
            this.btnKarta7.Click += new System.EventHandler(this.btnKarta7_Click);
            // 
            // btnKarta6
            // 
            this.btnKarta6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta6.BackColor = System.Drawing.Color.Silver;
            this.btnKarta6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta6.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta6.Image")));
            this.btnKarta6.Location = new System.Drawing.Point(184, 258);
            this.btnKarta6.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnKarta6.Name = "btnKarta6";
            this.btnKarta6.Size = new System.Drawing.Size(144, 218);
            this.btnKarta6.TabIndex = 5;
            this.btnKarta6.UseVisualStyleBackColor = false;
            this.btnKarta6.Click += new System.EventHandler(this.btnKarta6_Click);
            // 
            // btnKarta5
            // 
            this.btnKarta5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta5.BackColor = System.Drawing.Color.Silver;
            this.btnKarta5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta5.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta5.Image")));
            this.btnKarta5.Location = new System.Drawing.Point(20, 258);
            this.btnKarta5.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnKarta5.Name = "btnKarta5";
            this.btnKarta5.Size = new System.Drawing.Size(144, 218);
            this.btnKarta5.TabIndex = 4;
            this.btnKarta5.UseVisualStyleBackColor = false;
            this.btnKarta5.Click += new System.EventHandler(this.btnKarta5_Click);
            // 
            // btnKarta4
            // 
            this.btnKarta4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta4.BackColor = System.Drawing.Color.Silver;
            this.btnKarta4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta4.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta4.Image")));
            this.btnKarta4.Location = new System.Drawing.Point(512, 20);
            this.btnKarta4.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.btnKarta4.Name = "btnKarta4";
            this.btnKarta4.Size = new System.Drawing.Size(144, 218);
            this.btnKarta4.TabIndex = 3;
            this.btnKarta4.UseVisualStyleBackColor = false;
            this.btnKarta4.Click += new System.EventHandler(this.btnKarta4_Click);
            // 
            // btnKarta3
            // 
            this.btnKarta3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta3.BackColor = System.Drawing.Color.Silver;
            this.btnKarta3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta3.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta3.Image")));
            this.btnKarta3.Location = new System.Drawing.Point(348, 20);
            this.btnKarta3.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.btnKarta3.Name = "btnKarta3";
            this.btnKarta3.Size = new System.Drawing.Size(144, 218);
            this.btnKarta3.TabIndex = 2;
            this.btnKarta3.UseVisualStyleBackColor = false;
            this.btnKarta3.Click += new System.EventHandler(this.btnKarta3_Click);
            // 
            // btnKarta2
            // 
            this.btnKarta2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta2.BackColor = System.Drawing.Color.Silver;
            this.btnKarta2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta2.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta2.Image")));
            this.btnKarta2.Location = new System.Drawing.Point(184, 20);
            this.btnKarta2.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.btnKarta2.Name = "btnKarta2";
            this.btnKarta2.Size = new System.Drawing.Size(144, 218);
            this.btnKarta2.TabIndex = 1;
            this.btnKarta2.UseVisualStyleBackColor = false;
            this.btnKarta2.Click += new System.EventHandler(this.btnKarta2_Click);
            // 
            // btnKarta1
            // 
            this.btnKarta1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKarta1.BackColor = System.Drawing.Color.Silver;
            this.btnKarta1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKarta1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKarta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnKarta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta1.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta1.Image")));
            this.btnKarta1.Location = new System.Drawing.Point(20, 20);
            this.btnKarta1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.btnKarta1.Name = "btnKarta1";
            this.btnKarta1.Size = new System.Drawing.Size(144, 218);
            this.btnKarta1.TabIndex = 0;
            this.btnKarta1.UseVisualStyleBackColor = false;
            this.btnKarta1.Click += new System.EventHandler(this.btnKarta1_Click);
            // 
            // tim
            // 
            this.tim.Enabled = true;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // frmKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 576);
            this.Controls.Add(this.panRadniList);
            this.Controls.Add(this.panZaglavlje);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmKarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karte";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.panZaglavlje.ResumeLayout(false);
            this.panZaglavlje.PerformLayout();
            this.panRadniList.ResumeLayout(false);
            this.panRadniList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panZaglavlje;
        private System.Windows.Forms.Panel panRadniList;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnKarta1;
        private System.Windows.Forms.Button btnKarta8;
        private System.Windows.Forms.Button btnKarta7;
        private System.Windows.Forms.Button btnKarta6;
        private System.Windows.Forms.Button btnKarta5;
        private System.Windows.Forms.Button btnKarta4;
        private System.Windows.Forms.Button btnKarta3;
        private System.Windows.Forms.Button btnKarta2;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Label lblPotezi;
        private System.Windows.Forms.Label lblCestitamo;
        private System.Windows.Forms.ImageList imgIndex;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblRestartujIgru;
        private System.Windows.Forms.Label label1;
    }
}

