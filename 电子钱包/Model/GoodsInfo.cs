using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    //商品信息表
    public class GoodsInfo
    {
        //商品编号
        private int goodsID;

        public int GoodsID
        {
            get { return goodsID; }
            set { goodsID = value; }
        }
        private string goodsName;
        //商品名称
        public string GoodsName
        {
            get { return goodsName; }
            set { goodsName = value; }
        }
        //商品价格
        private decimal goodsPrice;

        public decimal GoodsPrice
        {
            get { return goodsPrice; }
            set { goodsPrice = value; }
        }
        //商品备注
        private string goodsComm;

        public string GoodsComm
        {
            get { return goodsComm; }
            set { goodsComm = value; }
        }
    }
}
