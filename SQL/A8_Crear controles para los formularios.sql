
SELECT        
		EntidadDeclaBenef.IdDeclaracion,
		EntidadDeclaBenef.IdEntidad,
		Entidad.Codigo,
		Entidad.NombreCompleto,
		EntidadDeclaBenef.Fecha,
		EntidadDeclaBenef.Folio,
		EntidadDeclaBenef.IdTipoDeclaracion,
		EntidadDeclaBenef.IdTipoSociedad,
		EntidadDeclaBenef.OtroTipoSociedad,
		EntidadDeclaBenef.IdEntidadDeclarante,
		EntidadDeclaBenef.IdNacionalidadTipo,
		EntidadDeclaBenef.RelacionDeclarante,
		EntidadDeclaBenef.IdDeclaracionRelacionada,
		EntidadDeclaBenef.IdEstadoDocumento Into A
	FROM            
		EntidadDeclaBenef INNER JOIN
		Entidad ON EntidadDeclaBenef.IdEntidad = Entidad.IdEntidad

Declare @Salto varchar(10) = Char(13) + Char(10)

Select
	c.name,
	'private System.Windows.Forms.Label lbl' + c.name + ';' + @Salto + 'private System.Windows.Forms.' + 
	Case 
		when ty.user_type_id in(167,175) Then
			'TextBox txt'+ c.name  		
		when ty.user_type_id in(56,48) And (c.name like '%Id%') Then
			'ComboBox ddl'+ c.name 
		When ty.user_type_id in(104) Then
			'CheckBox chk'+ c.name 
		When ty.user_type_id in(40) Then
			'DateTimePicker dtp'+ c.name 
		When ty.user_type_id in(56,60,106) Then
			'NumericUpDown nud'+ c.name 
	End +';', 


	'this.lbl' + c.name + '= new System.Windows.Forms.Label();' + @Salto +
	'this.' + 
	Case 
		when ty.user_type_id in(167,175) Then
			'txt'+ c.name + '= new System.Windows.Forms.TextBox()' 		
		when ty.user_type_id in(56,48) And (c.name like '%Id%') Then
			'ddl'+ c.name + '= new System.Windows.Forms.ComboBox()'
		When ty.user_type_id in(104) Then
			'chk'+ c.name + '= new System.Windows.Forms.CheckBox()'
		When ty.user_type_id in(40) Then
			'dtp'+ c.name + '= new System.Windows.Forms.DateTimePicker()'
		When ty.user_type_id in(56,60,106) Then
			'nud'+ c.name + '= new System.Windows.Forms.NumericUpDown()'
	End +';',

	'this.Controls.Add(this.lbl'+ c.name + ');' + @Salto +
	'this.Controls.Add(this.' +
	Case 
		when ty.user_type_id in(167,175) Then
			'txt'+ c.name  
		
		when ty.user_type_id in(56,48) And (c.name like '%Id%') Then
			'ddl'+ c.name 
		When ty.user_type_id in(104) Then
			'chk'+ c.name 
		When ty.user_type_id in(40) Then
			'dtp'+ c.name 
		When ty.user_type_id in(56,60,106) Then
			'nud'+ c.name 
	End + ');',


	Case 
		when ty.user_type_id in(167,175) Then
		'//'+ @Salto +
		'//txt' + c.name + @Salto +
		'//'+ @Salto +
		'txt'+ c.name + '.Location = new System.Drawing.Point(10, 10);'  + @Salto+
		'txt'+ c.name + '.MaxLength = '+ cast(c.max_length as varchar) +';'  + @Salto+
		'txt'+ c.name + '.Name = "'+ c.name +'";'  + @Salto
		
		when ty.user_type_id in(56,48) And (c.name like '%Id%') Then
			'ddl'+ c.name 
		When ty.user_type_id in(104) Then
			'chk'+ c.name 
		When ty.user_type_id in(40) Then
			'dtp'+ c.name 
		When ty.user_type_id in(56,60,106) Then
			'nud'+ c.name 
	End 
	+
	'//'+ @Salto +
	'//lbl' + c.name + @Salto +
	'//'+ @Salto +
	'lbl'+ c.name + '.AutoSize = true;'  + @Salto+
	'lbl'+ c.name + '.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));'  + @Salto+
	'lbl'+ c.name + '.Location = new System.Drawing.Point(10, 10);'  + @Salto+
	'lbl'+ c.name + '.Name =  "'+ c.name +'";'  + @Salto+
	'lbl'+ c.name + '.Text =  "'+ c.name +'";'  + @Salto

from 
	sys.columns c inner join 
	sys.types ty On c.user_type_id =  ty.user_type_id Inner join
	sys.tables t on c.object_id = t.object_id
Where 
	t.name  = 'A'  

Drop table A

