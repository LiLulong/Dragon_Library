using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    //消费信息表
    public class UserxiaofeiInfo
    {
        //用户卡号
        private string usercardID;

        public string UsercardID
        {
            get { return usercardID; }
            set { usercardID = value; }
        }
        //商品编号
        private int goodsID;

        public int GoodsID
        {
            get { return goodsID; }
            set { goodsID = value; }
        }
        //消费金额
        private decimal userxiaomoney;

        public decimal Userxiaomoney
        {
            get { return userxiaomoney; }
            set { userxiaomoney = value; }
        }
        //消费时间
        private DateTime userTime;

        public DateTime UserTime
        {
            get { return userTime; }
            set { userTime = value; }
        }
    }
}
