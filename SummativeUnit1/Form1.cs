// Lauren Steel
// September 19 2017
// Constellation Greeting Card

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummativeUnit1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Click1(object sender, EventArgs e)
        {
            //Front Page 
            BackgroundImage = null;
            capriLabel.Dispose();
            date1Label.Dispose();
            date2Label.Dispose();
            Refresh();
        }

        private void titlelable_Click(object sender, EventArgs e)
        {

        }
    }
}
