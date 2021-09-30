
SELECT     
		EntidadBeneficiarioTransf.IdEntidadBeneficiarioTransf,
		EntidadBeneficiarioTransf.IdEntidad,
		Entidad.Codigo AS CodigoEntidad,
		Entidad.NombreCompleto AS NombreEntidad,
		EntidadBeneficiarioTransf.IdBeneficiario,
		Beneficiario.Codigo AS CodigoBenef,
		Beneficiario.NombreCompleto AS NombreBenef,
		EntidadBeneficiarioTransf.IdBanco,
		EntidadBeneficiarioTransf.IdPais,
		EntidadBeneficiarioTransf.NumeroCuenta,
		EntidadBeneficiarioTransf.Swif,
		EntidadBeneficiarioTransf.ABA,
		EntidadBeneficiarioTransf.Ciudad,
		EntidadBeneficiarioTransf.Direccion,
		EntidadBeneficiarioTransf.IdBancoInter,
		EntidadBeneficiarioTransf.DireccionInter,
		EntidadBeneficiarioTransf.IdPaisInter,
		EntidadBeneficiarioTransf.CiudadInter,
		EntidadBeneficiarioTransf.NumeroCuentaInter,
		EntidadBeneficiarioTransf.SwifInter,
		EntidadBeneficiarioTransf.ABAInter,
		EntidadBeneficiarioTransf.Obs,
		EntidadBeneficiarioTransf.Motivo Into A
	FROM            
		EntidadBeneficiarioTransf INNER JOIN
		Entidad ON EntidadBeneficiarioTransf.IdEntidad = Entidad.IdEntidad INNER JOIN
		Entidad AS Beneficiario ON EntidadBeneficiarioTransf.IdBeneficiario = Beneficiario.IdEntidad

Select  
	Case 
		When ty.user_type_id in(56,48) and c.name like 'Id%' Then
			'if(ddl'+ c.name + '.SelectedValue == null)'  
		When ty.user_type_id in(56,60,106) Then
			'if(nud'+ c.name + '.Value == 0) '  
		when ty.user_type_id in(167)  Then
			'if(string.IsNullOrWhiteSpace(txt'+ c.name + '.Text))'   
		else null
	End
	 +  Char(13) + Char(10) + 'stbError.AppendLine("'+ c.name + ' es requerido.");' +  Char(13) + Char(10)
	 ,
	 ty.name,
	 ty.user_type_id,
	 c.name
from 
	sys.columns c inner join 
	sys.types ty On c.user_type_id =  ty.user_type_id Inner join
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'A'  --and c.is_nullable = 0 and c.default_object_id = 0

Drop Table A