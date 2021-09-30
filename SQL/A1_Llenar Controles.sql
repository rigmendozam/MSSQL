

Select
	c.name,
	Case 
		when ty.user_type_id in(167,175) Then
			'txt'+ c.name + '.Text = dtr["' +c.name+'"].ToString();'
		
		when ty.user_type_id in(61) And (c.name like '%Crea%' Or c.name like '%Mod%') And c.is_nullable = 0 Then
			'txt'+ c.name + '.Text = ((DateTime)dtr["' +c.name+'"]).ToString("g");'
		
		when ty.user_type_id in(61) And (c.name like '%Crea%' Or c.name like '%Mod%') And c.is_nullable = 1 Then
			'txt'+ c.name + '.Text = dtr.IsNull("' +c.name+'") ? "" : ((DateTime)dtr["' +c.name+'"]).ToString("g");'
		
		when ty.user_type_id in(56,48) And (c.name like '%Id%') Then
			'ddl'+ c.name + '.SelectedValue = dtr["' +c.name+'"];'

		when ty.user_type_id in(104) And (c.name like '%Activo%') Then
			'txt'+ c.name + '.Text = (bool)dtr["' +c.name+'"] ? "Activo" : "Inactivo";'

		--Descomentar si se usa un check
		--When ty.user_type_id in(104) Then
		--	Case When c.is_nullable = 0 Then
		--		'chk'+ c.name + '.Checked = (bool)dtr["' +c.name+'"];'
		--	else
		--		'chk'+ c.name + '.Checked = (dtr["' +c.name+'"] as bool?)??false;'
		--	end

		When ty.user_type_id in(104) Then
			'if((bool)dtr["' +c.name+'"]) rbt'+ c.name + 'Si.Checked = true; else rbt'+ c.name + 'No.Checked = false;'
		When ty.user_type_id in(40,61) Then
			Case When c.is_nullable = 0 Then
				'dtp'+ c.name + '.Value = (DateTime)dtr["' +c.name+'"];'
			else
				'dtp'+ c.name + '.Value = (dtr["' +c.name+'"] as DateTime?)??DateTime.Now;'
			End

		When ty.user_type_id in(56,60,106,127) Then
			Case When c.is_nullable = 0 Then
				'nud'+ c.name + '.Value = ( '+ case when ty.user_type_id = 56 then 
													'int'
												when ty.user_type_id in(60,106) then 
													'decimal' 
												when ty.user_type_id in(127) then 
													'long' 
												end + ')dtr["' +c.name+'"];'
			else
				'nud'+ c.name + '.Value = (dtr["' +c.name+'"] as '+ case when ty.user_type_id = 56 then 
													'int'
												when ty.user_type_id in(60,106) then 
													'decimal' 
												when ty.user_type_id in(127) then 
													'long' 
												end + '?)??0;'
			End


	End,
	ty.user_type_id,
	ty.name,
	c.is_nullable,

	Case 
		when ty.user_type_id in(167,175) Then
			'txt'+ c.name  
		
		when ty.user_type_id in(61) And (c.name like '%Crea%' Or c.name like '%Mod%') And c.is_nullable = 0 Then
			'txt'+ c.name 
		
		when ty.user_type_id in(61) And (c.name like '%Crea%' Or c.name like '%Mod%') And c.is_nullable = 1 Then
			'txt'+ c.name 
		
		when ty.user_type_id in(56,48) And (c.name like '%Id%') Then
			'ddl'+ c.name 

		when ty.user_type_id in(104) And (c.name like '%Activo%') Then
			'txt'+ c.name 
		--Descomentar si se quiere usar check
		--When ty.user_type_id in(104) Then
		--	'chk'+ c.name 
		When ty.user_type_id in(104) Then
			'rbt'+ c.name  + 'Si' + Char(10) + char(13) +
			'rbt'+ c.name  + 'No' 
		When ty.user_type_id in(40,61) Then
			'dtp'+ c.name 
		When ty.user_type_id in(56,60,106,127) Then
			'nud'+ c.name 
	End
from 
	sys.columns c inner join 
	sys.types ty On c.user_type_id =  ty.user_type_id Inner join
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'A'  


	drop table A