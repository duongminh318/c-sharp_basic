namespace Slide22_2_RenameFile_hangloat
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtChonPath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSave2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLuuPath = new System.Windows.Forms.TextBox();
            this.rtxGetFile = new System.Windows.Forms.RichTextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Chọn đường dẫn thư mục chừa File cần rename hàng loạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Get File để kiểm tra danh sách File trong thư mục cần Rename";
            // 
            // txtChonPath
            // 
            this.txtChonPath.Location = new System.Drawing.Point(24, 43);
            this.txtChonPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtChonPath.Name = "txtChonPath";
            this.txtChonPath.ReadOnly = true;
            this.txtChonPath.Size = new System.Drawing.Size(379, 21);
            this.txtChonPath.TabIndex = 2;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(439, 43);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(100, 27);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "OBrowser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Location = new System.Drawing.Point(24, 73);
            this.chkSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(229, 19);
            this.chkSave.TabIndex = 4;
            this.chkSave.Text = "Lưu đường dẫn để dùng lần sau";
            this.chkSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSave2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtLuuPath);
            this.groupBox1.Location = new System.Drawing.Point(16, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(523, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkSave2
            // 
            this.chkSave2.AutoSize = true;
            this.chkSave2.Location = new System.Drawing.Point(11, 89);
            this.chkSave2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSave2.Name = "chkSave2";
            this.chkSave2.Size = new System.Drawing.Size(229, 19);
            this.chkSave2.TabIndex = 9;
            this.chkSave2.Text = "Lưu đường dẫn để dùng lần sau";
            this.chkSave2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "3. Chọn đường dẫn chứa File sau khi Rename";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "SBrowser";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtLuuPath
            // 
            this.txtLuuPath.Location = new System.Drawing.Point(8, 62);
            this.txtLuuPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLuuPath.Name = "txtLuuPath";
            this.txtLuuPath.Size = new System.Drawing.Size(397, 21);
            this.txtLuuPath.TabIndex = 6;
            // 
            // rtxGetFile
            // 
            this.rtxGetFile.Location = new System.Drawing.Point(24, 138);
            this.rtxGetFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtxGetFile.Name = "rtxGetFile";
            this.rtxGetFile.Size = new System.Drawing.Size(400, 110);
            this.rtxGetFile.TabIndex = 6;
            this.rtxGetFile.Text = "";
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(439, 138);
            this.btnGetFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(100, 30);
            this.btnGetFile.TabIndex = 7;
            this.btnGetFile.Text = "Get File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(289, 387);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(109, 387);
            this.btnRename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(135, 40);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "ReName";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(555, 430);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.rtxGetFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtChonPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReName File Hàng Loạt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChonPath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLuuPath;
        private System.Windows.Forms.RichTextBox rtxGetFile;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.CheckBox chkSave2;
    }
}

