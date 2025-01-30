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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertCardForm));
            this.insert_card_picture_box = new System.Windows.Forms.PictureBox();
            this.insert_card_label = new System.Windows.Forms.Label();
            this.insert_card_panel = new System.Windows.Forms.Panel();
            this.english_button = new System.Windows.Forms.Button();
            this.french_button = new System.Windows.Forms.Button();
            this.spanish_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insert_card_picture_box)).BeginInit();
            this.insert_card_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_card_picture_box
            // 
            this.insert_card_picture_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.insert_card_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("insert_card_picture_box.Image")));
            this.insert_card_picture_box.InitialImage = ((System.Drawing.Image)(resources.GetObject("insert_card_picture_box.InitialImage")));
            this.insert_card_picture_box.Location = new System.Drawing.Point(275, 120);
            this.insert_card_picture_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insert_card_picture_box.Name = "insert_card_picture_box";
            this.insert_card_picture_box.Size = new System.Drawing.Size(750, 769);
            this.insert_card_picture_box.TabIndex = 0;
            this.insert_card_picture_box.TabStop = false;
            this.insert_card_picture_box.Click += new System.EventHandler(this.InsertcardpictureboxClick);
            // 
            // insert_card_label
            // 
            this.insert_card_label.AutoSize = true;
            this.insert_card_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_card_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.insert_card_label.Location = new System.Drawing.Point(442, 20);
            this.insert_card_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insert_card_label.Name = "insert_card_label";
            this.insert_card_label.Size = new System.Drawing.Size(415, 96);
            this.insert_card_label.TabIndex = 1;
            this.insert_card_label.Text = "Insert Card";
            // 
            // insert_card_panel
            // 
            this.insert_card_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.insert_card_panel.Controls.Add(this.spanish_button);
            this.insert_card_panel.Controls.Add(this.french_button);
            this.insert_card_panel.Controls.Add(this.english_button);
            this.insert_card_panel.Controls.Add(this.insert_card_label);
            this.insert_card_panel.Controls.Add(this.insert_card_picture_box);
            this.insert_card_panel.Location = new System.Drawing.Point(335, 106);
            this.insert_card_panel.Name = "insert_card_panel";
            this.insert_card_panel.Size = new System.Drawing.Size(1300, 900);
            this.insert_card_panel.TabIndex = 2;
            // 
            // english_button
            // 
            this.english_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.english_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.english_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.english_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.english_button.Image = ((System.Drawing.Image)(resources.GetObject("english_button.Image")));
            this.english_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.english_button.Location = new System.Drawing.Point(1130, 160);
            this.english_button.Name = "english_button";
            this.english_button.Size = new System.Drawing.Size(150, 60);
            this.english_button.TabIndex = 2;
            this.english_button.Text = "English";
            this.english_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.english_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.english_button.UseVisualStyleBackColor = true;
            // 
            // french_button
            // 
            this.french_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.french_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.french_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.french_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.french_button.Image = ((System.Drawing.Image)(resources.GetObject("french_button.Image")));
            this.french_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.french_button.Location = new System.Drawing.Point(1130, 20);
            this.french_button.Name = "french_button";
            this.french_button.Size = new System.Drawing.Size(150, 60);
            this.french_button.TabIndex = 3;
            this.french_button.Text = "Français";
            this.french_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.french_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.french_button.UseVisualStyleBackColor = true;
            // 
            // spanish_button
            // 
            this.spanish_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spanish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spanish_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spanish_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.spanish_button.Image = ((System.Drawing.Image)(resources.GetObject("spanish_button.Image")));
            this.spanish_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spanish_button.Location = new System.Drawing.Point(1130, 90);
            this.spanish_button.Name = "spanish_button";
            this.spanish_button.Size = new System.Drawing.Size(150, 60);
            this.spanish_button.TabIndex = 4;
            this.spanish_button.Text = "Español";
            this.spanish_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spanish_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.spanish_button.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.insert_card_picture_box)).EndInit();
            this.insert_card_panel.ResumeLayout(false);
            this.insert_card_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox insert_card_picture_box;
        private System.Windows.Forms.Label insert_card_label;
        private Panel insert_card_panel;
        private Button english_button;
        private Button spanish_button;
        private Button french_button;
    }
}