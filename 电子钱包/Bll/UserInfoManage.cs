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
    public class UserInfoManage
    {
        //初始化金额
        public static bool AddUserinfo(Userinfo userinfo)
        {
            return Uaerinfoservice.AddUserinfo(userinfo);
        }
        //查询所有
        public static DataTable GetAllUserinfos()
        {
            return Uaerinfoservice.GetAllUserinfos();
        }
        //按卡号/帐号名称查询
        public static DataTable GetSelectUserinfoByIDOrName(string value)
        {
            return Uaerinfoservice.GetSelectUserinfoByIDOrName(value);
        }
        public static Userinfo GetSelectUserinfoByID(string byID)
        {
            return Uaerinfoservice.GetSelectUserinfoByID(byID);
        }
        //账户充值
        public static bool UpdateUserinfo(Userinfo userinfo)
        {
            return Uaerinfoservice.UpdateUserinfo(userinfo);
        }
    }
}
