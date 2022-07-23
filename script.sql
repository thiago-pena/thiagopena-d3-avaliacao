CREATE DATABASE "thiagopena-d3-avaliacao";
GO

USE "thiagopena-d3-avaliacao";
GO

CREATE TABLE Users(
	id VARCHAR(255) PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
	email VARCHAR(255) UNIQUE NOT NULL,
	password VARCHAR(255) NOT NULL
);
GO

INSERT INTO Users (id, name, email, password)
VALUES
	('53509b82-a351-426c-8a92-e60f63759768', 'Admin', 'admin@email.com', 'admin123'),
	('2758e8cf-e0a6-48c4-abf9-fd0e6ae61f72', 'Thiago Pena', 'tjbpena@gmail.com', 'pena123')
;
GO

SELECT * FROM Users;
