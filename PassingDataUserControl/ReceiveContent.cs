using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace PassingDataUserControl
{
    public partial class ReceiveContent : UserControl
    {
        private string myReceiveContent;

        public ReceiveContent()
        {
            InitializeComponent();
        }

        public string MyReceiveContent { get => myReceiveContent; set
            {
                myReceiveContent = value;
                textBox1_receiveContent.Text = myReceiveContent;
            }
        }
        
    }
}
