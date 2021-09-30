Declare @Tabla varchar(100) = 'ListaPrecio'
DEclare @PA varchar(Max) = '-- =============================================
-- Author:		<Author,,Name>
-- Create date: '+convert(varchar,getdate(),102)+'
-- Description:	<Description,,>
-- =============================================
Create Procedure ' + @Tabla + 'Ins
( 
	{Parametros}
)
AS
Begin

	{Query}

End

',
@Parametros varchar(Max) = '',
@Query varchar(MAx) = ''

Select 
	@Parametros = @Parametros + '@' + c.name +' '+ ty.name +' '+ 
case c.system_type_id 
	When 167 Then '(' + cast(c.max_length as varchar) +')'
	When 175 Then '(' + cast(c.max_length as varchar) +')'
	When 106 Then '(' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
	else '' 
End  +' '+
Case c.is_nullable
	When 1 Then '= null'
	else ''
End +''+ Case When c.is_identity = 1 Then ' output ' else '' end + ','  + Char(13) 
 from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = @Tabla  --and c.is_nullable = 0 and c.default_object_id = 0

set @Parametros = substring(@Parametros,0,Len(@Parametros) - 1)

/********************Query****************/
Declare @Variable varchar(MAx) = 'Insert Into {0} With(Rowlock) (',
				@Values varchar(Max) = 'Values (',
				@Scope varchar(MAx) = 'Set @{c} = Scope_Identity()'

Select 																																																																				   
	@Variable = Replace(@Variable,'{0}',t.name) + Case When c.is_identity = 1 Then '' else  c.name + ',' end , 
	@Values = @Values +  case When c.is_identity = 1 Then '' else  '@'+ c.name + ',' end, 
	@Scope = REplace(@Scope,'{c}',case when c.is_identity = 1 then c.name else '' end)
From
	sys.columns c inner join
	sys.tables t on c.object_id = t.object_id
Where t.name  = @Tabla  --and c.is_nullable = 0 and c.default_object_id = 0

set @Query = Substring(@Variable,0,len(@Variable)) + ') ' + Char(13) + Substring(@Values,0,len(@Values)) + ') ' + Char(13) + Char(13) + @Scope



Select Replace(Replace(@PA,'{Parametros}',@Parametros),'{query}',@Query)