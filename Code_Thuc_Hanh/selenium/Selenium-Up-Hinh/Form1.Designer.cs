namespace Selenium_Up_Hinh
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
            this.btnUpAnh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpAnh
            // 
            this.btnUpAnh.Location = new System.Drawing.Point(13, 30);
            this.btnUpAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpAnh.Name = "btnUpAnh";
            this.btnUpAnh.Size = new System.Drawing.Size(135, 43);
            this.btnUpAnh.TabIndex = 0;
            this.btnUpAnh.Text = "Up Ảnh";
            this.btnUpAnh.UseVisualStyleBackColor = true;
            this.btnUpAnh.Click += new System.EventHandler(this.btnUpAnh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 300);
            this.Controls.Add(this.btnUpAnh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpAnh;
    }
}

