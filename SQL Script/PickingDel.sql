ALTER PRocedure [dbo].[PickingDel]
    @Id int
AS
BEGIN


	if exists(Select 1 From Picking where id = @Id and IdEstado <> 1)
	BEgin
		raiserror('El picking no se encuentra en un estado válido para ser eliminado',16,1)
		return
	End

	BEgin tran
	
		Delete from PickingUsrEstado with(rowlock)
		where IdPicking = @Id
		if @@ERROR <> 0 Goto ERROR

		delete from Picking with(rowlock)
		where Id = @Id
		if @@ERROR <> 0 Goto ERROR

	Commit tran
	return

ERROR:
	rollback tran
END



