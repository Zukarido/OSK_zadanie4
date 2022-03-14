namespace zadanie4
{
    partial class Transmitter
    {
        /// <summary>
        /// Required designer variable.
        private Receiver newreceiver; 
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
            this.textboxmessagetransmitted = new System.Windows.Forms.TextBox();
            this.buttonsend = new System.Windows.Forms.Button();
            this.buttoncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxmessagetransmitted
            // 
            this.textboxmessagetransmitted.Location = new System.Drawing.Point(213, 12);
            this.textboxmessagetransmitted.Multiline = true;
            this.textboxmessagetransmitted.Name = "textboxmessagetransmitted";
            this.textboxmessagetransmitted.Size = new System.Drawing.Size(200, 200);
            this.textboxmessagetransmitted.TabIndex = 0;
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(319, 227);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(94, 23);
            this.buttonsend.TabIndex = 1;
            this.buttonsend.Text = "send message";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // buttoncode
            // 
            this.buttoncode.Location = new System.Drawing.Point(213, 227);
            this.buttoncode.Name = "buttoncode";
            this.buttoncode.Size = new System.Drawing.Size(100, 23);
            this.buttoncode.TabIndex = 2;
            this.buttoncode.Text = "code message";
            this.buttoncode.UseVisualStyleBackColor = true;
            this.buttoncode.Click += new System.EventHandler(this.buttoncode_Click);
            // 
            // Transmitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 313);
            this.Controls.Add(this.buttoncode);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.textboxmessagetransmitted);
            this.MaximizeBox = false;
            this.Name = "Transmitter";
            this.Text = "Transmitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxmessagetransmitted;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.Button buttoncode;
    }
}

