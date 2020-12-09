CREATE DATABASE QLLOPHOC
USE QLLOPHOC
create table lophoc(
	malop varchar(50) not null,
	tenlop nvarchar(50) not null,
	constraint pk_lophoc primary key(malop)
)

insert into lophoc values('LH001','Lap trinh web')
insert into lophoc values('LH002','Lap trinh web nang cao')
insert into lophoc values('LH003','Lap trinh oop')