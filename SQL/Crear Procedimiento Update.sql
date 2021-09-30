Declare @Tabla varchar(100) = 'ListaPrecio'
DEclare @PA varchar(Max) = '-- =============================================
-- Author:		<Author,,Name>
-- Create date: '+convert(varchar,getdate(),102)+'
-- Description:	<Description,,>
-- =============================================
Create Procedure ' + @Tabla + 'Upd
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
End +''+	
 ',' + Char(13) from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = @Tabla  --and c.is_nullable = 0 and c.default_object_id = 0

set @Parametros = substring(@Parametros,0,Len(@Parametros) - 1)

/********************Query****************/
Declare @Update varchar(MAx) = 'Update {0} with(Rowlock) set ',
				@Where varchar(MAx) = ''

Select  

	@Update = Replace(@Update,'{0}', t.name) + Case When c.is_identity = 1 Then '' else + Char(13)  + char(9) + c.name + '=' + '@' + c.name + ',' end,
	@Where = Case When c.is_identity = 1 Then 'Where ' + Char(13) + char(9)+c.name+' = @'+c.name+''  else @Where end
from 
	sys.columns c inner join 
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = @Tabla --and c.is_nullable = 0 and c.default_object_id = 0

Set @Query = Substring(@Update ,0,len(@Update)) + Char(13) + @Where



Select Replace(Replace(@PA,'{Parametros}',@Parametros),'{query}',@Query)