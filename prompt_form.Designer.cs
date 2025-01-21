using System;

namespace ATM_forms
{
    partial class prompt_form
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
            this.prompt_panel = new System.Windows.Forms.Panel();
            this.prompt_label1 = new System.Windows.Forms.Label();
            this.no_btn = new System.Windows.Forms.Button();
            this.yes_btn = new System.Windows.Forms.Button();
            this.prompt_label2 = new System.Windows.Forms.Label();
            this.prompt_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prompt_panel
            // 
            this.prompt_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(232)))));
            this.prompt_panel.Controls.Add(this.prompt_label1);
            this.prompt_panel.Controls.Add(this.no_btn);
            this.prompt_panel.Controls.Add(this.yes_btn);
            this.prompt_panel.Controls.Add(this.prompt_label2);
            this.prompt_panel.Location = new System.Drawing.Point(508, 215);
            this.prompt_panel.Name = "prompt_panel";
            this.prompt_panel.Size = new System.Drawing.Size(886, 535);
            this.prompt_panel.TabIndex = 0;
            // 
            // prompt_label1
            // 
            this.prompt_label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.prompt_label1.Location = new System.Drawing.Point(3, 185);
            this.prompt_label1.Name = "prompt_label1";
            this.prompt_label1.Size = new System.Drawing.Size(886, 125);
            this.prompt_label1.TabIndex = 0;
            this.prompt_label1.Text = "Prompt....";
            this.prompt_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prompt_label1.Click += new System.EventHandler(this.prompt_label1_Click);
            // 
            // no_btn
            // 
            this.no_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.no_btn.FlatAppearance.BorderSize = 3;
            this.no_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.no_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.no_btn.Location = new System.Drawing.Point(21, 394);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(420, 123);
            this.no_btn.TabIndex = 4;
            this.no_btn.Text = "NO";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            this.no_btn.MouseEnter += new EventHandler(this.Btn_MouseEnter);
            this.no_btn.MouseLeave += new EventHandler(this.Btn_MouseLeave);
            // 
            // yes_btn
            // 
            this.yes_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.yes_btn.FlatAppearance.BorderSize = 3;
            this.yes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.yes_btn.Location = new System.Drawing.Point(447, 394);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(420, 123);
            this.yes_btn.TabIndex = 4;
            this.yes_btn.Text = "YES";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            this.yes_btn.MouseEnter += new EventHandler(this.Btn_MouseEnter);
            this.yes_btn.MouseLeave += new EventHandler(this.Btn_MouseLeave);
            // 
            // prompt_label2
            // 
            this.prompt_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt_label2.Location = new System.Drawing.Point(0, 185);
            this.prompt_label2.Name = "prompt_label2";
            this.prompt_label2.Size = new System.Drawing.Size(886, 108);
            this.prompt_label2.TabIndex = 0;
            this.prompt_label2.Text = "Prompt2...";
            this.prompt_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prompt_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1050);
            this.Controls.Add(this.prompt_panel);
            this.Name = "prompt_form";
            this.Text = "prompts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.prompt_form_Load);
            this.prompt_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel prompt_panel;
        private System.Windows.Forms.Label prompt_label1;
        private System.Windows.Forms.Label prompt_label2;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;

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