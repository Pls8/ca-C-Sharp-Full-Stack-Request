--create database Clinic
use Clinic
create table Patients (
    patientID int primary key,
    name varchar(50) not null,
    phone varchar(15),
    email varchar(50)
);

create table Doctors(
    doctorID int primary key,
    name varchar(50),
    specialty varchar(50) not null,
    phone varchar(50)
);

create table Appointments (
    appointmentID int primary key,
    patientID int foreign key references Patients(patientID),
    doctorID int foreign key references Doctors(doctorID),
    date DATE not null,
    time varchar(50) not null,
    status varchar(50)
);
