declare
    @Tabla           varchar(max) = 'Receta',
    @LlamadoDesde    varchar(max) = 'Receta',
    @Creador         varchar(max) = 'roberto',
    @SustituirNombre varchar(max) = null -- Dejar en null si no se usa. Reemplazar el nombre de la tabla por este en los nombres de los PA
    
declare 
    @Linea          varchar(max) = char(13) + char(10),
    @Tab            varchar(max) = '    ',
    @Sentencia      varchar(max),
    @Parametros     varchar(max),
    @Query          varchar(max),
    @Where          varchar(max),
    @Valores        varchar(max),
    @Scope          varchar(max),
    @NombrePA       varchar(max),
    @Resultado      varchar(max),
    @PA             varchar(max) = 'GO
-- --------------------------------
-- Creado:          ' + @Creador + ' ' + convert(varchar, getdate(), 23) + '
-- Llamado desde:   ' + @LlamadoDesde + '
-- Observaciones:   
-- Llamada SQL:     exec {NombrePA} <PARAMETROS_PA>
-- Buscar: select * from sys.sql_modules where definition like ''%{NombrePA}%''
-- --------------------------------
CREATE PROCEDURE {NombrePA}{Parametros}
AS
BEGIN

{Query}

END'

-- Rectificar el nombre de la tabla
select @Tabla = name from sys.tables where name = @Tabla

-- Crear la tabla temporal
create table #Tmp(
    nombrePA varchar(max),
    sqlPA    varchar(max),
    orden    int)



-- Parámetros Delete
set @Parametros = ''
select @Parametros = @Parametros + @Tab + '@' + c.name + ' ' + ty.name
    + case c.system_type_id
        when 167 then ' (' + cast(c.max_length as varchar) +')'
        when 175 then ' (' + cast(c.max_length as varchar) +')'
        when 106 then ' (' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
        else ''
    end
    + case c.is_nullable when 1 then ' = null' else '' end 
    + ',' + @Linea
from sys.columns as c
    inner join sys.types as ty on c.user_type_id = ty.user_type_id
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_identity = 1

print(@Parametros)
if len(@Parametros) > 0
    set @Parametros = substring(@Parametros, 0, len(@Parametros) - len(@Linea))

-- Delete
set @NombrePA  = isnull(@SustituirNombre, @Tabla) + 'Del'
set @Query = ''

select @Query = 'delete from ' + @Tabla + ' with(rowlock)' + @Linea + 'where ' + c.name + ' = @' + c.name
from sys.columns as c
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_identity = 1

set @Resultado = replace(@PA, '{Query}', @Query)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = replace(@Resultado, '{Parametros}', @Linea + @Parametros)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea
insert into #Tmp(nombrePA, sqlPA, orden) values(@NombrePA, @Resultado, 0)



-- Parámetros Sel_Id
-- SON LOS MISMOS QUE LOS DEL DELETE ASI QUE NO HAY QUE HACER NADA

-- Sel_Id
set @NombrePA  = isnull(@SustituirNombre, @Tabla) + 'Sel_Id'
set @Query = ''

select @Query = 'select ' + c.name + ' from ' + @Tabla
from sys.columns as c
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_identity = 1

set @Resultado = replace(@PA, '{Query}', @Query)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = replace(@Resultado, '{Parametros}', @Linea + @Parametros)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea
insert into #Tmp(nombrePA, sqlPA, orden) values(@NombrePA, @Resultado, 1)



-- Sel_Grids sin paginado
-- Parametros
set @Parametros = ''

-- Sel_Grids
set @NombrePA  = isnull(@SustituirNombre, @Tabla) + 'Sel_Grids'
-- LO MISMO QUE EL DEL SEL_ID ASI QUE NO HAY QUE HACER NADA

set @Resultado = replace(@PA, '{Query}', @Query)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = replace(@Resultado, '{Parametros}', @Parametros)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea
insert into #Tmp(nombrePA, sqlPA, orden) values(@NombrePA + ' (sin paginado)', @Resultado, 2)


-- Sel_Grids Con paginado
-- Parametros
set @Parametros = '
	@Pagina         int Output,
	@TamanoPagina   int,
	@TotalRegistros int Output,
	@Orden          varchar(600)  = Null,
	@Filtro         varchar(4000) = Null,
	@IdPosicionar   int           = Null
'

-- Sel_Grids
set @NombrePA  = isnull(@SustituirNombre, @Tabla) + 'Sel_Grids'
-- LO MISMO QUE EL DEL SEL_ID ASI QUE NO HAY QUE HACER NADA

select @Query =
'
Declare @Sql varchar(max),
      @Paginas int
     
	Create Table #Tmp
	(
		IdTabla int Identity(1, 1),
		' + c.name +  ' int
	)
            
	If ISNULL(@Orden, '''') = '''' Set @Orden = ''''
  
	Set @Sql = ''select ' + c.name + ' from ' + @Tabla +'''
	 
	If ISNULL(@Filtro, '''') <> ''''
	Begin
		Set @Sql = @Sql+'' Where ''+@Filtro
	End
		Set @Sql = @Sql+'' Order By ''+@Orden
    
	Insert Into #Tmp (' + c.name +  ')
	Exec (@Sql)

	Set @TotalRegistros = @@RowCount
	Set @Paginas = CEILING(@TotalRegistros / CAST(@TamanoPagina As decimal))
 
	If @Pagina > @Paginas - 1
		Set @Pagina = @Paginas - 1

	If @Pagina < 0
		Set @Pagina = 0

	If Not @IdPosicionar Is Null
	Begin
		Declare @IdTabla int
		Select
			@IdTabla = IdTabla
		From   
			#Tmp
		Where  
			' + c.name +  ' = @IdPosicionar

		If Not @IdTabla Is Null
		Begin
			Set @Pagina = FLOOR((@IdTabla - 1) / CAST(@TamanoPagina As decimal))
		End
	End

	--Select a mostrar
	Select
		' + c.name +  '
	From   #Tmp
	Where  IdTabla Between @TamanoPagina * @Pagina + 1 And @TamanoPagina * (@Pagina + 1)
'
from sys.columns as c
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_identity = 1

set @Resultado = replace(@PA, '{Query}', @Query)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = replace(@Resultado, '{Parametros}', @Parametros)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea
insert into #Tmp(nombrePA, sqlPA, orden) values(@NombrePA + ' (con paginado)', @Resultado, 2)





-- Parámetros Insert
set @Parametros = ''
select @Parametros = @Parametros + @Tab + '@' + c.name + ' ' + ty.name
    + case c.system_type_id
        when 167 then ' (' + cast(c.max_length as varchar) +')'
        when 175 then ' (' + cast(c.max_length as varchar) +')'
        when 106 then ' (' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
        else ''
    end
    + case c.is_nullable when 1 then ' = null' else '' end 
    + case when c.is_identity = 1 then ' output' else '' end + ',' + @Linea
from sys.columns as c
    inner join sys.types as ty on c.user_type_id = ty.user_type_id
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_computed = 0

if len(@Parametros) > 0
    set @Parametros = substring(@Parametros, 0, len(@Parametros) - len(@Linea))

-- Insert
set @NombrePA  = isnull(@SustituirNombre, @Tabla) + 'Ins'
set @Sentencia = 'insert into {0} with(rowlock) (' + @Linea + @Tab + @Tab + ' '
set @Scope     = 'set @{c} = scope_identity()'
set @Valores   = @Tab + 'values (' + @Linea + @Tab + @Tab

select
    @Sentencia = replace(@Sentencia, '{0}', @Tabla)
        + case
            when c.is_identity = 1 then ''
            else c.name + ',  '
        end,
    @Valores = @Valores
        + case
            when c.is_identity = 1 then ''
            else '@' + c.name + ', '
        end,
    @Scope = replace(@Scope, '{c}', case when c.is_identity = 1 then c.name else '' end)
from sys.columns as c
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_computed = 0

set @Query = substring(@Sentencia, 0, len(@Sentencia)) + ')' + @Linea + substring(@Valores, 0, len(@Valores)) +')' + @Linea + @Linea + @Scope

set @Resultado = replace(@PA, '{Query}', @Query)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = replace(@Resultado, '{Parametros}', @Linea + @Parametros)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea
insert into #Tmp(nombrePA, sqlPA, orden) values(@NombrePA, @Resultado, 0)



-- Parámetros Update
set @Parametros = ''
select @Parametros = @Parametros + @Tab + '@' + c.name + ' ' + ty.name
    + case c.system_type_id
        when 167 then ' (' + cast(c.max_length as varchar) +')'
        when 175 then ' (' + cast(c.max_length as varchar) +')'
        when 106 then ' (' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
        else ''
    end
    + case c.is_nullable when 1 then ' = null' else '' end 
    + ',' + @Linea
from sys.columns as c
    inner join sys.types as ty on c.user_type_id = ty.user_type_id
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_computed = 0

if len(@Parametros) > 0
    set @Parametros = substring(@Parametros, 0, len(@Parametros) - len(@Linea))

-- Update
set @NombrePA = isnull(@SustituirNombre, @Tabla) + 'Upd'
set @Sentencia = 'update {0} with(rowlock) set'
set @Where = ''

select
    @Sentencia = replace(@Sentencia, '{0}', @Tabla) 
        + case when c.is_identity = 1 then '' 
            else + @Linea + @Tab + c.name + ' = ' + '@' + c.name + ',' 
        end,
    @Where = case when c.is_identity = 1 
            then 'where ' + @Linea + @Tab + c.name + ' = @' + c.name + ''
            else @Where
        end
from sys.columns as c
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla and c.is_computed = 0

set @Query = substring(@Sentencia, 0, len(@Sentencia)) + @Linea + @Where

set @Resultado = replace(@PA, '{Query}', @Query)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = replace(@Resultado, '{Parametros}', @Linea + @Parametros)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea
insert into #Tmp(nombrePA, sqlPA, orden) values(@NombrePA, @Resultado, 0)


-- Devolver los resultados
select nombrePA as PA, sqlPA as SQL from #Tmp order by orden, nombrePA
drop table #Tmp