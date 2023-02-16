namespace Slide10_ex
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
            this.chklbLeft = new System.Windows.Forms.CheckedListBox();
            this.chklbRight = new System.Windows.Forms.CheckedListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbLeft
            // 
            this.chklbLeft.FormattingEnabled = true;
            this.chklbLeft.Items.AddRange(new object[] {
            "Xuyen tuong",
            "Nhay cao",
            "Chem Nhanh",
            "Chong Giat",
            "Aim bot",
            "Chong Giat"});
            this.chklbLeft.Location = new System.Drawing.Point(32, 53);
            this.chklbLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chklbLeft.Name = "chklbLeft";
            this.chklbLeft.Size = new System.Drawing.Size(281, 292);
            this.chklbLeft.TabIndex = 0;
            // 
            // chklbRight
            // 
            this.chklbRight.FormattingEnabled = true;
            this.chklbRight.Location = new System.Drawing.Point(485, 53);
            this.chklbRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chklbRight.Name = "chklbRight";
            this.chklbRight.Size = new System.Drawing.Size(281, 292);
            this.chklbRight.TabIndex = 0;
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRight.Location = new System.Drawing.Point(355, 65);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 27);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllRight.Location = new System.Drawing.Point(355, 98);
            this.btnAllRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(100, 27);
            this.btnAllRight.TabIndex = 1;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLeft.Location = new System.Drawing.Point(355, 143);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 27);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAllLeft
            // 
            this.btnAllLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllLeft.Location = new System.Drawing.Point(355, 189);
            this.btnAllLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.Size = new System.Drawing.Size(100, 27);
            this.btnAllLeft.TabIndex = 1;
            this.btnAllLeft.Text = "<<";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(816, 377);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.chklbRight);
            this.Controls.Add(this.chklbLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbLeft;
        private System.Windows.Forms.CheckedListBox chklbRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAllLeft;
    }
}

