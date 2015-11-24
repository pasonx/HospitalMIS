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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p1 = new PersonAction().queryOne(Convert.ToInt32(textBox1.Text));
            String str = "挂号业务ID：" + p1.Id + "\n"
                                           + "姓名：" + p1.Name + "\n"
                                           + "年龄：" + p1.Age + "\n"
                                           + "症状：" + p1.Desc + "\n"
                                           + "诊疗方法和建议: " + p1.Medicine + "\n";
            Form myForm = new Form7(str);
            myForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new PersonAction().delete(Convert.ToInt32(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Person> p = new PersonAction().query();
            String str = null;
            for (int i = 0; i < p.Count();i ++)
            {
                str += "挂号业务ID：" + p[i].Id + "\n"
                                           + "姓名：" + p[i].Name + "\n"
                                           + "年龄：" + p[i].Age + "\n"
                                           + "症状：" + p[i].Desc + "\n"
                                           + "诊疗方法和建议: " + p[i].Medicine + "\n\n\n" ;
            }
            Form myForm = new Form8(str);
            myForm.ShowDialog();
        }
    }
}
