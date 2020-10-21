using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class DataGridViewDemo : Form
    {
        private DataTable StudentList = new DataTable();
        private int SelectedRowIndex;
        public DataGridViewDemo()
        {
            InitializeComponent();
        }

        private void DataGridViewDemo_Load(object sender, EventArgs e)
        {
            StudentList.Columns.Add("PersonID", typeof(int));
            StudentList.Columns.Add("Name", typeof(string));
            StudentList.Columns.Add("Age", typeof(int));
            StudentList.Columns.Add("Phone Number", typeof(string));
            dataGridView1.DataSource = StudentList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            StudentList.Rows.Add(TxbPersonID.Text,TxbName.Text,TxbAge.Text,TxbPhoneNumber.Text);
            dataGridView1.DataSource = StudentList;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[SelectedRowIndex];
            TxbPersonID.Text = selectedRow.Cells[0].Value.ToString();
            TxbName.Text = selectedRow.Cells[1].Value.ToString();
            TxbAge.Text = selectedRow.Cells[2].Value.ToString();
            TxbPhoneNumber.Text = selectedRow.Cells[3].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewRowData = dataGridView1.Rows[SelectedRowIndex];
            try
            {
                NewRowData.Cells[0].Value = TxbPersonID.Text;     
                NewRowData.Cells[1].Value = TxbName.Text;     
                NewRowData.Cells[2].Value = TxbAge.Text;     
                NewRowData.Cells[3].Value = TxbPhoneNumber.Text;     

            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Input");
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(SelectedRowIndex);
            TxbPersonID.Text = "";
            TxbName.Text = "";
            TxbAge.Text = "";
            TxbPhoneNumber.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
