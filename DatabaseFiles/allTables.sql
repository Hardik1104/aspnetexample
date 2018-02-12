use libraryDB;
Create Table tblGenre
(
	genre nchar(20)
);
Create table tblUserInfo
 (
	userId int identity(1,1) ,
	userName nchar(20),
	password nchar(10),
	PRIMARY KEY (userId)
 );
 Create table tblBookInfo
 (
	bookId int identity(1,1) ,
	bookName nchar(20),
	Author nchar(20),
	ISBN nchar(10),
	Genre nchar(6),
	pageCount nchar(6),
	Lent nchar(10),
	FriendName nchar(6),
	Description nchar(200),
	PRIMARY KEY (bookId)
 );