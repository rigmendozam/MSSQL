ALTER PRocedure [dbo].[PickingIns]
    @Id int output,
    @IdProgra int = null,
    @obs_picking varchar (max) = null,
    @id_planta int = null,
    @IdUsuario int = null,
	@Fecha date,
	@IdLinea int
AS
BEGIN

	begin tran

		Declare @IdEncargada int, @IdPlanificacionDet int

		Select 
			@IdEncargada = PlanificacionDet.IdEncargada,  @IdPlanificacionDet = PlanificacionDet.Id
		from 
			PlanificacionDetProg inner join
			PlanificacionDet on PlanificacionDetProg.IdPlanificacionDet = PlanificacionDet.Id Inner join
			Planificacion on PlanificacionDet.IdPlanificacion = Planificacion.Id
		where 
			PlanificacionDetProg.IdProgramacion = @IdProgra and PlanificacionDet.IdLinea = @IdLinea and Planificacion.Fecha = @Fecha

		insert into Picking with(rowlock) (
				 IdProgramacion,  obs_picking,  id_planta,  IdUsuario, IdEstado,id_picking, IdEncargada, IdPlanificacionDet)
			values (
				@IdProgra, @obs_picking, @id_planta, @IdUsuario, 1,'', @IdEncargada, @IdPlanificacionDet)
		If @@ERROR <> 0 Goto ERROR
		set @Id = scope_identity()

		Insert into PickingUsrEstado
		Values (@Id, @IdUsuario, 1, getdate(), null, null, null)
		If @@ERROR <> 0 Goto ERROR

	Commit tran
	return

ERROR:
	rollback tran
END










