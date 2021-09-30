declare @Busqueda varchar(max) = 'Aryan 2016-08'

select
    o.type as Tipo,
    o.name as Nombre,
    isnull(t.name, '') as En,
    len(m.definition) as Longitud,
    m.definition as Definicion
from sys.sql_modules as m
    inner join sys.objects as o on m.object_id = o.object_id
    left outer join sys.tables as t on o.parent_object_id = t.object_id
where definition like '%' + @Busqueda + '%' 
    --and o.name not like '%Sel_%' and o.name not like '%Rpt_%' and o.name not like 'Cache%'
order by
    o.type,
    o.name