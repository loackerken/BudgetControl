using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Login fLogin = new Login();
            fLogin.ShowDialog();
            InitializeComponent();
            
        }

        private void budgetScenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Budget_Scenarios Budget_ScenariosForm = new Budget_Scenarios();
            Budget_ScenariosForm.TopLevel = false;
            tableLayoutPanel1.Controls.Add(Budget_ScenariosForm);
            Budget_ScenariosForm.Dock = DockStyle.Fill;
            Budget_ScenariosForm.Show();

        }

        private void budgetSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BudgetSetup BudgetSetupForm = new BudgetSetup();
            BudgetSetupForm.TopLevel = false;
            tableLayoutPanel1.Controls.Add(BudgetSetupForm);
            BudgetSetupForm.Dock = DockStyle.Fill;
            BudgetSetupForm.Show();
        }

        private void budgetTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetTransfer BudgetTransferForm = new BudgetTransfer();
            BudgetTransferForm.TopLevel = false;
            tableLayoutPanel1.Controls.Add(BudgetTransferForm);
            BudgetTransferForm.Dock = DockStyle.Fill;
            BudgetTransferForm.Show();
        }

        private void budgetImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetImport BudgetImportForm = new BudgetImport();
            BudgetImportForm.TopLevel = false;
            tableLayoutPanel1.Controls.Add(BudgetImportForm);
            BudgetImportForm.Dock = DockStyle.Fill;
            BudgetImportForm.Show();
        }
    }
}
