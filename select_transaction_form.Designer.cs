namespace ATM_forms
{
    partial class select_transaction_form
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
            this.select_transaction_panel = new System.Windows.Forms.Panel();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.select_transaction_label = new System.Windows.Forms.Label();
            this.cash_withdrawal_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.select_transaction_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_transaction_panel
            // 
            this.select_transaction_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.select_transaction_panel.Controls.Add(this.exit_btn);
            this.select_transaction_panel.Controls.Add(this.cash_withdrawal_btn);
            this.select_transaction_panel.Controls.Add(this.select_transaction_label);
            this.select_transaction_panel.Controls.Add(this.check_balance_btn);
            this.select_transaction_panel.Location = new System.Drawing.Point(508, 216);
            this.select_transaction_panel.Name = "select_transaction_panel";
            this.select_transaction_panel.Size = new System.Drawing.Size(886, 536);
            this.select_transaction_panel.TabIndex = 0;
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_balance_btn.Location = new System.Drawing.Point(265, 127);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(373, 123);
            this.check_balance_btn.TabIndex = 0;
            this.check_balance_btn.Text = "Check Balance";
            this.check_balance_btn.UseVisualStyleBackColor = true;
            // 
            // select_transaction_label
            // 
            this.select_transaction_label.AutoSize = true;
            this.select_transaction_label.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_transaction_label.Location = new System.Drawing.Point(216, 43);
            this.select_transaction_label.Name = "select_transaction_label";
            this.select_transaction_label.Size = new System.Drawing.Size(459, 65);
            this.select_transaction_label.TabIndex = 1;
            this.select_transaction_label.Text = "Select a Transaction";
            // 
            // cash_withdrawal_btn
            // 
            this.cash_withdrawal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_withdrawal_btn.Location = new System.Drawing.Point(265, 265);
            this.cash_withdrawal_btn.Name = "cash_withdrawal_btn";
            this.cash_withdrawal_btn.Size = new System.Drawing.Size(373, 123);
            this.cash_withdrawal_btn.TabIndex = 2;
            this.cash_withdrawal_btn.Text = "Cash Withdrawal";
            this.cash_withdrawal_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(288, 404);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(329, 111);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // select_transaction_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 770);
            this.Controls.Add(this.select_transaction_panel);
            this.Name = "select_transaction_form";
            this.Text = "Select Transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.select_transaction_form_Load);
            this.select_transaction_panel.ResumeLayout(false);
            this.select_transaction_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel select_transaction_panel;
        private System.Windows.Forms.Button cash_withdrawal_btn;
        private System.Windows.Forms.Label select_transaction_label;
        private System.Windows.Forms.Button check_balance_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}