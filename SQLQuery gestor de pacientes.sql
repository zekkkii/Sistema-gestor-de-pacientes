create database  Gestor_de_pacientes

create table usuarios
(
id int primary key identity,
nombre varchar(50),
apellido varchar(50),
correo varchar(30),
usuario varchar(15),
user_password varchar(50),
tipoUsuario varchar(10)
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
nombre varchar(50)
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
 
 select *from usuarios
  select *from medicos

  INSERT INTO medicos( nombre, apellido, correo, telefono, cedula, linkFoto) values(@nombre, @apellido, @correo, telefono, cedula, linkFoto)

 DELETE FROM usuarios WHERE id =1

 UPDATE usuarios SET nombre = @nombre, apellido = @apellido, correo = @correo, usuario = @usuario, user_password = @password, tipoUsuario = @tipoUser where id = @id

 SELECT id, nombre, apellido, correo, usuario, user_password as contraseña, tipoUsuario as funcion  FROM usuarios

 SELECT id, nombre, apellido, correo, telefono, cedula FROM medicos