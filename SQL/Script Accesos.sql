
Begin tran

SELECT     AccUsuarioOpcion.*
FROM         AccUsuarioOpcion INNER JOIN
                      AccOpcion ON AccUsuarioOpcion.IdOpcion = AccOpcion.IdOpcion
WHERE     (AccOpcion.Accion > 0)

Update  AccUsuarioOpcion set 
	Ver = case When AccOpcion.Accion = 2 then 0 else Ver end,
	Editar = case When AccOpcion.Accion = 1 then 0 else Editar end
From 
	AccUsuarioOpcion Inner join
	AccOpcion On AccUsuarioOpcion.IdOpcion	= AccOpcion.IdOpcion
Where AccOpcion.Accion > 0

Delete From AccUsuarioOpcion Where Ver = 0 and Editar = 0

SELECT     AccUsuarioOpcion.*
FROM         AccUsuarioOpcion INNER JOIN
                      AccOpcion ON AccUsuarioOpcion.IdOpcion = AccOpcion.IdOpcion
WHERE     (AccOpcion.Accion > 0)

rollback tran
