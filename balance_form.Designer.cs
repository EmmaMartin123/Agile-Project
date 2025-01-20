namespace ATM_forms
{
    partial class balance_form
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
            this.balance_panel = new System.Windows.Forms.Panel();
            this.balance_label = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.balance_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // balance_panel
            // 
            this.balance_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.balance_panel.Controls.Add(this.balance_label);
            this.balance_panel.Controls.Add(this.done_btn);
            this.balance_panel.Location = new System.Drawing.Point(508, 216);
            this.balance_panel.Name = "balance_panel";
            this.balance_panel.Size = new System.Drawing.Size(886, 536);
            this.balance_panel.TabIndex = 0;
            
            // 
            // balance_label
            // 
            this.balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.Location = new System.Drawing.Point(0, 185);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(886, 108);
            this.balance_label.TabIndex = 0;
            this.balance_label.Text = "Balance: £";
            this.balance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // done_btn
            // 
            this.done_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.Location = new System.Drawing.Point(345, 355);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(229, 61);
            this.done_btn.TabIndex = 4;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            // 
            // balance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 770);
            this.Controls.Add(this.balance_panel);
            this.Name = "balance_form";
            this.Text = "Check balance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.balance_form_Load);
            this.balance_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel balance_panel;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Button done_btn;
    }
}