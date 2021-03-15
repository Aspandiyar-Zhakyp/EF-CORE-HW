create database TheLibrary
use TheLibrary

create table Books (
	Id int primary key identity,
	Title varchar(40)
);



insert into Books values ('Sherlock Holmes'), 
('Master and Margarett'),
('Portret of Dorian Grey'), 
('Lord of Rings'),
('Dogs heart'),
('Little Prince'),
('1984'),
('Custle')



create table Author (
	Id int primary key identity,
	FirstName varchar(20),
	LastName varchar(20)
);

insert into Author values ('Artur', 'Doyl'),
('Mikhail', 'Bulgakov'),
('Oscar', 'Wilde'),
('George', 'Talking'),
('Antoine', 'Saint-exupery'),
('George', 'Oruel'),
('Franz', 'Kafka')

create table Clients (
	Id int primary key identity,
	FirstName varchar(20),
	LastName varchar(20),
	IsDebtor bit
);

insert into Clients values ('Arina', 'Ogur', 1), 
('Esenia', 'Nova', 1), 
('Polina', 'Sabanova', 1), 
('Eva', 'Plotnikova', 1), 
('Karina', 'Beresalvets', 1), 
('Alina', 'Demina', 1)

create table BooksTheLibrary (
	Id int primary key identity,
	Id_book int foreign key references Books(Id),
	Id_author int foreign key references Author(Id),
	Id_client int foreign key references Clients(Id)
);

insert into BooksTheLibrary values
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 2, null),
(6, 5, null),
(7, 6, null),
(8, 7, 5)