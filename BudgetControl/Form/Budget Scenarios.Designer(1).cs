namespace BudgetControl
{
    partial class Budget_Scenarios
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColBudgetCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBudgetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBudgetType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColSetupBudgetBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColBudgetPeriod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColFiscalYear = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColPeriodFrom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColPeriodTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColNoPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReviseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hMCBGSCENARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMCBGSCENARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 22);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Location = new System.Drawing.Point(121, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 22);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.15447F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.84553F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 682F));
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(989, 28);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 219);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBudgetCode,
            this.ColBudgetName,
            this.ColBudgetType,
            this.ColSetupBudgetBy,
            this.ColBudgetPeriod,
            this.ColFiscalYear,
            this.ColPeriodFrom,
            this.ColPeriodTo,
            this.ColNoPeriod,
            this.ColReviseNo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 213);
            this.dataGridView1.TabIndex = 1;

            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // ColBudgetCode
            // 
            this.ColBudgetCode.DataPropertyName = "BudgetCode";
            this.ColBudgetCode.HeaderText = "Budget Code";
            this.ColBudgetCode.Name = "ColBudgetCode";
            // 
            // ColBudgetName
            // 
            this.ColBudgetName.DataPropertyName = "BudgetName";
            this.ColBudgetName.HeaderText = "Budget Name";
            this.ColBudgetName.Name = "ColBudgetName";
            this.ColBudgetName.Width = 150;
            // 
            // ColBudgetType
            // 
            this.ColBudgetType.DataPropertyName = "BudgetType";
            this.ColBudgetType.HeaderText = "Budget Type";
            this.ColBudgetType.Items.AddRange(new object[] {
            "0 = OB",
            "1 = General Budget"});
            this.ColBudgetType.Name = "ColBudgetType";
            // 
            // ColSetupBudgetBy
            // 
            this.ColSetupBudgetBy.DataPropertyName = "BudgetBy";
            this.ColSetupBudgetBy.HeaderText = "Setup Budget by";
            this.ColSetupBudgetBy.Items.AddRange(new object[] {
            "1 = Project",
            "2 = Cost Center and Account",
            "3 = Cost Center and Project"});
            this.ColSetupBudgetBy.Name = "ColSetupBudgetBy";
            this.ColSetupBudgetBy.Width = 150;
            // 
            // ColBudgetPeriod
            // 
            this.ColBudgetPeriod.DataPropertyName = "BudgetPeriod";
            this.ColBudgetPeriod.HeaderText = "BudgetPeriod";
            this.ColBudgetPeriod.Items.AddRange(new object[] {
            "1 = Annual",
            "2 = Period",
            "3 = Ignore Peiod"});
            this.ColBudgetPeriod.Name = "ColBudgetPeriod";
            // 
            // ColFiscalYear
            // 
            this.ColFiscalYear.DataPropertyName = "BudgetYear";
            this.ColFiscalYear.HeaderText = "Fiscal Year";
            this.ColFiscalYear.Name = "ColFiscalYear";
            // 
            // ColPeriodFrom
            // 
            this.ColPeriodFrom.DataPropertyName = "PeriodFrom";
            this.ColPeriodFrom.HeaderText = "Period from";
            this.ColPeriodFrom.Name = "ColPeriodFrom";
            this.ColPeriodFrom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColPeriodTo
            // 
            this.ColPeriodTo.DataPropertyName = "PeriodTo";
            this.ColPeriodTo.HeaderText = "Period To";
            this.ColPeriodTo.Name = "ColPeriodTo";
            this.ColPeriodTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColNoPeriod
            // 
            this.ColNoPeriod.DataPropertyName = "NoOfPeriod";
            this.ColNoPeriod.HeaderText = "No. of Period";
            this.ColNoPeriod.Name = "ColNoPeriod";
            // 
            // ColReviseNo
            // 
            this.ColReviseNo.DataPropertyName = "ReviseNo";
            this.ColReviseNo.HeaderText = "Revise No";
            this.ColReviseNo.Name = "ColReviseNo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 333);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(995, 34);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // hMCBGSCENARIOBindingSource
            // 
            this.hMCBGSCENARIOBindingSource.DataSource = typeof(BudgetControl.Class.HMC_BGSCENARIO);
            // 
            // Budget_Scenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 367);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Budget_Scenarios";
            this.Text = "Budget Scenarios";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Budget_Scenarios_MouseClick);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hMCBGSCENARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hMCBGSCENARIOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBudgetCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBudgetName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColBudgetType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColSetupBudgetBy;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColBudgetPeriod;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColFiscalYear;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColPeriodFrom;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColPeriodTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNoPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReviseNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}