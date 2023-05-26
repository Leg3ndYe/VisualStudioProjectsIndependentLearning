namespace Testing_Figuring_Out
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.OpenDobriLosiSusjediBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseAppBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenDobriLosiSusjediBtn
            // 
            this.OpenDobriLosiSusjediBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OpenDobriLosiSusjediBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenDobriLosiSusjediBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDobriLosiSusjediBtn.ForeColor = System.Drawing.Color.Black;
            this.OpenDobriLosiSusjediBtn.Location = new System.Drawing.Point(426, 420);
            this.OpenDobriLosiSusjediBtn.Name = "OpenDobriLosiSusjediBtn";
            this.OpenDobriLosiSusjediBtn.Size = new System.Drawing.Size(282, 59);
            this.OpenDobriLosiSusjediBtn.TabIndex = 0;
            this.OpenDobriLosiSusjediBtn.Text = "Dobri i Loši susjedi";
            this.OpenDobriLosiSusjediBtn.UseVisualStyleBackColor = false;
            this.OpenDobriLosiSusjediBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(275, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "SVE ZA VRT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseAppBtn
            // 
            this.CloseAppBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CloseAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAppBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseAppBtn.Location = new System.Drawing.Point(426, 606);
            this.CloseAppBtn.Name = "CloseAppBtn";
            this.CloseAppBtn.Size = new System.Drawing.Size(282, 59);
            this.CloseAppBtn.TabIndex = 2;
            this.CloseAppBtn.Text = "Ugasi Aplikaciju";
            this.CloseAppBtn.UseVisualStyleBackColor = false;
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1134, 811);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenDobriLosiSusjediBtn);
            this.Name = "Form2";
            this.Text = "SVE ZA VRT";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDobriLosiSusjediBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseAppBtn;
    }
}