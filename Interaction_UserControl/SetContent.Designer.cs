namespace Interaction_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1_SetContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_Content
            // 
            this.textBox1_Content.Location = new System.Drawing.Point(0, 54);
            this.textBox1_Content.Name = "textBox1_Content";
            this.textBox1_Content.Size = new System.Drawing.Size(318, 22);
            this.textBox1_Content.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Content";
            // 
            // button1_SetContent
            // 
            this.button1_SetContent.Location = new System.Drawing.Point(243, 99);
            this.button1_SetContent.Name = "button1_SetContent";
            this.button1_SetContent.Size = new System.Drawing.Size(75, 23);
            this.button1_SetContent.TabIndex = 2;
            this.button1_SetContent.Text = "Set";
            this.button1_SetContent.UseVisualStyleBackColor = true;
            // 
            // SetContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1_SetContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_Content);
            this.Name = "SetContent";
            this.Size = new System.Drawing.Size(321, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_SetContent;
    }
}
