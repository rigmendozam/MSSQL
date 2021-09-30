
Select  
	'dtrFila["'+c.name+'"],'

from 
	sys.columns c inner join 
	sys.types ty On c.user_type_id =  ty.user_type_id Inner join
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'FormularioFiltroDet'  --and c.is_nullable = 0 and c.default_object_id = 0
