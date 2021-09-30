Declare @Tablas varchar(Max) = '', @EsIdentity bit, @NombreTabla varchar(Max) = 'Factura', @Valor varchar(MAx) = '', @Salto varchar(Max) = Char(13) + Char(10) 

Select 
	Cast(tr.name as varchar(Max)) as name, Cast(Isnull(ic.object_id,0) as bit) as Existe into #Tmp
from 
	sys.tables t Inner join
	sys.foreign_key_columns fk on t.object_id = fk.referenced_object_id Inner join
	sys.tables tr on fk.parent_object_id = tr.object_id Left outer Join 
	sys.identity_columns ic on tr.object_id = ic.object_id
where
	t.name = @NombreTabla
Order by name

Declare Cur_Tablas cursor  For 
Select 
	name, Existe
from #Tmp

open Cur_Tablas

FETCH NEXT FROM Cur_Tablas Into @Tablas, @EsIdentity

While @@FETCH_STATUS = 0
Begin

	set @Valor = @Valor + 'Delete From ' + @Tablas

	if @EsIdentity = 1
	Begin
		set @Valor = @Valor + @Salto + 'DBCC CHECKIDENT ('+@Tablas+', RESEED,0)' 
	End

	set @Valor = @Valor + @Salto + 'Go' + @Salto + @Salto

	FETCH NEXT FROM Cur_Tablas Into @Tablas, @EsIdentity
End

Close Cur_Tablas
Deallocate Cur_Tablas

drop table #Tmp

Select @Valor