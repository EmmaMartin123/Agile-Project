using System;

namespace ATM_forms
{
    partial class WithdrawForm
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
            this.withdraw_panel = new System.Windows.Forms.Panel();
            this.amount_label = new System.Windows.Forms.Label();
            this.amount_txtbox = new System.Windows.Forms.TextBox();
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
            this.btnY = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.withdraw_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // withdraw_panel
            // 
            this.withdraw_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.withdraw_panel.Controls.Add(this.amount_label);
            this.withdraw_panel.Controls.Add(this.amount_txtbox);
            this.withdraw_panel.Controls.Add(this.btn0);
            this.withdraw_panel.Controls.Add(this.btn1);
            this.withdraw_panel.Controls.Add(this.btn2);
            this.withdraw_panel.Controls.Add(this.btn3);
            this.withdraw_panel.Controls.Add(this.btn4);
            this.withdraw_panel.Controls.Add(this.btn5);
            this.withdraw_panel.Controls.Add(this.btn6);
            this.withdraw_panel.Controls.Add(this.btn7);
            this.withdraw_panel.Controls.Add(this.btn8);
            this.withdraw_panel.Controls.Add(this.btn9);
            this.withdraw_panel.Controls.Add(this.btnY);
            this.withdraw_panel.Controls.Add(this.btnN);
            this.withdraw_panel.Controls.Add(this.btnExit);
            this.withdraw_panel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.withdraw_panel.Location = new System.Drawing.Point(285, 76);
            this.withdraw_panel.Name = "withdraw_panel";
            this.withdraw_panel.Size = new System.Drawing.Size(1300, 900);
            this.withdraw_panel.TabIndex = 0;
            this.withdraw_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.withdraw_panel_Paint);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.amount_label.Location = new System.Drawing.Point(140, 20);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(1020, 70);
            this.amount_label.TabIndex = 0;
            this.amount_label.Text = "Enter the amount you wish to withdraw: ";
            this.amount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amount_txtbox
            // 
            this.amount_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.amount_txtbox.Location = new System.Drawing.Point(400, 190);
            this.amount_txtbox.Name = "amount_txtbox";
            this.amount_txtbox.Size = new System.Drawing.Size(500, 82);
            this.amount_txtbox.TabIndex = 1;
            this.amount_txtbox.Text = "£";
            this.amount_txtbox.TextChanged += new System.EventHandler(this.AmounttxtboxTextChanged);
            this.amount_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmounttxtboxKeyPress);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn0.FlatAppearance.BorderSize = 3;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn0.Location = new System.Drawing.Point(590, 680);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(120, 120);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn0.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn0.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn1.FlatAppearance.BorderSize = 3;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn1.Location = new System.Drawing.Point(460, 290);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(120, 120);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn1.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn2.FlatAppearance.BorderSize = 3;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn2.Location = new System.Drawing.Point(590, 290);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(120, 120);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn2.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn3.FlatAppearance.BorderSize = 3;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn3.Location = new System.Drawing.Point(720, 290);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(120, 120);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn3.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn4.FlatAppearance.BorderSize = 3;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn4.Location = new System.Drawing.Point(460, 420);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(120, 120);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn4.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn5.FlatAppearance.BorderSize = 3;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn5.Location = new System.Drawing.Point(590, 420);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(120, 120);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn5.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn6.FlatAppearance.BorderSize = 3;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn6.Location = new System.Drawing.Point(720, 420);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(120, 120);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn6.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn7.FlatAppearance.BorderSize = 3;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn7.Location = new System.Drawing.Point(460, 550);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(120, 120);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn7.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn8.FlatAppearance.BorderSize = 3;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn8.Location = new System.Drawing.Point(590, 550);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(120, 120);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn8.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn9.FlatAppearance.BorderSize = 3;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btn9.Location = new System.Drawing.Point(720, 550);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(120, 120);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumberButtonClick);
            this.btn9.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btn9.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btnY.FlatAppearance.BorderSize = 3;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btnY.Location = new System.Drawing.Point(460, 680);
            this.btnY.Margin = new System.Windows.Forms.Padding(2);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(120, 120);
            this.btnY.TabIndex = 9;
            this.btnY.Text = "Enter";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.BtnYClick);
            this.btnY.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnY.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btnN.FlatAppearance.BorderSize = 3;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btnN.Location = new System.Drawing.Point(720, 680);
            this.btnN.Margin = new System.Windows.Forms.Padding(2);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(120, 120);
            this.btnN.TabIndex = 9;
            this.btnN.Text = "Clear";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.BtnNClick);
            this.btnN.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnN.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.btnExit.Location = new System.Drawing.Point(460, 810);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(380, 70);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ExitbtnClick);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 770);
            this.Controls.Add(this.withdraw_panel);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "WithdrawForm";
            this.Text = "Withdraw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.withdraw_panel.ResumeLayout(false);
            this.withdraw_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel withdraw_panel;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox amount_txtbox;
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
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnExit;

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