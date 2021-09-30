
Select  
	Case 
		when ty.user_type_id in(104) Then
			'chk'+ c.name + '.Checked'  
		When ty.user_type_id in(56,48) and c.name like 'Id%' Then
			'ddl'+ c.name + '.SelectedValue'  
		When ty.user_type_id in(56,60,106,127) Then
			Case 
				When c.is_nullable = 0 then
					'nud'+ c.name + '.Value'  
				else
					'nud'+ c.name + '.Value == 0 ? null : (decimal?)nud'+ c.name + '.Value'
				End
		when ty.user_type_id in(167)  Then
			Case 
				When c.is_nullable = 0 then
					'txt'+ c.name + '.Text'  
				else
					'string.IsNullOrWhiteSpace(txt'+ c.name + '.Text) ? null : txt'+ c.name + '.Text'   
			End			
			when ty.user_type_id in(40,61)  Then
			Case 
				When c.is_nullable = 0 then
					'dtp'+ c.name + '.Value'  
				else
					'!dtp'+ c.name + '.Checked ? null : (DateTime?)dtp'+ c.name + '.Value'   
			End			
		--When ty.user_type_id in(61) And c.is_nullable = 0 Then
		--	'string.IsNullOrWhiteSpace(txt'+ c.name + '.Text) ? null : txt'+ c.name + '.Text'   

		else ''
	End
	 + ',',
	 ty.name,
	 ty.user_type_id,
	 c.name
from 
	sys.columns c inner join 
	sys.types ty On c.user_type_id =  ty.user_type_id Inner join
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'Entidad'  --and c.is_nullable = 0 and c.default_object_id = 0