CREATE TABLE Departament (
ID INTEGER NOT NULL PRIMARY KEY,
"Name" VARCHAR 
);

CREATE TABLE Employee (
ID INTEGER NOT NULL PRIMARY KEY,
Departament_Id INTEGER REFERENCES Departament(ID),
Cheief_id INTEGER REFERENCES Employee(ID),
"Name" VARCHAR,
Salary INTEGER
)