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
            this.balance_heading_label = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.balance_label = new System.Windows.Forms.Label();
            this.balance_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // balance_panel
            // 
            this.balance_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(232)))));
            this.balance_panel.Controls.Add(this.balance_label);
            this.balance_panel.Controls.Add(this.balance_heading_label);
            this.balance_panel.Controls.Add(this.done_btn);
            this.balance_panel.Location = new System.Drawing.Point(339, 140);
            this.balance_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.balance_panel.Name = "balance_panel";
            this.balance_panel.Size = new System.Drawing.Size(591, 348);
            this.balance_panel.TabIndex = 0;
            this.balance_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.balance_panel_Paint);
            // 
            // balance_heading_label
            // 
            this.balance_heading_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_heading_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.balance_heading_label.Location = new System.Drawing.Point(0, 0);
            this.balance_heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balance_heading_label.Name = "balance_heading_label";
            this.balance_heading_label.Size = new System.Drawing.Size(591, 70);
            this.balance_heading_label.TabIndex = 0;
            this.balance_heading_label.Text = "Balance";
            this.balance_heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // done_btn
            // 
            this.done_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.done_btn.FlatAppearance.BorderSize = 3;
            this.done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.done_btn.Location = new System.Drawing.Point(153, 257);
            this.done_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(280, 80);
            this.done_btn.TabIndex = 4;
            this.done_btn.Text = "DONE";
            this.done_btn.UseVisualStyleBackColor = true;
            // 
            // balance_label
            // 
            this.balance_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.balance_label.Location = new System.Drawing.Point(-2, 125);
            this.balance_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(591, 70);
            this.balance_label.TabIndex = 5;
            this.balance_label.Text = "£XXX.XX";
            this.balance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 785);
            this.Controls.Add(this.balance_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "balance_form";
            this.Text = "Check balance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.balance_form_Load);
            this.balance_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel balance_panel;
        private System.Windows.Forms.Label balance_heading_label;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label balance_label;
    }
}