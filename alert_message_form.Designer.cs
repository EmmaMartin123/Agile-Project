namespace ATM_forms
{
    partial class alert_message_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert_message_form));
            this.alert_Picture_Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alert_Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // alert_Picture_Box
            // 
            this.alert_Picture_Box.Image = ((System.Drawing.Image)(resources.GetObject("alert_Picture_Box.Image")));
            this.alert_Picture_Box.Location = new System.Drawing.Point(482, 203);
            this.alert_Picture_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alert_Picture_Box.Name = "alert_Picture_Box";
            this.alert_Picture_Box.Size = new System.Drawing.Size(750, 769);
            this.alert_Picture_Box.TabIndex = 0;
            this.alert_Picture_Box.TabStop = false;
            // 
            // alert_message_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 1050);
            this.Controls.Add(this.alert_Picture_Box);
            this.Name = "alert_message_form";
            this.Text = "alert_message_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.alert_message_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alert_Picture_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox alert_Picture_Box;
    }
}