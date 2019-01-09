namespace BudgetControl
{
    partial class CreateNewBudgetSetup
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
            this.radioBlank = new System.Windows.Forms.RadioButton();
            this.radioCopy = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBGCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRevNo = new System.Windows.Forms.TextBox();
            this.radUpdate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioBlank
            // 
            this.radioBlank.AutoSize = true;
            this.radioBlank.Checked = true;
            this.radioBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioBlank.Location = new System.Drawing.Point(37, 12);
            this.radioBlank.Name = "radioBlank";
            this.radioBlank.Size = new System.Drawing.Size(78, 17);
            this.radioBlank.TabIndex = 0;
            this.radioBlank.Text = "Blank Data";
            this.radioBlank.UseVisualStyleBackColor = true;
            // 
            // radioCopy
            // 
            this.radioCopy.AutoSize = true;
            this.radioCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioCopy.Location = new System.Drawing.Point(37, 61);
            this.radioCopy.Name = "radioCopy";
            this.radioCopy.Size = new System.Drawing.Size(75, 17);
            this.radioCopy.TabIndex = 1;
            this.radioCopy.Text = "Copy Form";
            this.radioCopy.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOK.Location = new System.Drawing.Point(120, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Location = new System.Drawing.Point(217, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtBGCode
            // 
            this.txtBGCode.BackColor = System.Drawing.Color.Honeydew;
            this.txtBGCode.Location = new System.Drawing.Point(120, 61);
            this.txtBGCode.Name = "txtBGCode";
            this.txtBGCode.ReadOnly = true;
            this.txtBGCode.Size = new System.Drawing.Size(100, 20);
            this.txtBGCode.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = global::BudgetControl.Properties.Resources.search_icon;
            this.button1.Location = new System.Drawing.Point(226, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRevNo
            // 
            this.txtRevNo.BackColor = System.Drawing.Color.Honeydew;
            this.txtRevNo.Location = new System.Drawing.Point(277, 61);
            this.txtRevNo.Name = "txtRevNo";
            this.txtRevNo.ReadOnly = true;
            this.txtRevNo.Size = new System.Drawing.Size(66, 20);
            this.txtRevNo.TabIndex = 7;
            // 
            // radUpdate
            // 
            this.radUpdate.AutoSize = true;
            this.radUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radUpdate.Location = new System.Drawing.Point(37, 37);
            this.radUpdate.Name = "radUpdate";
            this.radUpdate.Size = new System.Drawing.Size(60, 17);
            this.radUpdate.TabIndex = 8;
            this.radUpdate.Text = "Update";
            this.radUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(117, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Budget Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(274, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Revise No.";
            // 
            // CreateNewBudgetSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radUpdate);
            this.Controls.Add(this.txtRevNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBGCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioCopy);
            this.Controls.Add(this.radioBlank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewBudgetSetup";
            this.Text = "Create New Budget Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBlank;
        private System.Windows.Forms.RadioButton radioCopy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBGCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRevNo;
        private System.Windows.Forms.RadioButton radUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}