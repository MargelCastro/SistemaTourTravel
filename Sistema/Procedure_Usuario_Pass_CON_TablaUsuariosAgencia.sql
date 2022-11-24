USE [AgenciaTourDB]
GO
create proc login_usuarios
@NombreUsuario varchar(50),
@pass varchar(50)
as
select TipoUsuario,Nombre_Apellido,NombreUsuario,pass from usuarios
where NombreUsuario=@NombreUsuario and pass=@pass 
GO

USE [AgenciaTourDB]
GO
create proc Presentacion
@NombreUsuario varchar(50),
@TipoUsuario varchar(50)
as
select TipoUsuario,Nombre_Apellido,NombreUsuario,pass from usuarios
where NombreUsuario=@NombreUsuario and TipoUsuario=@TipoUsuario
GO
