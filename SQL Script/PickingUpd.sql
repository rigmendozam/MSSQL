ALTER PRocedure [dbo].[PickingUpd]
    @Id int ,
    @obs_picking varchar (max) = null,
    @IdUsuarioMod int = null,
	@Fecha date,
	@IdLinea int
AS
BEGIN

	

	Declare @IdEncargada int, @IdPlanificacionDet int, @IdProgra int

	select @IdProgra = IdProgramacion from picking where id = @Id

		Select 
			@IdEncargada = PlanificacionDet.IdEncargada,  @IdPlanificacionDet = PlanificacionDet.Id
		from 
			PlanificacionDetProg inner join
			PlanificacionDet on PlanificacionDetProg.IdPlanificacionDet = PlanificacionDet.Id Inner join
			Planificacion on PlanificacionDet.IdPlanificacion = Planificacion.Id
		where 
			PlanificacionDetProg.IdProgramacion = @IdProgra and PlanificacionDet.IdLinea = @IdLinea and Planificacion.Fecha = @Fecha

update Picking with(rowlock) set
    obs_picking = @obs_picking,
    IdUsuarioMod = @IdUsuarioMod,
    FechaMod = getdate(),
	IdPlanificacionDet = @IdPlanificacionDet,
	IdEncargada = @IdEncargada
where 
    Id = @Id

END




