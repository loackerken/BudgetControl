namespace BudgetControl
{
    partial class ListBudgetSetup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColBudgetCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBudgetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReviseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBudgetCode,
            this.ColBudgetName,
            this.ColReviseNo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColBudgetCode
            // 
            this.ColBudgetCode.DataPropertyName = "BudgetCode";
            this.ColBudgetCode.HeaderText = "Budget Code";
            this.ColBudgetCode.Name = "ColBudgetCode";
            this.ColBudgetCode.ReadOnly = true;
            this.ColBudgetCode.Width = 200;
            // 
            // ColBudgetName
            // 
            this.ColBudgetName.DataPropertyName = "BudgetName";
            this.ColBudgetName.HeaderText = "Budget Name";
            this.ColBudgetName.Name = "ColBudgetName";
            this.ColBudgetName.ReadOnly = true;
            this.ColBudgetName.Width = 200;
            // 
            // ColReviseNo
            // 
            this.ColReviseNo.DataPropertyName = "ReviseNo";
            this.ColReviseNo.HeaderText = "Revise No.";
            this.ColReviseNo.Name = "ColReviseNo";
            this.ColReviseNo.ReadOnly = true;
            // 
            // btnChoose
            // 
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChoose.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnChoose.Location = new System.Drawing.Point(13, 189);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(91, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Location = new System.Drawing.Point(110, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ListBudgetSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 224);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListBudgetSetup";
            this.Text = "List of Budget Setup";
            this.Load += new System.EventHandler(this.ListBudgetSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBudgetCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBudgetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReviseNo;
    }
}