using System;

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
            this.balance_heading_label = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.balance_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // balance_panel
            // 
            this.balance_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(232)))));
            this.balance_panel.Controls.Add(this.balance_label);
            this.balance_panel.Controls.Add(this.balance_heading_label);
            this.balance_panel.Controls.Add(this.done_btn);
            this.balance_panel.Location = new System.Drawing.Point(508, 215);
            this.balance_panel.Name = "balance_panel";
            this.balance_panel.Size = new System.Drawing.Size(886, 535);
            this.balance_panel.TabIndex = 0;
            this.balance_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.balance_panel_Paint);
            // 
            // balance_label
            // 
            this.balance_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.balance_label.Location = new System.Drawing.Point(-3, 192);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(886, 108);
            this.balance_label.TabIndex = 5;
            this.balance_label.Text = "£XXX.XX";
            this.balance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balance_heading_label
            // 
            this.balance_heading_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_heading_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.balance_heading_label.Location = new System.Drawing.Point(0, 0);
            this.balance_heading_label.Name = "balance_heading_label";
            this.balance_heading_label.Size = new System.Drawing.Size(886, 108);
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
            this.done_btn.Location = new System.Drawing.Point(230, 395);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(420, 123);
            this.done_btn.TabIndex = 4;
            this.done_btn.Text = "DONE";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            this.done_btn.MouseEnter += new EventHandler(this.Btn_MouseEnter);
            this.done_btn.MouseLeave += new EventHandler(this.Btn_MouseLeave);
            // 
            // balance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.balance_panel);
            this.Name = "balance_form";
            this.Text = "Check balance";
            this.Load += new System.EventHandler(this.balance_form_Load);
            this.balance_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel balance_panel;
        private System.Windows.Forms.Label balance_heading_label;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label balance_label;

        void Btn_MouseEnter(object sender, EventArgs e)
        {
            // Change the button color when the mouse enters
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
        }

        void Btn_MouseLeave(object sender, EventArgs e)
        {
            // Change the button color back to its original color when the mouse leaves
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(232)))));
        }
    }
}