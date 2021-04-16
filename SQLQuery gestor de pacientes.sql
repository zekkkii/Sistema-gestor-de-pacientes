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


create table resultados_pruebas_laboratorio
(
id int primary key identity,
idPaciente int,
cedula varchar(12),
idPrueba_lab int,
resultados varchar(max),
estado  varchar(25),
foreign key(idPaciente) references pacientes(id),
foreign key(idPrueba_lab) references pruebas_laboratorio(id)
)


 
 select *from usuarios
 select *from medicos
 SELECT * FROM pruebas_laboratorio
 SELECT * FROM pacientes
 SELECT * FROM resultados_pruebas_laboratorio


INSERT INTO pruebas_laboratorio(nombre) VALUES(@nombre)

  INSERT INTO medicos( nombre, apellido, correo, telefono, cedula, linkFoto) values(@nombre, @apellido, @correo, telefono, cedula, linkFoto)

  INSERT INTO pacientes(nombre, apellido, telefono, direccion,cedula,fechaNacimiento,fumador, alergias, linkFoto) VALUES(@nombre, @apellido, @telefono, @direccion, @cedula, @fechaNacimiento, @fumador, @alergias, @linkFoto)

  DELETE FROM usuarios WHERE id =1
  DELETE FROM pacientes WHERE id =1 


 UPDATE  usuarios SET nombre = @nombre, apellido = @apellido, correo = @correo, usuario = @usuario, user_password = @password, tipoUsuario = @tipoUser where id = @id
 

 UPDATE pacientes SET nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion, cedula = @cedula, fechaNacimiento = @fechaNacimiento, fumador = @fumador, alergias = @alergias, linkFoto = @linkFoto WHERE id = @id

 
UPDATE resultados_pruebas_laboratorio SET resultados = @resultados, estado = 'completado' where id = @id




SELECT id, nombre, apellido, correo, usuario, user_password as contraseña, tipoUsuario as funcion  FROM usuarios 

SELECT id, nombre, apellido, correo, telefono, cedula FROM medicos

SELECT id, nombre, apellido, telefono, direccion,cedula,fechaNacimiento as 'Fecha de nacimiento',fumador, alergias FROM pacientes


SELECT r.id, p.nombre, p.apellido, r.cedula, pl.nombre, r.resultados, r.estado
from resultados_pruebas_laboratorio r
INNER JOIN pacientes p on r.idPaciente = p.id
INNER JOIN pruebas_laboratorio pl on r.idPrueba_lab = pl.id
WHERE r.resultados = 'pendiente'


SELECT r.id, p.nombre, p.apellido, r.cedula, pl.nombre, r.resultados, r.estado
from resultados_pruebas_laboratorio r
INNER JOIN pacientes p on r.idPaciente = p.id
INNER JOIN pruebas_laboratorio pl on r.idPrueba_lab = pl.id
WHERE r.cedula = '0123456789'

insert into pacientes(nombre, apellido) values('juan','perez')
insert into resultados_pruebas_laboratorio(idPaciente,cedula,idPrueba_lab, resultados) values(2,'0123456789',1,'completados')

