
Declare @TablaReporte varchar(100) = 'OrdenPagoSel_RptEnc'

declare 
    @Salto varchar(10) = char(13) + char(10),
	@Cells varchar(Max) = '',
	@Member varchar(Max) = '',
	@Tablix varchar(Max) = '<Tablix Name="Tablix5">
            <TablixBody>
              <TablixColumns>
                <TablixColumn>
                  <Width>2.77122cm</Width>
                </TablixColumn>
                <TablixColumn>
                  <Width>7.91535cm</Width>
                </TablixColumn>                
              </TablixColumns>
              <TablixRows>
              {Row}
              </TablixRows>
            </TablixBody>
            <TablixColumnHierarchy>
              <TablixMembers>
                <TablixMember />
                <TablixMember />
              </TablixMembers>
            </TablixColumnHierarchy>            
            <TablixRowHierarchy>
              <TablixMembers>
               {FilasMember}
              </TablixMembers>
            </TablixRowHierarchy>
            <DataSetName>DataSetDatos</DataSetName>
            <Left>0.02647cm</Left>
            <Height>4.2cm</Height>
            <Width>19.06209cm</Width>
            <ZIndex>1</ZIndex>
            <Style>
              <Border>
                <Style>Solid</Style>
              </Border>
            </Style>
          </Tablix>'


SELECT        
	Factura.FechaEmision, 
	Factura.Numero, 
	FacturaTipoDoc.TipoDocumento, 
	FacturaConcepto.FacturaConcepto, 
	CC_Tipo.TipoCC, 
	FormaPago.FormaPago, 
	Factura.FechaValuta, 
	Entidad.Codigo, 
    Entidad.NombreCompleto, 
	Moneda.Moneda, 
	Factura.ValorTotal, 
	Factura.Liquidado, 
	Factura.PorLiquidar, 
	Factura.Observaciones 
	Into A 
FROM				
	Factura INNER JOIN
    FacturaTipoDoc ON Factura.IdFacturaTipoDoc = FacturaTipoDoc.IdTipoDocumento INNER JOIN
    FacturaConcepto ON Factura.IdFacturaConcepto = FacturaConcepto.IdFacturaConcepto INNER JOIN
    CC_Tipo ON Factura.IdTipoCC = CC_Tipo.IdTipoCC INNER JOIN
    FormaPago ON Factura.IdFormaPago = FormaPago.IdFormaPago INNER JOIN
    Moneda ON Factura.IdMoneda = Moneda.IdMoneda INNER JOIN
    Entidad ON Factura.IdEntidad = Entidad.IdEntidad


	 
Select Cast(@Tablix as text) as TablixPlantilla

Select 

	'<TablixRow>
	<Height>0.6cm</Height>
	<TablixCells>
	<TablixCell>
                      <CellContents>
                        <Textbox Name="Textbox'+Cast(ROW_NUMBER() OVER(ORDER BY c.column_id ASC) as varchar)+'">
                          <CanGrow>true</CanGrow>
                          <KeepTogether>true</KeepTogether>
                          <Paragraphs>
                            <Paragraph>
                              <TextRuns>
                                <TextRun>
                                  <Value>'+c.Name+':</Value>
                                  <Style>
                                    <FontWeight>Bold</FontWeight>
                                  </Style>
                                </TextRun>
                              </TextRuns>
                              <Style>
                                <TextAlign>Left</TextAlign>
                              </Style>
                            </Paragraph>
                          </Paragraphs>
                          <rd:DefaultName>Textbox'+Cast(ROW_NUMBER() OVER(ORDER BY c.column_id ASC) as varchar)+'</rd:DefaultName>
                          <Style>
                            <Border>
                              <Color>LightGrey</Color>
                              <Style>None</Style>
                            </Border>
                            <PaddingLeft>2pt</PaddingLeft>
                            <PaddingRight>2pt</PaddingRight>
                            <PaddingTop>2pt</PaddingTop>
                            <PaddingBottom>2pt</PaddingBottom>
                          </Style>
                        </Textbox>
                      </CellContents>
                    </TablixCell>
					<TablixCell>
                      <CellContents>
                        <Textbox Name="'+c.name+'">
                          <CanGrow>true</CanGrow>
                          <KeepTogether>true</KeepTogether>
                          <Paragraphs>
                            <Paragraph>
                              <TextRuns>
                                <TextRun>
                                  <Value>=Fields!'+c.name+'.Value</Value>
                                  '+case 
									when c.user_type_id in (40,61) then '<Style><Format>d</Format></Style>' 
									when c.user_type_id in (106,60) then '<Style><Format>#,##0.##</Format></Style>' 
									else '<Style />'
								end +' 
                                </TextRun>
                              </TextRuns>
                              <Style>
                                <TextAlign>Left</TextAlign>
                              </Style>
                            </Paragraph>
                          </Paragraphs>
                          <rd:DefaultName>'+c.name+'</rd:DefaultName>
                          <Style>
                            <Border>
                              <Color>LightGrey</Color>
                              <Style>None</Style>
                            </Border>
                            <PaddingLeft>2pt</PaddingLeft>
                            <PaddingRight>2pt</PaddingRight>
                            <PaddingTop>2pt</PaddingTop>
                            <PaddingBottom>2pt</PaddingBottom>
                          </Style>
                        </Textbox>
                      </CellContents>
                    </TablixCell>
					
                  </TablixCells>
                </TablixRow>' + @Salto as TablixRow,
		'<TablixMember />' + @Salto as TablixMember

from sys.columns as c
	inner join sys.types as ty on c.user_type_id = ty.user_type_id
	inner join sys.tables as t on c.object_id = t.object_id
where t.name = 'A'

--select 
--	'<xs:element name="' + c.name + '" msprop:Generator_ColumnVarNameInTable="column' + c.name + '" msprop:Generator_ColumnPropNameInRow="' + c.name + '" msprop:Generator_ColumnPropNameInTable="' + c.name + 'Column" msprop:Generator_UserColumnName="' + c.name + '" type="xs:'+case 
--								when c.user_type_id in (40,61) then 'dateTime' 
--								when c.user_type_id in (106,60) then 'decimal' 
--								else 'string'
--						  end +'" minOccurs="0" />' as EsquemaXSD
--from sys.columns as c
--	inner join sys.types as ty on c.user_type_id = ty.user_type_id
--	inner join sys.tables as t on c.object_id = t.object_id
--where t.name = 'A'

	set @Tablix = REPLACE(@Tablix, '{Cells}', @Cells)
	set @Tablix = REPLACE(@Tablix, '{FilasMember}', @Member)

--Select 
--		'<xs:element name="'+@TablaReporte+'" msprop:Generator_TableClassName="'+@TablaReporte+'DataTable" msprop:Generator_TableVarName="table'+@TablaReporte+'" msprop:Generator_TablePropName="'+@TablaReporte+'" msprop:Generator_RowDeletingName="'+@TablaReporte+'RowDeleting" msprop:Generator_RowChangingName="'+@TablaReporte+'RowChanging" msprop:Generator_RowEvHandlerName="'+@TablaReporte+'RowChangeEventHandler" msprop:Generator_RowDeletedName="'+@TablaReporte+'RowDeleted" msprop:Generator_UserTableName="'+@TablaReporte+'" msprop:Generator_RowChangedName="'+@TablaReporte+'RowChanged" msprop:Generator_RowEvArgName="'+@TablaReporte+'RowChangeEvent" msprop:Generator_RowClassName="'+@TablaReporte+'Row">' as EsquemaXSD


Drop Table A