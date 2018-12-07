using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Dal;
using Bll;
using System.IO.Ports;
using System.Text.RegularExpressions;
using XieCanRFID;

namespace 电子钱包
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定义一个句柄
        private IntPtr handle = IntPtr.Zero;
        //创建检查设备是否连接的方法
        private bool getinvatehandle
        {
            get {
                if (handle == IntPtr.Zero || (int)handle == -1)
                {
                    return false;
                }
                else 
                {
                    return true;
                }

            }
            
        }

       
       
        
 //创建新卡
        private void bttadd_Click(object sender, EventArgs e)
        {
            //如果没有发现可用设备，提示信息
            if (!getinvatehandle)
            {
                MessageBox.Show("请先连接设备！");
                return;
            }
            else if (string.IsNullOrEmpty(txtnewID.Text))
            {
                MessageBox.Show("未检测到可用卡！");
                return;
            }
            else if (UserInfoManage.GetSelectUserinfoByID(txtnewID.Text) != null)
            {
                MessageBox.Show("此卡已经开户，请更换新卡！");
                return;
            }
            else if (string.IsNullOrEmpty(txtmoney.Text))
            {
                MessageBox.Show("请先输入充值金额！");
                return;
            }
            else if (int.Parse(this.txtmoney.Text) <= 0)
            {
                MessageBox.Show("请先输入有效充值金额！");
                return;
            }
            string UserinfoName = this.txtuserName.Text;
            string reg1 = @"^[\u4e00-\u9fa5]+$";
            //如果账户含有中文，则提示信息
            if (!Regex.IsMatch(UserinfoName, reg1)) 
            {
                MessageBox.Show("账户名称只支持中文！");

            }
            try
            {
                byte[] name = Encoding.Default.GetBytes(this.txtuserName.Text);
                if (EPCSDKHelper.FastWriteTag(handle, 0x03, 0, 6, name, 0)) 
                {
                    byte[] id = new byte[12];
                    if (EPCSDKHelper.ReadTag(handle, 0x03, 0, 6, id, 0)) 
                    {
                        Userinfo userinfo = new Userinfo();
                        userinfo.UsercardID = this.txtnewID.Text;
                        userinfo.UserName = UserinfoName;
                        userinfo.UserMoney = decimal.Parse(this.txtmoney.Text);
                        if (UserInfoManage.AddUserinfo(userinfo))
                        {
                            MessageBox.Show("开卡成功！");
                        }
                        else 
                        {
                            MessageBox.Show("开卡失败！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
        //读取新卡号
       private void bttnewRead_Click(object sender, EventArgs e)
        {
            ReadInfo(this.txtnewID, txtuserName);
        }
        //读取标签信息到相关文本框  txtID帐号 txtName账户姓名
       private void ReadInfo(TextBox txtID, TextBox txtname) 
       {
           //如果没有发现可用设备，则提示信息
           if (!getinvatehandle) 
           {
               MessageBox.Show("请连接相关设备！");
               return;
           }
           try
           {
               byte[] tagId = new byte[12];
               byte[] antennaNos = new byte[1];
               byte[] data = new byte[12];
               //获取账户帐号
               if (txtID != null && EPCSDKHelper.IdentifySingleTag(handle, tagId, antennaNos, 0)) 
               {
                   txtID.Text = ConvertHelper.ByteArrayToHexString(tagId);
                   //获取账户姓名
                   if (txtname != null && EPCSDKHelper.ReadTag(handle, 0x03, 0, 6, data, 0)) 
                   {
                       txtname.Text = Encoding.Default.GetString(data);
                   }
               }
           }
           catch (Exception ex)
           {

               MessageBox.Show(ex.Message);
           }
       }
        //窗体加载
       private void Form1_Load(object sender, EventArgs e)
       {
           string[] comList = SerialPort.GetPortNames();
           this.cmbCom.Items.AddRange(comList);
           if (this.cmbCom.Items.Count > 0) 
           {
               this.cmbCom.SelectedIndex=0;
           }
       }
        //连接设备
       private void bttopen_Click(object sender, EventArgs e)
       {
           int portNo = Convert.ToInt32(this.cmbCom.Text.Replace("COM", ""));
           try
           {
               if (!getinvatehandle) 
               {
                   handle = EPCSDKHelper.OpenComm(portNo);
                   if (getinvatehandle)
                   {
                       EPCSDKHelper.StopReading(handle, 0);
                       this.toolStripStatusLabel1.Text = "连接状态：连接";
                       this.toolStripStatusLabel2.Text = "连接的COM口：" + this.cmbCom.Text;
                   }
                   else 
                   {
                       MessageBox.Show("连接设备失败，可能其他管理员端正在连接设备！");
                   }
               }
           }
           catch (Exception ex)
           {

               MessageBox.Show(ex.Message);
           }

       }

       
        //关闭设备
        private void bttclose_Click(object sender, EventArgs e)
       {
           try
           {
               if (getinvatehandle) 
               {
                   EPCSDKHelper.CloseComm(handle);
                   handle = IntPtr.Zero;
                   this.toolStripStatusLabel1.Text = "连接状态：断开";
                   this.toolStripStatusLabel2.Text = "连接的COM口：无";
               }
           }
           catch (Exception ex)
           {

               MessageBox.Show(ex.Message);
           }
       }

        
        //按卡号\账户名称查询
       private void btnSelect_Click(object sender, EventArgs e)
        {
            string userInfoName = this.txtidno.Text;
            if (string.IsNullOrEmpty(this.txtidno.Text))
            {
                this.dgvUser.DataSource = UserInfoManage.GetAllUserinfos();
            }
            else 
            {
                this.dgvUser.DataSource = UserInfoManage.GetSelectUserinfoByIDOrName(userInfoName);
            }
        }
 //购买商品
       private void bttgoodsshooping_Click(object sender, EventArgs e)
       {
           //如果未检测到可用卡，则提示信息
           if (string.IsNullOrEmpty(txtGoodsuserID.Text))
           {
               MessageBox.Show("未检测到可用账户！");
               return;
           }
           else 
           {
               Userinfo userinfo = UserInfoManage.GetSelectUserinfoByID(txtGoodsuserID.Text);
               if (userinfo == null) 
               {
                   MessageBox.Show("此卡还未开通，请开卡或者换卡！");
                   return;
               }
               else if (string.IsNullOrEmpty(txtGoodsID.Text))
               {
                   MessageBox.Show("请先选择购买商品！");
                   return;
               }
               else 
               {
                   decimal result = userinfo.UserMoney - Convert.ToDecimal(this.txtGoodsPrice.Text);
                   if (result < 0) 
                   {
                       MessageBox.Show("此卡余额不足，请充值后购买！");
                       return;
                   }
               }
           }
           UserxiaofeiInfo userxiaofei = new UserxiaofeiInfo();
           userxiaofei.UsercardID = Convert.ToString(this.txtGoodsuserID.Text);
           userxiaofei.GoodsID = Convert.ToInt32(this.txtGoodsID.Text);
           userxiaofei.Userxiaomoney = Convert.ToDecimal(this.txtGoodsPrice.Text);
           userxiaofei.UserTime = DateTime.Now;
           if (UserxiaofeiInfoservice.InsertUserxiaofeiinfo(userxiaofei))
           {
               MessageBox.Show("商品购买成功！");
           }
           else 
           {
               MessageBox.Show("商品购买失败！");
           }
       }

       private void bttmoney_Click(object sender, EventArgs e)
       {
           //如果未检测到可用卡，则提示信息
           if (string.IsNullOrEmpty(txtxiaofeiID.Text)) 
           {
               MessageBox.Show("未检测到可用账户！");
               return;
           }
           else if(UserInfoManage.GetSelectUserinfoByID(txtxiaofeiID.Text)==null)
           {
               MessageBox.Show("此卡还未开通，请开卡或换卡!");
               return;
           }
           else if (string.IsNullOrEmpty(txtxiaofeiMoney.Text)) 
           {
               MessageBox.Show("请先输入充值金额！");
               return;
           }
           else if (int.Parse(this.txtxiaofeiMoney.Text) <= 0) 
           {
               MessageBox.Show("请输入有效的充值金额！");
               return;
           }
           Userinfo userinfo = new Userinfo();
           userinfo.UsercardID = this.txtxiaofeiID.Text;
           userinfo.UserName = this.txtxiaofeiName.Text;
           userinfo.UserMoney = decimal.Parse(this.txtxiaofeiMoney.Text);
           if (UserInfoManage.UpdateUserinfo(userinfo)) 
           {
               MessageBox.Show("充值成功！");
           }
       }

       private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (tabControl1.SelectedTab == tpplus) //创建新卡选项卡
           {
               ReadInfo(txtxiaofeiID, txtxiaofeiName);
           }
           else if(tabControl1.SelectedTab==tpplus)//账户充值选项卡
           {
               while (getinvatehandle && string.IsNullOrEmpty(txtxiaofeiID.Text))
                   ReadInfo(txtxiaofeiID, txtxiaofeiName);
           }
           else if (tabControl1.SelectedTab == tpselect)//账户查询选项卡 
           {
               this.dgvUser.DataSource = UserInfoManage.GetAllUserinfos();
           }
           else if (tabControl1.SelectedTab == tpMinus) //消费记录选项卡
           {
               this.dgv.DataSource = UserInfoxiaofeiManage.SelectUserxiaofeiinfo();
           }
           else if (tabControl1.SelectedTab == tpgoods) //商品购物选项卡
           {
               this.listView1.Items.Clear();//清空列表
               this.listView1.View = View.LargeIcon;//视图样式 

               List<GoodsInfo> list = GoodsInfoManage.AllGoodsInfo();
               foreach (GoodsInfo model in list)
               {
                   ListViewItem item = new ListViewItem();
                   item.SubItems[0].Text = model.GoodsName + "\n\t￥" + Math.Round(Convert.ToDecimal(model.GoodsPrice),2);
                   item.Name = model.GoodsID.ToString();
                   item.ImageIndex = model.GoodsID - 1000;
                   this.listView1.Items.Add(item);
               }
               if (listView1.Items.Count > 0) 
               {
                   listView1.Select();
                   listView1.Items[0].Selected = true;
               }
               while (getinvatehandle && string.IsNullOrEmpty(txtGoodsuserID.Text))
                   ReadInfo(txtGoodsuserID, txtGoodsuserName);
           }
       }

       private void btnplusread_Click(object sender, EventArgs e)
       {
           ReadInfo(txtxiaofeiID, txtxiaofeiName);
       }

       private void btngoodsread_Click(object sender, EventArgs e)
       {
           ReadInfo(txtGoodsuserID, txtGoodsuserName);
       }

       private void listView1_SelectedIndexChanged(object sender, EventArgs e)
       {
           if(listView1.SelectedItems==null||listView1.SelectedItems.Count<1)
           {
               return;
           }
           ListViewItem item = listView1.SelectedItems[0];
           int id = Convert.ToInt32(item.Name);
           GoodsInfo goodinfo = GoodsInfoManage.AllGoodsInfoByGoodsID(id);
           if (goodinfo != null)
           {
               this.txtGoodsID.Text = goodinfo.GoodsID.ToString();
               this.txtGoodsName.Text = goodinfo.GoodsName;
               this.txtGoodsPrice.Text = Math.Round(Convert.ToDecimal(goodinfo.GoodsPrice), 2).ToString();
               this.bttgoodsshooping.Enabled = true;
           }
           else 
           {
               MessageBox.Show("该商品不存在！");
           }
       }
       

    }
}
