use master
go
create database SI
go
use SI
go
create table Userinfo
(
UsercardID varchar(100) not null primary key,--TagID
UserName varchar(32) not null,--�û���
UserMoney money not null--��ʼ���
)
go
create table GoodsInfo
(
GoodsID int primary key identity(1000,1) not null,--��Ʒ���
GoodsName varchar(100) not null,--��Ʒ����
GoodsPrice money not null,--��Ʒ�۸�
GoodsComm text default('')--��Ʒ��ע
)
go
create table UserxiaofeiInfo
(
UserxiaoID int primary key identity(1,1) not null,--���Ѽ�¼���
UsercardID varchar(100) references Userinfo(UsercardID),--����
GoodsID int references GoodsInfo(GoodsID),--��ƷID
Userxiaomoney money not null,--���ѽ��
UserTime datetime default(getdate())
)
go
insert into GoodsInfo
select 'С����',45.00,'С���޵�����������100%����' union
select '�廪�Ϲ�MP3',110.9,'�ò�Ʒ���ʳ��ã��������' union
select '������ʶ��',59.00,'�������' union
select 'Asp.NET',159.00,'�������' union
select 'Javascript',38.00,'�������' union
select 'SqlServer',68.00,'�������' union
select 'Winform',73.00,'�������' union
select 'Query',73.00,'�������' union
select '����',84.00,'�������' 
go
select * from Userinfo;
select * from GoodsInfo;
select * from UserxiaofeiInfo;
select Userinfo.UsercardID,UserName,GoodsName,Userxiaomoney,UserTime from Userinfo,GoodsInfo,UserxiaofeiInfo where GoodsInfo.GoodsID=UserxiaofeiInfo.GoodsID and Userinfo.UsercardID=UserxiaofeiInfo.UsercardID;
