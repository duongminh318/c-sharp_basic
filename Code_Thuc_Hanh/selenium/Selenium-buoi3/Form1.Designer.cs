namespace Selenium_buoi3
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
            this.btnClick = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.btnShoppe = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnWiki = new System.Windows.Forms.Button();
            this.btnTagName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(489, 138);
            this.btnClick.Margin = new System.Windows.Forms.Padding(4);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(135, 44);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "bai 3_ Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(41, 108);
            this.txtOutPut.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(556, 22);
            this.txtOutPut.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(240, 176);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(188, 22);
            this.txtUser.TabIndex = 2;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(240, 249);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(188, 22);
            this.txtPw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // btnBai4
            // 
            this.btnBai4.Location = new System.Drawing.Point(489, 189);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(135, 44);
            this.btnBai4.TabIndex = 6;
            this.btnBai4.Text = "bai 4_ Click";
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            // 
            // btnShoppe
            // 
            this.btnShoppe.Location = new System.Drawing.Point(489, 241);
            this.btnShoppe.Name = "btnShoppe";
            this.btnShoppe.Size = new System.Drawing.Size(135, 44);
            this.btnShoppe.TabIndex = 7;
            this.btnShoppe.Text = "Shoppe_ Click";
            this.btnShoppe.UseVisualStyleBackColor = true;
            this.btnShoppe.Click += new System.EventHandler(this.btnShoppe_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(489, 291);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 44);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnWiki
            // 
            this.btnWiki.Location = new System.Drawing.Point(489, 354);
            this.btnWiki.Name = "btnWiki";
            this.btnWiki.Size = new System.Drawing.Size(135, 41);
            this.btnWiki.TabIndex = 9;
            this.btnWiki.Text = "Wiki _Click";
            this.btnWiki.UseVisualStyleBackColor = true;
            this.btnWiki.Click += new System.EventHandler(this.btnWiki_Click);
            // 
            // btnTagName
            // 
            this.btnTagName.Location = new System.Drawing.Point(52, 311);
            this.btnTagName.Name = "btnTagName";
            this.btnTagName.Size = new System.Drawing.Size(126, 43);
            this.btnTagName.TabIndex = 10;
            this.btnTagName.Text = "TagName";
            this.btnTagName.UseVisualStyleBackColor = true;
            this.btnTagName.Click += new System.EventHandler(this.btnTagName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(667, 420);
            this.Controls.Add(this.btnTagName);
            this.Controls.Add(this.btnWiki);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnShoppe);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBai4;
        private System.Windows.Forms.Button btnShoppe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnWiki;
        private System.Windows.Forms.Button btnTagName;
    }
}

