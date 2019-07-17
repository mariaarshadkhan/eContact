namespace eContact
{
    partial class eContact
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
            this.CIDtb = new System.Windows.Forms.TextBox();
            this.labelCID = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.CNtb = new System.Windows.Forms.TextBox();
            this.labelCN = new System.Windows.Forms.Label();
            this.LNtb = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.FNtb = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.Addresstb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Gendercb = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.Searchtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // CIDtb
            // 
            this.CIDtb.Location = new System.Drawing.Point(181, 83);
            this.CIDtb.Name = "CIDtb";
            this.CIDtb.ReadOnly = true;
            this.CIDtb.Size = new System.Drawing.Size(198, 20);
            this.CIDtb.TabIndex = 0;
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCID.Location = new System.Drawing.Point(69, 87);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(66, 16);
            this.labelCID.TabIndex = 1;
            this.labelCID.Text = "ContactID";
            this.labelCID.Click += new System.EventHandler(this.labelCID_Click);
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLN.Location = new System.Drawing.Point(69, 164);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(73, 16);
            this.labelLN.TabIndex = 3;
            this.labelLN.Text = "Last Name";
            this.labelLN.Click += new System.EventHandler(this.label2_Click);
            // 
            // CNtb
            // 
            this.CNtb.Location = new System.Drawing.Point(181, 195);
            this.CNtb.Name = "CNtb";
            this.CNtb.Size = new System.Drawing.Size(198, 20);
            this.CNtb.TabIndex = 2;
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCN.Location = new System.Drawing.Point(70, 199);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(104, 16);
            this.labelCN.TabIndex = 5;
            this.labelCN.Text = "Contact Number";
            // 
            // LNtb
            // 
            this.LNtb.Location = new System.Drawing.Point(181, 155);
            this.LNtb.Name = "LNtb";
            this.LNtb.Size = new System.Drawing.Size(198, 20);
            this.LNtb.TabIndex = 4;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(70, 122);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(73, 16);
            this.labelFN.TabIndex = 7;
            this.labelFN.Text = "First Name";
            this.labelFN.Click += new System.EventHandler(this.label4_Click);
            // 
            // FNtb
            // 
            this.FNtb.Location = new System.Drawing.Point(181, 122);
            this.FNtb.Name = "FNtb";
            this.FNtb.Size = new System.Drawing.Size(198, 20);
            this.FNtb.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(69, 230);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 16);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.Location = new System.Drawing.Point(69, 308);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(53, 16);
            this.labelgender.TabIndex = 9;
            this.labelgender.Text = "Gender";
            // 
            // Addresstb
            // 
            this.Addresstb.Location = new System.Drawing.Point(181, 230);
            this.Addresstb.Multiline = true;
            this.Addresstb.Name = "Addresstb";
            this.Addresstb.Size = new System.Drawing.Size(198, 56);
            this.Addresstb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(406, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "eContact";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Gendercb
            // 
            this.Gendercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendercb.FormattingEnabled = true;
            this.Gendercb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gendercb.Location = new System.Drawing.Point(181, 302);
            this.Gendercb.Name = "Gendercb";
            this.Gendercb.Size = new System.Drawing.Size(198, 28);
            this.Gendercb.TabIndex = 12;
            this.Gendercb.SelectedIndexChanged += new System.EventHandler(this.Gendercb_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(181, 371);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(273, 371);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(370, 371);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(480, 371);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(469, 122);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(380, 208);
            this.dgvContactList.TabIndex = 17;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search";
            // 
            // Searchtb
            // 
            this.Searchtb.Location = new System.Drawing.Point(538, 83);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(311, 20);
            this.Searchtb.TabIndex = 19;
            this.Searchtb.TextChanged += new System.EventHandler(this.Searchtb_TextChanged);
            // 
            // eContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 452);
            this.Controls.Add(this.Searchtb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Gendercb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Addresstb);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.FNtb);
            this.Controls.Add(this.labelCN);
            this.Controls.Add(this.LNtb);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.CNtb);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.CIDtb);
            this.Name = "eContact";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.eContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CIDtb;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.TextBox CNtb;
        private System.Windows.Forms.Label labelCN;
        private System.Windows.Forms.TextBox LNtb;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox FNtb;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.TextBox Addresstb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Gendercb;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Searchtb;
    }
}

