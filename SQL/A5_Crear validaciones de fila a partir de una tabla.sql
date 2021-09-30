
Declare @Salto varchar(10) = Char(13) + Char(10) 


Select  
	'if(string.IsNullOrWhiteSpace(dtrFila["'+c.name+'"].ToString()))'+ @Salto + 'stbError.AppendLine("'+c.name+' es requerido");'+ @Salto+ @Salto

from 
	sys.columns c inner join 
	sys.types ty On c.user_type_id =  ty.user_type_id Inner join
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'DocumentoRequerido'  and c.is_nullable = 0 --and c.default_object_id = 0
