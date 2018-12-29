using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBhelper
    {
        private static MySqlConnection connection;
        /// <summary>
        /// 获取连接数据库对象
        /// </summary>
        public static MySqlConnection GetConnection
        {
            get
            {
      //          string strConn = "server = localhost; database = test; uid = root; pwd = 123456;Charset=utf8;Convert Zero Datetime=True ; Allow Zero Datetime=True;SslMode = none;"; //设置连接字符串
                                                                                                                                                                                      //     ExeConfigurationFileMap map = new ExeConfigurationFileMap();
                                                                                                                                                                                      //       map.ExeConfigFilename = @"app.config"; ;
                                                                                                                                                                                      //       Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

                string strConn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString; 
                if (connection == null)
                {
                    connection = new MySqlConnection(strConn);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection = new MySqlConnection(strConn);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }

                return connection;
            }
        }
        //创建SqlCommand对象 sql语句不带参数
        public static MySqlCommand Command(string strSql)
        {
            using (MySqlCommand cmd = new MySqlCommand(strSql, GetConnection))
            {
                return cmd;
            }
        }
        //创建SqlCommand对象 sql语句带参数
        public static MySqlCommand Command(string strSql, params SqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(strSql, GetConnection);
            if (values != null) cmd.Parameters.AddRange(values);
            return cmd;
        }
        //返回前向只读的结果集对象 sql语句不带参数(查询)
        public static MySqlDataReader ExecuteReader(string strSql)
        {
            MySqlCommand cmd = new MySqlCommand(strSql, GetConnection);
            return cmd.ExecuteReader();
        }
        public static int DateSet(string strSql)
        {
            
            MySqlCommand com = new MySqlCommand(strSql, GetConnection);
            if (Convert.ToInt32(com.ExecuteScalar()) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static string SelectOne(string str)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(str, GetConnection);
            adapter.Fill(ds);
            string a = ds.Tables[0].Rows[0][0].ToString();
            return a;
          
        }
        public static DataSet Dataset(string str)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(str, GetConnection);
            adapter.Fill(ds);
            return ds;
        }
        public static int ExecuteNonQuery(string strSql)
        {
            MySqlCommand cmd = new MySqlCommand(strSql, GetConnection);
            return cmd.ExecuteNonQuery();
        }
        public static DataTable GetTableBySql(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, GetConnection);
            try
            {
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static object ExecuteScalar(string strSql)
        {
            MySqlCommand cmd = new MySqlCommand(strSql, GetConnection);
            return cmd.ExecuteScalar();
        }
    }
}
