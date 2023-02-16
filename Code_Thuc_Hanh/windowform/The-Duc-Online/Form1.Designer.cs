namespace The_Duc_Online
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesigned = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.picHa = new System.Windows.Forms.PictureBox();
            this.picNang = new System.Windows.Forms.PictureBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 21);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Mời Cụ nhập tên : ";
            // 
            // lblDesigned
            // 
            this.lblDesigned.AutoSize = true;
            this.lblDesigned.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigned.Location = new System.Drawing.Point(900, 622);
            this.lblDesigned.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDesigned.Name = "lblDesigned";
            this.lblDesigned.Size = new System.Drawing.Size(182, 21);
            this.lblDesigned.TabIndex = 0;
            this.lblDesigned.Text = "Designed by DuongMinh";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(166, 501);
            this.lblCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(701, 74);
            this.lblCount.TabIndex = 0;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(815, 17);
            this.chkMusic.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(77, 25);
            this.chkMusic.TabIndex = 1;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // picHa
            // 
            this.picHa.Image = ((System.Drawing.Image)(resources.GetObject("picHa.Image")));
            this.picHa.Location = new System.Drawing.Point(171, 63);
            this.picHa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.picHa.Name = "picHa";
            this.picHa.Size = new System.Drawing.Size(696, 423);
            this.picHa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHa.TabIndex = 2;
            this.picHa.TabStop = false;
            // 
            // picNang
            // 
            this.picNang.Image = ((System.Drawing.Image)(resources.GetObject("picNang.Image")));
            this.picNang.Location = new System.Drawing.Point(171, 63);
            this.picNang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.picNang.Name = "picNang";
            this.picNang.Size = new System.Drawing.Size(696, 423);
            this.picNang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNang.TabIndex = 2;
            this.picNang.TabStop = false;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnClick.Location = new System.Drawing.Point(166, 580);
            this.btnClick.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(701, 74);
            this.btnClick.TabIndex = 3;
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Location = new System.Drawing.Point(933, 526);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 78);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 33);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 656);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.picNang);
            this.Controls.Add(this.picHa);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDesigned);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tập Thể Dục Online";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesigned;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.PictureBox picHa;
        private System.Windows.Forms.PictureBox picNang;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
    }
}

