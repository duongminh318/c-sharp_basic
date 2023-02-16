namespace Slide5_ex_Box
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblhienThi = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.tbnThoat = new System.Windows.Forms.Button();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.lblfont = new System.Windows.Forms.Label();
            this.grbColor.SuspendLayout();
            this.grbFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(38, 40);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(124, 20);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input gì đi Thím: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(229, 34);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(224, 26);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblhienThi
            // 
            this.lblhienThi.AutoSize = true;
            this.lblhienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblhienThi.Location = new System.Drawing.Point(65, 317);
            this.lblhienThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhienThi.Name = "lblhienThi";
            this.lblhienThi.Size = new System.Drawing.Size(60, 19);
            this.lblhienThi.TabIndex = 0;
            this.lblhienThi.Text = "Hiển Thị";
            this.lblhienThi.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutput.Location = new System.Drawing.Point(177, 291);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(374, 77);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbColor
            // 
            this.grbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbColor.Controls.Add(this.radBlack);
            this.grbColor.Controls.Add(this.radBlue);
            this.grbColor.Controls.Add(this.radGreen);
            this.grbColor.Controls.Add(this.radRed);
            this.grbColor.Location = new System.Drawing.Point(42, 86);
            this.grbColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbColor.Name = "grbColor";
            this.grbColor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbColor.Size = new System.Drawing.Size(248, 193);
            this.grbColor.TabIndex = 3;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // grbFont
            // 
            this.grbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbFont.Controls.Add(this.chkUnderline);
            this.grbFont.Controls.Add(this.chkItalic);
            this.grbFont.Controls.Add(this.chkBold);
            this.grbFont.Location = new System.Drawing.Point(375, 86);
            this.grbFont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbFont.Name = "grbFont";
            this.grbFont.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbFont.Size = new System.Drawing.Size(248, 193);
            this.grbFont.TabIndex = 3;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font";
            // 
            // tbnThoat
            // 
            this.tbnThoat.Location = new System.Drawing.Point(573, 317);
            this.tbnThoat.Name = "tbnThoat";
            this.tbnThoat.Size = new System.Drawing.Size(68, 37);
            this.tbnThoat.TabIndex = 4;
            this.tbnThoat.Text = "Thoát";
            this.tbnThoat.UseVisualStyleBackColor = true;
            this.tbnThoat.Click += new System.EventHandler(this.tbnThoat_Click);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(48, 27);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(57, 24);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(48, 72);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(72, 24);
            this.radGreen.TabIndex = 0;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(48, 111);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(59, 24);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(48, 151);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(66, 24);
            this.radBlack.TabIndex = 0;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(22, 40);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(126, 24);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "In Đậm (Bold)";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(22, 86);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(152, 24);
            this.chkItalic.TabIndex = 0;
            this.chkItalic.Text = "In Nghiêng (Italic)";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(22, 133);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(191, 24);
            this.chkUnderline.TabIndex = 0;
            this.chkUnderline.Text = "Gạch Chân (Underline)";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // lblfont
            // 
            this.lblfont.AutoSize = true;
            this.lblfont.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblfont.Location = new System.Drawing.Point(500, 40);
            this.lblfont.Name = "lblfont";
            this.lblfont.Size = new System.Drawing.Size(0, 73);
            this.lblfont.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 395);
            this.Controls.Add(this.lblfont);
            this.Controls.Add(this.tbnThoat);
            this.Controls.Add(this.grbFont);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblhienThi);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Định Dạng Chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblhienThi;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.Button tbnThoat;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label lblfont;
    }
}

