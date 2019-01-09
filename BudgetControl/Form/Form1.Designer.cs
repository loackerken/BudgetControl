namespace BudgetControl
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.budgetControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetSetupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // budgetControlToolStripMenuItem
            // 
            this.budgetControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetSetupToolStripMenuItem,
            this.budgetTransactionToolStripMenuItem,
            this.budgetReportToolStripMenuItem});
            this.budgetControlToolStripMenuItem.Name = "budgetControlToolStripMenuItem";
            this.budgetControlToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.budgetControlToolStripMenuItem.Text = "Budget Control";
            // 
            // budgetSetupToolStripMenuItem
            // 
            this.budgetSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetScenarioToolStripMenuItem,
            this.budgetSetupToolStripMenuItem1});
            this.budgetSetupToolStripMenuItem.Name = "budgetSetupToolStripMenuItem";
            this.budgetSetupToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.budgetSetupToolStripMenuItem.Text = "Budget Setup";
            // 
            // budgetScenarioToolStripMenuItem
            // 
            this.budgetScenarioToolStripMenuItem.Name = "budgetScenarioToolStripMenuItem";
            this.budgetScenarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.budgetScenarioToolStripMenuItem.Text = "Budget Scenario";
            this.budgetScenarioToolStripMenuItem.Click += new System.EventHandler(this.budgetScenarioToolStripMenuItem_Click);
            // 
            // budgetSetupToolStripMenuItem1
            // 
            this.budgetSetupToolStripMenuItem1.Name = "budgetSetupToolStripMenuItem1";
            this.budgetSetupToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.budgetSetupToolStripMenuItem1.Text = "Budget Setup";
            this.budgetSetupToolStripMenuItem1.Click += new System.EventHandler(this.budgetSetupToolStripMenuItem1_Click);
            // 
            // budgetTransactionToolStripMenuItem
            // 
            this.budgetTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetTransferToolStripMenuItem,
            this.budgetImportToolStripMenuItem});
            this.budgetTransactionToolStripMenuItem.Name = "budgetTransactionToolStripMenuItem";
            this.budgetTransactionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.budgetTransactionToolStripMenuItem.Text = "Budget Transaction";
            // 
            // budgetTransferToolStripMenuItem
            // 
            this.budgetTransferToolStripMenuItem.Name = "budgetTransferToolStripMenuItem";
            this.budgetTransferToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.budgetTransferToolStripMenuItem.Text = "Budget Transfer";
            this.budgetTransferToolStripMenuItem.Click += new System.EventHandler(this.budgetTransferToolStripMenuItem_Click);
            // 
            // budgetImportToolStripMenuItem
            // 
            this.budgetImportToolStripMenuItem.Name = "budgetImportToolStripMenuItem";
            this.budgetImportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.budgetImportToolStripMenuItem.Text = "Budget Import";
            this.budgetImportToolStripMenuItem.Click += new System.EventHandler(this.budgetImportToolStripMenuItem_Click);
            // 
            // budgetReportToolStripMenuItem
            // 
            this.budgetReportToolStripMenuItem.Name = "budgetReportToolStripMenuItem";
            this.budgetReportToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.budgetReportToolStripMenuItem.Text = "Budget Report";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1284, 706);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Budget Control";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem budgetControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetSetupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem budgetTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetReportToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

