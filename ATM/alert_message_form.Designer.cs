namespace ATM_forms
{
    partial class AlertMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertMessageForm));
            this.alert_Picture_Box = new System.Windows.Forms.PictureBox();
            this.alert_label = new System.Windows.Forms.Label();
            this.alert_ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alert_Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // alert_Picture_Box
            // 
            this.alert_Picture_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alert_Picture_Box.Image = ((System.Drawing.Image)(resources.GetObject("alert_Picture_Box.Image")));
            this.alert_Picture_Box.Location = new System.Drawing.Point(175, 20);
            this.alert_Picture_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alert_Picture_Box.Name = "alert_Picture_Box";
            this.alert_Picture_Box.Size = new System.Drawing.Size(250, 250);
            this.alert_Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alert_Picture_Box.TabIndex = 0;
            this.alert_Picture_Box.TabStop = false;
            // 
            // alert_label
            // 
            this.alert_label.AutoSize = true;
            this.alert_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_label.Location = new System.Drawing.Point(229, 293);
            this.alert_label.Name = "alert_label";
            this.alert_label.Size = new System.Drawing.Size(146, 28);
            this.alert_label.TabIndex = 1;
            this.alert_label.Text = "error message";
            // 
            // alert_ok_button
            // 
            this.alert_ok_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_ok_button.Location = new System.Drawing.Point(255, 375);
            this.alert_ok_button.Name = "alert_ok_button";
            this.alert_ok_button.Size = new System.Drawing.Size(90, 65);
            this.alert_ok_button.TabIndex = 2;
            this.alert_ok_button.Text = "Ok";
            this.alert_ok_button.UseVisualStyleBackColor = true;
            this.alert_ok_button.Click += new System.EventHandler(this.alert_ok_button_Click);
            // 
            // AlertMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.alert_ok_button);
            this.Controls.Add(this.alert_label);
            this.Controls.Add(this.alert_Picture_Box);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(93)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AlertMessageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.AlertMessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alert_Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alert_Picture_Box;
        private System.Windows.Forms.Label alert_label;
        private System.Windows.Forms.Button alert_ok_button;
    }
}