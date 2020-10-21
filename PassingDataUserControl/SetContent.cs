using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingDataUserControl
{

    
    public partial class SetContent : UserControl
    {


        public event ContentUpdateHandler ContentChange;
        private string myContent;
        public SetContent()
        {
            InitializeComponent();
        }

        public string MyContent { get => myContent; set => myContent = value; }

        private void button1_setContent_Click(object sender, EventArgs e)
        {
            myContent = textBox1_Content.Text;
            ContentChange(myContent);
        }
    }
}
