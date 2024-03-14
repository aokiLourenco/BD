DROP TABLE IF EXISTS Fare
DROP TABLE IF EXISTS Airplane
DROP TABLE IF EXISTS Airplane_Type
DROP TABLE IF EXISTS Airport
DROP TABLE IF EXISTS Seat
DROP TABLE IF EXISTS Leg_Instance
DROP TABLE IF EXISTS Flight_Leg
DROP TABLE IF EXISTS Flight

CREATE TABLE Flight (
    Number INT NOT NULL,
    Airline VARCHAR(128) NOT NULL,
    Weekdays VARCHAR(128) NOT NULL,
    PRIMARY KEY (Number)
)

CREATE TABLE Flight_Leg(
    Flight_Number INT NOT NULL REFERENCES Flight(Number),
    Leg_no INT NOT NULL,
    Departure_Airport INT NOT NULL,
    Arrival_Airport INT NOT NULL,
    Schedule_dep_time VARCHAR(10) NOT NULL,
    Schedule_arr_time VARCHAR(10) NOT NULL
    PRIMARY KEY(Flight_Number,Leg_no)
)

CREATE TABLE Leg_Instance(
    [Date] VARCHAR(128) NOT NULL,
    Flight_Leg_Flight_Number INT NOT NULL,
    Flight_Leg_Leg_No INT NOT NULL,
    Airplane_id INT NOT NULL,
    Departs_Airport_Time INT NOT NULL,
    Arrival_Airport_time INT NOT NULL,
    Airport_Airport_code INT NOT NULL REFERENCES Airport(Airport_code),
	FOREIGN KEY (Flight_Leg_Flight_Number,Flight_Leg_Leg_No)
		REFERENCES Flight_Leg(Flight_Number,Leg_no),
    PRIMARY KEY([Date], Flight_Leg_Flight_Number,Flight_Leg_Leg_No),
)

CREATE TABLE Seat(
    Seat_no INT NOT NULL,
    [Date] VARCHAR(128) NOT NULL,
    Flight_Leg_Flight_Number INTEGER NOT NULL,
    Flight_Leg_Leg_No INT NOT NULL,
    Reservation_Customer_name VARCHAR(128) NOT NULL,
    Reservation_Cphone INT NOT NULL,
    FOREIGN KEY ([Date],Flight_Leg_Flight_Number,Flight_Leg_Leg_No)
		REFERENCES Leg_Instance([Date],Flight_Leg_Flight_Number,Flight_Leg_Leg_No),
	PRIMARY KEY(Seat_no,[Date], Flight_Leg_Flight_Number,Flight_Leg_Leg_No)
)

CREATE TABLE Airport(
    Airport_code INT NOT NULL,
    PRIMARY KEY(Airport_code),
    City VARCHAR(128) NOT NULL,
    State VARCHAR(128) NOT NULL,
    Name VARCHAR(128) NOT NULL
)

CREATE TABLE Airplane_Type(
    Type_name VARCHAR(128) NOT NULL,
    PRIMARY KEY(Type_name),
    Max_seats INT NOT NULL,
    Company VARCHAR(128) NOT NULL
)

CREATE TABLE Airplane(
    Airplane_id INT NOT NULL,
    Airplane_Type_name VARCHAR(128) NOT NULL REFERENCES Airplane_Type(Type_name),
    PRIMARY KEY (Airplane_id,Airplane_Type_name),
    Total_no_of_seats INT NOT NULL
)

CREATE TABLE Fare(
    Flight_Number INT NOT NULL REFERENCES Flight(Number),
    Code INT NOT NULL,
    PRIMARY KEY(Flight_Number, Code),
    Restrictions VARCHAR(128),
    Amount INT NOT NULL, 

)