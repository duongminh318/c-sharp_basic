namespace Slide12_MDIForm
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
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepKieu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepKieu1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepKieu1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepKieu1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepKieu1ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.sapXepToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(646, 24);
            this.mnu.TabIndex = 1;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenForm1,
            this.mnuOpenForm2,
            this.mnuOpenForm3,
            this.mnuOpenForm4});
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(48, 20);
            this.mnuOpen.Text = "Open";
            // 
            // mnuOpenForm1
            // 
            this.mnuOpenForm1.Name = "mnuOpenForm1";
            this.mnuOpenForm1.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm1.Text = "Form 1";
            this.mnuOpenForm1.Click += new System.EventHandler(this.mnuOpenForm1_Click);
            // 
            // mnuOpenForm2
            // 
            this.mnuOpenForm2.Name = "mnuOpenForm2";
            this.mnuOpenForm2.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm2.Text = "Form 2";
            this.mnuOpenForm2.Click += new System.EventHandler(this.mnuOpenForm2_Click);
            // 
            // mnuOpenForm3
            // 
            this.mnuOpenForm3.Name = "mnuOpenForm3";
            this.mnuOpenForm3.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm3.Text = "Form 3";
            this.mnuOpenForm3.Click += new System.EventHandler(this.mnuOpenForm3_Click);
            // 
            // mnuOpenForm4
            // 
            this.mnuOpenForm4.Name = "mnuOpenForm4";
            this.mnuOpenForm4.Size = new System.Drawing.Size(111, 22);
            this.mnuOpenForm4.Text = "Form 4";
            // 
            // sapXepToolStripMenuItem
            // 
            this.sapXepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sapXepKieu1ToolStripMenuItem,
            this.sapXepKieu1ToolStripMenuItem1,
            this.sapXepKieu1ToolStripMenuItem2,
            this.sapXepKieu1ToolStripMenuItem3,
            this.sapXepKieu1ToolStripMenuItem4});
            this.sapXepToolStripMenuItem.Name = "sapXepToolStripMenuItem";
            this.sapXepToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sapXepToolStripMenuItem.Text = "Sap Xep";
            // 
            // sapXepKieu1ToolStripMenuItem
            // 
            this.sapXepKieu1ToolStripMenuItem.Name = "sapXepKieu1ToolStripMenuItem";
            this.sapXepKieu1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sapXepKieu1ToolStripMenuItem.Text = "Sap xep kieu 1";
            this.sapXepKieu1ToolStripMenuItem.Click += new System.EventHandler(this.sapXepKieu1ToolStripMenuItem_Click);
            // 
            // sapXepKieu1ToolStripMenuItem1
            // 
            this.sapXepKieu1ToolStripMenuItem1.Name = "sapXepKieu1ToolStripMenuItem1";
            this.sapXepKieu1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sapXepKieu1ToolStripMenuItem1.Text = "Sap xep kieu 2";
            this.sapXepKieu1ToolStripMenuItem1.Click += new System.EventHandler(this.sapXepKieu1ToolStripMenuItem1_Click);
            // 
            // sapXepKieu1ToolStripMenuItem2
            // 
            this.sapXepKieu1ToolStripMenuItem2.Name = "sapXepKieu1ToolStripMenuItem2";
            this.sapXepKieu1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.sapXepKieu1ToolStripMenuItem2.Text = "Sap xep kieu 3";
            this.sapXepKieu1ToolStripMenuItem2.Click += new System.EventHandler(this.sapXepKieu1ToolStripMenuItem2_Click);
            // 
            // sapXepKieu1ToolStripMenuItem3
            // 
            this.sapXepKieu1ToolStripMenuItem3.Name = "sapXepKieu1ToolStripMenuItem3";
            this.sapXepKieu1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.sapXepKieu1ToolStripMenuItem3.Text = "Sap xep kieu 4";
            this.sapXepKieu1ToolStripMenuItem3.Click += new System.EventHandler(this.sapXepKieu1ToolStripMenuItem3_Click);
            // 
            // sapXepKieu1ToolStripMenuItem4
            // 
            this.sapXepKieu1ToolStripMenuItem4.Name = "sapXepKieu1ToolStripMenuItem4";
            this.sapXepKieu1ToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.sapXepKieu1ToolStripMenuItem4.Text = "Sap xep kieu 5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mnu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm3;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm4;
        private System.Windows.Forms.ToolStripMenuItem sapXepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sapXepKieu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sapXepKieu1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sapXepKieu1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sapXepKieu1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sapXepKieu1ToolStripMenuItem4;
        private System.Windows.Forms.Button button1;
    }
}

