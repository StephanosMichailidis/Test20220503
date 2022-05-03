CREATE TABLE Fakturace (
id int identity(1,1) NOT NULL Primary key, 
datum DATE,
cislo int,
odberatel nvarchar(30),
nazev nvarchar(10),
pocet int,
cenajednoho float,
cenacelkem float,
DPH float,
cenaDPH float)


