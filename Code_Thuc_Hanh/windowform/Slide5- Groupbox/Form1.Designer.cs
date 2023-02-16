namespace Slide5__Groupbox
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
            this.grbSoThich = new System.Windows.Forms.GroupBox();
            this.chkMovie = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkCode = new System.Windows.Forms.CheckBox();
            this.chkSport = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.radBoy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGirl = new System.Windows.Forms.RadioButton();
            this.btnCheckRad = new System.Windows.Forms.Button();
            this.grbSoThich.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSoThich
            // 
            this.grbSoThich.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbSoThich.Controls.Add(this.chkSport);
            this.grbSoThich.Controls.Add(this.btnCheck);
            this.grbSoThich.Controls.Add(this.chkCode);
            this.grbSoThich.Controls.Add(this.chkMusic);
            this.grbSoThich.Controls.Add(this.chkMovie);
            this.grbSoThich.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSoThich.Location = new System.Drawing.Point(36, 23);
            this.grbSoThich.Name = "grbSoThich";
            this.grbSoThich.Size = new System.Drawing.Size(238, 263);
            this.grbSoThich.TabIndex = 0;
            this.grbSoThich.TabStop = false;
            this.grbSoThich.Text = "Sở Thích";
            // 
            // chkMovie
            // 
            this.chkMovie.AutoSize = true;
            this.chkMovie.Location = new System.Drawing.Point(20, 43);
            this.chkMovie.Name = "chkMovie";
            this.chkMovie.Size = new System.Drawing.Size(123, 38);
            this.chkMovie.TabIndex = 0;
            this.chkMovie.Text = "Xem Phim";
            this.chkMovie.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(20, 102);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(134, 38);
            this.chkMusic.TabIndex = 1;
            this.chkMusic.Text = "Nghe Nhạc";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkCode
            // 
            this.chkCode.AutoSize = true;
            this.chkCode.Location = new System.Drawing.Point(20, 157);
            this.chkCode.Name = "chkCode";
            this.chkCode.Size = new System.Drawing.Size(120, 38);
            this.chkCode.TabIndex = 2;
            this.chkCode.Text = "Lập Trình";
            this.chkCode.UseVisualStyleBackColor = true;
            // 
            // chkSport
            // 
            this.chkSport.AutoSize = true;
            this.chkSport.Location = new System.Drawing.Point(20, 219);
            this.chkSport.Name = "chkSport";
            this.chkSport.Size = new System.Drawing.Size(117, 38);
            this.chkSport.TabIndex = 3;
            this.chkSport.Text = "Thể Thao";
            this.chkSport.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(146, 188);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 43);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // radBoy
            // 
            this.radBoy.AutoSize = true;
            this.radBoy.Font = new System.Drawing.Font("VNI-Baybuom", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBoy.Location = new System.Drawing.Point(38, 43);
            this.radBoy.Name = "radBoy";
            this.radBoy.Size = new System.Drawing.Size(75, 30);
            this.radBoy.TabIndex = 2;
            this.radBoy.TabStop = true;
            this.radBoy.Text = "Male";
            this.radBoy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnCheckRad);
            this.groupBox1.Controls.Add(this.radGirl);
            this.groupBox1.Controls.Add(this.radBoy);
            this.groupBox1.Font = new System.Drawing.Font("VNI-Baybuom", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(435, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // radGirl
            // 
            this.radGirl.AutoSize = true;
            this.radGirl.Font = new System.Drawing.Font("VNI-Baybuom", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGirl.Location = new System.Drawing.Point(38, 102);
            this.radGirl.Name = "radGirl";
            this.radGirl.Size = new System.Drawing.Size(95, 30);
            this.radGirl.TabIndex = 2;
            this.radGirl.TabStop = true;
            this.radGirl.Text = "Female";
            this.radGirl.UseVisualStyleBackColor = true;
            // 
            // btnCheckRad
            // 
            this.btnCheckRad.Location = new System.Drawing.Point(38, 188);
            this.btnCheckRad.Name = "btnCheckRad";
            this.btnCheckRad.Size = new System.Drawing.Size(75, 43);
            this.btnCheckRad.TabIndex = 3;
            this.btnCheckRad.Text = "check";
            this.btnCheckRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbSoThich);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSoThich.ResumeLayout(false);
            this.grbSoThich.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSoThich;
        private System.Windows.Forms.CheckBox chkSport;
        private System.Windows.Forms.CheckBox chkCode;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkMovie;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton radBoy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGirl;
        private System.Windows.Forms.Button btnCheckRad;
    }
}

