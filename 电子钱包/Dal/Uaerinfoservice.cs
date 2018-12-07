using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model;


namespace Dal
{
    //用户信息表中
    public class Uaerinfoservice
    {
       //初始化金额
        public static bool AddUserinfo(Userinfo userinfo) 
        {
            string sql = "insert into Userinfo values(@UsercardID,@UserName,@UserMoney)";
            SqlParameter[] sqlpa ={
                                     new SqlParameter("@UsercardID",userinfo.UsercardID),
                                     new SqlParameter("@UserName",userinfo.UserName),
                                     new SqlParameter("@UserMoney",userinfo.UserMoney)
                                 };
            return DBHelper.ExcuteCommand(sql, sqlpa);
        }
        //查询所有
        public static DataTable GetAllUserinfos() 
        {
            string sql = "select * from Userinfo";
            return DBHelper.GetTable(sql, null);
        }
        //按卡号/帐号名称查询
        public static DataTable GetSelectUserinfoByIDOrName(string value) 
        {
            string sql = "select * from Userinfo where UsercardID like '%'+@UsercardID+'%' or UserName like '%'+@UsercardID+'%'";
            SqlParameter[] sqlpa ={
                                     new SqlParameter("@UsercardID",value)
                                 };
            return DBHelper.GetTable(sql, sqlpa);
        }
        //按卡号来查询
        public static Userinfo GetSelectUserinfoByID(string byID) 
        {
            string sql = "select * from Userinfo where UsercardID='" + byID + "'";
            DataTable dt = DBHelper.GetTable(sql);
            if (dt.Rows.Count < 1) 
            {
                return null;
            }
            DataRow dr = dt.Rows[0];
            Userinfo userin = new Userinfo();//实例化
            userin.UsercardID = byID;
            userin.UserName = (string)dr["UserName"];
            userin.UserMoney = (decimal)dr["UserMoney"];
            return userin;
        }
        //账户充值
        public static bool UpdateUserinfo(Userinfo userinfo) 
        {
            string sql = "update Userinfo set UserMoney=UserMoney+@UserMoney where UsercardID=@UsercardID";
            SqlParameter[] sqlpa ={
                                     new SqlParameter("@UserMoney",userinfo.UserMoney),
                                     new SqlParameter("@UsercardID",userinfo.UsercardID)
                                 };
            return DBHelper.ExcuteCommand(sql, sqlpa);
        }

    }
}
