use master
go
create database SI
go
use SI
go
create table Userinfo
(
UsercardID varchar(100) not null primary key,--TagID
UserName varchar(32) not null,--用户名
UserMoney money not null--初始金额
)
go
create table GoodsInfo
(
GoodsID int primary key identity(1000,1) not null,--商品编号
GoodsName varchar(100) not null,--商品名称
GoodsPrice money not null,--商品价格
GoodsComm text default('')--商品备注
)
go
create table UserxiaofeiInfo
(
UserxiaoID int primary key identity(1,1) not null,--消费记录编号
UsercardID varchar(100) references Userinfo(UsercardID),--卡号
GoodsID int references GoodsInfo(GoodsID),--商品ID
Userxiaomoney money not null,--消费金额
UserTime datetime default(getdate())
)
go
insert into GoodsInfo
select '小娃娃',45.00,'小娃娃的制作材料是100%纯棉' union
select '清华紫光MP3',110.9,'该产品音质超好，画面高清' union
select '物联网识别',59.00,'画面高清' union
select 'Asp.NET',159.00,'画面高清' union
select 'Javascript',38.00,'画面高清' union
select 'SqlServer',68.00,'画面高清' union
select 'Winform',73.00,'画面高清' union
select 'Query',73.00,'画面高清' union
select '功夫',84.00,'画面高清' 
go
select * from Userinfo;
select * from GoodsInfo;
select * from UserxiaofeiInfo;
select Userinfo.UsercardID,UserName,GoodsName,Userxiaomoney,UserTime from Userinfo,GoodsInfo,UserxiaofeiInfo where GoodsInfo.GoodsID=UserxiaofeiInfo.GoodsID and Userinfo.UsercardID=UserxiaofeiInfo.UsercardID;
