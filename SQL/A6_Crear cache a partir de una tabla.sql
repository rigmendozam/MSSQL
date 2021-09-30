declare
    @Tabla           varchar(max) = 'DocumentoPeriodicidad',
    @LlamadoDesde    varchar(max) = 'Cache',
    @Creador         varchar(max) = 'Ariel',
    @SustituirNombre varchar(max) = null -- Dejar en null si no se usa. Reemplazar el nombre de la tabla por este en los nombres de los PA


declare 
    @Linea          varchar(max) = char(13) + char(10),
    @Tab            varchar(max) = '    ',
    @Query          varchar(max),
    @NombrePA       varchar(max),
    @Resultado      varchar(max),
		@Campo1					varchar(MAx) = '',
		@Campo2					varchar(MAx) = '',
    @PA             varchar(max) = 'GO
-- --------------------------------
-- Creado:          ' + @Creador + ' ' + convert(varchar, getdate(), 23) + '
-- Llamado desde:   ' + @LlamadoDesde + '
-- Observaciones:   
-- Llamada SQL:     exec {NombrePA} 
-- --------------------------------
CREATE PROCEDURE {NombrePA}
AS
BEGIN

Select {Campo1}
Union
Select 
	{Campo2}
From 
	{Tabla}

END'



set @NombrePA  = 'Cache'+isnull(@SustituirNombre, @Tabla)





set @Query = ''

select 
	@Campo1 = @Campo1 + Case		
								when c.name like 'Id%' or c.user_type_id in(61) then 'null' 
								When c.user_type_id in(167) Then ''' '''
								When c.user_type_id in(56) Then '0'
							else
								'null' 
							end +   ' As ' +c.name + ',',
	@Campo2 = @Campo2 + c.name + ',' + @Linea
from sys.columns as c
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = @Tabla 
select @Campo1, @Campo2
set @Resultado = replace(@PA, '{Campo1}', @Campo1)
set @Resultado = replace(@Resultado, '{Campo2}', @Campo2)
set @Resultado = replace(@Resultado, '{Tabla}', @Tabla)
set @Resultado = replace(@Resultado, '{NombrePA}', @NombrePA)
set @Resultado = @Resultado + @Linea + @Linea + @Linea + @Linea

Print @Resultado