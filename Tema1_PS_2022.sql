use ticketingsystem;

DROP TABLE IF EXISTS Users;
CREATE TABLE Users(
	id INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(255) NOT NULL,
	password VARCHAR(255) NOT NULL,
	name VARCHAR(255) NOT NULL,
	role VARCHAR(255) NOT NULL,
);

DROP TABLE IF EXISTS Spectacole;
CREATE TABLE Spectacole(
	id INT IDENTITY(1,1) PRIMARY KEY,
	titlu VARCHAR(255) NOT NULL,
	regizor VARCHAR(255) NOT NULL,
	actori VARCHAR(8000) NOT NULL,
	data datetime NOT NULL,
	nrBilete INT NOT NULL
);

DROP TABLE IF EXISTS Bilete;
CREATE TABLE Bilete(
	id INT IDENTITY(1,1) PRIMARY KEY,
	rand INT NOT NULL,
	numar INT NOT NULL,
	stare BIT NOT NULL,
	spectacolID INT FOREIGN KEY REFERENCES Spectacole(id)
);

INSERT INTO Users(username, password, role, name) VALUES ('admin1', '827ccb0eea8a706c4c34a16891f84e7b', 'administrator', 'Marcel'); --12345
INSERT INTO Users(username, password, role, name) VALUES ('admin2', '827ccb0eea8a706c4c34a16891f84e7b', 'administrator', 'Mirel');  --12345
INSERT INTO Users(username, password, role, name) VALUES ('operator1', '01cfcd4f6b8770febfb40cb906715822', 'operator', 'Ionut');   --54321

INSERT INTO Spectacole(titlu, regizor, actori, data, nrBilete) VALUES ('Death on the Nile', 'Kenneth Branagh', 'Gal Gadot,Kenneth Branagh, Armie Hammer', '20220410 8:34:00 PM', '4');
INSERT INTO Spectacole(titlu, regizor, actori, data, nrBilete) VALUES ('The lost city', 'Aaron Nee, Adam Nee', 'Sandra Bullock, Channing Tatum, Daniel Radcliffe', '20220410 9:00:00 PM', '5');

INSERT INTO Bilete(rand, numar, stare, spectacolID) VALUES ('1', '1', 'false', '1');
INSERT INTO Bilete(rand, numar, stare, spectacolID) VALUES ('1', '1', 'false', '2');