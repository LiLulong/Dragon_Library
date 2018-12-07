using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Dal
{
    public class UserxiaofeiInfoservice
    {
        //查询所有
        public static DataTable SelectUserxiaofeiinfo() 
        {
            string sql = "select Userinfo.UsercardID,UserName,GoodsName,Userxiaomoney,UserTime from Userinfo,GoodsInfo,UserxiaofeiInfo ";
            sql += " where GoodsInfo.GoodsID=UserxiaofeiInfo.GoodsID and Userinfo.UsercardID=UserxiaofeiInfo.UsercardID";
            return DBHelper.GetTable(sql, null);
        }
        //添加
        public static bool InsertUserxiaofeiinfo(UserxiaofeiInfo UserxiaofeiInfo) 
        {
            string sql = "insert into UserxiaofeiInfo values(@UsercardID,@GoodsID,@Userxiaomoney,@UserTime)";
            sql += "; update Userinfo set UserMoney=(UserMoney-@Userxiaomoney) where UsercardID=@UsercardID";
            SqlParameter[] sqlpa ={
                                      new SqlParameter("@UsercardID",UserxiaofeiInfo.UsercardID),
                                      new SqlParameter("@GoodsID",UserxiaofeiInfo.GoodsID),
                                      new SqlParameter("@Userxiaomoney",UserxiaofeiInfo.Userxiaomoney),
                                      new SqlParameter("@UserTime",UserxiaofeiInfo.UserTime)
                                  };
            return DBHelper.ExcuteCommand(sql, sqlpa);
        }
    }
}
