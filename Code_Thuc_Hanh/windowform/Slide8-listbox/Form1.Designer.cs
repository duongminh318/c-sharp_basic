namespace Slide8_listbox
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
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnSelecID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Items.AddRange(new object[] {
            "huynh thi teo",
            "dang van addddddddddddd"});
            this.lstDanhSach.Location = new System.Drawing.Point(104, 33);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDanhSach.Size = new System.Drawing.Size(120, 95);
            this.lstDanhSach.TabIndex = 0;
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(104, 187);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(104, 248);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(225, 187);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Index 1";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(225, 247);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 4;
            this.btnRemoveAt.Text = "RemoveAt";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnSelecID
            // 
            this.btnSelecID.Location = new System.Drawing.Point(381, 187);
            this.btnSelecID.Name = "btnSelecID";
            this.btnSelecID.Size = new System.Drawing.Size(75, 23);
            this.btnSelecID.TabIndex = 5;
            this.btnSelecID.Text = "SelectedID";
            this.btnSelecID.UseVisualStyleBackColor = true;
            this.btnSelecID.Click += new System.EventHandler(this.btnSelecID_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "thaydoigiatritronglist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "SelectedIndex";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelecID);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lstDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnSelecID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

