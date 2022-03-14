namespace zadanie4
{
    partial class Receiver
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
            this.textboxmessagereceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxmessagereceived
            // 
            this.textboxmessagereceived.Location = new System.Drawing.Point(196, 91);
            this.textboxmessagereceived.Multiline = true;
            this.textboxmessagereceived.Name = "textboxmessagereceived";
            this.textboxmessagereceived.Size = new System.Drawing.Size(295, 200);
            this.textboxmessagereceived.TabIndex = 0;
            // 
            // Receiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 388);
            this.Controls.Add(this.textboxmessagereceived);
            this.MaximizeBox = false;
            this.Name = "Receiver";
            this.Text = "Receiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textboxmessagereceived;
    }
}