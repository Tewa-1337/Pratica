using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mishaninprjc
{
    public partial class statForm : Form
    {
        public statForm()
        {
            InitializeComponent();
        }

        private void achsumLabel_Click(object sender, EventArgs e)
        {

        }

        private void pointsumLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.Show();
            Close();
        }
    }
}
