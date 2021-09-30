ALTER PROCEDURE [dbo].[ParteUpd]
    @Id int,
	@Fecha date,
    @IdPlanta int = null,
    @IdOrigen int = null,
    @IdAreas int,
	@IdSistema int,
    @IdTipoHallazgo int,
	@IdResponsable int,
	@IdEntidad int = null,
	@IdPlanificacionDet int = null,
    @Asunto varchar (150),
    @Detalle varchar (2500) = null,
	@AccionInmediata varchar(2500) = null,
	@FechaAI date = null,
	@Hombre   varchar(2500) = null,
	@Material varchar(2500) = null,
	@Maquina  varchar(2500) = null,
	@Metodo   varchar(2500) = null,
	@Entorno  varchar(2500) = null,
	@Medida   varchar(2500) = null,
	@FechaHoraRA datetime = null,
	@IdUsuarioMod int ,
	@IdAlerta int = null,
	@CantidadRecibida int,
	@CantidadRevisada int,
	@CantidadRechazada int,
	@IdRecepcion int = null,
	@TipoProducto varchar(30) = null,
	@IdMedida int = null,
	@IdTipoAsunto int,
	@IdAmonestado int = null,
	@IdPlantaOrigen int = null,
	@CorreoEntidad varchar(250) =null,
	@IdParteAsunto int
AS
BEGIN

update Parte with(rowlock) set
    IdPlanta=@IdPlanta,
	IdOrigen=@IdOrigen,
	IdAreas=@IdAreas,
	IdTipoHallazgo=@IdTipoHallazgo,
	IdSistema=@IdSistema,
	IdEntidad=@IdEntidad,
	IdPlanificacionDet=@IdPlanificacionDet,
	Fecha=@Fecha,
	Asunto=@Asunto,
	Descripcion=@Detalle,
	IdResponsable=@IdResponsable,
	AccionInmediata=@AccionInmediata,
	FechaAI=@FechaAI,
	FechaMod = getdate(),
	Hombre  = @Hombre  ,
	Material= @Material,
	Maquina = @Maquina ,
	Metodo  = @Metodo  ,
	Entorno = @Entorno ,
	Medida  = @Medida  ,
	FechaHoraRA = @FechaHoraRA,
	IdUsuarioMod = @IdUsuarioMod,
	IdAlerta = @IdAlerta,
	CantidadRecibida = @CantidadRecibida,
	CantidadRevisada = @CantidadRevisada,
	CantidadRechazada = @CantidadRechazada,
	IdRecepcion = @IdRecepcion,
	TipoProducto = @TipoProducto,
	IdMedida = @IdMedida,
	IdTipoAsunto = @IdTipoAsunto,
	IdPersonalAmonestado = @IdAmonestado,
	IdPlantaOrigen = @IdPlantaOrigen,
	CorreoEntidad = @CorreoEntidad,
	IdParteAsunto=@IdParteAsunto
where 
    Id = @Id

END






