using System;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
