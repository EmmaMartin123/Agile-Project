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
            this.alert_Picture_Box.Location = new System.Drawing.Point(321, 132);
            this.alert_Picture_Box.Name = "alert_Picture_Box";
            this.alert_Picture_Box.Size = new System.Drawing.Size(500, 500);
            this.alert_Picture_Box.TabIndex = 0;
            this.alert_Picture_Box.TabStop = false;
            // 
            // alert_message_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 822);
            this.Controls.Add(this.alert_Picture_Box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "alert_message_form";
            this.Text = "alert_message_form";
            this.Load += new System.EventHandler(this.alert_message_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alert_Picture_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox alert_Picture_Box;
    }
}