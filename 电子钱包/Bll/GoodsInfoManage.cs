using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dal;

namespace Bll
{
    public class GoodsInfoManage
    {
        public static GoodsInfo AllGoodsInfoByGoodsID(int GoodsID)
        {
            return GoodsInfoservice.AllGoodsInfoByGoodsID(GoodsID);
        }
        public static List<GoodsInfo> AllGoodsInfo()
        {
            return GoodsInfoservice.AllGoodsInfo();
        }
    }
}
