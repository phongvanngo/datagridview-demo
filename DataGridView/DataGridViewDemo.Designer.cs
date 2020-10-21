namespace DataGridView
{
    partial class DataGridViewDemo
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.TxbPersonID = new System.Windows.Forms.TextBox();
            this.TxbAge = new System.Windows.Forms.TextBox();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbPhoneNumber = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(132, 96);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(132, 54);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(33, 17);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Location = new System.Drawing.Point(132, 12);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(70, 17);
            this.lbPersonID.TabIndex = 3;
            this.lbPersonID.Text = "Person ID";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(132, 138);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lbPhoneNumber.TabIndex = 4;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // TxbPersonID
            // 
            this.TxbPersonID.Location = new System.Drawing.Point(238, 12);
            this.TxbPersonID.Name = "TxbPersonID";
            this.TxbPersonID.Size = new System.Drawing.Size(354, 22);
            this.TxbPersonID.TabIndex = 5;
            // 
            // TxbAge
            // 
            this.TxbAge.Location = new System.Drawing.Point(238, 54);
            this.TxbAge.Name = "TxbAge";
            this.TxbAge.Size = new System.Drawing.Size(354, 22);
            this.TxbAge.TabIndex = 6;
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(238, 96);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(354, 22);
            this.TxbName.TabIndex = 7;
            // 
            // TxbPhoneNumber
            // 
            this.TxbPhoneNumber.Location = new System.Drawing.Point(238, 138);
            this.TxbPhoneNumber.Name = "TxbPhoneNumber";
            this.TxbPhoneNumber.Size = new System.Drawing.Size(354, 22);
            this.TxbPhoneNumber.TabIndex = 8;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(43, 189);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(152, 189);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(98, 23);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(261, 189);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(98, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(370, 189);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(98, 23);
            this.BtnPay.TabIndex = 12;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            // 
            // DataGridViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxbPhoneNumber);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.TxbAge);
            this.Controls.Add(this.TxbPersonID);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridViewDemo";
            this.Text = "DataGridViewDemo";
            this.Load += new System.EventHandler(this.DataGridViewDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox TxbPersonID;
        private System.Windows.Forms.TextBox TxbAge;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.TextBox TxbPhoneNumber;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPay;
    }
}