namespace Slide7_datetime
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dtpSign = new System.Windows.Forms.DateTimePicker();
            this.grpSign = new System.Windows.Forms.GroupBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(112, 82);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(144, 20);
            this.txtAge.TabIndex = 1;
            // 
            // dtpSign
            // 
            this.dtpSign.CustomFormat = "dd/MM/yyyy";
            this.dtpSign.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSign.Location = new System.Drawing.Point(112, 145);
            this.dtpSign.Name = "dtpSign";
            this.dtpSign.Size = new System.Drawing.Size(144, 20);
            this.dtpSign.TabIndex = 2;
            // 
            // grpSign
            // 
            this.grpSign.BackColor = System.Drawing.Color.Lavender;
            this.grpSign.Controls.Add(this.btnSign);
            this.grpSign.Controls.Add(this.dtpSign);
            this.grpSign.Controls.Add(this.label4);
            this.grpSign.Controls.Add(this.txtPhone);
            this.grpSign.Controls.Add(this.label3);
            this.grpSign.Controls.Add(this.txtAge);
            this.grpSign.Controls.Add(this.label2);
            this.grpSign.Location = new System.Drawing.Point(71, 28);
            this.grpSign.Name = "grpSign";
            this.grpSign.Size = new System.Drawing.Size(347, 238);
            this.grpSign.TabIndex = 3;
            this.grpSign.TabStop = false;
            this.grpSign.Text = "Sign Up Information";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(128, 191);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(96, 23);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "Sign Up";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(497, 278);
            this.Controls.Add(this.grpSign);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký xem phim";
            this.grpSign.ResumeLayout(false);
            this.grpSign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DateTimePicker dtpSign;
        private System.Windows.Forms.GroupBox grpSign;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

