USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[MantencionIns]    Script Date: 01-03-2021 14:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- --------------------------------
-- Creado:          Roberto 2020-10-01
-- Llamado desde:   Mantencion
-- Observaciones:   
-- Llamada SQL:     exec MantencionIns <PARAMETROS_PA>
-- Buscar: select * from sys.sql_modules where definition like '%MantencionIns%'
-- --------------------------------
ALTER PROCEDURE [dbo].[MantencionIns]
    @Id int output,
    @IdPlanta int,
    @Fecha date,
    @Observacion varchar (1500) = null,
    @IdUsuario int
AS
BEGIN

insert into Mantencion with(rowlock) (
         IdPlanta,  IdEstado,  Fecha,  Observacion,  IdUsuario)
    values (
        @IdPlanta, 1, @Fecha, @Observacion, @IdUsuario)

set @Id = scope_identity()

END