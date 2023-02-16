namespace slide2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtSoNguyenA = new System.Windows.Forms.TextBox();
            this.txtSoNguyenB = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbl1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl1.Location = new System.Drawing.Point(75, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(132, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Số Nguyên A:";
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl2.Location = new System.Drawing.Point(75, 129);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(132, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Số Nguyên B: ";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoNguyenA
            // 
            this.txtSoNguyenA.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSoNguyenA.Location = new System.Drawing.Point(299, 58);
            this.txtSoNguyenA.Multiline = true;
            this.txtSoNguyenA.Name = "txtSoNguyenA";
            this.txtSoNguyenA.PasswordChar = '*';
            this.txtSoNguyenA.Size = new System.Drawing.Size(179, 48);
            this.txtSoNguyenA.TabIndex = 2;
            // 
            // txtSoNguyenB
            // 
            this.txtSoNguyenB.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSoNguyenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoNguyenB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSoNguyenB.Location = new System.Drawing.Point(299, 129);
            this.txtSoNguyenB.Multiline = true;
            this.txtSoNguyenB.Name = "txtSoNguyenB";
            this.txtSoNguyenB.ReadOnly = true;
            this.txtSoNguyenB.Size = new System.Drawing.Size(179, 49);
            this.txtSoNguyenB.TabIndex = 2;
            this.txtSoNguyenB.Text = "read only";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Cyan;
            this.btnLogin.Font = new System.Drawing.Font("Javanese Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(80, 205);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(147, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Cyan;
            this.btnexit.Font = new System.Drawing.Font("Javanese Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.Location = new System.Drawing.Point(313, 205);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(147, 42);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 259);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSoNguyenB);
            this.Controls.Add(this.txtSoNguyenA);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtSoNguyenA;
        private System.Windows.Forms.TextBox txtSoNguyenB;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnexit;
    }
}

