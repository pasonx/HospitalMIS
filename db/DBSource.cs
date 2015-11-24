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
    class DBSource
    {
        private static readonly String SERVER = "127.0.0.1";
        private static readonly String DB_NAME = "hospital";
        private static readonly String USER = "root";
        private static readonly String PASSWD = "";
        private static MySqlConnection mysqlCon = null;
        private static String connStr = null;

        public static MySqlConnection getConn()
        {
            
            connStr = string.Empty;
            connStr = string.Format("Charset=utf8;Server=" + SERVER + ";Database=" + DB_NAME + ";Uid=" + USER + ";Pwd=" + PASSWD + ";");
            mysqlCon = new MySqlConnection(connStr);
            return mysqlCon;
            
        }
    }
}
