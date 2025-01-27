using System;

namespace ATM_forms
{
    partial class EnterPinForm
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
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.enter_pin_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter_pin_panel
            // 
            this.enter_pin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.enter_pin_panel.Controls.Add(this.continue_btn);
            this.enter_pin_panel.Controls.Add(this.exit_btn);
            this.enter_pin_panel.Controls.Add(this.delete_btn);
            this.enter_pin_panel.Controls.Add(this.pin_txt_box);
            this.enter_pin_panel.Controls.Add(this.pin_prompt);
            this.enter_pin_panel.Controls.Add(this.btn0);
            this.enter_pin_panel.Controls.Add(this.btn1);
            this.enter_pin_panel.Controls.Add(this.btn2);
            this.enter_pin_panel.Controls.Add(this.btn3);
            this.enter_pin_panel.Controls.Add(this.btn4);
            this.enter_pin_panel.Controls.Add(this.btn5);
            this.enter_pin_panel.Controls.Add(this.btn6);
            this.enter_pin_panel.Controls.Add(this.btn7);
            this.enter_pin_panel.Controls.Add(this.btn8);
            this.enter_pin_panel.Controls.Add(this.btn9);
            this.enter_pin_panel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_pin_panel.Location = new System.Drawing.Point(508, 215);
            this.enter_pin_panel.Name = "enter_pin_panel";
            this.enter_pin_panel.Size = new System.Drawing.Size(886, 535);
            this.enter_pin_panel.TabIndex = 0;
            // 
            // continue_btn
            // 
            this.continue_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.continue_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.continue_btn.FlatAppearance.BorderSize = 3;
            this.continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continue_btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.continue_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continue_btn.Location = new System.Drawing.Point(227, 412);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(411, 87);
            this.continue_btn.TabIndex = 4;
            this.continue_btn.Text = "ENTER";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.ContinuebtnClick);
            this.continue_btn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.continue_btn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.exit_btn.FlatAppearance.BorderSize = 3;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.exit_btn.Location = new System.Drawing.Point(312, 335);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(326, 71);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitbtnClick);
            this.exit_btn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.delete_btn.FlatAppearance.BorderSize = 3;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.delete_btn.Location = new System.Drawing.Point(227, 335);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(79, 71);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "X";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.DeletebtnClick);
            this.delete_btn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.delete_btn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // pin_txt_box
            // 
            this.pin_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin_txt_box.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_txt_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.pin_txt_box.Location = new System.Drawing.Point(227, 104);
            this.pin_txt_box.Name = "pin_txt_box";
            this.pin_txt_box.Size = new System.Drawing.Size(411, 75);
            this.pin_txt_box.TabIndex = 1;
            this.pin_txt_box.TextChanged += new System.EventHandler(this.PinTxtboxTextChanged);
            this.pin_txt_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PintxtboxKeyPress);
            // 
            // pin_prompt
            // 
            this.pin_prompt.AutoSize = true;
            this.pin_prompt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_prompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.pin_prompt.Location = new System.Drawing.Point(32, 14);
            this.pin_prompt.Name = "pin_prompt";
            this.pin_prompt.Size = new System.Drawing.Size(845, 74);
            this.pin_prompt.TabIndex = 0;
            this.pin_prompt.Text = "Enter PIN and Press ENTER Key";
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn0.FlatAppearance.BorderSize = 3;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn0.Location = new System.Drawing.Point(559, 259);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 71);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn0.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn0.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn1.FlatAppearance.BorderSize = 3;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn1.Location = new System.Drawing.Point(227, 184);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 71);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn1.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn2.FlatAppearance.BorderSize = 3;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn2.Location = new System.Drawing.Point(310, 184);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 71);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn2.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn3.FlatAppearance.BorderSize = 3;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn3.Location = new System.Drawing.Point(393, 184);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 71);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn3.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn4.FlatAppearance.BorderSize = 3;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn4.Location = new System.Drawing.Point(476, 184);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 71);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn4.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn5.FlatAppearance.BorderSize = 3;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn5.Location = new System.Drawing.Point(559, 184);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 71);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn5.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn6.FlatAppearance.BorderSize = 3;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn6.Location = new System.Drawing.Point(227, 259);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 71);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn6.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn7.FlatAppearance.BorderSize = 3;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn7.Location = new System.Drawing.Point(310, 259);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 71);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn7.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn8.FlatAppearance.BorderSize = 3;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn8.Location = new System.Drawing.Point(393, 259);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 71);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn8.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn9.FlatAppearance.BorderSize = 3;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn9.Location = new System.Drawing.Point(476, 259);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 71);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumberbtnClick);
            this.btn9.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn9.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // EnterPinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1050);
            this.Controls.Add(this.enter_pin_panel);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "EnterPinForm";
            this.Text = "Enter Pin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EnterPinForm_Load);
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
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        void BtnMouseEnter(object sender, EventArgs e)
        {
            // Change the button color when the mouse enters
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
        }

        void BtnMouseLeave(object sender, EventArgs e)
        {
            // Change the button color back to its original color when the mouse leaves
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
        }
    }
}