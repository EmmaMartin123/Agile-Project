using System;

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
            this.exit_btn = new System.Windows.Forms.Button();
            this.cash_withdrawal_btn = new System.Windows.Forms.Button();
            this.select_transaction_label = new System.Windows.Forms.Label();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.select_transaction_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_transaction_panel
            // 
            this.select_transaction_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.select_transaction_panel.Controls.Add(this.exit_btn);
            this.select_transaction_panel.Controls.Add(this.cash_withdrawal_btn);
            this.select_transaction_panel.Controls.Add(this.select_transaction_label);
            this.select_transaction_panel.Controls.Add(this.check_balance_btn);
            this.select_transaction_panel.Location = new System.Drawing.Point(508, 215);
            this.select_transaction_panel.Name = "select_transaction_panel";
            this.select_transaction_panel.Size = new System.Drawing.Size(886, 535);
            this.select_transaction_panel.TabIndex = 0;
            this.select_transaction_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.select_transaction_panel_Paint);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.exit_btn.FlatAppearance.BorderSize = 3;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.exit_btn.Location = new System.Drawing.Point(286, 423);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(315, 92);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // cash_withdrawal_btn
            // 
            this.cash_withdrawal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.cash_withdrawal_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.cash_withdrawal_btn.FlatAppearance.BorderSize = 3;
            this.cash_withdrawal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cash_withdrawal_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_withdrawal_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.cash_withdrawal_btn.Location = new System.Drawing.Point(170, 266);
            this.cash_withdrawal_btn.Name = "cash_withdrawal_btn";
            this.cash_withdrawal_btn.Size = new System.Drawing.Size(562, 123);
            this.cash_withdrawal_btn.TabIndex = 2;
            this.cash_withdrawal_btn.Text = "CASH WITHDRAWAL";
            this.cash_withdrawal_btn.UseVisualStyleBackColor = true;
            this.cash_withdrawal_btn.Click += new System.EventHandler(this.cash_withdrawal_btn_Click);
            this.cash_withdrawal_btn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.cash_withdrawal_btn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // select_transaction_label
            // 
            this.select_transaction_label.AutoSize = true;
            this.select_transaction_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_transaction_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.select_transaction_label.Location = new System.Drawing.Point(183, 17);
            this.select_transaction_label.Name = "select_transaction_label";
            this.select_transaction_label.Size = new System.Drawing.Size(551, 74);
            this.select_transaction_label.TabIndex = 1;
            this.select_transaction_label.Text = "Select a Transaction";
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.check_balance_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.check_balance_btn.FlatAppearance.BorderSize = 3;
            this.check_balance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_balance_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_balance_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.check_balance_btn.Location = new System.Drawing.Point(170, 120);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(562, 123);
            this.check_balance_btn.TabIndex = 0;
            this.check_balance_btn.Text = "CHECK BALANCE";
            this.check_balance_btn.UseVisualStyleBackColor = true;
            this.check_balance_btn.Click += new System.EventHandler(this.check_balance_btn_Click);
            this.check_balance_btn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.check_balance_btn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // select_transaction_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
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

        void Btn_MouseEnter(object sender, EventArgs e)
        {
            // Change the button color when the mouse enters
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
        }

        void Btn_MouseLeave(object sender, EventArgs e)
        {
            // Change the button color back to its original color when the mouse leaves
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
        }
    }
}