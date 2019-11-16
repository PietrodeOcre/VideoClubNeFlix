begin tran
	Declare @sinopsis varchar(255)
	Set @sinopsis = 'Había una vez...' --Metemos el troncho de sinopsis. xD
  --Insertamos los datos de la pelicula
  insert into tabla_peliculas(id,nombre,director,estreno,genero,sinopsis,cantidad,precio)
	values (8,'Sonic: La película','Jeff Fowler',2019,'Aventura', @sinopsis,3,5)
  Declare @id int
  select top (1) @id=id from tabla_peliculas order by id DESC --Pillamos el id, para nuestra otra insert.
  -- Insertamos la imágen de la pelicula
  INSERT INTO galeria (Id, [file]) 
	SELECT @id, BulkColumn 
	FROM Openrowset( Bulk 'D:\\Workspace\\VideoClubDI\\IMG\\Portadas\\sonic.jpg', Single_Blob) as image
 --Comprobamos los resultados.
	select t1.*,t2.[file] from tabla_peliculas t1 
		left join galeria t2 on t1.id=t2.id 
		where t1.id= @id
rollback tran

  