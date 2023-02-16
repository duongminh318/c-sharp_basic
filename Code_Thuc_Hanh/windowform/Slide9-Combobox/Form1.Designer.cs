namespace Slide9_Combobox
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
            this.cboList = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelectedInded = new System.Windows.Forms.Button();
            this.btnSelectedItem = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboList
            // 
            this.cboList.FormattingEnabled = true;
            this.cboList.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3"});
            this.cboList.Location = new System.Drawing.Point(77, 64);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(121, 21);
            this.cboList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(53, 191);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelectedInded
            // 
            this.btnSelectedInded.Location = new System.Drawing.Point(53, 230);
            this.btnSelectedInded.Name = "btnSelectedInded";
            this.btnSelectedInded.Size = new System.Drawing.Size(104, 23);
            this.btnSelectedInded.TabIndex = 3;
            this.btnSelectedInded.Text = "SelectedInded";
            this.btnSelectedInded.UseVisualStyleBackColor = true;
            this.btnSelectedInded.Click += new System.EventHandler(this.btnSelectedInded_Click);
            // 
            // btnSelectedItem
            // 
            this.btnSelectedItem.Location = new System.Drawing.Point(258, 152);
            this.btnSelectedItem.Name = "btnSelectedItem";
            this.btnSelectedItem.Size = new System.Drawing.Size(137, 23);
            this.btnSelectedItem.TabIndex = 4;
            this.btnSelectedItem.Text = "SelectedItem";
            this.btnSelectedItem.UseVisualStyleBackColor = true;
            this.btnSelectedItem.Click += new System.EventHandler(this.btnSelectedItem_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(258, 191);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(137, 23);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Count Item of Combo";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Location = new System.Drawing.Point(258, 229);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(137, 23);
            this.btnAddRange.TabIndex = 6;
            this.btnAddRange.Text = "Add Range";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(258, 269);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(441, 151);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveAt.TabIndex = 8;
            this.btnRemoveAt.Text = "RemoveAt";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(441, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 304);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSelectedItem);
            this.Controls.Add(this.btnSelectedInded);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelectedInded;
        private System.Windows.Forms.Button btnSelectedItem;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnAddRange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnClear;
    }
}

