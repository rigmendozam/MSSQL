ALTER PRocedure [dbo].[PickingDetDel]
    @Id int
AS
BEGIN

delete from DetPicking with(rowlock)
where Id = @Id

END




