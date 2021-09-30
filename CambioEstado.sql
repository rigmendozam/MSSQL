FUNCIONES ***********************************************************************************************************************************************************

GO
/****** Object:  UserDefinedFunction [dbo].[ObtenerDigitoVerificador]    Script Date: 10-03-2021 13:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER  FUNCTION [dbo].[ObtenerDigitoVerificador]
(
	@rut INTEGER
 )
 RETURNS VARCHAR(1)
 
 AS
 BEGIN
 
 DECLARE @dv VARCHAR(1)
 DECLARE @rutAux INTEGER
 DECLARE @Digito INTEGER
 DECLARE @Contador INTEGER
 DECLARE @Multiplo INTEGER
 DECLARE @Acumulador INTEGER
 
 
 SET @Contador = 2;
 SET @Acumulador = 0;
 SET @Multiplo = 0;
 
	WHILE(@rut!=0)
		BEGIN
 
			SET @Multiplo = (@rut % 10) * @Contador;
			SET @Acumulador = @Acumulador + @Multiplo;
			SET @rut = @rut / 10;
			SET @Contador = @Contador + 1;
			if(@Contador = 8)
			BEGIN
				SET @Contador = 2;
			End;
		END;
 
	SET @Digito = 11 - (@Acumulador % 11);
 
	SET @dv = LTRIM(RTRIM(CONVERT(VARCHAR(2),@Digito)));
 
	IF(@Digito = 10)
	BEGIN
		SET @dv = 'K';
	END;
 
	IF(@Digito = 11)
	BEGIN
		SET @dv = '0';
	END;
 
RETURN @dv
 
END
 


FUNCIONES ***********************************************************************************************************************************************************

USE [SPMProd]
GO
/****** Object:  UserDefinedFunction [dbo].[Split]    Script Date: 10-03-2021 13:04:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[Split](@data NVARCHAR(MAX), @delimiter NVARCHAR(5))
RETURNS @t TABLE (data NVARCHAR(max))
AS
BEGIN
    
    DECLARE @textXML XML;
    SELECT    @textXML = CAST('<d>' + REPLACE(@data, @delimiter, '</d><d>') + '</d>' AS XML);

    INSERT INTO @t(data)
    SELECT  T.split.value('.', 'nvarchar(max)') AS data
    FROM    @textXML.nodes('/d') T(split)
    
    RETURN
END


****************************************************************************************************

USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[CacheMantencionEstado]    Script Date: 10-03-2021 13:04:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[CacheMantencionEstado]
AS
BEGIN
	SELECT null as Id, ' ' as Estado
	Union 
	Select 
	Id, Estado

	From MantencionEstado
END


****************************************************************************************************

USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[CachePickingEstado]    Script Date: 10-03-2021 13:03:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- --------------------------------
-- Creado:          Ariel 2018-06-06
-- Llamado desde:   Cache
-- Observaciones:   
-- Llamada SQL:     exec CachePickingEstado 
-- --------------------------------
ALTER PROCEDURE [dbo].[CachePickingEstado]
AS
BEGIN

Select null As Id,' ' As Estado, 0 as Orden
Union
Select 
	Id,
Estado,
Orden

From 
	PickingEstado
Order by Orden

END



****************************************************************************************************

USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[PTTCambiarEstado]    Script Date: 10-03-2021 13:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- --------------------------------
-- Creado:          Carlos 2018-01-04
-- Llamado desde:   FichaTecnica
-- Observaciones:   
-- Llamada SQL:     exec FichaTecnicaUpd <PARAMETROS_PA>
-- Buscar: select * from sys.sql_modules where definition like '%FichaTecnicaUpd%'
-- --------------------------------
ALTER PRocedure [dbo].[PTTCambiarEstado]
    @Id int,
	@IdEstado int,
    @IdUsuarioMod int = null
AS
BEGIN

	Declare @id_cotiz varchar(Max)

		if @IdEstado = 2
			Select @id_cotiz = id_prefijo_correlativo + cast(numero_correlativo + 1 as varchar) from Correlativos where modulo_correlativo = 'FichaTecnica'

	Begin tran
	
		update PTT with(rowlock) set
			id_ptt = ISNULL(@id_cotiz,id_ptt ),
			IdEstado = @IdEstado,
			IdUsuarioMod = @IdUsuarioMod,
			FechaMod = GETDATE()
		where 
			Id = @Id
		if @@ERROR <> 0 Goto ERROR

		Insert into PTTUsrEstado with(rowlock)
		Values (@Id, @IdEstado, @IdUsuarioMod, GETDATE())
		if @@ERROR <> 0 Goto ERROR

		if @IdEstado = 2
		Begin
			Update Correlativos set numero_correlativo = numero_correlativo + 1 where modulo_correlativo = 'FichaTecnica'
			If @@ERROR <> 0 Goto ERROR
		End

	Commit tran
	return 

ERROR:
	rollback tran

END








****************************************************************************************************


USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[ProductoPedidoDetCambiarEstado]    Script Date: 10-03-2021 13:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Roberto>                               
-- Create date: <10-06-2020>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ProductoPedidoDetCambiarEstado]
	@IdDet int,
	@IdEstadoDet int,
	@IdUsuario int
AS
BEGIN
 
	Declare @IdProductoPedido int

	Select @IdProductoPedido = IdPedido from ProductoPedidoDet where id = @IdDet

	BEgin tran

		Update ProductoPedidoDet set 
			IdEstado =  @IdEstadoDet
		from 
			ProductoPedidoDet 
		where Id=@IdDet
		If @@Error <> 0 GOTo ERROR
		
		If not Exists( SELECT        1
		FROM            ProductoPedidoDet INNER JOIN
								 ProductoPedidoDet AS ProductoPedidoDet_1 ON ProductoPedidoDet.IdPedido = ProductoPedidoDet_1.IdPedido
		WHERE        (ProductoPedidoDet.Id = @IdDet) And ProductoPedidoDet_1.IdEstado = 1)
		BEgin
			
			update Productopedido set
				Idestado	 = 4,
				FEchaMod = getdate(),
				IdUsuarioMod = @IdUsuario
			where
				Id = @IdProductoPedido
			If @@Error <> 0 GOTo ERROR

		end

		
		
		
	commit tran
	Return

ERROR:
Rollback tran
END


--select * from productoPEdidoDetEstado
--select * from productoPEdidoEstado

--select * from productoPed

****************************************************************************************************

USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[ProductoPedidoCambiarEstado]    Script Date: 10-03-2021 13:03:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ProductoPedidoCambiarEstado] 
	@Id int,
	@IdEstado int,
	@IdUsuario int,
	@IdMotivo int = null,
	@ObsMotivo varchar(1500) = null
AS
BEGIN

	DEclare @Numero int,
			@IdSolicita int,
			@IdEncargado int,
			@EmailSolicita varchar(1000),
			@EmailEncargado varchar(1000),
			@NombreSolicita varchar(1000),
			@Texto varchar(MAx),
			@IdBodega int

	if @IdEstado = 2
	Begin

		Select @Numero = MAx(Numero) from ProductoPedido

		set @Numero = isnull(@Numero, 0) + 1
	End

	If @IdEstado = 4 and Exists(
		SELECT 1       
		FROM            ProductoPedido INNER JOIN
								 ProductoPedidoDet ON ProductoPedido.Id = ProductoPedidoDet.IdPedido LEFT OUTER JOIN
								 Existencia ON ProductoPedido.IdPlanta = Existencia.IdPlanta AND ProductoPedido.IdBodega = Existencia.IdBodega AND ProductoPedidoDet.IdProducto = Existencia.IdProducto
		WHERE        (ProductoPedido.Id = @Id) And ProductoPedidoDet.Cantidad > Isnull(Existencia.Cantidad,0)
	)
	Begin
		raiserror('No hay stock para algunos de los códigos del pedido',16,1)
		return
	End

	Begin Tran

		Update ProductoPedido with(Rowlock) set
			IdEStado = @IdEstado,
			IdUsuarioMod = @IdUsuario,
			FechaMod = GETDATE(),
			Numero = Isnull	(@Numero, Numero),
			IdMotivo = @IdMotivo,
			ObsMotivo = @ObsMotivo,
			IdUsuarioMotivo = case when @IdMotivo is not null then @IdUsuario else null end
		where	
			Id = @Id
		If @@ERROR <> 0 Goto ERROR

		
		Insert into ProductoPedidoUsrEstado With(Rowlock) (IdPedido, IdUsuario, IdEstado, Fecha, IdMotivo, ObsMotivo)
		Values (@Id, @IdUsuario, @IdEstado, GETDATE(), @IdMotivo, @ObsMotivo)
		if @@ERROR <> 0 Goto ERROR



		--Envía correo
		If @IdEstado = 2
		Begin
			SELECT        
				@IdSolicita = ProductoPedido.IdSolicitante, 
				@IdEncargado = BodegaMovipack.IdEncargado, 
				@EmailSolicita = Usuarios.Email, 
				@EmailEncargado = Encargado.Email,
				@NombreSolicita = Usuarios.nombre_empleado,
				@IdBodega = ProductoPedido.IdBodega
			FROM            
				ProductoPedido INNER JOIN
				BodegaMovipack ON ProductoPedido.IdBodega = BodegaMovipack.Id Inner join
				Usuarios on ProductoPedido.IdSolicitante = Usuarios.Id inner join
				Usuarios as Encargado on BodegaMovipack.IdEncargado = Encargado.Id
			WHERE        (ProductoPedido.Id = @Id)

			if @IdSolicita <> @IdEncargado
			BEgin

				
				set @EmailSolicita  = @EmailSolicita + ';dario.lagos@movipack.cl;administracion.gerencia@movipack.cl;nestor.jara@movipack.cl'

				if @IdBodega = 2
					set @EmailSolicita  = @EmailSolicita + ';david.andrade@movipack.cl' 

				set @Texto = 'Estimado/a <br> Se ha generado la solicitud N° ' + Cast(@Numero as varchar) + ' de parte de ' + @NombreSolicita

				Insert into FactElect..tCorreosAEnviar(Id_Aplicacion, Para, Copia, Asunto, Texto, Prioridad)
				Values (4, @EmailEncargado, @EmailSolicita, 'Solicitud de Pedido N° ' + Cast(@Numero as varchar), @Texto, 1)

			End
			
		End


		IF @IdEstado = 4
		Begin
			
			Insert into ExistenciaMovimiento (IdExistencia, Cantidad, IdMotivo,	IdUsuario, FechaHora, PPP)
			SELECT        Existencia.Id, ProductoPedidoDet.Cantidad, 2, @IdUsuario, getdate(), Producto.PPP
			FROM            
				ProductoPedido INNER JOIN
				ProductoPedidoDet ON ProductoPedido.Id = ProductoPedidoDet.IdPedido INNER JOIN
				Existencia ON ProductoPedido.IdPlanta = Existencia.IdPlanta AND ProductoPedido.IdBodega = Existencia.IdBodega AND ProductoPedidoDet.IdProducto = Existencia.IdProducto Inner join
				Producto on Existencia.IdProducto = Producto.Id
			WHERE        (ProductoPedido.Id = @Id)
			if @@ERROR <> 0 Goto ERROR

			UPDATE Existencia SET         
				Cantidad = Existencia.Cantidad - ProductoPedidoDet.Cantidad
			FROM            
				ProductoPedido INNER JOIN
				ProductoPedidoDet ON ProductoPedido.Id = ProductoPedidoDet.IdPedido INNER JOIN
				Existencia ON ProductoPedido.IdPlanta = Existencia.IdPlanta AND ProductoPedido.IdBodega = Existencia.IdBodega AND ProductoPedidoDet.IdProducto = Existencia.IdProducto
			WHERE        
				(ProductoPedido.Id = @Id)
			if @@ERROR <> 0 Goto ERROR

		End

	Commit tran
	Return

ERROR:
	rollback tran

END



****************************************************************************************************

USE [SPMProd]
GO
/****** Object:  StoredProcedure [dbo].[PickingCambioEstado]    Script Date: 10-03-2021 13:02:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PickingCambioEstado]
	@Id int,
	@IdEstado int,
	@IdUsuario int,
	@IdMotivo int  = null,
	@ObsMotivo varchar(250) = null,
	@IdResponsable int = null
AS
BEGIN

	Declare @IdLinea int,	
			@id_picking varchar(100),
			@Cantidad int,
			@IdProducto int,
			@IdPicking int,
			@IdPlanta int,
			@Motivo int,
			@IdExistencia int,
			@PPP money

		

	--if @IdEstado not in( 4, 5) And Exists(SELECT        1
	--FROM            Picking INNER JOIN
	--						 PlanificacionDet ON Picking.IdPlanificacionDet = PlanificacionDet.Id INNER JOIN
	--						 Planificacion ON PlanificacionDet.IdPlanificacion = Planificacion.Id
	--WHERE        (Picking.Id = @Id) AND (Planificacion.Fecha < cast(GETDATE() as date)))
	--BEgin
	--	raiserror('No se puede cambiar el estado del picking. Contáctese con el administrador',16,1)
	--	return
	--End
	
	If @IdEstado in(2) and exists(Select 1 from Picking  where Picking.Id = @Id and IdEstado not in(8,4) )
	Begin
		raiserror('No se puede cambiar el estado, el picking no está en un estado válido',16,1)
		return
	End
		
	
	If @IdEstado in(7) 
	Begin
		If exists(Select 1 from Picking  where Picking.Id = @Id and IdEstado not in(1) )
		Begin
			raiserror('No se puede cambiar el estado, el picking no está en un estado válido',16,1)
			return
		End

		If (Select Count(Id) From DetPicking where IdPicking = @Id) = 0 and (Select Count(Id) From PickingExistencia where IdPicking = @Id) = 0
		BEgin
			raiserror('El picking no posee detalles, debe agregar tarjas al picking para que puedan ser pickeadas',16,1)
			return
		End

	End
	If @IdEstado in(6) and exists(Select 1 from Picking  where Picking.Id = @Id and IdEstado not in(7) )
	Begin
		raiserror('No se puede cambiar el estado, el picking no está en un estado válido',16,1)
		return
	End
		
	If @IdEstado in(8) and exists(Select 1 from Picking  where Picking.Id = @Id and IdEstado not in(6) )
	Begin
		raiserror('No se puede cambiar el estado, el picking no está en un estado válido',16,1)
		return
	End
			
	If @IdEstado in(6,7,8)
	Begin
		if exists(Select 1 from Picking  where Picking.Id = @Id and IdEstado in(2,3) )
		Begin
			raiserror('No se puede cambiar el estado, el picking no está en un estado válido',16,1)
			return
		End
	End

	if @IdEstado not in( 4,5)
	Begin
		if exists(Select 1 from Picking Inner join Programacion on Picking.IdProgramacion = Programacion.Id where Picking.Id = @Id and Programacion.IdEstado <> 2 )
		Begin
			raiserror('No se puede cambiar el estado, el proceso no está en un estado válido',16,1)
			return
		End
	End

	if @IdEstado = 7
	BEgin
		If (Select count(*) from PickingParticipante where IdPicking = @Id) = 0
		Begin
			raiserror('Debe ingresar a los participantes de este picking',16,1)
			return
		End
	End

	if @IdEstado = 3
	Begin

		Declare @HaIniciado int

		SELECT   @HaIniciado = ProgramacionTiempo.Id
			FROM            Programacion INNER JOIN
									 ProgramacionTiempo ON Programacion.Id = ProgramacionTiempo.IdProgramacion INNER JOIN
									 Picking ON Programacion.Id = Picking.IdProgramacion
			WHERE        (ProgramacionTiempo.FechaHoraFin IS NULL) AND (Picking.Id = @Id)

		If @HaIniciado is null
			BEgin
				raiserror('Para validar un picking, debe iniciar el proceso',16,1)
				return
			End
	End



	--if @IdEstado = 7
	--Begin
	--	SELECT DetPicking.IdTarjaIng, TarjaIngreso.id_insumo, TarjaIngreso.IdCliente, TarjaIngreso.venceLote_tarIng Into #Vences
	--	FROM            DetPicking INNER JOIN
	--							 TarjaIngreso ON DetPicking.IdTarjaIng = TarjaIngreso.Id
	--	WHERE        (DetPicking.IdPicking = @Id) AND (TarjaIngreso.venceLote_tarIng IS NOT NULL) 

	--	Select 
	--		Distinct TarjaIngreso.id_insumo, TarjaIngreso.IdCliente, TarjaIngreso.venceLote_tarIng Into #Actuales
	--	from 
	--		TarjaIngreso inner join
	--		#Vences as V on TarjaIngreso.id_insumo = V.id_insumo and TarjaIngreso.IdCliente = V.IdCliente Left Outer join
	--		DetPicking inner join
	--		Picking on DetPicking.IdPicking = Picking.Id on TarjaIngreso.Id =  DetPicking.IdTarjaIng and Picking.IdEstado not in(4,5)
	--	Where
	--		TarjaIngreso.saldo_taring > 0 and V.IdTarjaIng <> TarjaIngreso.Id and DetPicking.Id is null

	--	If Exists(Select 
	--		1 
	--	from 
	--		#Vences as V inner join
	--		#Actuales as A on V.id_insumo = A.id_insumo and  V.IdCliente = A.IdCliente
	--	Where
	--		V.venceLote_tarIng  > A.venceLote_tarIng
	--	)
	--	Begin
			
	--		raiserror('Se están pickeando productos que vencen mas a futuro, favor de pickear los que están proximos a vencer.',16,1)

	--		drop table #Vences
	--		drop table #Actuales
	--		return

	--	End

	--	drop table #Vences
	--	drop table #Actuales

	--End
	
	--If @IdEstado not in ( 2,4,5)
	--BEgin

	--	Declare @Tarjas varchar(Max) = ''


	--	Select @Tarjas = @Tarjas + cast(TarjaIngreso.id_taring  as varchar) + ','
	--	From	
	--		DetPicking inner join
	--		TarjaIngreso on DetPicking.IdTarjaIng = TarjaIngreso.Id inner join
	--		SegregacionDet on TarjaIngreso.Id = SegregacionDet.IdTarjaIngreso
	--	Where
	--		DetPicking.IdPicking = @Id

	--	If @@ROWCOUNT > 0
	--	BEgin
	--		raiserror('Las siguientes tarjas se encuentran asociadas a unas segregaciones: %s', 16,1,@Tarjas)
	--		return
	--	End

	--End

	BEgin tran

		if @IdEstado = 7
		Begin
			Select @id_picking = numero_correlativo from Correlativos where modulo_correlativo = 'Picking'

			update Correlativos set numero_correlativo = numero_correlativo + 1  where modulo_correlativo = 'Picking'
			If @@ERROR <> 0 Goto ERROR
	
		End

		Update Picking with(Rowlock) set 
			IdEstado = @IdEstado,
			IdMotivo = @IdMotivo,
			FechaMotivo = case when @IdMotivo is null then null else getdate() end,
			IdUsuarioMod = @IdUsuario,
			FechaMod = GETDATE(),
			id_picking = isnull(@id_picking,id_picking)
			
		Where	
			Id = @Id
		If @@ERROR <> 0 Goto ERROR

		Insert into PickingUsrEstado 
		Values (@Id, @IdUsuario, @IdEstado, getdate(), @IdMotivo, @ObsMotivo, @IdResponsable)
		If @@ERROR <> 0 Goto ERROR



		--Parte que quita del inventario de Adquisiciones
		if @IdEstado= 2
		BEGIN
				
			DECLARE  cur_picking CURSOR	for SELECT   DetPTT.IdProducto,  SUM(DetPicking.cant_detPick) , Picking.id_planta
					FROM            
						DetPicking INNER JOIN
						DetPTT ON DetPicking.IdDetPTT = DetPTT.Id inner join
						Picking on DetPicking.IdPicking = Picking.Id
					WHERE        
						(DetPicking.IdPicking = @Id) AND (DetPTT.IdProducto IS NOT NULL)
					GROUP BY 
						DetPTT.IdProducto, Picking.id_planta

					OPEN cur_picking 	

						fetch next from cur_picking INTO @IdProducto, @Cantidad ,@IdPlanta

						WHILE @@FETCH_STATUS = 0 
----------------------------------------------------------------------------------------------------------------------------------------------
						BEGIN
								UPDATE Existencia SET 
										Cantidad = ( Cantidad - @Cantidad) 
								WHERE  IdProducto = @IdProducto and idplanta = @IdPlanta
								If @@ERROR <> 0 Goto ERROR_CUR
----------------------------------------------------------------------------------------------------------------------------------------------
						 SELECT       @PPP=Producto.PPP, 
									  @IdExistencia=Existencia.Id
						 FROM         Existencia INNER JOIN
						 Producto ON Existencia.IdProducto = Producto.Id
						 WHERE Existencia.IdProducto=@IdProducto and Existencia.IdPlanta = @IdPlanta

						 
						insert into ExistenciaMovimiento with(rowlock) (
							 IdExistencia, Cantidad ,IdMotivo,IdUsuario,FechaHora, PPP )
						values (
							@IdExistencia, @Cantidad ,1,@IdUsuario,getdate(), @PPP)							
						If @@ERROR <> 0 Goto ERROR_CUR

----------------------------------------------------------------------------------------------------------------------------------------------								
			fetch next from cur_picking INTO @IdProducto, @Cantidad ,@IdPlanta
						END
			CLOSE cur_picking
			DEALLOCATE cur_picking
	END
	commit tran
	return

ERROR_CUR:
	close cur_picking
	deallocate cur_picking

ERROR:
	Rollback tran


END


****************************************************************************************************
****************************************************************************************************
****************************************************************************************************
****************************************************************************************************



