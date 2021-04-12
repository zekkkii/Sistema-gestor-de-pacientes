create database  Gestor_de_pacientes

create table usuarios
(
id int primary key identity,
nombre varchar(50),
apellido varchar(50),
correo varchar(30),
usuario varchar(15),
user_password varchar(50),
tipoUsuario tinyint
)

create table medicos
(
id int primary key identity,
nombre varchar(50),
apellido varchar(50),
correo varchar(30),
telefono varchar(13),
cedula varchar(12),
linkFoto varchar(max)
)

create table pacientes
(
id int primary key identity,
nombre varchar(50),
apellido varchar(50),
telefono varchar(30),
direccion varchar(13),
cedula varchar(12),
fechaNacimiento varchar(12),
fumador varchar(6),
alergias varchar(max),
linkFoto varchar(max)
)

create table pruebas_laboratorio
(
id int primary key identity,
nombre varchar(50),
idPaciente int,
cedulaPaciente tinyint,
foreign key(idPaciente) references pacientes(id)
)

create table citas
(
id int primary key identity,
idPaciente int,
idDoctor int,
fechaCita varchar(12),
horaCita varchar(12),
causaCita varchar(max),
estadoCita varchar(30),
foreign key(idPaciente) references pacientes(id),
foreign key(idDoctor) references medicos(id),
)

