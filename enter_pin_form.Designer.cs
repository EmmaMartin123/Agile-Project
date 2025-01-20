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
            this.pin_prompt = new System.Windows.Forms.Label();
            this.pin_txt_box = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.continue_btn = new System.Windows.Forms.Button();
            this.enter_pin_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter_pin_panel
            // 
            this.enter_pin_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.enter_pin_panel.Controls.Add(this.continue_btn);
            this.enter_pin_panel.Controls.Add(this.exit_btn);
            this.enter_pin_panel.Controls.Add(this.delete_btn);
            this.enter_pin_panel.Controls.Add(this.pin_txt_box);
            this.enter_pin_panel.Controls.Add(this.pin_prompt);
            this.enter_pin_panel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_pin_panel.Location = new System.Drawing.Point(508, 216);
            this.enter_pin_panel.Name = "enter_pin_panel";
            this.enter_pin_panel.Size = new System.Drawing.Size(886, 536);
            this.enter_pin_panel.TabIndex = 0;
            this.enter_pin_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.enter_pin_panel_Paint);
            // 
            // pin_promt
            // 
            this.pin_prompt.AutoSize = true;
            this.pin_prompt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_prompt.Location = new System.Drawing.Point(95, 62);
            this.pin_prompt.Name = "pin_promt";
            this.pin_prompt.Size = new System.Drawing.Size(700, 65);
            this.pin_prompt.TabIndex = 0;
            this.pin_prompt.Text = "Enter PIN and press ENTER key";
            this.pin_prompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // pin_txt_box
            // 
            this.pin_txt_box.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_txt_box.Location = new System.Drawing.Point(186, 183);
            this.pin_txt_box.Name = "pin_txt_box";
            this.pin_txt_box.Size = new System.Drawing.Size(373, 82);
            this.pin_txt_box.TabIndex = 1;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(591, 183);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(88, 82);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(106, 380);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(329, 111);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // continue_btn
            // 
            this.continue_btn.Location = new System.Drawing.Point(466, 380);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(329, 111);
            this.continue_btn.TabIndex = 4;
            this.continue_btn.Text = "Continue";
            this.continue_btn.UseVisualStyleBackColor = true;
            // 
            // enter_pin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 795);
            this.Controls.Add(this.enter_pin_panel);
            this.Name = "enter_pin_form";
            this.Text = "Enter Pin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}