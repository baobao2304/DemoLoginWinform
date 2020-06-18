create database dangnhapdemo

create table dangnhap(
	id nvarchar(10) not null,
	pass nvarchar(10),
	constraint PK_dangnhap primary key (id)
)
