using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Dal
{
    public class DBHelper
    {
        //创建连接字段
        static string constr = ConfigurationManager.ConnectionStrings["SIConnectionString"].ConnectionString;
        //数据连接设为空
        static SqlConnection sqlconn = null;
        //创建一个新的把constr加入里面
        static DBHelper() 
        {
            sqlconn = new SqlConnection(constr);
        }
        //查询
        
        public static DataTable GetTable(string sql, SqlParameter[] sqlParams = null) 
        {
            SqlDataAdapter sqldapter = new SqlDataAdapter(sql, sqlconn);
            if (sqlParams != null) 
            {
                sqldapter.SelectCommand.Parameters.AddRange(sqlParams);
            }
            DataTable ds = new DataTable();
            sqldapter.Fill(ds);
            return ds;
        }
        //添加、删除、修改
        public static bool ExcuteCommand(string sql, SqlParameter[] sqlParams = null) 
        {
            bool flag = false;
            try
            {
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
                if (sqlParams != null)
                {
                    sqlcmd.Parameters.AddRange(sqlParams);
                }
                if (sqlcmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (sqlconn.State == ConnectionState.Open) 
                {
                    sqlconn.Close();
                }
            }
            return flag;
        }
    }
}
