using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingDataUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setContent1.MyContent = "24324";
            receiveContent1.MyReceiveContent = setContent1.MyContent;
            setContent1.ContentChange += SetContent1_ContentChange;
        }

        private void SetContent1_ContentChange(string s)
        {
            MessageBox.Show("Set Button Clicked");
        }
    }
}
