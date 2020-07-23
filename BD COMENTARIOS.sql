Create Database BD_comentarios

use BD_comentarios


create table Usuarios(
idusuario int not null primary key,
nomuser varchar (50) not null UNIQUE,
email varchar (50) not null
)

create table publicaciones
(
idpublicacion varchar (50) not null primary key,
idusuario int not null,
comentario varchar(50)  not null,
constraint fk_iduser foreign key(idusuario) references Usuarios(idusuario)

)

--Procedimiento alamcenado que me inserta un usuario
GO
create procedure insertarusuario 
@iduser int ,
@nomuser varchar (50),
@email varchar(50)
as
  IF(@iduser IS NOT NULL AND @nomuser  IS NOT NULL AND @email IS NOT NULL)
   
   BEGIN
        
		IF(EXISTS(select idusuario from Usuarios where idusuario=@iduser) OR EXISTS(select nomuser from Usuarios where nomuser=@nomuser))
	    
		   BEGIN 
		
		       print 'No podemos registrar el usuario'+@nomuser +' o porque su id '+ ltrim(str(@iduser))+ ' ya se encuentra registrado intente nuevamente'
		
		   END
		
		ELSE
		
		   BEGIN TRY
		   
		       insert into Usuarios values (@iduser,@nomuser,@email)
           
		   END TRY
		   
		   BEGIN CATCH
		      
			   print 'No pudimos registrar a el usuario por el siguiente numero de error'+ltrim(str(ERROR_NUMBER()))
		   
		   END CATCH
   END
ELSE
  
  print 'No deje campos vacios por favor'

exec insertarusuario 424,'Estero789','estebanardila57@gmail.com'


--Procedimiento alamacenado que me lista el nombre de un usuario entregandole el id
GO
Create procedure listarusuariosporID
@iduser int 
as
 IF(@iduser IS NOT NULL)
   BEGIN 
      IF(EXISTS(select idusuario from Usuarios where idusuario=@iduser))
        BEGIN  
	
		 select nomuser from Usuarios where idusuario=@iduser	  
        
		END
      ELSE
	   BEGIN 
	      print'el id '+ltrim(str(@iduser))+' No se encuentra registrado en la base de datos'
	   END
	   
   END
 ELSE
  print'No deje campos vacios por favor' 

exec listarusuariosporID 456


--Procedimiento alamcenado que me lista los nombres de todos los usuarios registrados en la BD
go
Create procedure listarusers
as
  select nomuser  from Usuarios 

exec listarusers

--procedimiento alamacenado que me retorna el id de un usuario indicandole el nombre
go
create procedure obteneriduser
@nomuser varchar(50)
as
  IF(@nomuser IS NOT NULL)
    BEGIN
	   IF(EXISTS(select nomuser from Usuarios where nomuser=@nomuser))
	    BEGIN 
		   select idusuario from Usuarios where nomuser=@nomuser
		END
       ELSE
	    BEGIN 
		   print ' el usuario '+@nomuser+' no se encuetra registrado en la base de datos intentelo nuevamente'
		END
	END
  ELSE
  print 'no deje campos vacios por favor'

exec obteneriduser 'ark1409'
 

--Procedimiento almacenado que me inserta las publicaciones
go
create procedure insertarpublicaciones
@idpublicacion varchar (50),
@iduser int,
@comen varchar(50)
as
 IF (@idpublicacion IS NOT NULL AND @iduser IS NOT NULL AND @comen IS NOT NULL)

  BEGIN TRY
        
		INSERT INTO publicaciones values(@idpublicacion,@iduser,@comen)
	  
  END TRY

  BEGIN CATCH
    
	print 'No pudimos registrar su publicacion por el siguiente numero de error ' + ltrim(str(ERROR_NUMBER())) +' verifique que el codigo de la publicacion no este registrado y que el usuario si se encuentre registrado en la base de datos por favor'

  END CATCH

 ELSE
 
  print 'No deje campos vacios por favor'  

  select*from Usuarios

exec insertarpublicaciones  '766682cug',556,'Lluvia :('

--procedimiento que me lista el id de las publicaciones realizadas
go
create procedure listaridpublica
as
select idpublicacion from publicaciones

exec listaridpublica


--procedimeinto que me lista las publiaciones asociadas a un usuario
go
create procedure listarpublisusario
@idusua int 
as
if(@idusua is not null)
   BEGIN
      select idpublicacion as 'ID publicación asociada' from publicaciones where idusuario=@idusua group by idpublicacion,idusuario 
   END
else
 print 'No deje campso vacios por favor'
  
exec listarpublisusario 424

--procedimiento almacenado que me lista todas las publicaciones y comentarios asociados a un usuario
Go
create procedure listarpubliasociadas
@idpublicacion varchar(50)
as
IF (@idpublicacion IS NOT NULL)
   BEGIN TRY
       select idpublicacion as 'ID publicación', Usuarios.nomuser as 'Nombre User',comentario as 'Comentario realizado' from publicaciones inner join  Usuarios on publicaciones.idusuario=Usuarios.idusuario where publicaciones.idpublicacion=@idpublicacion Group by idpublicacion,Usuarios.nomuser,publicaciones.idusuario,comentario
   END TRY

   BEGIN CATCH
      
	  print 'No pudimos realizar  la operacion por el siguiente numero de error ' +ltrim(str(ERROR_NUMBER()))
  
   END CATCH
ELSE
 print ' NO deje campos vacios por favor'

exec listarpubliasociadas  '8389cg'




