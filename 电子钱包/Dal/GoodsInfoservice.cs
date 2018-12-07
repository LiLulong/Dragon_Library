using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    //商品信息表中
   public class GoodsInfoservice
    {
       //查询单个商品
       public static GoodsInfo AllGoodsInfoByGoodsID(int GoodsID) 
       {
           string sql = "select * from GoodsInfo where GoodsID=" + GoodsID;
           DataTable dt = DBHelper.GetTable(sql, null);
           if (dt.Rows.Count < 1) 
           {
               return null;
           }
           DataRow dr = dt.Rows[0];
           GoodsInfo goods = new GoodsInfo();//实例化
           goods.GoodsID = (int)dr["GoodsID"];
           goods.GoodsName = (string)dr["GoodsName"];
           goods.GoodsPrice = (decimal)dr["GoodsPrice"];
           goods.GoodsComm = (string)dr["GoodsComm"];
           return goods;
       }
       //通过索引来访问对象进行搜索，排序，操作
       public static List<GoodsInfo> AllGoodsInfo() 
       {
           string sql = "select * from GoodsInfo";
           List<GoodsInfo> list = new List<GoodsInfo>();
           DataTable dt = DBHelper.GetTable(sql, null);
           foreach (DataRow dr in dt.Rows) 
           {
               GoodsInfo GoodsInfo = new GoodsInfo();//实例化
               GoodsInfo.GoodsID = (int)dr["GoodsID"];
               GoodsInfo.GoodsName = (string)dr["GoodsName"];
               GoodsInfo.GoodsPrice = (decimal)dr["GoodsPrice"];
               GoodsInfo.GoodsComm = (string)dr["GoodsComm"];
               list.Add(GoodsInfo);
           }
           return list;
       }
    }
}
