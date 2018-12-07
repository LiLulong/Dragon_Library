using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dal;
using System.Data;
using System.Data.SqlClient;

namespace Bll
{
    public class UserInfoxiaofeiManage
    {
        public static DataTable SelectUserxiaofeiinfo()
        {
            return UserxiaofeiInfoservice.SelectUserxiaofeiinfo();
        }
        //添加
        public static bool InsertUserxiaofeiinfo(UserxiaofeiInfo UserxiaofeiInfo)
        {
            return UserxiaofeiInfoservice.InsertUserxiaofeiinfo(UserxiaofeiInfo);
        }
    }
}
