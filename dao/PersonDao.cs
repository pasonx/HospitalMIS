using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class PersonDao
    {
        public void add(Person p)
        {
            MySqlConnection conn = DBSource.getConn();
            
            String sqlInsert = "insert into person(id,name,age,descs) values("+p.Id+",'"+p.Name+"',"+p.Age+",'"+p.Desc+"')";
            MySqlCommand mysqlinsert = new MySqlCommand(sqlInsert,conn);
            conn.Open();
            mysqlinsert.ExecuteNonQuery();
            conn.Close();

        }
        public void update(Person p)
        {
            MySqlConnection conn = DBSource.getConn();
            String sqlUpdate = "update person set medicine = '" + p.Medicine + "' where id =" + p.Id + "";
            MySqlCommand mysqlupdate = new MySqlCommand(sqlUpdate, conn);
            conn.Open();
            mysqlupdate.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(int id)
        {
            MySqlConnection conn = DBSource.getConn();
            String sqlDelete = "delete from person where id = " + id + "";
            MySqlCommand mysqldelete = new MySqlCommand(sqlDelete, conn);
            conn.Open();
            mysqldelete.ExecuteNonQuery();
            conn.Close();
        }
        public List<Person> query()
        {
            MySqlConnection conn = DBSource.getConn();
            String sqlSearch = "select * from person";
            MySqlCommand mysqlcommand = new MySqlCommand(sqlSearch, conn);
            conn.Open();
            MySqlDataReader reader = mysqlcommand.ExecuteReader();
            List<Person> person = new List<Person>();
            Person p = null;
            try
            {
                while (reader.Read())
                {
                    p = new Person();
                    if (reader.HasRows)
                    {
                        p.Id = reader.GetInt32(0);
                        p.Name = reader.GetString(1);
                        p.Age = reader.GetInt32(2);
                        p.Desc = reader.GetString(3);
                        p.Medicine = reader.GetString(4);
                        //Console.WriteLine(" 姓名:  " + reader.GetString(1) + "  编号  " + reader.GetInt32(0) + "  地址  " + reader.GetString(2));
                    }
                    person.Add(p);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("查询失败!" + ex.Message);
            }
            finally
            {
                reader.Close();
            }
            conn.Close();

           return person;
        }
        public Person queryOne(int id)
        {
            MySqlConnection conn = DBSource.getConn();
            String sqlSearch = "select * from person where id = " + id + "";
            MySqlCommand mysqlcommand = new MySqlCommand(sqlSearch, conn);
            conn.Open();
            MySqlDataReader reader = mysqlcommand.ExecuteReader();
            Person p = null;
            try
            {
                while (reader.Read())
                {
                    p = new Person();
                    if (reader.HasRows)
                    {
                        p.Id = reader.GetInt32(0);
                        p.Name = reader.GetString(1);
                        p.Age = reader.GetInt32(2);
                        p.Desc = reader.GetString(3);
                        p.Medicine = reader.GetString(4);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("查询失败!" + ex.Message);
            }
            finally
            {
                reader.Close();
            }
            conn.Close();
           
            return p;
        }
    }
}
