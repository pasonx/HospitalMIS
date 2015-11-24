using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form myForm1 = new Form2();
            myForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form myForm = new Form6();
            myForm.ShowDialog();
        }
    }
}
