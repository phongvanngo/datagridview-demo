namespace PassingDataUserControl
{
    partial class SetContent
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
            this.textBox1_Content = new System.Windows.Forms.TextBox();
            this.button1_setContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_Content
            // 
            this.textBox1_Content.Location = new System.Drawing.Point(3, 30);
            this.textBox1_Content.Name = "textBox1_Content";
            this.textBox1_Content.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Content.TabIndex = 0;
            // 
            // button1_setContent
            // 
            this.button1_setContent.Location = new System.Drawing.Point(3, 58);
            this.button1_setContent.Name = "button1_setContent";
            this.button1_setContent.Size = new System.Drawing.Size(115, 23);
            this.button1_setContent.TabIndex = 1;
            this.button1_setContent.Text = "Set Content";
            this.button1_setContent.UseVisualStyleBackColor = true;
            this.button1_setContent.Click += new System.EventHandler(this.button1_setContent_Click);
            // 
            // SetContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1_setContent);
            this.Controls.Add(this.textBox1_Content);
            this.Name = "SetContent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_Content;
        private System.Windows.Forms.Button button1_setContent;
    }
}
