namespace Slide22_1_tool_creat_file_folder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnpath = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRun2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txttu = new System.Windows.Forms.TextBox();
            this.txtden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap duong dan vao day";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(42, 112);
            this.txtpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(586, 26);
            this.txtpath.TabIndex = 1;
            // 
            // btnpath
            // 
            this.btnpath.Location = new System.Drawing.Point(658, 112);
            this.btnpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(147, 35);
            this.btnpath.TabIndex = 2;
            this.btnpath.Text = "Browser";
            this.btnpath.UseVisualStyleBackColor = true;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(42, 203);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(125, 35);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRun2
            // 
            this.btnRun2.Location = new System.Drawing.Point(503, 202);
            this.btnRun2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRun2.Name = "btnRun2";
            this.btnRun2.Size = new System.Drawing.Size(125, 35);
            this.btnRun2.TabIndex = 4;
            this.btnRun2.Text = "Run2";
            this.btnRun2.UseVisualStyleBackColor = true;
            this.btnRun2.Click += new System.EventHandler(this.btnRun2_Click);
            // 
            // txttu
            // 
            this.txttu.Location = new System.Drawing.Point(42, 157);
            this.txttu.Name = "txttu";
            this.txttu.Size = new System.Drawing.Size(100, 26);
            this.txttu.TabIndex = 5;
            // 
            // txtden
            // 
            this.txtden.Location = new System.Drawing.Point(227, 157);
            this.txtden.Name = "txtden";
            this.txtden.Size = new System.Drawing.Size(100, 26);
            this.txtden.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 289);
            this.Controls.Add(this.txtden);
            this.Controls.Add(this.txttu);
            this.Controls.Add(this.btnRun2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tao thu muc va file hang loat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRun2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txttu;
        private System.Windows.Forms.TextBox txtden;
    }
}

