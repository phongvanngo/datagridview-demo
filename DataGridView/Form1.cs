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
    public partial class Form1 : Form
    {
        public List<Person> People { get; set; }
        public Form1()
        {
            People = GetPeople();
            InitializeComponent();
        }

        private List<Person> GetPeople()
        {
            var list = new List<Person>();
            list.Add(new Person()
            {
                Name = "Person",
                PersonId = 0,
                Surname = "surname",
                Profession = "profession"
            });
            list.Add(new Person()
            {
                Name = "Person 1",
                PersonId = 1,
                Surname = "surname 1 ",
                Profession = "profession 1"
            });
            list.Add(new Person()
            {
                Name = "Person 2",
                PersonId = 2,
                Surname = "surname 2",
                Profession = "profession 2"
            });

            return list;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var People = this.People;
            dataGridView1.DataSource = People;
            dataGridView1.Columns["PersonID"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
