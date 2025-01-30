using System;
using System.Windows.Forms;

namespace ATM_forms
{
    partial class InsertCardForm
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
            this.insert_card_panel = new System.Windows.Forms.Panel();
            this.language2_button = new System.Windows.Forms.Button();
            this.language1_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insert_card_picture_box)).BeginInit();
            this.insert_card_label = new System.Windows.Forms.Label();
            this.mastercardbtn = new System.Windows.Forms.Button();
            this.visabtn = new System.Windows.Forms.Button();
            this.unionpaybtn = new System.Windows.Forms.Button();

            this.insert_card_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_card_panel
            // 
            this.insert_card_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.insert_card_panel.Controls.Add(this.language2_button);
            this.insert_card_panel.Controls.Add(this.language1_button);
            this.insert_card_panel.Controls.Add(this.insert_card_label);
            this.insert_card_panel.Controls.Add(this.mastercardbtn);
            this.insert_card_panel.Controls.Add(this.visabtn);
            this.insert_card_panel.Controls.Add(this.unionpaybtn);
            this.insert_card_panel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_card_panel.Location = new System.Drawing.Point(508, 215);
            this.insert_card_panel.Name = "insert_card_panel";
            this.insert_card_panel.Size = new System.Drawing.Size(1300, 900);
            this.insert_card_panel.TabIndex = 2;
            this.insert_card_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.insert_card_panel_Paint);
            // 
            // language2_button
            // 
            this.language2_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.language2_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.language2_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language2_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.language2_button.Image = ((System.Drawing.Image)(resources.GetObject("language2_button.Image")));
            this.language2_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.language2_button.Location = new System.Drawing.Point(1130, 90);
            this.language2_button.Name = "language2_button";
            this.language2_button.Size = new System.Drawing.Size(160, 60);
            this.language2_button.TabIndex = 4;
            this.language2_button.Text = "Español";
            this.language2_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.language2_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.language2_button.UseVisualStyleBackColor = true;
            this.language2_button.Click += new System.EventHandler(this.language2_button_Click);
            // 
            // language1_button
            // 
            this.language1_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.language1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.language1_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language1_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.language1_button.Image = ((System.Drawing.Image)(resources.GetObject("language1_button.Image")));
            this.language1_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.language1_button.Location = new System.Drawing.Point(1130, 20);
            this.language1_button.Name = "language1_button";
            this.language1_button.Size = new System.Drawing.Size(160, 60);
            this.language1_button.TabIndex = 3;
            this.language1_button.Text = "Français";
            this.language1_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.language1_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.language1_button.UseVisualStyleBackColor = true;
            this.language1_button.Click += new System.EventHandler(this.language1_button_Click);
            // 
            // insert_card_label
            // 
            this.insert_card_label.AutoSize = true;
            this.insert_card_label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_card_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.insert_card_label.Location = new System.Drawing.Point(37, 25);
            this.insert_card_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insert_card_label.Name = "insert_card_label";
            this.insert_card_label.Size = new System.Drawing.Size(845, 81);
            this.insert_card_label.TabIndex = 1;
            this.insert_card_label.Text = "Please select your card type: ";
            // 
            // mastercardbtn
            // 
            this.mastercardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.mastercardbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.mastercardbtn.FlatAppearance.BorderSize = 3;
            this.mastercardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastercardbtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastercardbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.mastercardbtn.Location = new System.Drawing.Point(285, 125);
            this.mastercardbtn.Name = "mastercardbtn";
            this.mastercardbtn.Size = new System.Drawing.Size(355, 89);
            this.mastercardbtn.TabIndex = 0;
            this.mastercardbtn.Text = "Mastercard";
            this.mastercardbtn.UseVisualStyleBackColor = true;
            this.mastercardbtn.Click += new System.EventHandler(this.MastercardbtnClick);
            this.mastercardbtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.mastercardbtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // visabtn
            // 
            this.visabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.visabtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.visabtn.FlatAppearance.BorderSize = 3;
            this.visabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visabtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.visabtn.Location = new System.Drawing.Point(285, 220);
            this.visabtn.Name = "visabtn";
            this.visabtn.Size = new System.Drawing.Size(355, 89);
            this.visabtn.TabIndex = 0;
            this.visabtn.Text = "Visa";
            this.visabtn.UseVisualStyleBackColor = true;
            this.visabtn.Click += new System.EventHandler(this.VisabtnClick);
            this.visabtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.visabtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // unionpaybtn
            // 
            this.unionpaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.unionpaybtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.unionpaybtn.FlatAppearance.BorderSize = 3;
            this.unionpaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unionpaybtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unionpaybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.unionpaybtn.Location = new System.Drawing.Point(285, 315);
            this.unionpaybtn.Name = "unionpaybtn";
            this.unionpaybtn.Size = new System.Drawing.Size(355, 89);
            this.unionpaybtn.TabIndex = 0;
            this.unionpaybtn.Text = "Union Pay";
            this.unionpaybtn.UseVisualStyleBackColor = true;
            this.unionpaybtn.Click += new System.EventHandler(this.UnionpaybtnClick);
            this.unionpaybtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.unionpaybtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // InsertCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.insert_card_panel);
            this.Name = "InsertCardForm";
            this.Text = "Insert Card";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InsertCardFormLoad);
            this.insert_card_panel.ResumeLayout(false);
            this.insert_card_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.PictureBox insert_card_picture_box;
        private System.Windows.Forms.Panel insert_card_panel;
        private System.Windows.Forms.Label insert_card_label;
        private Panel insert_card_panel;
        private Button language2_button;
        private Button language1_button;
        private System.Windows.Forms.Button mastercardbtn;
        private System.Windows.Forms.Button visabtn;
        private System.Windows.Forms.Button unionpaybtn;

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
