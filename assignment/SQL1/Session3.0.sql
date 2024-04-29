SELECT * FROM tblEmployee

select * from tblEmployee where EmployeeNumber = 531

CREATE TABLE tblTransaction (
   TransactionID INT PRIMARY KEY,
   EmployeeNumber INT,
   Amount DECIMAL(10, 2),
   TransactionDate DATE,
   FOREIGN KEY (EmployeeNumber) REFERENCES tblEmployee(EmployeeNumber)
);
INSERT INTO tblTransaction (TransactionID, EmployeeNumber, Amount, TransactionDate)
VALUES
(1, 530, 100.00, '2024-04-01'),
(2, 531, 150.50, '2024-04-02'),
(3, 532, 200.75, '2024-04-03'),
(4, 533, 75.25, '2024-04-04'),
(5, 534, 300.00, '2024-04-05')


select T.EmployeeNumber as TEmployeeNumber,
       E.EmployeeNumber as EEmployeeNumber,
	   sum(Amount) as SumAmount
from tblTransaction AS T
LEFT JOIN tblEmployee AS E
ON T.EmployeeNumber = E.EmployeeNumber
group by T.EmployeeNumber, E.EmployeeNumber
order by EEmployeeNumber



BEGIN TRAN
UPDATE tblEmployee
SET DateOfBirth = '2101-01-01'
WHERE EmployeeNumber = 537
select * from tblEmployee ORDER BY DateOfBirth DESC
ROLLBACK TRAN

BEGIN TRAN
UPDATE tblEmployee
SET EmployeeGovernmentID = 'aaaa'
WHERE EmployeeNumber BETWEEN 530 AND 539
select * from tblEmployee ORDER BY EmployeeGovernmentID ASC
ROLLBACK TRAN
GO
 --constraints

INSERT INTO tblEmployee
values (2001, 'FirstName', 'M', 'LastName', 'AB123456C', '1994-01-01', 'Commerical')
INSERT INTO tblEmployee
values (2002, 'AnotherFirstName', 'N', 'AnotherLastName', 'AB123457C', '1994-01-02', 'Finance')

delete from tblEmployee
Where EmployeeNumber > 2000
GO


alter table tblEmployee
ADD CONSTRAINT unqGovernmentID UNIQUE (EmployeeGovernmentID);

select EmployeeGovernmentID, count(EmployeeGovernmentID) as MyCount from tblEmployee
group by EmployeeGovernmentID
having count(EmployeeGovernmentID)>1

select * from tblEmployee where EmployeeGovernmentID IN ('BBB456', 'DDD234')
GO

begin tran
delete from tblEmployee
where EmployeeNumber < 3
ROLLBACK
GO

delete top(2) from tblEmployee
where EmployeeNumber in (131, 132)

select * from tblEmployee where EmployeeGovernmentID IN ('HN513777D', 'TX593671R')

commit tran
SELECT * FROM tblTransaction

alter table tblTransaction
add constraint unqTransaction UNIQUE (Amount, TransactionDate, EmployeeNumber)

delete from tblTransaction
where EmployeeNumber = 131

insert into tblTransaction
VALUES (1,'2015-01-01', 131)
insert into tblTransaction
VALUES (1,'2015-01-01', 131)

alter table tblTransaction
Drop constraint unqTransaction

create table tblTransaction2
(Amount smallmoney not null,
DateOfTransaction smalldatetime not null,
EmployeeNumber int not null,
CONSTRAINT unqTransaction2 UNIQUE (Amount,DateOfTransaction,EmployeeNumber))

drop table tblTransaction2

--Default constraints in action
alter table tblTransaction
add DateOfEntry datetime

alter table tblTransaction
add constraint defDateOfEntry DEFAULT GETDATE() for DateOfEntry;

alter table tblTransaction
drop constraint defDateOfEntry


delete from tblTransaction where EmployeeNumber < 3

insert into tblTransaction(Amount,TransactionDate, EmployeeNumber)
values (1, '2014-01-01', 1)
insert into tblTransaction(Amount, TransactionDate, EmployeeNumber, DateOfEntry)
values (2, '2014-01-02', 1, '2013-01-01')

select * from tblTransaction where EmployeeNumber < 3

create table tblTransaction2
(Amount smallmoney not null,
DateOfTransaction smalldatetime not null,
EmployeeNumber int not null,
DateOfEntry datetime null CONSTRAINT tblTransaction2_defDateOfEntry DEFAULT GETDATE())

insert into tblTransaction2(Amount, DateOfTransaction, EmployeeNumber)
values (1, '2014-01-01', 1)
insert into tblTransaction2(Amount, DateOfTransaction, EmployeeNumber, DateOfEntry)
values (2, '2014-01-02', 1, '2013-01-01')

select * from tblTransaction2 where EmployeeNumber < 3
go

drop table tblTransaction2

alter table tblTransaction
drop column DateOfEntry

alter table tblTransaction
drop constraint defDateOfEntry
go

BEGIN TRAN

ALTER TABLE tblTransaction
ADD DateOfEntry datetime
DEFAULT GETDATE() WITH VALUES
go

SELECT * FROM tblTransaction

ROLLBACK TRAN
--Check constraints in practice
alter table tblTransaction
add constraint chkAmount check (Amount>-100 and Amount < 300)

insert into tblTransaction
values (1010, '2014-01-01', 1)
go

alter table tblEmployee with nocheck
add constraint chkMiddleName check
(REPLACE(EmployeeMiddleName,'.','') = EmployeeMiddleName or EmployeeMiddleName is null)
go

alter table tblEmployee
drop constraint chkMiddleName
go

begin tran
  insert into tblEmployee
  values (2003, 'A', 'B.', 'C', 'D', '2014-01-01', 'Accounts')
  select * from tblEmployee where EmployeeNumber = 2003
rollback tran
go

alter table tblEmployee with nocheck
add constraint chkDateOfBirth check (DateOfBirth between '1900-01-01' and getdate())
go

begin tran
  insert into tblEmployee
  values (2003, 'A', 'B', 'C', 'D', '2115-01-01', 'Accounts')
    select * from tblEmployee where EmployeeNumber = 2003
rollback tran
go

create table tblEmployee2
(EmployeeMiddleName varchar(50) null, constraint CK_EmployeeMiddleName check
(REPLACE(EmployeeMiddleName,'.','') = EmployeeMiddleName or EmployeeMiddleName is null))

drop table tblEmployee2

alter table tblEmployee
drop chkDateOfBirth
alter table tblEmployee
drop chkMiddleName
alter table tblTransaction
drop chkAmount
go


alter table tblEmployee
add constraint PK_tblEmployee PRIMARY KEY (EmployeeNumber)

insert into tblEmployee(EmployeeNumber, EmployeeFirstName, EmployeeMiddleName, EmployeeLastName, 
EmployeeGovernmentID, DateOfBirth, Department) 
values (2004, 'FirstName', 'MiddleName', 'LastName', 'AB12345FI', '2014-01-01', 'Accounts')

delete from tblEmployee
where EmployeeNumber = 2004

alter table tblEmployee
drop constraint PK_tblEmployee

create table tblEmployee2
(EmployeeNumber int CONSTRAINT PK_tblEmployee2 PRIMARY KEY IDENTITY(1,1),
EmployeeName nvarchar(20))

insert into tblEmployee2
values ('My Name'),
('My Name')

select * from tblEmployee2

delete from tblEmployee2

truncate table tblEmployee2

insert into tblEmployee2(EmployeeNumber, EmployeeName)
values (3, 'My Name'), (4, 'My Name')

SET IDENTITY_INSERT tblEmployee2 ON

insert into tblEmployee2(EmployeeNumber, EmployeeName)
values (38, 'My Name'), (39, 'My Name')

SET IDENTITY_INSERT tblEmployee2 OFF

drop table tblEmployee2

select @@IDENTITY
select SCOPE_IDENTITY()

select IDENT_CURRENT('dbo.tblEmployee2')

create table tblEmployee3
(EmployeeNumber int CONSTRAINT PK_tblEmployee3 PRIMARY KEY IDENTITY(1,1),
EmployeeName nvarchar(20))

insert into tblEmployee3
values ('My Name'),
('My Name')

drop table tblEmployee3
go

--Foreign key – in practice
BEGIN TRAN
ALTER TABLE tblTransaction ALTER COLUMN EmployeeNumber INT NULL 
ALTER TABLE tblTransaction ADD CONSTRAINT DF_tblTransaction DEFAULT 124 FOR EmployeeNumber
ALTER TABLE tblTransaction WITH NOCHECK
ADD CONSTRAINT FK_tblTransaction_EmployeeNumber FOREIGN KEY (EmployeeNumber)
REFERENCES tblEmployee(EmployeeNumber)
ON UPDATE CASCADE
ON DELETE set default
--UPDATE tblEmployee SET EmployeeNumber = 9123 Where EmployeeNumber = 123
DELETE tblEmployee Where EmployeeNumber = 123

SELECT E.EmployeeNumber, T.*
FROM tblEmployee as E
RIGHT JOIN tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
where T.Amount IN (-179.47, 786.22, -967.36, 957.03)

ROLLBACK TRAN
GO


----Creating views
--select 1

create view ViewByDepartment as 
select D.Department, T.EmployeeNumber, T.TransactionDate, T.Amount as TotalAmount
from tblDepartment as D
left join tblEmployee as E
on D.Department = E.Department
left join tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
where T.EmployeeNumber between 120 and 139
--order by D.Department, T.EmployeeNumber
go

create view ViewSummary as 
select D.Department, T.EmployeeNumber as EmpNum, sum(T.Amount) as TotalAmount
from tblDepartment as D
left join tblEmployee as E
on D.Department = E.Department
left join tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
group by D.Department, T.EmployeeNumber
--order by D.Department, T.EmployeeNumber
go
select * from ViewByDepartment
select * from ViewSummary
