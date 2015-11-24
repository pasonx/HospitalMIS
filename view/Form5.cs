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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(String str)
            : this()
        {
            richTextBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
