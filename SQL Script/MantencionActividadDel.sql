ALTER PROCEDURE [dbo].[MantencionActividadDel]
    @Id int
AS
BEGIN

delete from MantencionActividad with(rowlock)
where Id = @Id

END





