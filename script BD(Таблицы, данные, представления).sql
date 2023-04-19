create database Cursach
use Cursach
-- Справочник с должность сотрудника
create table EmployeesPost
(
EmpStatusID int identity primary key not null,
StatusName varchar(255) not null
)
-- Справочник с клиентским статусом
create table ClientStatus
(
ClientStatusID int identity primary key not null,
StatusName varchar(255) not null
)
-- Таблица сотрудников, необходима для совершения сделок и функционирования системы
create table Employees
(EmpID int identity primary key not null,
Position int not null foreign key references EmployeesPost(EmpStatusID),
FIO char(255) not null,
Gender char(1) not null,
BirthdayDate date not null,
EmpPassport char(20) not null,
NumberPH char(11) not null,
EmpLogin varchar(255) not null,
EmpPassword varchar(255) not null
)
-- Таблица клиентов, необходима для покупки автомобиля и функционирования системы
create table Clients
(ClientID int identity primary key not null,
FIO char(255) not null,
Gender char(1),
BirthdayDate date,
ClientPassport char(20) not null,
NumberPH char(11) not null,
Position int not null foreign key references ClientStatus(ClientStatusID)
)
-- Справочник о стране производителе автомобиля
create table CompanySypplierCountry
(CompanyCountryID int identity primary key not null,
Country varchar(255) not null,
CountryCode varchar(10) not null
)
-- Таблица компании производителя
create table CompanySypplier
(CompanyID int identity primary key not null,
CompanyName varchar(255) not null,
CompanyCountry int not null foreign key references CompanySypplierCountry(CompanyCountryID)
)
-- Справочник автомобильного топлива, необходим для заполнения таблицы автомобиль
create table AutomobileFuel
(AutomobileFuelID int identity primary key not null,
FuelName varchar(255) not null
)
-- Справочник цвета автомобиля, необходим для заполнения таблицы автомобиль
create table AutomobileColor
(AutomobileColorID int identity primary key not null,
ColorName varchar(255) not null
)
-- Справочник кузова автомобиля, необходим для заполнения таблицы автомобиль
create table AutomobileBody
(AutomobileBodyID int identity primary key not null,
BodyType varchar(255) not null
)
-- Таблица Автомобиль, необходима для возможности совершения клиентом сделки с автосалоном, а так же для контролирования автомобилей в наличии автосалона
create table Automobile
(AutoID int identity primary key not null,
Fuel int not null foreign key references AutomobileFuel(AutomobileFuelID),
BodyType int not null foreign key references AutomobileColor(AutomobileColorID),
Color int not null foreign key references  AutomobileBody(AutomobileBodyID),
DateOfRealese date not null,
CarName varchar(255) not null,
Perfomance int not null,
CarAvalible char(1) not null default 'Y',
)
select distinct Perfomance from Automobile
-- Таблица Натариальной компании, необходима для подтвержденения совершения сделок, между клиентом и автосалоно
create table NotaryСompany
(NotaryСompanyID int identity primary key not null,
NotaryСompanyName varchar(255) not null
)
-- Таблица Сделки, основная таблица, необходимая для записи о покупке автомобиля и функционирования системы, для отслеживания выкупленных автомобилей, с целью контроля таблицы Автомобили 
create table Deals
(DealID int identity primary key not null,
DateOfDeal date not null,
Price int not null,
Automobile int not null foreign key references Automobile(AutoID),
CompanySypplier int not null foreign key references CompanySypplier(CompanyID),
EmpSeller int not null foreign key references Employees(EmpID),
Client int not null foreign key references Clients(ClientID),
NotaryСompanyConfirmed int not null foreign key references NotaryСompany(NotaryСompanyID)
)
-- Таблица Налогооблажения, необходимо для вычисления чистой прибыли автосалона, после вычита налогов 
create table Taxation
(TaxaID int identity primary key not null,
DealNumber int not null foreign key references Deals(DealID),
AmountOfTaxa int not null
)

insert into [dbo].[EmployeesPost]
values
('Manager'),
('Director'),
('Administator'),
('Director Assistant')

insert into [dbo].[ClientStatus]
values
('New Client'),
('Premium')

insert into [dbo].[CompanySypplierCountry]
values
('Russia', 'RU'),
('Germany', 'GE'),
('United Kingdom', 'GB'),
('United State', 'US'),
('Italy', 'IT')

insert into [dbo].[AutomobileBody]
values
('Sedan'),
('Coupe'),
('Hatchback'),
('Universal'),
('Cabriolet'),
('Liftback'),
('Roadster')

insert into [dbo].[AutomobileFuel]
values
('Diesel'),
('Gasoline'),
('Electricity')

insert into [dbo].[AutomobileColor]
values
('White'),
('Black'),
('Mixed'),
('Red'),
('Blue'),
('Purple'),
('Green'),
('Yellow'),
('Orange')

insert into [dbo].[NotaryСompany]
values
('Auto Notary Services'),
('Annabelle’s Notary Services'),
('A Plus Notary'),
('SAS Notary'),
('Notary Xpert'),
('Worldwide Notary')

insert into [dbo].[CompanySypplier]
values 
('Mercedes-Bens Germany', 2),
('Mercedes-Bens America', 4),
('Mercedes-Bens England', 3),
('Audi', 2),
('BMW', 2),
('Porsche', 2),
('Ferrari', 5)

insert into [dbo].[Employees]
values
(4, 'Filippov Fedor', 'M', '2004-11-10', '1923123985', '79616104654', 'Dungier' , '@Dungier123'),
(1, 'Juanita Hedrick', 'F', '1982-09-08', '1594567890', '79616104654', 'JuanitaHedrick', '@JuanitaHedrick123'),
(1, 'Darcie Fenner', 'M', '1973-06-01', '1544567890', '79615674655', 'DarcieFenner', '@DarcieFenner123'),
(1, 'Ellan Gaylord', 'M', '1987-04-24', '1224567890', '79616103245', 'EllanGaylord', '@EllanGaylord123'),
(1, 'Lupita Streeter', 'F', '2015-09-02', '1124567890', '79616105566', 'LupitaStreeter', '@LupitaStreeter123'),
(1, 'Bambi Delong', 'M', '1999-11-19', '1234643890', '79616102156', 'BambiDelong', '@BambiDelong123'),
(1, 'Jenee Cooper' , 'F', '1981-07-12', '1223467890', '79616103890', 'JeneeCooper', '@JeneeCooper123'),
(1, 'Halley Dupre-Mathias', 'F', '1995-09-25', '22144567890', '79616106570', 'HalleyDupreMathias', '@HalleyDupreMathias123 '),
(1, 'Jeanmarie Rodman', 'F', '1972-09-09', '5521567890', '79616100976', 'JeanmarieRodman', '@JeanmarieRodman123'),
(2, 'Andreas Mojica', 'M', '1991-08-10', '2234568890', '79616107655', 'AndreasMojica', '@AndreasMojica123'),
(4, 'Shanika Kenney', 'F', '2002-07-06', '1835296750', '79616101234', 'ShanikaKenney', '@ShanikaKenney123'),
(4, 'Ned Brownlee', 'M', '2003-11-06', '1784564590', '79616101122', 'NedBrownlee', '@JNedBrownlee123'),
(1, 'Lucretia Baskin', 'M', '1995-04-25', '1784567890', '79616103453', 'LucretiaBaskin', '@LucretiaBaskin123'),
(1, 'Karma Zapata', 'F', '1979-06-07', '1234561470', '79616104725', 'KarmaZapata', '@KarmaZapata123'),
(1, 'Kendrick Maas-Blodgett', 'M', '1984-10-05', '9384567890', '79616104539', 'KendrickMaasBlodgett', '@KendrickMaasBlodgett123'),
(1, 'Catherine Labelle', 'F', '2005-09-02', '1234396790', '79616109784', 'CatherineLabelle', '@CatherineLabelle123')

insert into Clients
values
('Trinidad Wille', 'F', '2000-09-08', '5594567690', '79216114654', 1),
('Lia Sizemore', 'M', '1999-06-01', '1544567890', '79615674625', 1),
('Michel Thomsen', 'M', '1987-04-24', '1524567890', '79616104245', 1),
('Charlsie Blackwell', 'F', '2002-09-02', '1524567890', '79656105566', 1),
('Delora Moya', 'M', '1999-11-19', '1534643890', '79616102166', 1),
('Charlsie Blackwell' , 'F', '1992-07-12', '1523467890', '77616103890', 1),
('Cathi Mcelroy', 'F', '1995-09-25', '25144567890', '79616166570', 1),
('Dulcie Alley', 'F', '1972-09-09', '2521567890', '79616100576', 1),
('Coy Crook', 'M','2001-09-02' , '2234568891', '79636107651', 1),
('Shad Pederson', 'F', '2002-07-06', '1825296750', '79612101234', 1),
('Todd Isaac', 'M','2001-09-01', '1784564590', '79616101121', 1),
('Caroline Norwood', 'M', '1995-04-25', '1724567890', '79646103453', 1),
('Ed Casper', 'F', '1979-06-07', '1234561472', '7961616725', 1),
('Seema Vanmeter', 'M', '1984-10-05', '9384527890', '79616545539', 1),
('Esperanza Nealy', 'F', '2001-09-02', '1234296790', '79616109444', 1),
('Kaleigh Halcomb', 'M', '1995-04-25', '1784367890', '79614103453', 1),
('Patsy Ruby', 'F', '1979-06-07', '1234561475', '79616104745', 1),
('Tereasa Mcallister', 'M', '1984-10-05', '9381567890', '79616104439', 1),
('Thersa Knotts', 'F', '2001-09-02', '1234396720', '79616109744', 1),
('Amina Cade', 'F', '2000-09-08', '5594567890', '79616114652', 1),
('Rolande Corcoran', 'M', '1999-06-01', '1544567890', '79615624625', 1),
('Nicolasa Bostic', 'M', '1987-04-24', '1524567890', '79616102245', 1),
('Lorretta Spangler', 'F', '2002-09-02', '1524567890', '79656205566', 1),
('Akiko Gaddis', 'M', '1999-11-19', '1534643890', '79616102162', 1),
('Belinda Langley' , 'F', '1992-07-12', '1523467890', '77616123890', 1),
('Coralee Manns', 'F', '1995-09-25', '25144567890', '79616166270', 1),
('Vertie Hamby', 'F', '1972-09-09', '2521567890', '79616100572', 1),
('Consuela Maguire', 'M','2001-09-02' , '2234568891', '79636127651', 1),
('Gail Gunderson', 'F', '2002-07-06', '1825296750', '79612101334', 1),
('Rudolf Sierra', 'M','2001-09-01', '1784564590', '79616101122', 1),
('Thanh Jefferson', 'M', '1995-04-25', '1724567890', '79646102453', 1),
('Samatha Mathias', 'F', '1979-06-07', '1234561472', '7961616225', 1),
('Beatris Ashby', 'M', '1984-10-05', '9384527890', '79616545529', 1),
('Merrilee Wilde', 'F', '2001-09-02', '1234296790', '79616109244', 1),
('Lorita Whyte', 'M', '1995-04-25', '1784367890', '79614103452', 1),
('Reiko Mcmullen', 'F', '1979-06-07', '1234561475', '79616104725', 1),
('Clora Sammons', 'M', '1984-10-05', '9381567890', '79616104432', 1),
('Mallie Driggers', 'F', '2001-09-02', '1234396720', '79616109722', 1)

insert into [dbo].[Automobile] ([Fuel],[BodyType],[Color],[DateOfRealese],[CarName],[Perfomance])
values
(2, 2, 2, '2022-02-20', 'Ferrari California', 655),
(2, 2, 2, '2022-02-20', 'Mercedes-Bens S200', 155),
(2, 2, 2, '2022-02-20', 'Mercedes-Bens S200', 155),
(2, 2, 2, '2022-03-20', 'Mercedes-Bens S300', 235),
(2, 2, 2, '2022-02-20', 'Mercedes-Bens S300', 235),
(2, 2, 2, '2022-02-20', 'Mercedes-Bens S350', 275),
(2, 2, 2, '2023-02-20', 'Mercedes-Bens S400', 333),
(2, 2, 2, '2023-02-20', 'Mercedes-Bens S400', 333),
(2, 2, 2, '2023-02-20', 'Mercedes-Bens S450', 387),
(2, 2, 2, '2023-02-20', 'Mercedes-Bens S500', 455),
(2, 2, 2, '2023-02-20', 'Mercedes-Bens S500', 455),
(2, 1, 1, '2023-02-16', 'Mercedes-Bens S200', 155),
(2, 1, 1, '2023-02-16', 'Mercedes-Bens S200', 155),
(2, 1, 1, '2023-02-16', 'Mercedes-Bens S200', 155),
(2, 1, 2, '2022-12-16', 'Mercedes-Bens S200', 155),
(2, 1, 2, '2022-12-16', 'Mercedes-Bens S200', 155),
(2, 5, 2, '2022-02-20', 'Mercedes-Bens S500', 155),
(2, 5, 2, '2022-02-20', 'Mercedes-Bens S500', 155),
(2, 5, 1, '2023-01-01', 'Mercedes-Bens S63', 575),
(2, 5, 2, '2023-02-01', 'Mercedes-Bens S63', 575),
(2, 6, 3, '2022-02-10', 'Mercedes-Bens GT53', 155),
(2, 6, 4, '2022-02-10', 'Mercedes-Bens GT63', 155),
(2, 2, 5, '2022-07-20', 'Audi TT', 255),
(2, 2, 6, '2022-08-10', 'Audi TT', 255),
(2, 2, 7, '2022-08-10', 'BMW M4 Competition', 575),
(2, 2, 7, '2022-08-10', 'BMW M4 Competition', 575),
(1, 3, 1, '2022-08-10', 'BMW M5 Competition', 300),
(3, 1, 2, '2022-08-10', 'BMW M7 Competition', 575),
(2, 2, 6, '2022-08-10', 'Porsche Carrera 911', 655),
(2, 2, 3, '2022-08-10', 'Porsche Carrera 911', 655),
(2, 2, 1, '2022-08-10', 'Porsche Carrera 911', 655),
(2, 3, 2, '2022-08-10', 'Porsche Panamera', 455),
(2, 3, 2, '2022-08-10', 'Porsche Panamera', 355),
(2, 3, 2, '2022-08-10', 'Porsche Panamera', 255)


-- Процедура заключения сделки
CREATE PROCEDURE AddDeal
(
@DateIfDeal date,
@Price int,
@Auto int,
@Company int,
@EmpSellers int,
@Client int,
@Notary int
)
as
BEGIN
insert into [dbo].[Deals]
values
(@DateIfDeal, @Price, @Auto, @Company, @EmpSellers, @Client, @Notary)

update [dbo].[Automobile] set CarAvalible = 'N' where Automobile.AutoID = @Auto

insert into [dbo].[Taxation]
values
((select max (Deals.DealID) from Deals), ((@Price / 100) * 13))
return
END
-- Внос данных в табилцы Сделки и Налогообложение, а так же изменения статуса автомобиля на "продан"
exec AddDeal '2023-03-13', 17000000, 1, 1, 15, 31, 5
exec AddDeal '2023-03-19', 17000000, 3, 1, 15, 31, 5
exec AddDeal '2023-03-18', 11000000, 5, 5, 1, 1, 5
exec AddDeal '2023-03-17', 23000000, 7, 5, 2, 5, 3
exec AddDeal '2023-03-16', 21000000, 9, 5, 3, 17, 1
exec AddDeal '2023-03-16', 25000000, 25, 1, 4, 21, 1
-- Представления
-- 1 Вывод всех автомобилей одного модельного ряда
create view SelectAutoModel
as
select [AutoID],[Fuel],[BodyType],[Color],[DateOfRealese],[CarName],[Perfomance] from [dbo].[Automobile] a
where a.[CarName] like '%s200%' and a.CarAvalible like 'Y'

select * from SelectAutoModel

-- 2 Сортировка автомобилей по типу топлива

create view SelectAutomobileFuel
as
select AutoID, Perfomance, CarName, Color, DateOfRealese, [BodyType], f.FuelName from [dbo].[Automobile] a
join [dbo].[AutomobileFuel] f
on f.[AutomobileFuelID] = a.Fuel
where f.[FuelName] like 'Gasoline' and a.CarAvalible like 'Y'

select * from SelectAutomobileFuel
-- 3 Сортировка автомобилей по типу кузова

create view SelectAutomobileBody
as
select AutoID, Perfomance, CarName, Color, DateOfRealese, b.[BodyType], Fuel from [dbo].[Automobile] a
join [dbo].[AutomobileBody] b
on b.[AutomobileBodyID] = a.BodyType
where b.[BodyType] like 'Coupe' and a.CarAvalible like 'Y'

select * from SelectAutomobileBody
-- 4 Сортировка автомобилей по году выхода

create view SelectAutoRealeseDate
as
select * from [dbo].[Automobile] 
where [DateOfRealese] like '2023-%-%' and CarAvalible like 'Y'

select * from SelectAutoRealeseDate

-- 5 Выборка автомобилей, где количество мощность двигателя выше 600 л.с

create view SelectAutoHorsePower
as
select * from [dbo].[Automobile]
where [Perfomance] > 600 and CarAvalible like 'Y'

select * from SelectAutoHorsePower

-- 6 Выборка автомобилей по цвету

create view SelectAutomobileColor
as
select AutoID, Perfomance, CarName, c.ColorName, DateOfRealese, [BodyType], Fuel from [dbo].[Automobile] a
join [dbo].[AutomobileColor] c
on c.AutomobileColorID = a.Color
where c.ColorName like 'White' and a.CarAvalible like 'Y'

select * from SelectAutomobileColor
-- 7 Выбор автомобилей по кузову, топливу, дате выхода

create view SelectAutoBodyFuelColorDate
as
select AutoID, Perfomance, CarName, c.ColorName, DateOfRealese, b.[BodyType], f.FuelName from [dbo].[Automobile] a
join [dbo].[AutomobileBody] b
on b.[AutomobileBodyID] = a.BodyType
join [dbo].[AutomobileFuel] f
on f.[AutomobileFuelID] = a.Fuel
join [dbo].[AutomobileColor] c
on c.AutomobileColorID = a.Color
where [DateOfRealese] like '2023-%-%' and b.[BodyType] like 'Sedan' and f.[FuelName] like 'Gasoline' and a.CarAvalible like 'Y'

select * from SelectAutoBodyFuelColorDate

-- 8 Список всех автомобилей и их характеристик

create view SelectAllAuto
as
select AutoID, Perfomance, CarName, c.ColorName, DateOfRealese, b.[BodyType], f.FuelName from [dbo].[Automobile] a
join [dbo].[AutomobileBody] b
on b.[AutomobileBodyID] = a.BodyType
join [dbo].[AutomobileFuel] f
on f.[AutomobileFuelID] = a.Fuel
join [dbo].[AutomobileColor] c
on c.AutomobileColorID = a.Color
where a.CarAvalible like 'Y'
select * from  SelectAllAuto

-- 9 Список всех сотрудников и их должности

create view AllEmpWithPost
as
select [EmpID], ep.StatusName,[FIO],[Gender],[BirthdayDate],[EmpPassport],[NumberPH] from Employees E
join [dbo].[EmployeesPost] EP
on E.Position = EP.EmpStatusID

select * from AllEmpWithPost

--10 Вывод всех сделок
create view AllDealsInfo
as
select [DealID] as 'Номер сделки',[DateOfDeal] as 'Дата сделки',[Price] as 'Цена автомобиля',[Automobile] as 'AutoID', a.CarName as 'Наименование автомобиля',ComSyp.CompanyName as 'Компания поставщик', ComSypCoun.Country as 'Страна Производителя', Emp.FIO as 'Сотрудник', EmpPost.StatusName as 'Должность сотрудника', Client.FIO as 'Клиент',NotaryComp.NotaryСompanyName as 'Нотариальная компания заверитель' from [dbo].[Deals] deal
join [dbo].[Automobile] A
on a.[AutoID] = deal.[Automobile]
join [dbo].[CompanySypplier] ComSyp
on ComSyp.CompanyID = deal.[CompanySypplier]
join [dbo].[CompanySypplierCountry] ComSypCoun
on ComSyp.CompanyCountry = ComSypCoun.CompanyCountryID
join [dbo].[Employees] Emp
on deal.EmpSeller = Emp.EmpID
join [dbo].[EmployeesPost] EmpPost
on Emp.Position = EmpPost.EmpStatusID
join [dbo].[Clients] Client
on deal.Client = Client.ClientID
join [dbo].[NotaryСompany] NotaryComp
on deal.NotaryСompanyConfirmed = NotaryComp.NotaryСompanyID
order by DealID

select * from  AllDealsInfo

Select EmpID, StatusName, FIO, Gender, BirthdayDate, EmpPassport, NumberPH, EmpLogin, EmpPassword from Employees
join EmployeesPost on Position = EmpStatusID
where EmpLogin = 'Dungier'

Select ClientID, FIO, StatusName, NumberPH from Clients
join ClientStatus
on Position = ClientStatusID