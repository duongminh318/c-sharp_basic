namespace Selenium_buoi4_autoit
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
            this.btnConvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvent
            // 
            this.btnConvent.Location = new System.Drawing.Point(204, 179);
            this.btnConvent.Name = "btnConvent";
            this.btnConvent.Size = new System.Drawing.Size(151, 61);
            this.btnConvent.TabIndex = 0;
            this.btnConvent.Text = "Convent";
            this.btnConvent.UseVisualStyleBackColor = true;
            this.btnConvent.Click += new System.EventHandler(this.btnConvent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.btnConvent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvent;
    }
}

