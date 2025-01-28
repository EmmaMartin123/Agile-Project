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
            ((System.ComponentModel.ISupportInitialize)(this.insert_card_picture_box)).BeginInit();
            this.insert_card_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_card_picture_box
            // 
            this.insert_card_picture_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.insert_card_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("insert_card_picture_box.Image")));
            this.insert_card_picture_box.InitialImage = ((System.Drawing.Image)(resources.GetObject("insert_card_picture_box.InitialImage")));
            this.insert_card_picture_box.Location = new System.Drawing.Point(127, 109);
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
            this.insert_card_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_card_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.insert_card_label.Location = new System.Drawing.Point(351, 30);
            this.insert_card_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insert_card_label.Name = "insert_card_label";
            this.insert_card_label.Size = new System.Drawing.Size(322, 74);
            this.insert_card_label.TabIndex = 1;
            this.insert_card_label.Text = "Insert Card";
            // 
            // insert_card_panel
            // 
            this.insert_card_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.insert_card_panel.Controls.Add(this.insert_card_label);
            this.insert_card_panel.Controls.Add(this.insert_card_picture_box);
            this.insert_card_panel.Location = new System.Drawing.Point(335, 106);
            this.insert_card_panel.Name = "insert_card_panel";
            this.insert_card_panel.Size = new System.Drawing.Size(1000, 900);
            this.insert_card_panel.TabIndex = 2;
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
    }
}