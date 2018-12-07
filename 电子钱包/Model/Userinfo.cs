using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    //用户账户信息表
    public class Userinfo
    {
        //用户帐号
        private string usercardID;

        public string UsercardID
        {
            get { return usercardID; }
            set { usercardID = value; }
        }
        //用户姓名
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        //账户余额
        private decimal userMoney;

        public decimal UserMoney
        {
            get { return userMoney; }
            set { userMoney = value; }
        }
    }
}
