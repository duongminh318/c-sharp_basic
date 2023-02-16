namespace Slide8_ex
{
    partial class frmListBox
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbListNumber = new System.Windows.Forms.GroupBox();
            this.grbFunction = new System.Windows.Forms.GroupBox();
            this.btnChooseOdd = new System.Windows.Forms.Button();
            this.btnChooseEven = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSitem = new System.Windows.Forms.Button();
            this.btnRemoveFiteam = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.grbListNumber.SuspendLayout();
            this.grbFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Number";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(103, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(363, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(504, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbListNumber
            // 
            this.grbListNumber.BackColor = System.Drawing.Color.Azure;
            this.grbListNumber.Controls.Add(this.lstNumber);
            this.grbListNumber.Location = new System.Drawing.Point(16, 65);
            this.grbListNumber.Name = "grbListNumber";
            this.grbListNumber.Size = new System.Drawing.Size(364, 256);
            this.grbListNumber.TabIndex = 3;
            this.grbListNumber.TabStop = false;
            this.grbListNumber.Text = "List Number";
            // 
            // grbFunction
            // 
            this.grbFunction.BackColor = System.Drawing.Color.Ivory;
            this.grbFunction.Controls.Add(this.btnChooseOdd);
            this.grbFunction.Controls.Add(this.btnChooseEven);
            this.grbFunction.Controls.Add(this.btnchange);
            this.grbFunction.Controls.Add(this.btnUp);
            this.grbFunction.Controls.Add(this.btnSitem);
            this.grbFunction.Controls.Add(this.btnRemoveFiteam);
            this.grbFunction.Controls.Add(this.btnCount);
            this.grbFunction.Location = new System.Drawing.Point(411, 65);
            this.grbFunction.Name = "grbFunction";
            this.grbFunction.Size = new System.Drawing.Size(268, 256);
            this.grbFunction.TabIndex = 3;
            this.grbFunction.TabStop = false;
            this.grbFunction.Text = "Function";
            // 
            // btnChooseOdd
            // 
            this.btnChooseOdd.Location = new System.Drawing.Point(6, 227);
            this.btnChooseOdd.Name = "btnChooseOdd";
            this.btnChooseOdd.Size = new System.Drawing.Size(245, 23);
            this.btnChooseOdd.TabIndex = 0;
            this.btnChooseOdd.Text = "choose odd number";
            this.btnChooseOdd.UseVisualStyleBackColor = true;
            this.btnChooseOdd.Click += new System.EventHandler(this.btnChooseOdd_Click);
            // 
            // btnChooseEven
            // 
            this.btnChooseEven.Location = new System.Drawing.Point(6, 198);
            this.btnChooseEven.Name = "btnChooseEven";
            this.btnChooseEven.Size = new System.Drawing.Size(245, 23);
            this.btnChooseEven.TabIndex = 0;
            this.btnChooseEven.Text = "choose even number";
            this.btnChooseEven.UseVisualStyleBackColor = true;
            this.btnChooseEven.Click += new System.EventHandler(this.btnChooseEven_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(6, 160);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(245, 23);
            this.btnchange.TabIndex = 0;
            this.btnchange.Text = "change by Square";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(6, 131);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(245, 23);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up to 2";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSitem
            // 
            this.btnSitem.Location = new System.Drawing.Point(6, 91);
            this.btnSitem.Name = "btnSitem";
            this.btnSitem.Size = new System.Drawing.Size(245, 23);
            this.btnSitem.TabIndex = 0;
            this.btnSitem.Text = "Remove The Selected Item";
            this.btnSitem.UseVisualStyleBackColor = true;
            this.btnSitem.Click += new System.EventHandler(this.btnSitem_Click);
            // 
            // btnRemoveFiteam
            // 
            this.btnRemoveFiteam.Location = new System.Drawing.Point(6, 62);
            this.btnRemoveFiteam.Name = "btnRemoveFiteam";
            this.btnRemoveFiteam.Size = new System.Drawing.Size(245, 23);
            this.btnRemoveFiteam.TabIndex = 0;
            this.btnRemoveFiteam.Text = "Remove The First and Finall Item ";
            this.btnRemoveFiteam.UseVisualStyleBackColor = true;
            this.btnRemoveFiteam.Click += new System.EventHandler(this.btnRemoveFiteam_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(6, 19);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(245, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Count of List";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Ivory;
            this.btnFinish.Location = new System.Drawing.Point(16, 327);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(663, 34);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lstNumber
            // 
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.Location = new System.Drawing.Point(6, 19);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstNumber.Size = new System.Drawing.Size(352, 225);
            this.lstNumber.TabIndex = 0;
            // 
            // frmListBox
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(715, 362);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.grbFunction);
            this.Controls.Add(this.grbListNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example List Box";
            this.grbListNumber.ResumeLayout(false);
            this.grbFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grbListNumber;
        private System.Windows.Forms.GroupBox grbFunction;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnChooseOdd;
        private System.Windows.Forms.Button btnChooseEven;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSitem;
        private System.Windows.Forms.Button btnRemoveFiteam;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ListBox lstNumber;
    }
}

