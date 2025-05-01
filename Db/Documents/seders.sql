INSERT INTO role (role_name, description) VALUES 
('Doctor', 'Usuario con permisos de médico'),
('Admin', 'Usuario administrador');

-- Información de 10 doctores, 1 inactivo y 9 usuarios
INSERT INTO person_information (firstname, surname, date_of_birth, dui, phone_number, email) VALUES 
('Juan', 'Perez', '1985-03-15', '12345678', '1234-5678', 'juan.perez@mail.com'),
('Ana', 'Lopez', '1990-07-20', '23456789', '2345-6789', 'ana.lopez@mail.com'),
('Carlos', 'Gonzalez', '1982-02-25', '34567890', '3456-7890', 'carlos.gonzalez@mail.com'),
('Maria', 'Hernandez', '1978-11-30', '45678901', '4567-8901', 'maria.hernandez@mail.com'),
('Luis', 'Martinez', '1992-08-10', '56789012', '5678-9012', 'luis.martinez@mail.com'),
('Beatriz', 'Morales', '1987-05-12', '67890123', '6789-0123', 'beatriz.morales@mail.com'),
('Miguel', 'Jimenez', '1989-04-05', '78901234', '7890-1234', 'miguel.jimenez@mail.com'),
('Laura', 'Castillo', '1991-09-18', '89012345', '8901-2345', 'laura.castillo@mail.com'),
('Roberto', 'Ramirez', '1984-01-27', '90123456', '9012-3456', 'roberto.ramirez@mail.com'),
('Patricia', 'Diaz', '1985-06-02', '01234567', '0123-4567', 'patricia.diaz@mail.com'); 

-- Información de 20 pacientes
INSERT INTO patient (firstname, surname, date_of_birth, dui, phone_number, email, blood_group, gender) VALUES 
('Pedro', 'Martinez', '1990-01-10', '12341234', '2345-6789', 'pedro.martinez@mail.com', 'A+', 'Masculino'),
('Sofia', 'Perez', '1985-03-15', '23452345', '3456-7890', 'sofia.perez@mail.com', 'OC-', 'Femenino'),
('Antonio', 'Gomez', '1992-07-21', '34563456', '4567-8901', 'antonio.gomez@mail.com','B-', 'Masculino'),
('Carmen', 'Sanchez', '1987-05-18', '45674567', '5678-9012', 'carmen.sanchez@mail.com', 'O+', 'Femenino'),
('Raul', 'Fernandez', '1989-11-30', '56785678', '6789-0123', 'raul.fernandez@mail.com', 'O+','Masculino'),
('Isabel', 'Romero', '1991-02-05', '67896789', '7890-1234', 'isabel.romero@mail.com', 'A-','Femenino'),
('David', 'Alvarez', '1993-06-25', '78907890', '8901-2345', 'david.alvarez@mail.com', 'BO-','Masculino'),
('Estela', 'Torres', '1990-12-30', '89018901', '9012-3456', 'estela.torres@mail.com','AB+','Femenino'),
('Eva', 'Lopez', '1988-09-01', '90129012', '0123-4567', 'eva.lopez@mail.com','O-','Femenino'),
('Fernando', 'Rodriguez', '1995-01-17', '01230123', '1234-5678', 'fernando.rodriguez@mail.com', 'A+', 'Masculino'),
('Pedro', 'Soto', '1994-03-25', '12341234', '2345-6789', 'pedro.soto@mail.com', 'O-','Masculino'),
('Andrea', 'Mendez', '1993-08-22', '23452345', '3456-7890', 'andrea.mendez@mail.com', 'O+','Femenino'),
('Javier', 'Herrera', '1987-04-13', '34563456', '4567-8901', 'javier.herrera@mail.com', 'B+', 'Masculino'),
('Maria', 'Vazquez', '1990-02-11', '45674567', '5678-9012', 'maria.vazquez@mail.com', 'AB-','Femenino'),
('Lucia', 'Gomez', '1992-09-07', '56785678', '6789-0123', 'lucia.gomez@mail.com', 'AB-','Femenino'),
('Carlos', 'Torres', '1988-12-20', '67896789', '7890-1234', 'carlos.torres@mail.com', 'BO+','Masculino'),
('Daniela', 'Ruiz', '1991-11-02', '78907890', '8901-2345', 'daniela.ruiz@mail.com', 'O-','Femenino'),
('Manuel', 'Castro', '1989-07-30', '89018901', '9012-3456', 'manuel.castro@mail.com', 'A-','Masculino'),
('Luis', 'Martin', '1986-04-23', '90129012', '0123-4567', 'luis.martin@mail.com', 'A+','Masculino'),
('Ricardo', 'Jimenez', '1993-05-15', '01230123', '1234-5678', 'ricardo.jimenez@mail.com', 'O-','Masculino');

INSERT INTO [user] (information, password, role) VALUES 
((SELECT id FROM person_information WHERE email = 'juan.perez@mail.com'), 'password123', 1),
((SELECT id FROM person_information WHERE email = 'ana.lopez@mail.com'), 'password234', 1),
((SELECT id FROM person_information WHERE email = 'carlos.gonzalez@mail.com'), 'password567', 1),
((SELECT id FROM person_information WHERE email = 'maria.hernandez@mail.com'), 'password891', 1),
((SELECT id FROM person_information WHERE email = 'luis.martinez@mail.com'), 'password101', 1),
((SELECT id FROM person_information WHERE email = 'beatriz.morales@mail.com'), 'password112', 1),
((SELECT id FROM person_information WHERE email = 'miguel.jimenez@mail.com'), 'password214', 1),
((SELECT id FROM person_information WHERE email = 'laura.castillo@mail.com'), 'password141', 1),
((SELECT id FROM person_information WHERE email = 'roberto.ramirez@mail.com'), 'password516', 2),
-- Usuario inactivo
((SELECT id FROM person_information WHERE email = 'patricia.diaz@mail.com'), 'password128', 1); 

INSERT INTO doctor (information, gender, specialism, medical_license, active, hiring_date, work_area) VALUES 
((SELECT id FROM person_information WHERE email = 'juan.perez@mail.com'), 'Masculino', 'Cardiología', 'ML12345', 1, '2020-01-10', 1),
((SELECT id FROM person_information WHERE email = 'ana.lopez@mail.com'), 'Femenino', 'Pediatría', 'ML12346', 1, '2019-07-15', 2),
((SELECT id FROM person_information WHERE email = 'carlos.gonzalez@mail.com'), 'Masculino', 'Dermatología', 'ML12347', 1, '2018-05-25', 3),
((SELECT id FROM person_information WHERE email = 'maria.hernandez@mail.com'), 'Femenino', 'Neurología', 'ML12348', 1, '2017-03-13', 1),
((SELECT id FROM person_information WHERE email = 'luis.martinez@mail.com'), 'Masculino', 'Traumatología', 'ML12349', 1, '2021-11-05', 2),
((SELECT id FROM person_information WHERE email = 'beatriz.morales@mail.com'), 'Femenino', 'Oncología', 'ML12350', 1, '2020-06-18', 3),
((SELECT id FROM person_information WHERE email = 'miguel.jimenez@mail.com'), 'Masculino', 'Psiquiatría', 'ML12351', 1, '2019-02-20', 1),
((SELECT id FROM person_information WHERE email = 'laura.castillo@mail.com'), 'Femenino', 'Endocrinología', 'ML12352', 1, '2020-08-12', 2),
((SELECT id FROM person_information WHERE email = 'roberto.ramirez@mail.com'), 'Masculino', 'Ginecología', 'ML12353', 0, '2021-01-10', 3), -- Doctor inactivo
((SELECT id FROM person_information WHERE email = 'patricia.diaz@mail.com'), 'Femenino', 'Medicina General', 'ML12354', 1, '2018-02-20', 1);

-- 30 prescripciones médicas
INSERT INTO appointment (appointment_date, reasons, doctor_id, patient_id, room_id ) VALUES
('2025-01-15', 'Chequeo general', (SELECT id FROM doctor WHERE specialism = 'Pediatría'), (SELECT id FROM patient WHERE email = 'estela.torres@mail.com'), 1),
('2025-01-20', 'Dolor de cabeza', (SELECT id FROM doctor WHERE specialism = 'Neurología'), (SELECT id FROM patient WHERE email = 'isabel.romero@mail.com'), 3),
('2025-02-10', 'Tos persistente', (SELECT id FROM doctor WHERE specialism = 'Medicina General'), (SELECT id FROM patient WHERE email = 'estela.torres@mail.com'), 4),
('2025-03-01', 'Control de presión arterial', (SELECT id FROM doctor WHERE specialism = 'Cardiología'), (SELECT id FROM patient WHERE email = 'pedro.martinez@mail.com'), 6),
('2025-03-05', 'Consulta prenatal', (SELECT id FROM doctor WHERE specialism = 'Ginecología'), (SELECT id FROM patient WHERE email = 'isabel.romero@mail.com'), 8),
('2025-03-18', 'Chequeo escolar', (SELECT id FROM doctor WHERE specialism = 'Pediatría'), (SELECT id FROM patient WHERE email = 'andrea.mendez@mail.com'), 4),
('2025-03-28', 'Fiebre sin causa', (SELECT id FROM doctor WHERE specialism = 'Medicina General'), (SELECT id FROM patient WHERE email = 'manuel.castro@mail.com'), 6),
('2025-03-30', 'Chequeo de diabetes', (SELECT id FROM doctor WHERE specialism = 'Endocrinología'), (SELECT id FROM patient WHERE email = 'daniela.ruiz@mail.com'), 8);

INSERT INTO prescription (appointment_id, issue_date)
VALUES 
((SELECT TOP 1 id FROM appointment ORDER BY appointment_date ASC), '2025-01-15'),
((SELECT id FROM appointment WHERE reasons = 'Dolor de cabeza'), '2025-01-20'),
((SELECT id FROM appointment WHERE reasons = 'Tos persistente'), '2025-02-10'),
((SELECT id FROM appointment WHERE reasons = 'Chequeo post-operatorio'), '2025-02-15'),
((SELECT id FROM appointment WHERE reasons = 'Control de presión arterial'), '2025-03-01'),
((SELECT id FROM appointment WHERE reasons = 'Consulta prenatal'), '2025-03-05'),
((SELECT id FROM appointment WHERE reasons = 'Dolor de espalda'), '2025-03-10'),
((SELECT id FROM appointment WHERE reasons = 'Infección de garganta'), '2025-03-15'),
((SELECT id FROM appointment WHERE reasons = 'Chequeo escolar'), '2025-03-18'),
((SELECT id FROM appointment WHERE reasons = 'Alergia a medicamentos'), '2025-03-20'),
((SELECT id FROM appointment WHERE reasons = 'Dolor estomacal'), '2025-03-25'),
((SELECT id FROM appointment WHERE reasons = 'Fiebre sin causa'), '2025-03-28'),
((SELECT id FROM appointment WHERE reasons = 'Chequeo de diabetes'), '2025-03-30'),
((SELECT id FROM appointment WHERE reasons = 'Control post tratamiento'), '2025-04-02'),
((SELECT id FROM appointment WHERE reasons = 'Revisión anual'), '2025-04-05');

INSERT INTO area (area_name, floor_number) VALUES
('Emergencias', 1),
('Pediatría', 2),
('Cardiología', 3),
('Neurología', 3),
('Oncología', 4),
('Cirugía General', 2),
('Ginecología', 2),
('Medicina Interna', 3),
('Ortopedia', 4),
('Urología', 4),
('Dermatología', 5),
('Endocrinología', 5),
('Gastroenterología', 5),
('Otorrinolaringología', 6),
('Inmunología', 6),
('Psiquiatría', 6),
('Neumología', 5),
('Rehabilitación', 1),
('Farmacia', 1),
('Laboratorio Clínico', 1);

INSERT INTO room (room_name, area_id) VALUES
('A101', 1), ('A102', 1), ('A103', 1), ('A104', 1),
('B201', 2), ('B202', 2), ('B203', 2),
('C301', 3), ('C302', 3),
('D301', 4), ('D302', 4),
('E401', 5), ('E402', 5),
('F201', 6), ('F202', 6),
('G202', 7),
('H301', 8), ('H302', 8),
('I401', 9), ('I402', 9),
('J401', 10), ('J402', 10),
('K501', 11), ('K502', 11),
('L501', 12), ('L502', 12),
('M501', 13), ('M502', 13),
('N601', 14), ('N602', 14),
('O601', 15),
('P601', 16), ('P602', 16),
('Q501', 17), ('Q502', 17),
('R101', 18), ('R102', 18), ('R103', 18),
('S101', 19), ('S102', 19),
('T101', 20), ('T102', 20), ('T103', 20), ('T104', 20),
('U101', 19), ('U102', 19),
('V101', 18), ('V102', 18),
('W101', 17), ('W102', 17),
('X101', 16);
