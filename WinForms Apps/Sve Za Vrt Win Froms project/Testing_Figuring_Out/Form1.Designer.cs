namespace Testing_Figuring_Out
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OdabirBiljkaCBx = new System.Windows.Forms.ComboBox();
            this.LosiSusjediLb = new System.Windows.Forms.Label();
            this.DobriSusjediLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.RightSidePtbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RightSidePtbx)).BeginInit();
            this.SuspendLayout();
            // 
            // OdabirBiljkaCBx
            // 
            this.OdabirBiljkaCBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OdabirBiljkaCBx.DropDownHeight = 550;
            this.OdabirBiljkaCBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdabirBiljkaCBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdabirBiljkaCBx.ForeColor = System.Drawing.SystemColors.MenuText;
            this.OdabirBiljkaCBx.FormattingEnabled = true;
            this.OdabirBiljkaCBx.IntegralHeight = false;
            this.OdabirBiljkaCBx.ItemHeight = 25;
            this.OdabirBiljkaCBx.Items.AddRange(new object[] {
            "Mrkva",
            "Celer",
            "Cikla",
            "Češnjak",
            "Endivija",
            "Grah",
            "Grašak",
            "Jagoda",
            "Komorač",
            "Korabica",
            "Krastavac",
            "Krumpir",
            "Kupusnjače",
            "Luk",
            "Blitva",
            "Poriluk",
            "Rukola",
            "Radič",
            "Rajčica",
            "Rotkvica",
            "Salata",
            "Šparoga",
            "Špinat",
            "Tikvice",
            "Brokula",
            "Paprika"});
            this.OdabirBiljkaCBx.Location = new System.Drawing.Point(318, 90);
            this.OdabirBiljkaCBx.Name = "OdabirBiljkaCBx";
            this.OdabirBiljkaCBx.Size = new System.Drawing.Size(237, 33);
            this.OdabirBiljkaCBx.TabIndex = 1;
            this.OdabirBiljkaCBx.SelectedIndexChanged += new System.EventHandler(this.OdabirBiljkaCBx_SelectedIndexChanged);
            // 
            // LosiSusjediLb
            // 
            this.LosiSusjediLb.BackColor = System.Drawing.Color.Transparent;
            this.LosiSusjediLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LosiSusjediLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LosiSusjediLb.Location = new System.Drawing.Point(850, 90);
            this.LosiSusjediLb.MaximumSize = new System.Drawing.Size(250, 550);
            this.LosiSusjediLb.Name = "LosiSusjediLb";
            this.LosiSusjediLb.Size = new System.Drawing.Size(250, 550);
            this.LosiSusjediLb.TabIndex = 2;
            this.LosiSusjediLb.Text = "...";
            this.LosiSusjediLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LosiSusjediLb.Click += new System.EventHandler(this.LosiSusjediLb_Click);
            // 
            // DobriSusjediLb
            // 
            this.DobriSusjediLb.BackColor = System.Drawing.Color.Transparent;
            this.DobriSusjediLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobriSusjediLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DobriSusjediLb.Location = new System.Drawing.Point(594, 90);
            this.DobriSusjediLb.MaximumSize = new System.Drawing.Size(250, 550);
            this.DobriSusjediLb.Name = "DobriSusjediLb";
            this.DobriSusjediLb.Size = new System.Drawing.Size(250, 550);
            this.DobriSusjediLb.TabIndex = 3;
            this.DobriSusjediLb.Text = "...";
            this.DobriSusjediLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(612, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dobri susjedi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(883, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loši susjedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(311, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odaberite biljku";
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NazadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NazadBtn.ForeColor = System.Drawing.Color.Black;
            this.NazadBtn.Location = new System.Drawing.Point(827, 698);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(252, 60);
            this.NazadBtn.TabIndex = 7;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // RightSidePtbx
            // 
            this.RightSidePtbx.Image = ((System.Drawing.Image)(resources.GetObject("RightSidePtbx.Image")));
            this.RightSidePtbx.Location = new System.Drawing.Point(-15, -61);
            this.RightSidePtbx.Name = "RightSidePtbx";
            this.RightSidePtbx.Size = new System.Drawing.Size(253, 893);
            this.RightSidePtbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RightSidePtbx.TabIndex = 8;
            this.RightSidePtbx.TabStop = false;
            this.RightSidePtbx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1134, 811);
            this.Controls.Add(this.RightSidePtbx);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DobriSusjediLb);
            this.Controls.Add(this.LosiSusjediLb);
            this.Controls.Add(this.OdabirBiljkaCBx);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Dobri I Loši susjedi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RightSidePtbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OdabirBiljkaCBx;
        private System.Windows.Forms.Label LosiSusjediLb;
        private System.Windows.Forms.Label DobriSusjediLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.PictureBox RightSidePtbx;
    }
}

