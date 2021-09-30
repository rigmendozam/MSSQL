/***********************Nombre de los campos***********************/
Select  c.name + ',' from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = 'Actividad'  --and c.is_nullable = 0 and c.default_object_id = 0

/***********************Nombre de las variables***********************/
Select  '@' + c.name + ',' from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = 'Actividad'  --and c.is_nullable = 0 and c.default_object_id = 0


/***********************Parametros***********************/
Select 
'@' + c.name +' '+ ty.name +' '+ 
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
 ',' from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = 'Actividad'  --and c.is_nullable = 0 and c.default_object_id = 0

				 

/***********************Crear el insert***********************/

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
Where t.name  = 'ListaPrecio'  and c.is_nullable = 0 and c.default_object_id = 0

Select Substring(@Variable,0,len(@Variable)) + ') ' + Char(13) + Substring(@Values,0,len(@Values)) + ') ' + Char(13) + Char(13) + @Scope



/**********************Para la actualizacion**********************/
Declare @Update varchar(MAx) = 'Update {0} with(Rowlock) set ',
				@Where varchar(MAx) = ''
		
Select  

	@Update = Replace(@Update,'{0}', t.name) + Case When c.is_identity = 1 Then '' else + Char(13)  + char(9) + c.name + ' = ' + '@' + c.name + ',' end,
	@Where = Case When c.is_identity = 1 Then 'Where ' + Char(13) + char(9)+c.name+' = @'+c.name+''  else @Where end
from 
	sys.columns c inner join 
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'ListaPrecio' --and c.is_nullable = 0 and c.default_object_id = 0

Select Substring(@Update ,0,len(@Update)) + Char(13) + @Where

/**********************Para la eliminacion**********************/

Select 
	'Delete from ' + t.name + ' With(Rowlock) ' + Char(13) + 'Where ' + c.name + ' = @' + c.name
from 
	sys.columns c inner join 
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'ListaPrecio' and c.is_identity = 1

/**********************Para Crear Tablas**********************/
Select 
c.name +' '+ ty.name +' '+ 
case c.system_type_id 
	When 167 Then '(' + cast(c.max_length as varchar) +')'
	When 175 Then '(' + cast(c.max_length as varchar) +')'
	When 106 Then '(' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
	else '' 
End  +''+	
 ',' from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = 'A' 

/***********************Actualizacion masiva de campos***********************/
select 
	'Alter Table ' +  t.name + ' Alter Column ' + c.name + ' ' + ty.name + ' (15)' + Case When c.is_nullable  = 1Then ' Null' else ' Not Null' end
from 
	sys.columns c inner join
	sys.tables t on c.object_id = t.object_id inner join
	sys.types ty On c.user_type_id = ty.user_type_id
where 
	t.name like 'g%' and (c.name like 'Folio%') and c.max_length = 10

	Order by t.name


/***********************Genera el sp_help de las tablas que cumplan con la condicion (Normalmente utilizado cuando se necesita cambiar tamaño de una columna o el tipo de dato)***********************/

select 
	'sp_help''' + t.name + ''''
from 
	sys.columns c inner join
	sys.tables t on c.object_id = t.object_id 
where 
	t.name like 'g%' and (c.name like 'Folio%') and c.max_length = 10

	Order by t.name

/***********************Crea el script de eliminacion de triggers a partir de una tabla***********************/

Select 
  'Drop Trigger '	+ tr.name
from 
	sys.triggers tr Inner join
	sys.tables t on tr.parent_id = t.object_id
Where
	t.name = 'FacturaDetImp'

/******************************Buscar palabras en PA o TR************************************************/

select 
	o.name, m.* 
from 
 sys.sql_modules  as m Inner join
 sys.objects as o on m.object_id = o.object_id
where 
 definition like '%CE%'
Order by 
 o.type, name