using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interaction_UserControl
{
    public partial class SetContent : UserControl
    {

        private string myContent;
        public SetContent()
        {
            InitializeComponent();
        }

        public string MyContent { get => myContent; set => myContent = value; }
    }
}
