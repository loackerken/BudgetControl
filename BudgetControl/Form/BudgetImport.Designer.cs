namespace BudgetControl
{
    partial class BudgetImport
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowseAnnual = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtGridAnnual = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGridPeriod = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.BGCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrjCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCRCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidateMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidPass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAnnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import File";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(85, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnBrowseAnnual
            // 
            this.btnBrowseAnnual.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBrowseAnnual.Location = new System.Drawing.Point(650, 10);
            this.btnBrowseAnnual.Name = "btnBrowseAnnual";
            this.btnBrowseAnnual.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseAnnual.TabIndex = 4;
            this.btnBrowseAnnual.Text = "Browse";
            this.btnBrowseAnnual.UseVisualStyleBackColor = true;
            this.btnBrowseAnnual.Click += new System.EventHandler(this.btnBrowseAnnual_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox1.Location = new System.Drawing.Point(12, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Auto Allocate to period";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnImport.Location = new System.Drawing.Point(12, 548);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(91, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Location = new System.Drawing.Point(109, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtGridAnnual
            // 
            this.dtGridAnnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAnnual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BGCode,
            this.ReviseNo,
            this.PrjCode,
            this.OCRCode,
            this.Amount,
            this.BGTotal,
            this.NoOfPeriod,
            this.ValidateMessage,
            this.ValidPass});
            this.dtGridAnnual.Location = new System.Drawing.Point(12, 111);
            this.dtGridAnnual.Name = "dtGridAnnual";
            this.dtGridAnnual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridAnnual.Size = new System.Drawing.Size(701, 198);
            this.dtGridAnnual.TabIndex = 9;
            this.dtGridAnnual.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAnnual_RowEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Annual Budget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Period Budget";
            // 
            // dtGridPeriod
            // 
            this.dtGridPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPeriod.Location = new System.Drawing.Point(12, 344);
            this.dtGridPeriod.Name = "dtGridPeriod";
            this.dtGridPeriod.Size = new System.Drawing.Size(701, 198);
            this.dtGridPeriod.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(650, 37);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(178, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Annual Budget Sheet";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(308, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(419, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Period Budget Sheet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(545, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // chkShowAll
            // 
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.Checked = true;
            this.chkShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAll.Location = new System.Drawing.Point(120, 327);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(66, 17);
            this.chkShowAll.TabIndex = 18;
            this.chkShowAll.Text = "Show all";
            this.chkShowAll.UseVisualStyleBackColor = true;
            this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowAll_CheckedChanged);
            // 
            // BGCode
            // 
            this.BGCode.DataPropertyName = "BudgetCode";
            this.BGCode.HeaderText = "BudgetCode";
            this.BGCode.Name = "BGCode";
            this.BGCode.ReadOnly = true;
            // 
            // ReviseNo
            // 
            this.ReviseNo.DataPropertyName = "ReviseNo";
            this.ReviseNo.HeaderText = "ReviseNo";
            this.ReviseNo.Name = "ReviseNo";
            this.ReviseNo.ReadOnly = true;
            // 
            // PrjCode
            // 
            this.PrjCode.DataPropertyName = "PrjCode";
            this.PrjCode.HeaderText = "Project Code";
            this.PrjCode.Name = "PrjCode";
            this.PrjCode.ReadOnly = true;
            // 
            // OCRCode
            // 
            this.OCRCode.DataPropertyName = "_OCRCode";
            this.OCRCode.HeaderText = "Cost Center";
            this.OCRCode.Name = "OCRCode";
            this.OCRCode.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "_Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // BGTotal
            // 
            this.BGTotal.DataPropertyName = "BGTotal";
            this.BGTotal.HeaderText = "BGTotal";
            this.BGTotal.Name = "BGTotal";
            this.BGTotal.ReadOnly = true;
            // 
            // NoOfPeriod
            // 
            this.NoOfPeriod.DataPropertyName = "_NoOfPeriod";
            this.NoOfPeriod.HeaderText = "NoOfPeriod";
            this.NoOfPeriod.Name = "NoOfPeriod";
            this.NoOfPeriod.ReadOnly = true;
            // 
            // ValidateMessage
            // 
            this.ValidateMessage.DataPropertyName = "_ValidateMessage";
            this.ValidateMessage.HeaderText = "ValidateMessage";
            this.ValidateMessage.Name = "ValidateMessage";
            this.ValidateMessage.ReadOnly = true;
            // 
            // ValidPass
            // 
            this.ValidPass.DataPropertyName = "_ValidPass";
            this.ValidPass.HeaderText = "ValidPass";
            this.ValidPass.Name = "ValidPass";
            this.ValidPass.ReadOnly = true;
            // 
            // BudgetImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 582);
            this.Controls.Add(this.chkShowAll);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtGridAnnual);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnBrowseAnnual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "BudgetImport";
            this.Text = "Budget Import";
            this.Load += new System.EventHandler(this.BudgetImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAnnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowseAnnual;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtGridAnnual;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGridPeriod;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
      //  private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrjCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCRCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidateMessage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ValidPass;
    }
}