﻿namespace ATM_forms
{
    partial class insert_card_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insert_card_form));
            this.insert_card_picture_box = new System.Windows.Forms.PictureBox();
            this.insert_card_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insert_card_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // insert_card_picture_box
            // 
            this.insert_card_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("insert_card_picture_box.Image")));
            this.insert_card_picture_box.InitialImage = ((System.Drawing.Image)(resources.GetObject("insert_card_picture_box.InitialImage")));
            this.insert_card_picture_box.Location = new System.Drawing.Point(404, 237);
            this.insert_card_picture_box.Name = "insert_card_picture_box";
            this.insert_card_picture_box.Size = new System.Drawing.Size(499, 501);
            this.insert_card_picture_box.TabIndex = 0;
            this.insert_card_picture_box.TabStop = false;
            // 
            // insert_card_label
            // 
            this.insert_card_label.AutoSize = true;
            this.insert_card_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_card_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(219)))));
            this.insert_card_label.Location = new System.Drawing.Point(543, 152);
            this.insert_card_label.Name = "insert_card_label";
            this.insert_card_label.Size = new System.Drawing.Size(213, 50);
            this.insert_card_label.TabIndex = 1;
            this.insert_card_label.Text = "Insert Card";
            // 
            // insert_card_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 973);
            this.Controls.Add(this.insert_card_label);
            this.Controls.Add(this.insert_card_picture_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "insert_card_form";
            this.Text = "Insert Card";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.insert_card_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insert_card_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox insert_card_picture_box;
        private System.Windows.Forms.Label insert_card_label;
    }
}