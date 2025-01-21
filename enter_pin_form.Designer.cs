using System;

namespace ATM_forms
{
    partial class enter_pin_form
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
            this.enter_pin_panel = new System.Windows.Forms.Panel();
            this.continue_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.pin_txt_box = new System.Windows.Forms.TextBox();
            this.pin_prompt = new System.Windows.Forms.Label();
            this.enter_pin_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter_pin_panel
            // 
            this.enter_pin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(202)))), ((int)(((byte)(232)))));
            this.enter_pin_panel.Controls.Add(this.continue_btn);
            this.enter_pin_panel.Controls.Add(this.exit_btn);
            this.enter_pin_panel.Controls.Add(this.delete_btn);
            this.enter_pin_panel.Controls.Add(this.pin_txt_box);
            this.enter_pin_panel.Controls.Add(this.pin_prompt);
            this.enter_pin_panel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_pin_panel.Location = new System.Drawing.Point(508, 215);
            this.enter_pin_panel.Name = "enter_pin_panel";
            this.enter_pin_panel.Size = new System.Drawing.Size(886, 535);
            this.enter_pin_panel.TabIndex = 0;
            this.enter_pin_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.enter_pin_panel_Paint);
            // 
            // continue_btn
            // 
            this.continue_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.continue_btn.FlatAppearance.BorderSize = 3;
            this.continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continue_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.continue_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continue_btn.Location = new System.Drawing.Point(447, 391);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(420, 123);
            this.continue_btn.TabIndex = 4;
            this.continue_btn.Text = "CONTINUE";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            this.continue_btn.MouseEnter += new EventHandler(this.Btn_MouseEnter);
            this.continue_btn.MouseLeave += new EventHandler(this.Btn_MouseLeave);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.exit_btn.FlatAppearance.BorderSize = 3;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.exit_btn.Location = new System.Drawing.Point(21, 391);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(420, 123);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new EventHandler(this.Btn_MouseEnter);
            this.exit_btn.MouseLeave += new EventHandler(this.Btn_MouseLeave);
            // 
            // delete_btn
            // 
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.delete_btn.FlatAppearance.BorderSize = 3;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.delete_btn.Location = new System.Drawing.Point(591, 183);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 77);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "X";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            this.delete_btn.MouseEnter += new EventHandler(this.Btn_MouseEnter);
            this.delete_btn.MouseLeave += new EventHandler(this.Btn_MouseLeave);
            // 
            // pin_txt_box
            // 
            this.pin_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin_txt_box.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_txt_box.Location = new System.Drawing.Point(186, 183);
            this.pin_txt_box.Name = "pin_txt_box";
            this.pin_txt_box.Size = new System.Drawing.Size(399, 75);
            this.pin_txt_box.TabIndex = 1;
            this.pin_txt_box.TextChanged += new System.EventHandler(this.pin_txt_box_TextChanged);
            this.pin_txt_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pin_txt_box_KeyPress);
            // 
            // pin_prompt
            // 
            this.pin_prompt.AutoSize = true;
            this.pin_prompt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_prompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.pin_prompt.Location = new System.Drawing.Point(32, 14);
            this.pin_prompt.Name = "pin_prompt";
            this.pin_prompt.Size = new System.Drawing.Size(845, 74);
            this.pin_prompt.TabIndex = 0;
            this.pin_prompt.Text = "Enter PIN and Press ENTER Key";
            this.pin_prompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // enter_pin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1050);
            this.Controls.Add(this.enter_pin_panel);
            this.Name = "enter_pin_form";
            this.Text = "Enter Pin";
            this.Load += new System.EventHandler(this.enter_pin_form_Load);
            this.enter_pin_panel.ResumeLayout(false);
            this.enter_pin_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel enter_pin_panel;
        private System.Windows.Forms.Label pin_prompt;
        private System.Windows.Forms.TextBox pin_txt_box;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button continue_btn;

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