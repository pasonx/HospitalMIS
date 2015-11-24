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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //传递给update()
            Person p = new Person();
            p.Id = Convert.ToInt32(richTextBox1.Text);
            p.Medicine = richTextBox2.Text;
            new PersonAction().update(p);
            
            Person p1 = new PersonAction().queryOne(Convert.ToInt32(richTextBox1.Text));
            String str = "挂号业务ID：" + p1.Id + "\n"
                                           + "姓名：" + p1.Name + "\n"
                                           + "年龄：" + p1.Age + "\n"
                                           + "症状：" + p1.Desc + "\n"
                                           + "诊疗方法和建议: " + p1.Medicine + "\n";
            Form5 myForm = new Form5(str);
            myForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
