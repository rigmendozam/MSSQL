declare										
    @Tabla         varchar(max) = 'Factura',	  
    @LlamadoDesde  varchar(max) = 'Formulario XYZ',
    @Creador       varchar(max) = 'Ariel',
		@Columnas			 varchar(max) = 'Factura.Numero,Factura.IdEmisor,' -- Separados por , y debe terminar con una , EJ(Factura.Numero,Factura.Fecha)

declare            
    @Linea         varchar(max) = char(13) + char(10),
    @Tab           varchar(max) = '    ',
    @Sentencia     varchar(max),
    @Parametros    varchar(max),
    @Query         varchar(max),
    @Where         varchar(max),
    @Valores       varchar(max),
    @Scope         varchar(max),
    @NombrePA      varchar(max),
    @Resultado     varchar(max),
    @PA            varchar(max) = 'GO
-- ================================================================
-- Creado:          ' + @Creador + ' ' + convert(varchar, getdate(), 105) + '
-- Llamado desde:   ' + @LlamadoDesde + '
-- Observaciones:   <Observaciones, si las tiene, para los que vayan a revisar o modificar el PA en el futuro.>
-- Llamada SQL:     exec {NombrePA} <PARAMETROS_PA>
-- ================================================================
CREATE PROCEDURE {NombrePA}{Parametros}
AS
BEGIN

{Query}

END'

Create Table #Tmp(		
		Tabla varchar(100),
		Columna varchar(100),
		TipoDato varchar(100), --Con el largo si corresponde
		IdTipoDato int
)

Declare @Pos int,
				@Aux varchar(100),
				@TablaSel varchar(100),
				@ColumnaSel varchar(100),
				@IdAux bigint

While len(@Columnas) > 0
BEgin
	Set @Pos	= 	Charindex(',', @Columnas)
	Set @Aux 		= 	Left(@Columnas, @Pos -1)
	select @Aux
	set @TablaSel = Left(@Aux,Charindex('.', @Aux) - 1)
	set @ColumnaSel = Right(@Aux,Charindex('.', @Aux) - 2)
	Select @TablaSel, @ColumnaSel, Right(@Aux,Charindex('.', @Aux) - 2 )
	Insert into #Tmp
	Select 
		t.name,c.name	,
		case c.system_type_id 
			When 167 Then '(' + cast(c.max_length as varchar) +')'
			When 175 Then '(' + cast(c.max_length as varchar) +')'
			When 106 Then '(' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
			else '' 
		End, c.system_type_id 
	from 
		sys.columns c inner join 
		sys.types ty On c.user_type_id =  ty.user_type_id Inner join
		sys.tables t on c.object_id = t.object_id
	Where t.name  = @TablaSel and c.name = @ColumnaSel
	If @@ROWCOUNT = 0
	BEgin
		raiserror('El valor %s no existe',16,1,@Aux)
		Goto ERROR
	End

	Set @Columnas		=		Right(@Columnas, Len(@Columnas) - @Pos)

End

Select * From #Tmp

ERROR:

drop table #Tmp