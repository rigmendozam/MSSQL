create table #Tmp(
    Tipo     char(10),
    TipoDesc nvarchar(120),
    Esquema  nvarchar(256),
    Nombre   nvarchar(256))

declare
    @Resultado int,
    @Tipo      char(10),
    @TipoDesc  nvarchar(120),
    @Esquema   nvarchar(256),
    @Nombre    nvarchar(256)

declare cur cursor fast_forward for
    select
        o.type,
        o.type_desc,
        schema_name(o.schema_id),
        object_name(o.object_id)
    from sys.objects as o
    where type_desc in('SQL_STORED_PROCEDURE', 'SQL_TRIGGER', 'SQL_SCALAR_FUNCTION', 'SQL_TABLE_VALUED_FUNCTION', 'SQL_INLINE_TABLE_VALUED_FUNCTION', 'VIEW')
          and isnull(objectproperty(o.object_id, 'IsSchemaBound'), 0) = 0
    order by o.type, quotename(schema_name(o.schema_id)) + '.' + quotename(object_name(o.object_id))

open cur
fetch next from cur into @Tipo, @TipoDesc, @Esquema, @Nombre

while @@fetch_status = 0
    begin
        begin tran

        begin try
            exec @Resultado = sp_refreshsqlmodule @Nombre
            if @Resultado != 0 raiserror('sp_refreshsqlmodule falló con %s', 16, 1, @Nombre)
        end try
        begin catch
            set @Resultado = -1
        end catch

        if @@trancount > 0 rollback tran

        if @Resultado != 0 insert into #Tmp values (@Tipo, @TipoDesc, @Esquema, @Nombre)

        fetch next from cur into @Tipo, @TipoDesc, @Esquema, @Nombre
    end

close cur
deallocate cur

select * from #Tmp
drop table #Tmp