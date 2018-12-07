namespace 电子钱包
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.bttopen = new System.Windows.Forms.Button();
            this.bttclose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.bttadd = new System.Windows.Forms.Button();
            this.bttnewRead = new System.Windows.Forms.Button();
            this.txtnewID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpplus = new System.Windows.Forms.TabPage();
            this.bttmoney = new System.Windows.Forms.Button();
            this.btnplusread = new System.Windows.Forms.Button();
            this.txtxiaofeiMoney = new System.Windows.Forms.TextBox();
            this.txtxiaofeiName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxiaofeiID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpMinus = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpselect = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpgoods = new System.Windows.Forms.TabPage();
            this.bttgoodsshooping = new System.Windows.Forms.Button();
            this.btngoodsread = new System.Windows.Forms.Button();
            this.txtGoodsPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.txtGoodsuserName = new System.Windows.Forms.TextBox();
            this.txtGoodsuserID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpplus.SuspendLayout();
            this.tpMinus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tpselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tpgoods.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择连接串口:";
            // 
            // cmbCom
            // 
            this.cmbCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(216, 26);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(299, 22);
            this.cmbCom.TabIndex = 1;
            // 
            // bttopen
            // 
            this.bttopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttopen.Location = new System.Drawing.Point(546, 24);
            this.bttopen.Name = "bttopen";
            this.bttopen.Size = new System.Drawing.Size(75, 23);
            this.bttopen.TabIndex = 2;
            this.bttopen.Text = "连接";
            this.bttopen.UseVisualStyleBackColor = true;
            this.bttopen.Click += new System.EventHandler(this.bttopen_Click);
            // 
            // bttclose
            // 
            this.bttclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttclose.Location = new System.Drawing.Point(648, 24);
            this.bttclose.Name = "bttclose";
            this.bttclose.Size = new System.Drawing.Size(75, 23);
            this.bttclose.TabIndex = 3;
            this.bttclose.Text = "关闭";
            this.bttclose.UseVisualStyleBackColor = true;
            this.bttclose.Click += new System.EventHandler(this.bttclose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpplus);
            this.tabControl1.Controls.Add(this.tpMinus);
            this.tabControl1.Controls.Add(this.tpselect);
            this.tabControl1.Controls.Add(this.tpgoods);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 463);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtmoney);
            this.tabPage1.Controls.Add(this.txtuserName);
            this.tabPage1.Controls.Add(this.bttadd);
            this.tabPage1.Controls.Add(this.bttnewRead);
            this.tabPage1.Controls.Add(this.txtnewID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "创建新卡";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(460, 218);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(118, 22);
            this.txtmoney.TabIndex = 7;
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(160, 219);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(190, 22);
            this.txtuserName.TabIndex = 6;
            // 
            // bttadd
            // 
            this.bttadd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttadd.Location = new System.Drawing.Point(252, 287);
            this.bttadd.Name = "bttadd";
            this.bttadd.Size = new System.Drawing.Size(116, 38);
            this.bttadd.TabIndex = 5;
            this.bttadd.Text = "创建新卡";
            this.bttadd.UseVisualStyleBackColor = true;
            this.bttadd.Click += new System.EventHandler(this.bttadd_Click);
            // 
            // bttnewRead
            // 
            this.bttnewRead.Location = new System.Drawing.Point(470, 52);
            this.bttnewRead.Name = "bttnewRead";
            this.bttnewRead.Size = new System.Drawing.Size(75, 23);
            this.bttnewRead.TabIndex = 4;
            this.bttnewRead.Text = "读取";
            this.bttnewRead.UseVisualStyleBackColor = true;
            this.bttnewRead.Click += new System.EventHandler(this.bttnewRead_Click);
            // 
            // txtnewID
            // 
            this.txtnewID.Location = new System.Drawing.Point(124, 56);
            this.txtnewID.Name = "txtnewID";
            this.txtnewID.ReadOnly = true;
            this.txtnewID.Size = new System.Drawing.Size(311, 22);
            this.txtnewID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "初始金额：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "账户名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "卡号:";
            // 
            // tpplus
            // 
            this.tpplus.Controls.Add(this.bttmoney);
            this.tpplus.Controls.Add(this.btnplusread);
            this.tpplus.Controls.Add(this.txtxiaofeiMoney);
            this.tpplus.Controls.Add(this.txtxiaofeiName);
            this.tpplus.Controls.Add(this.label7);
            this.tpplus.Controls.Add(this.label6);
            this.tpplus.Controls.Add(this.txtxiaofeiID);
            this.tpplus.Controls.Add(this.label5);
            this.tpplus.Location = new System.Drawing.Point(4, 26);
            this.tpplus.Name = "tpplus";
            this.tpplus.Padding = new System.Windows.Forms.Padding(3);
            this.tpplus.Size = new System.Drawing.Size(758, 433);
            this.tpplus.TabIndex = 1;
            this.tpplus.Text = "账户充值";
            this.tpplus.UseVisualStyleBackColor = true;
            // 
            // bttmoney
            // 
            this.bttmoney.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttmoney.Location = new System.Drawing.Point(371, 272);
            this.bttmoney.Name = "bttmoney";
            this.bttmoney.Size = new System.Drawing.Size(106, 38);
            this.bttmoney.TabIndex = 7;
            this.bttmoney.Text = "账户充值";
            this.bttmoney.UseVisualStyleBackColor = true;
            this.bttmoney.Click += new System.EventHandler(this.bttmoney_Click);
            // 
            // btnplusread
            // 
            this.btnplusread.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplusread.Location = new System.Drawing.Point(60, 272);
            this.btnplusread.Name = "btnplusread";
            this.btnplusread.Size = new System.Drawing.Size(97, 38);
            this.btnplusread.TabIndex = 6;
            this.btnplusread.Text = "识别卡号";
            this.btnplusread.UseVisualStyleBackColor = true;
            this.btnplusread.Click += new System.EventHandler(this.btnplusread_Click);
            // 
            // txtxiaofeiMoney
            // 
            this.txtxiaofeiMoney.Location = new System.Drawing.Point(486, 178);
            this.txtxiaofeiMoney.Name = "txtxiaofeiMoney";
            this.txtxiaofeiMoney.Size = new System.Drawing.Size(122, 25);
            this.txtxiaofeiMoney.TabIndex = 5;
            // 
            // txtxiaofeiName
            // 
            this.txtxiaofeiName.Location = new System.Drawing.Point(163, 174);
            this.txtxiaofeiName.Name = "txtxiaofeiName";
            this.txtxiaofeiName.ReadOnly = true;
            this.txtxiaofeiName.Size = new System.Drawing.Size(179, 25);
            this.txtxiaofeiName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "充值金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "账户名称：";
            // 
            // txtxiaofeiID
            // 
            this.txtxiaofeiID.Location = new System.Drawing.Point(147, 47);
            this.txtxiaofeiID.Name = "txtxiaofeiID";
            this.txtxiaofeiID.ReadOnly = true;
            this.txtxiaofeiID.Size = new System.Drawing.Size(240, 25);
            this.txtxiaofeiID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "卡号：";
            // 
            // tpMinus
            // 
            this.tpMinus.Controls.Add(this.dgv);
            this.tpMinus.Location = new System.Drawing.Point(4, 26);
            this.tpMinus.Name = "tpMinus";
            this.tpMinus.Padding = new System.Windows.Forms.Padding(3);
            this.tpMinus.Size = new System.Drawing.Size(758, 433);
            this.tpMinus.TabIndex = 2;
            this.tpMinus.Text = "消费记录";
            this.tpMinus.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(752, 352);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UsercardID";
            this.Column1.HeaderText = "卡号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "用户名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GoodsName";
            this.Column3.HeaderText = "商品名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Userxiaomoney";
            this.Column4.HeaderText = "消费金额";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UserTime";
            this.Column5.HeaderText = "消费时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tpselect
            // 
            this.tpselect.Controls.Add(this.dgvUser);
            this.tpselect.Controls.Add(this.btnSelect);
            this.tpselect.Controls.Add(this.txtidno);
            this.tpselect.Controls.Add(this.label8);
            this.tpselect.Location = new System.Drawing.Point(4, 26);
            this.tpselect.Name = "tpselect";
            this.tpselect.Padding = new System.Windows.Forms.Padding(3);
            this.tpselect.Size = new System.Drawing.Size(758, 433);
            this.tpselect.TabIndex = 3;
            this.tpselect.Text = "账户查询";
            this.tpselect.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvUser.Location = new System.Drawing.Point(-7, 68);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(752, 362);
            this.dgvUser.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "UsercardID";
            this.Column6.HeaderText = "卡号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "UserName";
            this.Column7.HeaderText = "用户名";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "UserMoney";
            this.Column8.HeaderText = "金额";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(495, 24);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtidno
            // 
            this.txtidno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidno.Location = new System.Drawing.Point(179, 24);
            this.txtidno.Name = "txtidno";
            this.txtidno.Size = new System.Drawing.Size(250, 25);
            this.txtidno.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "卡号/账户名称：";
            // 
            // tpgoods
            // 
            this.tpgoods.Controls.Add(this.bttgoodsshooping);
            this.tpgoods.Controls.Add(this.btngoodsread);
            this.tpgoods.Controls.Add(this.txtGoodsPrice);
            this.tpgoods.Controls.Add(this.txtGoodsName);
            this.tpgoods.Controls.Add(this.txtGoodsID);
            this.tpgoods.Controls.Add(this.txtGoodsuserName);
            this.tpgoods.Controls.Add(this.txtGoodsuserID);
            this.tpgoods.Controls.Add(this.label13);
            this.tpgoods.Controls.Add(this.label12);
            this.tpgoods.Controls.Add(this.label11);
            this.tpgoods.Controls.Add(this.label10);
            this.tpgoods.Controls.Add(this.label9);
            this.tpgoods.Controls.Add(this.listView1);
            this.tpgoods.Location = new System.Drawing.Point(4, 26);
            this.tpgoods.Name = "tpgoods";
            this.tpgoods.Padding = new System.Windows.Forms.Padding(3);
            this.tpgoods.Size = new System.Drawing.Size(758, 433);
            this.tpgoods.TabIndex = 4;
            this.tpgoods.Text = "购买商品";
            this.tpgoods.UseVisualStyleBackColor = true;
            // 
            // bttgoodsshooping
            // 
            this.bttgoodsshooping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttgoodsshooping.Location = new System.Drawing.Point(567, 339);
            this.bttgoodsshooping.Name = "bttgoodsshooping";
            this.bttgoodsshooping.Size = new System.Drawing.Size(93, 31);
            this.bttgoodsshooping.TabIndex = 12;
            this.bttgoodsshooping.Text = "确定购买";
            this.bttgoodsshooping.UseVisualStyleBackColor = true;
            this.bttgoodsshooping.Click += new System.EventHandler(this.bttgoodsshooping_Click);
            // 
            // btngoodsread
            // 
            this.btngoodsread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngoodsread.Location = new System.Drawing.Point(393, 339);
            this.btngoodsread.Name = "btngoodsread";
            this.btngoodsread.Size = new System.Drawing.Size(93, 31);
            this.btngoodsread.TabIndex = 11;
            this.btngoodsread.Text = "识别卡号";
            this.btngoodsread.UseVisualStyleBackColor = true;
            this.btngoodsread.Click += new System.EventHandler(this.btngoodsread_Click);
            // 
            // txtGoodsPrice
            // 
            this.txtGoodsPrice.Location = new System.Drawing.Point(465, 261);
            this.txtGoodsPrice.Name = "txtGoodsPrice";
            this.txtGoodsPrice.ReadOnly = true;
            this.txtGoodsPrice.Size = new System.Drawing.Size(287, 25);
            this.txtGoodsPrice.TabIndex = 10;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(465, 199);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.ReadOnly = true;
            this.txtGoodsName.Size = new System.Drawing.Size(287, 25);
            this.txtGoodsName.TabIndex = 9;
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(465, 147);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.ReadOnly = true;
            this.txtGoodsID.Size = new System.Drawing.Size(287, 25);
            this.txtGoodsID.TabIndex = 8;
            // 
            // txtGoodsuserName
            // 
            this.txtGoodsuserName.Location = new System.Drawing.Point(465, 93);
            this.txtGoodsuserName.Name = "txtGoodsuserName";
            this.txtGoodsuserName.ReadOnly = true;
            this.txtGoodsuserName.Size = new System.Drawing.Size(287, 25);
            this.txtGoodsuserName.TabIndex = 7;
            // 
            // txtGoodsuserID
            // 
            this.txtGoodsuserID.Location = new System.Drawing.Point(465, 41);
            this.txtGoodsuserID.Name = "txtGoodsuserID";
            this.txtGoodsuserID.ReadOnly = true;
            this.txtGoodsuserID.Size = new System.Drawing.Size(287, 25);
            this.txtGoodsuserID.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "商品价格：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "商品名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "商品编号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "用户名称：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "用户卡号：";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 418);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1000.jpg");
            this.imageList1.Images.SetKeyName(1, "1001.jpg");
            this.imageList1.Images.SetKeyName(2, "1002.jpg");
            this.imageList1.Images.SetKeyName(3, "1003.jpg");
            this.imageList1.Images.SetKeyName(4, "1004.jpg");
            this.imageList1.Images.SetKeyName(5, "1005.jpg");
            this.imageList1.Images.SetKeyName(6, "1006.jpg");
            this.imageList1.Images.SetKeyName(7, "1007.jpg");
            this.imageList1.Images.SetKeyName(8, "1008.jpg");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bttclose);
            this.Controls.Add(this.bttopen);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "电子钱包";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpplus.ResumeLayout(false);
            this.tpplus.PerformLayout();
            this.tpMinus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tpselect.ResumeLayout(false);
            this.tpselect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tpgoods.ResumeLayout(false);
            this.tpgoods.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Button bttopen;
        private System.Windows.Forms.Button bttclose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpplus;
        private System.Windows.Forms.TabPage tpMinus;
        private System.Windows.Forms.TabPage tpselect;
        private System.Windows.Forms.TabPage tpgoods;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnewRead;
        private System.Windows.Forms.TextBox txtnewID;
        private System.Windows.Forms.Button bttadd;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtxiaofeiMoney;
        private System.Windows.Forms.TextBox txtxiaofeiName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxiaofeiID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttmoney;
        private System.Windows.Forms.Button btnplusread;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtidno;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtGoodsPrice;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.TextBox txtGoodsuserName;
        private System.Windows.Forms.TextBox txtGoodsuserID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bttgoodsshooping;
        private System.Windows.Forms.Button btngoodsread;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

