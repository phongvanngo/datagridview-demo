namespace DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelPersonId = new System.Windows.Forms.Label();
            this.labelFristName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProfession = new System.Windows.Forms.Label();
            this.txbPersonID = new System.Windows.Forms.TextBox();
            this.txbProfession = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelPersonId
            // 
            this.labelPersonId.AutoSize = true;
            this.labelPersonId.Location = new System.Drawing.Point(49, 50);
            this.labelPersonId.Name = "labelPersonId";
            this.labelPersonId.Size = new System.Drawing.Size(66, 17);
            this.labelPersonId.TabIndex = 1;
            this.labelPersonId.Text = "PersonID";
            // 
            // labelFristName
            // 
            this.labelFristName.AutoSize = true;
            this.labelFristName.Location = new System.Drawing.Point(230, 49);
            this.labelFristName.Name = "labelFristName";
            this.labelFristName.Size = new System.Drawing.Size(76, 17);
            this.labelFristName.TabIndex = 2;
            this.labelFristName.Text = "Frist Name";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(435, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(671, 49);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(75, 17);
            this.labelProfession.TabIndex = 4;
            this.labelProfession.Text = "Profession";
            // 
            // txbPersonID
            // 
            this.txbPersonID.Location = new System.Drawing.Point(12, 91);
            this.txbPersonID.Name = "txbPersonID";
            this.txbPersonID.Size = new System.Drawing.Size(143, 22);
            this.txbPersonID.TabIndex = 5;
            // 
            // txbProfession
            // 
            this.txbProfession.Location = new System.Drawing.Point(635, 91);
            this.txbProfession.Name = "txbProfession";
            this.txbProfession.Size = new System.Drawing.Size(143, 22);
            this.txbProfession.TabIndex = 6;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(402, 91);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(143, 22);
            this.txName.TabIndex = 7;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(223, 91);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(143, 22);
            this.txbFirstName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txbProfession);
            this.Controls.Add(this.txbPersonID);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFristName);
            this.Controls.Add(this.labelPersonId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DataTableDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelPersonId;
        private System.Windows.Forms.Label labelFristName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.TextBox txbPersonID;
        private System.Windows.Forms.TextBox txbProfession;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txbFirstName;
    }
}

