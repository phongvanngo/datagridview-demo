namespace Panel_FlowPanel
{
    partial class FlowPanelDemo
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
            this.myFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_render_mybtn = new System.Windows.Forms.Button();
            this.dataGridView_invoice = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // myFlowLayoutPanel
            // 
            this.myFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.myFlowLayoutPanel.Name = "myFlowLayoutPanel";
            this.myFlowLayoutPanel.Size = new System.Drawing.Size(350, 450);
            this.myFlowLayoutPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_render_mybtn
            // 
            this.button_render_mybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_render_mybtn.Location = new System.Drawing.Point(511, 386);
            this.button_render_mybtn.Name = "button_render_mybtn";
            this.button_render_mybtn.Size = new System.Drawing.Size(242, 52);
            this.button_render_mybtn.TabIndex = 1;
            this.button_render_mybtn.Text = "Render MyButton";
            this.button_render_mybtn.UseVisualStyleBackColor = true;
            this.button_render_mybtn.Click += new System.EventHandler(this.button_render_mybtn_Click);
            // 
            // dataGridView_invoice
            // 
            this.dataGridView_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_invoice.Location = new System.Drawing.Point(363, 55);
            this.dataGridView_invoice.Name = "dataGridView_invoice";
            this.dataGridView_invoice.RowHeadersWidth = 51;
            this.dataGridView_invoice.RowTemplate.Height = 24;
            this.dataGridView_invoice.Size = new System.Drawing.Size(404, 150);
            this.dataGridView_invoice.TabIndex = 2;
            this.dataGridView_invoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_invoice_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(374, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 130);
            this.panel1.TabIndex = 3;
            // 
            // FlowPanelDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_invoice);
            this.Controls.Add(this.button_render_mybtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myFlowLayoutPanel);
            this.Name = "FlowPanelDemo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_invoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_render_mybtn;
        private System.Windows.Forms.DataGridView dataGridView_invoice;
        private System.Windows.Forms.Panel panel1;
    }
}

