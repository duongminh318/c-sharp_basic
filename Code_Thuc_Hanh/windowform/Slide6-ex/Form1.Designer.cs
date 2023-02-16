namespace Slide6_ex
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
            this.picHaTa = new System.Windows.Forms.PictureBox();
            this.picNangTa = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).BeginInit();
            this.SuspendLayout();
            // 
            // picHaTa
            // 
            this.picHaTa.Image = ((System.Drawing.Image)(resources.GetObject("picHaTa.Image")));
            this.picHaTa.Location = new System.Drawing.Point(129, 71);
            this.picHaTa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHaTa.Name = "picHaTa";
            this.picHaTa.Size = new System.Drawing.Size(387, 290);
            this.picHaTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHaTa.TabIndex = 0;
            this.picHaTa.TabStop = false;
            // 
            // picNangTa
            // 
            this.picNangTa.Image = ((System.Drawing.Image)(resources.GetObject("picNangTa.Image")));
            this.picNangTa.Location = new System.Drawing.Point(129, 71);
            this.picNangTa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picNangTa.Name = "picNangTa";
            this.picNangTa.Size = new System.Drawing.Size(387, 290);
            this.picNangTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNangTa.TabIndex = 1;
            this.picNangTa.TabStop = false;
            this.picNangTa.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nhập tên cụ vào đây: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(748, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClick.Location = new System.Drawing.Point(46, 423);
            this.btnClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(501, 56);
            this.btnClick.TabIndex = 4;
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designed By DuongMinh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDem
            // 
            this.lblDem.BackColor = System.Drawing.Color.Gold;
            this.lblDem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDem.Location = new System.Drawing.Point(129, 367);
            this.lblDem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(387, 43);
            this.lblDem.TabIndex = 5;
            this.lblDem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDem.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(554, 435);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 39);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(386, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(506, 4);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(65, 17);
            this.chkMusic.TabIndex = 8;
            this.chkMusic.Text = "MUSIC";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 498);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picNangTa);
            this.Controls.Add(this.picHaTa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẬP LUYỆN MÙA COVID";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHaTa;
        private System.Windows.Forms.PictureBox picNangTa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkMusic;
    }
}

