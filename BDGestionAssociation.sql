create database BDGestionAssociation
use BDGestionAssociation;


create table utilisateur(CIN varchar(20) primary key, Nom varchar(200), Pass varchar(200), userRole varchar(20) check (userRole in ('Admin','User')));

insert into utilisateur values('ID','mohamed','12345','Admin');

create table financement(ID int identity(1,1) primary key ,DateInsert date ,MoneyType varchar(30) check(MoneyType in('entre','sortie')) , caisse float)

create table activites(ID varchar(100) primary key,DateDebut date,DateFin date,Frais float,Revenue float,descript text)

create table adherent(ID int identity(1,1) primary key,CIN varchar(20),Nom varchar(200),DateInscription date,
Telephone char(10) check (Telephone like '[0][567][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),Email varchar(100),Adresse varchar(200),photo varbinary(max));


create table Months(id int primary key identity(1,1),nom varchar(30));

insert into Months values ('يناير'),('فبراير'),('مارس'),('ابريل'),('ماي'),('يونيو'),('يوليوز')
,('غشت'),('شتنبر'),('أكتوبر'),('نونبر'),('دجنبر');

create  trigger SubscribeFees on adherent  after insert 
as begin
	insert into financement values(getdate(),'entre',(select Frais from Inserted));
end


