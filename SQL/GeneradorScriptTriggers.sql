/*
	Script para generar todos los triggers de una base de datos.
	Hay que generarlo a un documento de texto.
	Luego de generarlo hay que eliminar las dos filas que separan los drop con los create. Estas filas son:
		Texto
		-----------------------------------------------------------------------------------------------------
*/
SET NOCOUNT ON
GO
declare @trigger nvarchar(100)

Create table #Tmp
	(Texto nvarchar(255))
declare cr cursor for
select distinct user_name(uid)+'.'+name from sysobjects where type='tr'
open cr
fetch next from cr into @trigger
while @@fetch_status=0
	begin
		print 'IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N''' + @trigger +''') AND type =''TR'')'
		print 'DROP TRIGGER ' + @trigger
		print 'GO'
		Insert into #Tmp
		exec sp_helptext @trigger
		Insert into #Tmp
		values ('GO')
		fetch next from cr into @trigger
	End
Select * from #Tmp
Close cr
deallocate cr
Drop table #Tmp