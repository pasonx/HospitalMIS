using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOK() && textBox1.Text == "root" && textBox2.Text == "123456")
            {
                Form myForm = new Form4();
                myForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("密码错误！请重新输入");
            }
        }
        private bool isOK()
        {
            MySqlConnection mysqlCon = null;
            /*
            string sqlCmd = string.Empty;
            sqlCmd = string.Format("Server=127.0.0.1;Database=test;Uid=root;Pwd=;");
            mysqlCon = new MySqlConnection(sqlCmd);*/
            mysqlCon = DBSource.getConn();
            //The following is a temp test-case
            /*string sqlInsert = "insert into student(id,name,age,descs) values(53784,'pason',22,'12345')";
            MySqlCommand mysqlinsert = new MySqlCommand(sqlInsert,mysqlCon);
            mysqlCon.Open();
            mysqlinsert.ExecuteNonQuery();
            mysqlCon.Close();*/
            /* 检测数据库有没有连接成功 */
            bool isConnectedOk = false;
            try
            {
                mysqlCon.Open();
                isConnectedOk = true;
            }
            catch
            {
                isConnectedOk = false;
                //this.mIsHandlerOK = true;
                MessageBox.Show(this, "连接数据库失败!");
            }
            finally
            {
                mysqlCon.Clone();
            }
            if (!isConnectedOk)
                return false;
            return true;
        }
    }
}

