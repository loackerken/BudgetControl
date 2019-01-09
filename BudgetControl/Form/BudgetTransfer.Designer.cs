namespace BudgetControl
{
    partial class BudgetTransfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBGName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBGCode = new System.Windows.Forms.TextBox();
            this.chkApprove = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTRNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRevNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBGCode = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ColHFCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFromCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBFCost = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHFProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFromProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBFProject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColFromPeriod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHTCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColToCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBTCost = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHTProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColToProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBTProject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColToPeriod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBGName
            // 
            this.txtBGName.Location = new System.Drawing.Point(142, 32);
            this.txtBGName.Name = "txtBGName";
            this.txtBGName.ReadOnly = true;
            this.txtBGName.Size = new System.Drawing.Size(233, 20);
            this.txtBGName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget Code";
            // 
            // txtBGCode
            // 
            this.txtBGCode.Location = new System.Drawing.Point(11, 32);
            this.txtBGCode.Name = "txtBGCode";
            this.txtBGCode.ReadOnly = true;
            this.txtBGCode.Size = new System.Drawing.Size(96, 20);
            this.txtBGCode.TabIndex = 1;
            // 
            // chkApprove
            // 
            this.chkApprove.AutoSize = true;
            this.chkApprove.Location = new System.Drawing.Point(495, 34);
            this.chkApprove.Name = "chkApprove";
            this.chkApprove.Size = new System.Drawing.Size(66, 17);
            this.chkApprove.TabIndex = 3;
            this.chkApprove.Text = "Approve";
            this.chkApprove.UseVisualStyleBackColor = true;
            this.chkApprove.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No.";
            // 
            // txtTRNo
            // 
            this.txtTRNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNo.Location = new System.Drawing.Point(680, 9);
            this.txtTRNo.Name = "txtTRNo";
            this.txtTRNo.ReadOnly = true;
            this.txtTRNo.Size = new System.Drawing.Size(133, 20);
            this.txtTRNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(680, 35);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(134, 20);
            this.dtDate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHFCost,
            this.ColFromCost,
            this.ColBFCost,
            this.ColHFProject,
            this.ColFromProject,
            this.ColBFProject,
            this.ColFromPeriod,
            this.ColBalance,
            this.ColHTCost,
            this.ColToCost,
            this.ColBTCost,
            this.ColHTProject,
            this.ColToProject,
            this.ColBTProject,
            this.ColToPeriod,
            this.ColAmount,
            this.ColRemark});
            this.dataGridView1.Location = new System.Drawing.Point(11, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 253);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOK.Location = new System.Drawing.Point(16, 338);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Location = new System.Drawing.Point(113, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRevNo
            // 
            this.txtRevNo.Location = new System.Drawing.Point(381, 32);
            this.txtRevNo.Name = "txtRevNo";
            this.txtRevNo.ReadOnly = true;
            this.txtRevNo.Size = new System.Drawing.Size(73, 20);
            this.txtRevNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rev No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Budget Name";
            // 
            // btnBGCode
            // 
            this.btnBGCode.Image = global::BudgetControl.Properties.Resources.search_icon;
            this.btnBGCode.Location = new System.Drawing.Point(112, 32);
            this.btnBGCode.Name = "btnBGCode";
            this.btnBGCode.Size = new System.Drawing.Size(24, 18);
            this.btnBGCode.TabIndex = 7;
            this.btnBGCode.UseVisualStyleBackColor = true;
            this.btnBGCode.Click += new System.EventHandler(this.btnBGCode_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::BudgetControl.Properties.Resources.search_icon;
            this.btnSearch.Location = new System.Drawing.Point(819, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 18);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ColHFCost
            // 
            this.ColHFCost.DataPropertyName = "FromOCR";
            this.ColHFCost.HeaderText = "Hidden From Cost";
            this.ColHFCost.Name = "ColHFCost";
            this.ColHFCost.Visible = false;
            // 
            // ColFromCost
            // 
            this.ColFromCost.HeaderText = "From Cost Center";
            this.ColFromCost.Name = "ColFromCost";
            // 
            // ColBFCost
            // 
            this.ColBFCost.HeaderText = "...";
            this.ColBFCost.Name = "ColBFCost";
            this.ColBFCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBFCost.Width = 25;
            // 
            // ColHFProject
            // 
            this.ColHFProject.DataPropertyName = "FromPRJ";
            this.ColHFProject.HeaderText = "Hidden From Project";
            this.ColHFProject.Name = "ColHFProject";
            this.ColHFProject.Visible = false;
            // 
            // ColFromProject
            // 
            this.ColFromProject.HeaderText = "From Project";
            this.ColFromProject.Name = "ColFromProject";
            // 
            // ColBFProject
            // 
            this.ColBFProject.HeaderText = "...";
            this.ColBFProject.Name = "ColBFProject";
            this.ColBFProject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBFProject.Width = 25;
            // 
            // ColFromPeriod
            // 
            this.ColFromPeriod.DataPropertyName = "FromPeriod";
            this.ColFromPeriod.HeaderText = "From Period";
            this.ColFromPeriod.Name = "ColFromPeriod";
            this.ColFromPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColFromPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColBalance
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.ColBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColBalance.HeaderText = "Balance";
            this.ColBalance.Name = "ColBalance";
            this.ColBalance.ReadOnly = true;
            // 
            // ColHTCost
            // 
            this.ColHTCost.DataPropertyName = "ToOCR";
            this.ColHTCost.HeaderText = "Hidden To Cost";
            this.ColHTCost.Name = "ColHTCost";
            this.ColHTCost.Visible = false;
            // 
            // ColToCost
            // 
            this.ColToCost.DataPropertyName = "ToOCR";
            this.ColToCost.HeaderText = "To Cost Center";
            this.ColToCost.Name = "ColToCost";
            // 
            // ColBTCost
            // 
            this.ColBTCost.HeaderText = "...";
            this.ColBTCost.Name = "ColBTCost";
            this.ColBTCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBTCost.Width = 25;
            // 
            // ColHTProject
            // 
            this.ColHTProject.DataPropertyName = "ToPRJ";
            this.ColHTProject.HeaderText = "Hidden To Project";
            this.ColHTProject.Name = "ColHTProject";
            this.ColHTProject.Visible = false;
            // 
            // ColToProject
            // 
            this.ColToProject.DataPropertyName = "ToPRJ";
            this.ColToProject.HeaderText = "To Project";
            this.ColToProject.Name = "ColToProject";
            // 
            // ColBTProject
            // 
            this.ColBTProject.HeaderText = "...";
            this.ColBTProject.Name = "ColBTProject";
            this.ColBTProject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBTProject.Width = 25;
            // 
            // ColToPeriod
            // 
            this.ColToPeriod.DataPropertyName = "ToPeriod";
            this.ColToPeriod.HeaderText = "To Period";
            this.ColToPeriod.Name = "ColToPeriod";
            // 
            // ColAmount
            // 
            this.ColAmount.DataPropertyName = "TRAmnt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.ColAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColAmount.HeaderText = "Transfer Amount";
            this.ColAmount.MaxInputLength = 20;
            this.ColAmount.Name = "ColAmount";
            // 
            // ColRemark
            // 
            this.ColRemark.DataPropertyName = "Remark";
            this.ColRemark.HeaderText = "Remark";
            this.ColRemark.MaxInputLength = 2000;
            this.ColRemark.Name = "ColRemark";
            // 
            // BudgetTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRevNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBGCode);
            this.Controls.Add(this.txtBGName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBGCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.chkApprove);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTRNo);
            this.Controls.Add(this.btnSearch);
            this.Name = "BudgetTransfer";
            this.Text = "Budget Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBGName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBGCode;
        private System.Windows.Forms.CheckBox chkApprove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTRNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBGCode;
        private System.Windows.Forms.TextBox txtRevNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHFCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFromCost;
        private System.Windows.Forms.DataGridViewButtonColumn ColBFCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHFProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFromProject;
        private System.Windows.Forms.DataGridViewButtonColumn ColBFProject;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColFromPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHTCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColToCost;
        private System.Windows.Forms.DataGridViewButtonColumn ColBTCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHTProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColToProject;
        private System.Windows.Forms.DataGridViewButtonColumn ColBTProject;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColToPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemark;
    }
}