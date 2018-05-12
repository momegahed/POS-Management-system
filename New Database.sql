CREATE DATABASE Exo
GO
USE Exo

CREATE TABLE Store (
Store# INT NOT NULL CHECK (Store# > 0 AND Store# < 100000),
Operating_hours	SMALLINT NOT NULL CHECK (Operating_hours > 0 AND Operating_hours < 25),
St_City	VARCHAR(20) NOT NULL,
St_Street VARCHAR(25) NOT NULL,
St_State VARCHAR(20) NOT NULL,
PRIMARY KEY (Store#) );

CREATE TABLE Employee (
ID INT NOT NULL CHECK (ID > 0 AND ID < 1000000000),
E_Fname	VARCHAR(15) NOT NULL,
E_Lname	VARCHAR(15) NOT NULL,
E_City	VARCHAR(20) NOT NULL,
E_Street VARCHAR(25) NOT NULL,
E_State	VARCHAR(20) NOT NULL,
St_Hours SMALLINT NOT NULL CHECK (St_Hours > -1 AND St_Hours <13),
St_ID INT ,
SuperID INT ,
PRIMARY KEY (ID),
FOREIGN KEY (St_ID) REFERENCES Store ON DELETE SET NULL ON UPDATE CASCADE ,
FOREIGN KEY (SuperID) REFERENCES Employee );

CREATE TABLE Customer (
MembershipID# INT NOT NULL CHECK (MembershipID# > 0 AND MembershipID# < 1000000000),
C_Fname	VARCHAR(15) NOT NULL,
C_Lname	VARCHAR(15) NOT NULL,
C_Phone# CHAR(11),
PRIMARY KEY (MembershipID#) );

CREATE TABLE Receipt (
Receipt# BIGINT NOT NULL CHECK (Receipt# > 0),
Total_price SMALLMONEY NOT NULL,
Discount_price SMALLMONEY ,
R_Time TIME NOT NULL,
R_Date DATE NOT NULL,
MemID# INT,
Em_ID INT NOT NULL,
PRIMARY KEY (Receipt#),
FOREIGN KEY (MemID#) REFERENCES Customer ON DELETE SET NULL ON UPDATE CASCADE ,
FOREIGN KEY (Em_ID) REFERENCES Employee ON DELETE NO ACTION ON UPDATE CASCADE);

CREATE TABLE Offer (
OfferID INT NOT NULL CHECK (OfferID > 0 AND OfferID < 1000000000),
O_Start DATE NOT NULL,
O_End DATE NOT NULL,
Value FLOAT NOT NULL,
PRIMARY KEY (OfferID) );

CREATE TABLE Items (
ItemNO# BIGINT NOT NULL CHECK (ItemNO# > 0),
Item_discription VARCHAR(40) NOT NULL,
Item_detailed_discription VARCHAR(100),
Price SMALLMONEY NOT NULL,
Category VARCHAR(15) ,
Brand VARCHAR(15) ,
OfID INT ,
PRIMARY KEY (ItemNO#),
FOREIGN KEY (OfID) REFERENCES Offer ON DELETE SET NULL ON UPDATE CASCADE);

CREATE TABLE Supplier (
SupplierID# INT NOT NULL CHECK (SupplierID# > 0 AND SupplierID# < 1000000000),
Su_Fname VARCHAR(15) NOT NULL,
Su_Lname VARCHAR(15) NOT NULL,
Su_City VARCHAR(20) ,
Su_Street VARCHAR(25) ,
Su_State VARCHAR(20) NOT NULL,
Su_Phone# CHAR(11) ,
Email VARCHAR(50) ,
PRIMARY KEY (SupplierID#) ); 

CREATE TABLE Shipment (
ShipmentID# INT NOT NULL CHECK (ShipmentID# > 0 AND ShipmentID# < 1000000000),
Sh_Date DATE NOT NULL,
SupID# INT NOT NULL,
PRIMARY KEY (ShipmentID#),
FOREIGN KEY (SupID#) REFERENCES Supplier ON UPDATE CASCADE);

CREATE TABLE Supply_Store (
ItemsNum BIGINT NOT NULL,
StoreID INT NOT NULL,
ShipID INT NOT NULL,
Quantity INT NOT NULL CHECK (Quantity > 0),
PRIMARY KEY (ItemsNum, StoreID, ShipID),
FOREIGN KEY (ItemsNum) REFERENCES Items ON UPDATE CASCADE,
FOREIGN KEY (StoreID) REFERENCES Store ,
FOREIGN KEY (ShipID) REFERENCES Shipment ); 

CREATE TABLE SoldAt (
Sold INT NOT NULL CHECK (Sold > 0),
Available INT NOT NULL CHECK (Available > 0),
StID INT NOT NULL,
ItemsNumber BIGINT NOT NULL ,
PRIMARY KEY (StID,ItemsNumber ),
FOREIGN KEY (ItemsNumber) REFERENCES Items ON UPDATE CASCADE,
FOREIGN KEY (StID) REFERENCES Store );

CREATE TABLE R_Contains (
Quantity INT NOT NULL CHECK (Quantity > 0),
ReceiptID BIGINT NOT NULL,
Item#No BIGINT NOT NULL,
Price SMALLMONEY NOT NULL,
Discount decimal(3,2),
PRIMARY KEY (ReceiptID, Item#No),
FOREIGN KEY (ReceiptID) REFERENCES Receipt ,
FOREIGN KEY (Item#No) REFERENCES Items ON UPDATE CASCADE );

CREATE TABLE PaymentOption  (
StoreID	INT NOT NULL,
P_Option VARCHAR(15) NOT NULL CHECK (P_Option IN ('Cash' , 'Visa', 'Mastercard' , 'Paypal')),
PRIMARY KEY (StoreID, P_Option),
FOREIGN KEY (StoreID) REFERENCES Store ); 

CREATE TABLE User_Type (
username   VARCHAR (50) NOT NULL,
password   VARCHAR (50) NOT NULL,
type       VARCHAR (50) NOT NULL CHECK (type IN ('Admin' , 'Branch Manager', 'Sales Assistant')),
EmployeeID INT     NOT NULL,
Security   VARCHAR (50),
PRIMARY KEY CLUSTERED (EmployeeID ASC),
FOREIGN KEY (EmployeeID) REFERENCES Employee );

INSERT INTO Store VALUES('1','14','Shibin Al-Kawm','Omar Afandy','Menofia');
INSERT INTO Store VALUES('2','14','Tanta','Gamal Abdelnaser','Gharbia');
INSERT INTO Store VALUES('3','14','Mansoura','Elmadares','Sharqia');
INSERT INTO Store VALUES('4','14','New Cairo','Saad Zagloul','Cairo');
INSERT INTO Store VALUES('5','14','6th October','Elmehwar','Giza');
INSERT INTO Store VALUES('6','14','Eldokki','Mekka','Cairo');
INSERT INTO Store VALUES('7','14','Somouha','Elbahr','Alexandria');
INSERT INTO Store VALUES('8','14','Tanta','Saad Zagloul','Gharbia');
INSERT INTO Store VALUES('9','14','Elharam','Elharam','Giza');
INSERT INTO Store VALUES('10','14','Elagouza','Abdelaziz','Cairo');

INSERT INTO Employee VALUES('1','Ahmed','Shokry','Shibin Al-Kawm','Omar Afandy','Menofia','8','1','1');
INSERT INTO Employee VALUES('2','Ibrahim','Hammad','Tanta','Gamal Abdelnaser','Gharbia','8','2','2');
INSERT INTO Employee VALUES('3','Hamdy','Shdeid','Mansoura','Elmadares','Sharqia','8','3','3');
INSERT INTO Employee VALUES('4','Shokria','Ibrahim','New Cairo','Saad Zagloul','Cairo','8','4','4');
INSERT INTO Employee VALUES('5','Fawzy','Qandeel','6th October','Elmehwar','Giza','8','5','5');
INSERT INTO Employee VALUES('6','Hamad','Mohsen','Eldokki','Mekka','Cairo','8','6','6');
INSERT INTO Employee VALUES('7','Ismail','Mostafa','Somouha','Elbahr','Alexandria','8','7','7');
INSERT INTO Employee VALUES('8','Mostafa','Mahmoud','Tanta','Saad Zagloul','Gharbia','8','8','8');
INSERT INTO Employee VALUES('9','Magdy','Sherif','Elharam','Elharam','Giza','8','9','9');
INSERT INTO Employee VALUES('10','Shimaa','Elgamal','Elagouza','Abdelaziz','Cairo','8','10','10');

INSERT INTO Customer VALUES('1','Ahmed','Ibrahim','010973667');
INSERT INTO Customer VALUES('2','Ibrahim','Hammad','012489435');
INSERT INTO Customer VALUES('3','Shrouk','Shokry','011834778');
INSERT INTO Customer VALUES('4','Samah','Elshabory','010783647');
INSERT INTO Customer VALUES('5','Sabry','Mohsen','015873879');
INSERT INTO Customer VALUES('6','Shokry','Hassan','010874823');
INSERT INTO Customer VALUES('7','Ibrahim','Gad','012783474');
INSERT INTO Customer VALUES('8','Mahmoud','Shedid','011872876');
INSERT INTO Customer VALUES('9','Ahmed','Adel','010089734');
INSERT INTO Customer VALUES('10','Ahmed','Ashraf','012783476');

INSERT INTO Receipt VALUES('1','500','88','17:00','1/21/2018','1','2');
INSERT INTO Receipt VALUES('2','650','163','18:00','2/21/2018','2','3');
INSERT INTO Receipt VALUES('3','700','573','19:00','3/21/2018','3','1');
INSERT INTO Receipt VALUES('4','1500','1833','20:00','4/21/2018','4','4');
INSERT INTO Receipt VALUES('5','1600','178','21:00','5/21/2018','5','6');
INSERT INTO Receipt VALUES('6','1905','212','22:00','6/21/2018','6','2');
INSERT INTO Receipt VALUES('7','2210','246','13:00','7/21/2018','7','6');
INSERT INTO Receipt VALUES('8','2515','279','14:00','8/21/2018','8','10');
INSERT INTO Receipt VALUES('9','2820','1209','15:00','9/21/2018','9','8');
INSERT INTO Receipt VALUES('10','3125','1683','16:00','10/21/2018','10','9');

INSERT INTO Offer VALUES('1','1/21/2018','2/21/2018','0.15');
INSERT INTO Offer VALUES('2','2/21/2018','3/21/2018','0.2');
INSERT INTO Offer VALUES('3','3/21/2018','4/21/2018','0.45');
INSERT INTO Offer VALUES('4','4/21/2018','5/21/2018','0.55');
INSERT INTO Offer VALUES('5','5/21/2018','6/21/2018','0.1');
INSERT INTO Offer VALUES('6','6/21/2018','7/21/2018','0.1');
INSERT INTO Offer VALUES('7','7/21/2018','8/21/2018','0.1');
INSERT INTO Offer VALUES('8','8/21/2018','9/21/2018','0.1');
INSERT INTO Offer VALUES('9','9/21/2018','10/21/2018','0.3');
INSERT INTO Offer VALUES('10','10/21/2018','11/21/2018','0.35');

INSERT INTO Items VALUES('1','shirt','shirtdetails','230','tops','P&B','5');
INSERT INTO Items VALUES('2','t-shirt','red sports Tshirt','160','tops','P&B','6');
INSERT INTO Items VALUES('3','trousers','detailed discription','300','trousers','Bershka','7');
INSERT INTO Items VALUES('4','jeans','detailed discription','250','category','Bershka','8');
INSERT INTO Items VALUES('5','sweatpants','detailed discription','180','category','P&B','9');
INSERT INTO Items VALUES('6','pullover','detailed discription','270','category','Bershka','10');
INSERT INTO Items VALUES('7','jacket','detailed discription','700','category','P&B','1');
INSERT INTO Items VALUES('8','hoodie','detailed discription','360','category','Bershka','2');
INSERT INTO Items VALUES('9','sweatshirt','detailed discription','360','category','TownTeam','3');
INSERT INTO Items VALUES('10','shirt','detailed discription','270','category','TownTeam','4');

INSERT INTO Supplier VALUES('1','Hamdy','Shokry','Tanta','Saad Zagloul','Gharbia','011732874','Hamdy@gmail.com');
INSERT INTO Supplier VALUES('2','Shokria','Hammad','Elharam','Elharam','Giza','011723456','Shokria@gmail.com');
INSERT INTO Supplier VALUES('3','Ismail','Shdeid','Elagouza','Abdelaziz','Cairo','011733454','Ismail@gmail.com');
INSERT INTO Supplier VALUES('4','Mostafa','Ibrahim','6th October','Elmehwar','Giza','015345555','Mostafa@gmail.com');
INSERT INTO Supplier VALUES('5','Magdy','Qandeel','Eldokki','Mekka','Cairo','010543645','Magdy@gmail.com');
INSERT INTO Supplier VALUES('6','Shimaa','Mohsen','Somouha','Elbahr','Alexandria','011732874','Shimaa@gmail.com');
INSERT INTO Supplier VALUES('7','Ahmed','Mostafa','Shibin Al-Kawm','Omar Afandy','Menofia','011484955','Ahmed@gmail.com');
INSERT INTO Supplier VALUES('8','Ibrahim','Mahmoud','Tanta','Gamal Abdelnaser','Gharbia','017748848','Ibrahim@gmail.com');
INSERT INTO Supplier VALUES('9','Fawzy','Sherif','Mansoura','Elmadares','Sharqia','019437474','Fawzy@gmail.com');
INSERT INTO Supplier VALUES('10','Hamad','Elgamal','New Cairo','Saad Zagloul','Cairo','012733474','Hamad@gmail.com');

INSERT INTO Shipment VALUES('1','1/21/2018','1');
INSERT INTO Shipment VALUES('2','1/25/2018','2');
INSERT INTO Shipment VALUES('3','2/21/2018','3');
INSERT INTO Shipment VALUES('4','2/25/2018','4');
INSERT INTO Shipment VALUES('5','3/21/2018','1');
INSERT INTO Shipment VALUES('6','3/25/2018','5');
INSERT INTO Shipment VALUES('7','4/21/2018','2');
INSERT INTO Shipment VALUES('8','4/25/2018','3');
INSERT INTO Shipment VALUES('9','5/21/2018','6');
INSERT INTO Shipment VALUES('10','6/25/2018','7');
INSERT INTO Shipment VALUES('11','7/21/2018','4');
INSERT INTO Shipment VALUES('12','7/25/2018','6');
INSERT INTO Shipment VALUES('13','8/21/2018','8');
INSERT INTO Shipment VALUES('14','9/25/2018','9');
INSERT INTO Shipment VALUES('15','10/21/2018','10');

INSERT INTO Supply_Store VALUES('1','3','1','100');
INSERT INTO Supply_Store VALUES('2','2','2','100');
INSERT INTO Supply_Store VALUES('3','1','3','100');
INSERT INTO Supply_Store VALUES('1','3','4','100');
INSERT INTO Supply_Store VALUES('5','5','5','50');
INSERT INTO Supply_Store VALUES('4','7','6','50');
INSERT INTO Supply_Store VALUES('2','10','7','50');
INSERT INTO Supply_Store VALUES('6','9','8','50');
INSERT INTO Supply_Store VALUES('7','6','9','50');
INSERT INTO Supply_Store VALUES('5','4','10','50');
INSERT INTO Supply_Store VALUES('8','2','11','100');
INSERT INTO Supply_Store VALUES('9','1','12','100');
INSERT INTO Supply_Store VALUES('10','1','13','100');
INSERT INTO Supply_Store VALUES('5','1','14','100');
INSERT INTO Supply_Store VALUES('2','1','15','100');

INSERT INTO PaymentOption VALUES('1','Cash');
INSERT INTO PaymentOption VALUES('2','Cash');
INSERT INTO PaymentOption VALUES('3','Cash');
INSERT INTO PaymentOption VALUES('4','Cash');
INSERT INTO PaymentOption VALUES('5','Cash');
INSERT INTO PaymentOption VALUES('6','Cash');
INSERT INTO PaymentOption VALUES('7','Cash');
INSERT INTO PaymentOption VALUES('8','Cash');
INSERT INTO PaymentOption VALUES('9','Cash');
INSERT INTO PaymentOption VALUES('10','Cash');

INSERT INTO SoldAt VALUES('20','80','1','9');
INSERT INTO SoldAt VALUES('10','90','2','2');
INSERT INTO SoldAt VALUES('30','70','3','1');
INSERT INTO SoldAt VALUES('40','60','4','5');
INSERT INTO SoldAt VALUES('12','38','5','5');
INSERT INTO SoldAt VALUES('35','15','6','7');
INSERT INTO SoldAt VALUES('5','45','7','4');
INSERT INTO SoldAt VALUES('8','42','9','6');
INSERT INTO SoldAt VALUES('9','41','10','2');
INSERT INTO SoldAt VALUES('10','90','2','8');
INSERT INTO SoldAt VALUES('55','45','1','3');
INSERT INTO SoldAt VALUES('80','20','1','10');
INSERT INTO SoldAt VALUES('12','88','1','5');
INSERT INTO SoldAt VALUES('34','66','1','2');

INSERT INTO R_Contains VALUES('1','1','8','360','0');
INSERT INTO R_Contains VALUES('1','1','2','160','0');
INSERT INTO R_Contains VALUES('2','2','1','230','0');
INSERT INTO R_Contains VALUES('1','2','2','160','0');
INSERT INTO R_Contains VALUES('1','3','7','700','0');
INSERT INTO R_Contains VALUES('2','4','7','700','0');
INSERT INTO R_Contains VALUES('1','4','2','160','0');
INSERT INTO R_Contains VALUES('2','5','7','700','0');
INSERT INTO R_Contains VALUES('1','5','1','230','0');
INSERT INTO R_Contains VALUES('2','6','7','700','0');
INSERT INTO R_Contains VALUES('1','6','1','230','0');
INSERT INTO R_Contains VALUES('1','6','2','160','0');
INSERT INTO R_Contains VALUES('3','7','9','360','0');
INSERT INTO R_Contains VALUES('3','7','8','360','0');
INSERT INTO R_Contains VALUES('1','7','3','300','0');
INSERT INTO R_Contains VALUES('3','8','9','360','0');
INSERT INTO R_Contains VALUES('3','8','8','360','0');
INSERT INTO R_Contains VALUES('1','8','3','300','0');
INSERT INTO R_Contains VALUES('1','8','2','160','0');
INSERT INTO R_Contains VALUES('4','9','4','250','0');
INSERT INTO R_Contains VALUES('5','9','5','180','0');
INSERT INTO R_Contains VALUES('5','9','10','180','0');
INSERT INTO R_Contains VALUES('3','10','7','700','0');
INSERT INTO R_Contains VALUES('2','10','1','230','0');
INSERT INTO R_Contains VALUES('3','10','2','160','0');
INSERT INTO R_Contains VALUES('2','10','4','250','0');

insert into User_Type values ('admin','admin','Admin','1',NULL);