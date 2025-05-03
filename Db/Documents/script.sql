CREATE DATABASE clinicDB;

use [clinicDB]

CREATE TABLE role(
    id INT IDENTITY(1,1) PRIMARY KEY,
    role_name VARCHAR(40) NOT NULL,
    description VARCHAR(250) NOT NULL,
);

CREATE TABLE person_information(
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    firstname VARCHAR(10) NOT NULL,
    surname VARCHAR(10) NOT NULL,
    date_of_birth DATE NOT NULL,
    dui CHAR(10),
    phone_number CHAR(14) NOT NULL,
    email VARCHAR NOT NULL UNIQUE
);

CREATE TABLE [user] (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    information UNIQUEIDENTIFIER NOT NULL,
    password VARCHAR NOT NULL UNIQUE,
    role INT NOT NULL,
    CONSTRAINT FK_ROLE_USER FOREIGN KEY ( role ) REFERENCES role( id ),
    CONSTRAINT FK_INFORMATION_USER FOREIGN KEY( information ) REFERENCES person_information( id ) 
);

CREATE TABLE area(
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    area_name VARCHAR(50) NOT NULL,
    floor_number INT NOT NULL
);

CREATE TABLE room(
    id INT IDENTITY(1,1) PRIMARY KEY,
    room_name CHAR(10),
    area_id INT NOT NULL,
    CONSTRAINT FK_AREA_ROOM FOREIGN KEY ( area_id ) REFERENCES area( id )
);

CREATE TABLE doctor(
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    information UNIQUEIDENTIFIER NOT NULL,
    gender VARCHAR(10) CHECK ( gender IN ('Masculino', 'Femenino') ) NOT NULL,
    specialism VARCHAR(40) NOT NULL,
    medical_license VARCHAR(40) NOT NULL UNIQUE,
    active BIT NOT NULL DEFAULT 0,
    hiring_date DATE NOT NULL,
    work_area INT NOT NULL
    CONSTRAINT FK_DOCTOR_INFORMATION FOREIGN KEY ( information ) REFERENCES person_information( id ),
    CONSTRAINT FK_WORK_AREA FOREIGN KEY ( work_area ) REFERENCES area( id )
);

CREATE TABLE patient(
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    firstname VARCHAR(10) NOT NULL,
    surname VARCHAR(10) NOT NULL,
    phone_number CHAR(14) NOT NULL,
    dui CHAR(8) NOT NULL,
    email VARCHAR(200) NOT NULL UNIQUE,
    gender VARCHAR(10) CHECK(  gender IN ( 'Masculino', 'Femenino' ) ) NOT NULL,
    blood_group VARCHAR(5) NOT NULL,
    date_of_birth DATE NOT NULL
);


CREATE TABLE appointment(
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    appointment_date DATE NOT NULL,
    reasons VARCHAR(200) NOT NULL,
    doctor_id UNIQUEIDENTIFIER NOT NULL, 
    patient_id UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_DOCTOR_APPOIMENT FOREIGN KEY ( doctor_id ) REFERENCES doctor( id ),
    CONSTRAINT FK_PATIENT_ID FOREIGN KEY( patient_id ) REFERENCES patient( id )
);


CREATE TABLE prescription(
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    appointment_id UNIQUEIDENTIFIER NOT NULL UNIQUE,
    issue_date DATE NOT NULL,
    CONSTRAINT FK_PRESCRIPTION_APPOIMENT FOREIGN KEY ( appointment_id ) REFERENCES appointment( id )
);

CREATE TABLE prescription_drug(
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    drug_name VARCHAR(100) NOT NULL,
    duration VARCHAR(20) NOT NULL,
    dose VARCHAR(20) NOT NULL,
    frecuency VARCHAR(20) NOT NULL,
    prescription_id UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_PRESCRIPTION_DRUG FOREIGN KEY ( prescription_id ) REFERENCES prescription( id )
);

CREATE TABLE medical_history(
    id INT IDENTITY(1,1) PRIMARY KEY,
    responsible_doctor UNIQUEIDENTIFIER NOT NULL,
    patient_id UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_MEDICAL_HISTORY_PATIENT FOREIGN KEY ( patient_id ) REFERENCES patient( id ),
    CONSTRAINT FK_MEDICAL_HISTORY_DOCTOR FOREIGN KEY ( responsible_doctor ) REFERENCES doctor( id ) 
);

CREATE TABLE medication(
    id INT IDENTITY(1,1) PRIMARY KEY,
    drug VARCHAR(100) NOT NULL,
    dose VARCHAR(20) NOT NULL,
    duration VARCHAR(20) NOT NULL,
    observation VARCHAR(200) NOT NULL,
    medical_history_id INT NOT NULL,
    CONSTRAINT FK_MEDICATION_MEDICAL_HISTORY FOREIGN KEY ( medical_history_id ) REFERENCES medical_history( id )
);

CREATE TABLE diagnoses(
    id INT IDENTITY(1,1) PRIMARY KEY,
    disease VARCHAR(100) NOT NULL,
    severity VARCHAR(20) CHECK ( severity IN ('low', 'Medium', 'High') ) NOT NULL,
    notes VARCHAR(200) NOT NULL,
    medical_history_id INT NOT NULL,
    CONSTRAINT FK_DIAGNOSES_MEDICAL_HISTORY FOREIGN KEY ( medical_history_id ) REFERENCES medical_history( id )
);

-------------------------------ALTERACIONES Y CORRECCIONES---------------
ALTER TABLE appointment ADD room_id INT NOT NULL;
ALTER TABLE appointment ADD CONSTRAINT FK_APPOINMENT_ROOM FOREIGN KEY (room_id) REFERENCES room( id );

SELECT 
    tc.CONSTRAINT_NAME,
    tc.CONSTRAINT_TYPE,
    ccu.COLUMN_NAME
FROM 
    INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
JOIN 
    INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu
    ON tc.CONSTRAINT_NAME = ccu.CONSTRAINT_NAME
WHERE 
    tc.TABLE_NAME = 'room';

SELECT TABLE_NAME, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '<table name>'
