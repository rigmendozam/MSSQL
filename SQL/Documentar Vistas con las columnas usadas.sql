If Exists(Select * from sys.tables where name = 'AAA')
	Drop table AAA
	
Declare @IdVista bigint, @Nombre varchar(1000), @column_id int, @name varchar(1000), @Concatenado varchar(MAx)

	Declare @Vista table (
		Id bigint,
		Nombre varchar(1000)
	)

	Declare @Columnas table (
		Id bigint,
		IdVista int,
		Nombre varchar(1000),
		Usada bit
	)
	DEclare @TablaFinal table (
		NombreTabla varchar(1000),
		Columnas varchar(MAx)
	)

	Insert into @Vista
	Select object_id, name from sys.views order by name

	Declare cur_vista cursor forward_only for Select Id, Nombre From @Vista

	open cur_vista

	fetch next from cur_vista into @IdVista, @Nombre

	while (@@FETCH_STATUS = 0)
	Begin

		Declare cur_col cursor forward_only for  Select distinct column_id, name from sys.columns c Where c.object_id = @IdVista
		open cur_col

		fetch next from cur_col into @column_id, @name
	
		while (@@FETCH_STATUS = 0)
		Begin
		
			If exists(Select 1 From sys.sql_modules where definition like '%'+@name+'%' and definition not	like  '%CREATE VIEW%')
			BEgin
				Insert into @Columnas
				Values (@column_id, @IdVista, @name,1)
			End
			else
			Begin
				Insert into @Columnas
				Values (@column_id, @IdVista, @name,0)
			End

			fetch next from cur_col into @column_id, @name
		End

		close cur_col
		deallocate cur_col

		set @Concatenado = ''

		Select 
			@Concatenado = @Concatenado  + col.Nombre + ' ' + t.name +  
			case 
				when t.user_type_id in(231,175) then 
					'(' + case when c.max_length < 0 Then 'Max' else  Cast(c.max_length as varchar) end + ')'  
				When t.user_type_id in(108) Then
					'(' + Cast(c.scale as varchar) + ',' + Cast(c.precision as varchar) + ')'  
				else ''
			end  + case when Usada = 1 Then '(Usada)' else '' end + Char(13)+ Char(10)
		From 
			@Columnas as col inner join 
			sys.columns c on c.object_id = @IdVista and col.Id = c.column_id inner join
			sys.types t on c.user_type_id = t.user_type_id
		Where 
			IdVista = @IdVista

		If isnull(@Concatenado,'') <> ''
		BEgin
			Insert into @TablaFinal
			Values (@Nombre, @Concatenado)
		End
		fetch next from cur_vista into @IdVista, @Nombre

	End


	close cur_vista
	deallocate cur_vista

	Select * into AAA from @TablaFinal
 