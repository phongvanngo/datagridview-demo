namespace PassingDataUserControl
{
    partial class ReceiveContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1_receiveContent = new System.Windows.Forms.TextBox();
            this.getContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_receiveContent
            // 
            this.textBox1_receiveContent.Location = new System.Drawing.Point(3, 60);
            this.textBox1_receiveContent.Name = "textBox1_receiveContent";
            this.textBox1_receiveContent.Size = new System.Drawing.Size(132, 22);
            this.textBox1_receiveContent.TabIndex = 0;
            // 
            // getContent
            // 
            this.getContent.Location = new System.Drawing.Point(3, 88);
            this.getContent.Name = "getContent";
            this.getContent.Size = new System.Drawing.Size(120, 23);
            this.getContent.TabIndex = 1;
            this.getContent.Text = "GetContent";
            this.getContent.UseVisualStyleBackColor = true;
            // 
            // ReceiveContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getContent);
            this.Controls.Add(this.textBox1_receiveContent);
            this.Name = "ReceiveContent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_receiveContent;
        private System.Windows.Forms.Button getContent;
    }
}
