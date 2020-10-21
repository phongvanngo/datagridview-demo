namespace PassingDataUserControl
{
    partial class Form1
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
            this.receiveContent1 = new PassingDataUserControl.ReceiveContent();
            this.setContent1 = new PassingDataUserControl.SetContent();
            this.SuspendLayout();
            // 
            // receiveContent1
            // 
            this.receiveContent1.Location = new System.Drawing.Point(94, 61);
            this.receiveContent1.Name = "receiveContent1";
            this.receiveContent1.Size = new System.Drawing.Size(150, 150);
            this.receiveContent1.TabIndex = 1;
            // 
            // setContent1
            // 
            this.setContent1.Location = new System.Drawing.Point(340, 95);
            this.setContent1.MyContent = null;
            this.setContent1.Name = "setContent1";
            this.setContent1.Size = new System.Drawing.Size(150, 150);
            this.setContent1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiveContent1);
            this.Controls.Add(this.setContent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SetContent setContent1;
        private ReceiveContent receiveContent1;
    }
}

