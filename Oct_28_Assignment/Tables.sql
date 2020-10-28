create database Training
use Training

create table student(ID int, FirstName varchar(10),LastName varchar(10),Location varchar(10));
insert into student values(101,'Aishwarya','Jadhav','Solapur');
insert into student values(102,'Asmita','Jadhav','Delhi');
insert into student values(103,'Aasha','Waghmode','Mumbai');
insert into student values(104,'varsha','Aainure','Chennai');
insert into student values(105,'Manasi','Wabhuvan','Pune');
select * from student

create table Employee(ID int,EmpName varchar(50),Designation varchar(10),Location varchar(10))
insert into Employee values(1001,'Raj','Manager','Hyderabad')
insert into Employee values(1002,'shivani','HR','Mumbai')
insert into Employee values(1003,'Dev','Intern','Solapur')
insert into Employee values(1004,'Roma','Engineer','Pune')
insert into Employee values(1005,'Dezy','Manager','Hyderabad')
select * from Employee

create table Indian_Cricket_Team(Juesey_No int,FirstName varchar(30),LastName varchar(30),No_of_Centuries int)
insert into Indian_Cricket_Team values(18,'Virat','Kohali',20)
insert into Indian_Cricket_Team values(19,'MS','Dhoni',50)
insert into Indian_Cricket_Team values(20,'sachin','Tendulakar',51)
insert into Indian_Cricket_Team values(15,'Rohit','Sharma',20)
insert into Indian_Cricket_Team values(14,'Kedar','Jadhav',21)
select * from Indian_Cricket_Team

create table Indian_Railway_System(Train_no int,TrainName varchar(50),source varchar(50),destination varchar(50),Time_arrival time)
insert into Indian_Railway_System values(2121,'RajDhaniExpress','solapur','Pune','10:30')
insert into Indian_Railway_System values(2121,'DurontoExpress','Delhi','Pune','11:30')
insert into Indian_Railway_System values(2121,'ShatabdiExpress','Chennai','Kolhapur','12:30')
insert into Indian_Railway_System values(2120,'RajDhaniExpress','solapur','Pune','01:30')
select * from Indian_Railway_System

create table Bank(EmpID int,EmpName varchar(max),Department varchar(50),Location varchar(30))
insert into Bank values(2001,'RajSingh','Bancking_dept','Pune')
insert into Bank values(2002,'DevDarekar','Issue_dept','Kolhapur')
insert into Bank values(2003,'SamRoma','ExchangeControl_dept','Sangli')
insert into Bank values(2004,'KristalDezy','Bancking_dept','Noida')
insert into Bank values(2005,'RaniSingh','Bancking_dept','Pune')
select * from Bank
