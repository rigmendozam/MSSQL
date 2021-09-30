-- Usar un select top 0 que devuelva la estructura de la tabla y hacer un "into A"

Declare @TablaReporte varchar(100) = 'ORFSel_Grids'

declare
    @FormularioCons bit = 0,  -- En 1 para los formulario de consulta. En las consultas todas las columnas son de texto.
    @Salto varchar(10) = char(13) + char(10)

SELECT        
		ProgramaDevolucion.Id, ProgramaDevolucion.IdPrograDetPicking, 
		ProgramaDevolucion.IdTipo, ProgramaDevolucion.IdMotivo, ProgramaDevolucion.Cantidad Into A
	FROM            
		PrograDetPicking INNER JOIN
		ProgramaDevolucion ON PrograDetPicking.Id = ProgramaDevolucion.IdPrograDetPicking

select

    -- Declaracion
    'private System.Windows.Forms.' + 
    case when @FormularioCons = 1 then 'DataGridViewTextBoxColumn' 
         when ty.user_type_id in(56, 48) and c.name like 'Id%' then 'DataGridViewComboBoxColumn'
         when ty.user_type_id in(167, 56, 60) then 'DataGridViewTextBoxColumn'
         when ty.user_type_id in(104) then 'DataGridViewCheckBoxColumn'
         when ty.user_type_id in(40,61,106) then 'DataGridViewTextBoxColumn'
         else '' 
    end + ' col' + c.name + ';' as Declaracion,

    -- Inicializacion
    'this.col' + c.name + ' = new System.Windows.Forms.' + 
    case when @FormularioCons = 1 then 'DataGridViewTextBoxColumn();'
         when ty.user_type_id in(56, 48) and c.name like 'Id%' then 'DataGridViewComboBoxColumn();'
         when ty.user_type_id in(167, 56, 60) then 'DataGridViewTextBoxColumn();'
         when ty.user_type_id in(104) then 'DataGridViewCheckBoxColumn();'
         when ty.user_type_id in(40,61,106) then 'DataGridViewTextBoxColumn();'
         else ''
    end as Inicializacion,

    -- AgregarCol
    'this.col' + c.name + ',' as AgregarCol,

    -- Propiedades
    '//' + @Salto +
    '//col' + c.name + @Salto + 
    '//' + @Salto + 'this.col' + c.name + '.HeaderText = "' + c.name + '"; ' + @Salto +
    'this.col' + c.name + '.Name = "col' + c.name + '"; ' + @Salto +
    'this.col' + c.name + '.DataPropertyName = "' + c.name + '"; ' + @Salto +
    case when ty.user_type_id in(167) then 'this.col' + c.name + '.MaxInputLength = ' + cast(c.max_length as varchar) + '; '
         when ty.user_type_id in(56, 48) and c.name like 'Id%' then 'this.col' + c.name + '.DisplayStyleForCurrentCellOnly = true;'
         when ty.user_type_id in(167, 56, 60,106) then 'System.Windows.Forms.DataGridViewCellStyle style' + c.name + ' = new System.Windows.Forms.DataGridViewCellStyle();' + @Salto +
                                                   'style' + c.name + '.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;' + @Salto +
                                                   'style' + c.name + '.Format = "#,##0.##";' + @Salto +
													'this.col' + c.name + '.DefaultCellStyle = style' + c.name + ';'
         when ty.user_type_id in(40, 61) then 'System.Windows.Forms.DataGridViewCellStyle style' + c.name + ' = new System.Windows.Forms.DataGridViewCellStyle();' + @Salto +
                                                   'style' + c.name + '.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;' + @Salto +
                                                   'style' + c.name + '.Format = "'+ Case when ty.user_type_id = 40 then 'd' else 'g' end +'";' + @Salto  +
													'this.col' + c.name + '.DefaultCellStyle = style' + c.name + ';'
        else ''
    end as Propiedades,

	-- FiltroCelda
    'Filtro.Agregar(new FiltroCelda(dtgGrillaFiltro.AgregarColumnaFiltro(col' + c.name + '.Index), "'+t.name+'.'+c.name+'", col' + c.name + '.HeaderText, TIPO_DATO.' + 
    case 
		when ty.user_type_id in(56, 48, 127, 60,106) then 'Numero'
        when ty.user_type_id in(167) then 'Texto'
        when ty.user_type_id in(40,61) then 'Fecha'
        else ''
    end + '));' as Inicializacion,
	--ColReporte
	'<TablixColumn>
              <Width>2.5cm</Width>
            </TablixColumn>' as ColReporte,
	'<TablixCell>
                  <CellContents>
                    <Textbox Name="' + c.name + Cast(ROW_NUMBER() OVER(ORDER BY c.column_id ASC) as varchar) + '">
                      <CanGrow>true</CanGrow>
                      <KeepTogether>true</KeepTogether>
                      <Paragraphs>
                        <Paragraph>
                          <TextRuns>
                            <TextRun>
                              <Value>' + c.name + '</Value>
                              <Style>
                                <FontWeight>Bold</FontWeight>
                              </Style>
                            </TextRun>
                          </TextRuns>
                           '+case 
								when c.user_type_id in (40,61) then '<Style><TextAlign>Center</TextAlign></Style>' 
								when c.user_type_id in (106,60) then '<Style><TextAlign>Right</TextAlign></Style>' 
								else '<Style />'
						  end +' 
                        </Paragraph>
                      </Paragraphs>
                      <rd:DefaultName>' + c.name + Cast(ROW_NUMBER() OVER(ORDER BY c.column_id ASC) as varchar) + '</rd:DefaultName>
                      <Style>
                        <Border>
                          <Style>Solid</Style>
                        </Border>
                        <TopBorder>
                          <Color>Black</Color>
                          <Style>Solid</Style>
                          <Width>1pt</Width>
                        </TopBorder>
                        <BottomBorder>
                          <Color>Black</Color>
                          <Style>Solid</Style>
                          <Width>1pt</Width>
                        </BottomBorder>
                        <LeftBorder>
                          <Color>Black</Color>
                          <Style>Solid</Style>
                          <Width>1pt</Width>
                        </LeftBorder>
                        <RightBorder>
                          <Color>Black</Color>
                          <Style>Solid</Style>
                          <Width>1pt</Width>
                        </RightBorder>
                        <BackgroundColor>WhiteSmoke</BackgroundColor>
                        <PaddingLeft>2pt</PaddingLeft>
                        <PaddingRight>2pt</PaddingRight>
                        <PaddingTop>2pt</PaddingTop>
                        <PaddingBottom>2pt</PaddingBottom>
                      </Style>
                    </Textbox>
                  </CellContents>
                </TablixCell>' as ColReporte2,
				'<TablixCell>
                  <CellContents>
                    <Textbox Name="' + c.name + '">
                      <CanGrow>true</CanGrow>
                      <KeepTogether>true</KeepTogether>
                      <Paragraphs>
                        <Paragraph>
                          <TextRuns>
                            <TextRun>
                              <Value>=Fields!' + c.name + '.Value</Value>
                               '+case 
									when c.user_type_id in (40,61) then '<Style><Format>d</Format></Style>' 
									when c.user_type_id in (106,60) then '<Style><Format>#,##0.##</Format></Style>' 
									else '<Style />'
								end +' 
                            </TextRun>
                          </TextRuns>
                          '+case 
								when c.user_type_id in (40,61) then '<Style><TextAlign>Center</TextAlign></Style>' 
								when c.user_type_id in (106,60) then '<Style><TextAlign>Right</TextAlign></Style>' 
								else '<Style />'
						  end +' 
                        </Paragraph>
                      </Paragraphs>
                      <rd:DefaultName>' + c.name + '</rd:DefaultName>
                      <Style>
                        <Border>
                          <Color>LightGrey</Color>
                          <Style>Solid</Style>
                        </Border>
                        <PaddingLeft>2pt</PaddingLeft>
                        <PaddingRight>2pt</PaddingRight>
                        <PaddingTop>2pt</PaddingTop>
                        <PaddingBottom>2pt</PaddingBottom>
                      </Style>
                    </Textbox>
                  </CellContents>
                </TablixCell>' as ColReporte3,
				'<TablixMember />' as Member,
	'<xs:element name="' + c.name + '" msprop:Generator_ColumnVarNameInTable="column' + c.name + '" msprop:Generator_ColumnPropNameInRow="' + c.name + '" msprop:Generator_ColumnPropNameInTable="' + c.name + 'Column" msprop:Generator_UserColumnName="' + c.name + '" type="xs:'+case 
								when c.user_type_id in (40,61) then 'dateTime' 
								when c.user_type_id in (106,60) then 'decimal' 
								else 'string'
						  end +'" minOccurs="0" />' as EsquemaXSD,

    -- Otros
    ty.user_type_id,
    ty.name,
    c.is_nullable
from sys.columns as c
    inner join sys.types as ty on c.user_type_id = ty.user_type_id
    inner join sys.tables as t on c.object_id = t.object_id
where t.name = 'A'



Select 
c.name +' '+ ty.name +' '+ 
case c.system_type_id 
	When 167 Then '(' + cast(c.max_length as varchar) +')'
	When 175 Then '(' + cast(c.max_length as varchar) +')'
	When 106 Then '(' + cast(c.precision as varchar) + ',' + cast(c.scale as varchar) + ')'
	else '' 
End  +''+	
 ',',
 c.name + ',' from sys.columns c inner join 
sys.types ty On c.user_type_id =  ty.user_type_id Inner join
sys.tables t on c.object_id = t.object_id
Where t.name  = 'A' 


Select 
		'<xs:element name="'+@TablaReporte+'" msprop:Generator_TableClassName="'+@TablaReporte+'DataTable" msprop:Generator_TableVarName="table'+@TablaReporte+'" msprop:Generator_TablePropName="'+@TablaReporte+'" msprop:Generator_RowDeletingName="'+@TablaReporte+'RowDeleting" msprop:Generator_RowChangingName="'+@TablaReporte+'RowChanging" msprop:Generator_RowEvHandlerName="'+@TablaReporte+'RowChangeEventHandler" msprop:Generator_RowDeletedName="'+@TablaReporte+'RowDeleted" msprop:Generator_UserTableName="'+@TablaReporte+'" msprop:Generator_RowChangedName="'+@TablaReporte+'RowChanged" msprop:Generator_RowEvArgName="'+@TablaReporte+'RowChangeEvent" msprop:Generator_RowClassName="'+@TablaReporte+'Row">' as EsquemaXSD


drop table A