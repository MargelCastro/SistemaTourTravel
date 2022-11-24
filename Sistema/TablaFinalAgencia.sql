create table usuarios(
Id int identity (1,1)primary key  not null,
NombreUsuario varchar(50)not null,
pass varchar(50)not null,
TipoUsuario varchar(50)not null,
Nombre_Apellido varchar(50)not null,
);

insert into usuarios values('Fernanda','RosaFernanda','Administrador','Fernanda Jarquin');
insert into usuarios values('Ariel','ArielDavid','Invitado','Ariel Castellon');
insert into usuarios values('Margel','MargelGabriel','Invitado','Margel Castro');

select*from usuarios