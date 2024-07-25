using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox1
{
    public partial class FCheckBox : Form
    {
        private FCheckBox2 fm2 = new FCheckBox2();
        public FCheckBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            if (checkBox1.Checked == true)
            {
                txtName.Text = txtName.Text + "(Inglés)";
            }
            if (checkBox2.Checked == true)
            {
                txtName.Text = txtName.Text + "(Francés)";
            }
            if (checkBox3.Checked == true)
            {
                txtName.Text = txtName.Text + "(Alemán)";
            }
        }

        private void mensajeDeAceptacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm2.ShowDialog();
        }
    }
}
