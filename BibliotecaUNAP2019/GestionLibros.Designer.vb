<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionLibros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim lblCodigoCategorias As System.Windows.Forms.Label
        Dim lblIsbn As System.Windows.Forms.Label
        Dim lblTitulo As System.Windows.Forms.Label
        Dim lblFechaEdicion As System.Windows.Forms.Label
        Dim lblCodigoEditorial As System.Windows.Forms.Label
        Dim lblDescripcion As System.Windows.Forms.Label
        Dim lblNumeroPagina As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLibros))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumeroPaginas = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtCodigoCategorias = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.lblCodigoAutor = New System.Windows.Forms.Label()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txCodigoEditorial = New System.Windows.Forms.TextBox()
        Me.txtCodigoAutor = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PtbImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGTablaLibros = New System.Windows.Forms.DataGridView()
        lblCodigoCategorias = New System.Windows.Forms.Label()
        lblIsbn = New System.Windows.Forms.Label()
        lblTitulo = New System.Windows.Forms.Label()
        lblFechaEdicion = New System.Windows.Forms.Label()
        lblCodigoEditorial = New System.Windows.Forms.Label()
        lblDescripcion = New System.Windows.Forms.Label()
        lblNumeroPagina = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGTablaLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigoCategorias
        '
        lblCodigoCategorias.AutoSize = True
        lblCodigoCategorias.Location = New System.Drawing.Point(712, 35)
        lblCodigoCategorias.Name = "lblCodigoCategorias"
        lblCodigoCategorias.Size = New System.Drawing.Size(202, 26)
        lblCodigoCategorias.TabIndex = 33
        lblCodigoCategorias.Text = "Código Categorias"
        '
        'lblIsbn
        '
        lblIsbn.AutoSize = True
        lblIsbn.Location = New System.Drawing.Point(33, 35)
        lblIsbn.Name = "lblIsbn"
        lblIsbn.Size = New System.Drawing.Size(75, 26)
        lblIsbn.TabIndex = 18
        lblIsbn.Text = "ISBN:"
        '
        'lblTitulo
        '
        lblTitulo.AutoSize = True
        lblTitulo.Location = New System.Drawing.Point(29, 143)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(74, 26)
        lblTitulo.TabIndex = 20
        lblTitulo.Text = "Título"
        '
        'lblFechaEdicion
        '
        lblFechaEdicion.AutoSize = True
        lblFechaEdicion.Location = New System.Drawing.Point(255, 35)
        lblFechaEdicion.Name = "lblFechaEdicion"
        lblFechaEdicion.Size = New System.Drawing.Size(159, 26)
        lblFechaEdicion.TabIndex = 22
        lblFechaEdicion.Text = "Fecha Edición"
        '
        'lblCodigoEditorial
        '
        lblCodigoEditorial.AutoSize = True
        lblCodigoEditorial.Location = New System.Drawing.Point(730, 143)
        lblCodigoEditorial.Name = "lblCodigoEditorial"
        lblCodigoEditorial.Size = New System.Drawing.Size(184, 26)
        lblCodigoEditorial.TabIndex = 26
        lblCodigoEditorial.Text = "Código Editorial"
        '
        'lblDescripcion
        '
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New System.Drawing.Point(482, 35)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New System.Drawing.Size(134, 26)
        lblDescripcion.TabIndex = 24
        lblDescripcion.Text = "Descripción"
        '
        'lblNumeroPagina
        '
        lblNumeroPagina.AutoSize = True
        lblNumeroPagina.Location = New System.Drawing.Point(255, 143)
        lblNumeroPagina.Name = "lblNumeroPagina"
        lblNumeroPagina.Size = New System.Drawing.Size(181, 26)
        lblNumeroPagina.TabIndex = 36
        lblNumeroPagina.Text = "Número Páginas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lime
        Me.GroupBox2.Controls.Add(lblNumeroPagina)
        Me.GroupBox2.Controls.Add(Me.txtNumeroPaginas)
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.txtCodigoCategorias)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(lblCodigoCategorias)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.lblCodigoAutor)
        Me.GroupBox2.Controls.Add(Me.btnImagen)
        Me.GroupBox2.Controls.Add(lblIsbn)
        Me.GroupBox2.Controls.Add(lblTitulo)
        Me.GroupBox2.Controls.Add(Me.txtTitulo)
        Me.GroupBox2.Controls.Add(Me.txCodigoEditorial)
        Me.GroupBox2.Controls.Add(lblFechaEdicion)
        Me.GroupBox2.Controls.Add(lblCodigoEditorial)
        Me.GroupBox2.Controls.Add(Me.txtCodigoAutor)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(lblDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtIsbn)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PtbImagen)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(132, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1294, 431)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'txtNumeroPaginas
        '
        Me.txtNumeroPaginas.Location = New System.Drawing.Point(260, 191)
        Me.txtNumeroPaginas.Name = "txtNumeroPaginas"
        Me.txtNumeroPaginas.Size = New System.Drawing.Size(173, 34)
        Me.txtNumeroPaginas.TabIndex = 35
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.new_file_40454
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 306)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(135, 47)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.cancel_stop_exit_1583
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(826, 308)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(172, 43)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.diskette_save_saveas_1514
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(197, 307)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(159, 46)
        Me.BtnAgregar.TabIndex = 26
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtCodigoCategorias
        '
        Me.txtCodigoCategorias.Location = New System.Drawing.Point(734, 81)
        Me.txtCodigoCategorias.Name = "txtCodigoCategorias"
        Me.txtCodigoCategorias.Size = New System.Drawing.Size(178, 34)
        Me.txtCodigoCategorias.TabIndex = 34
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(616, 309)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(172, 43)
        Me.BtnEliminar.TabIndex = 28
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(254, 77)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(177, 34)
        Me.DtpFecha.TabIndex = 32
        '
        'BtnModificar
        '
        Me.BtnModificar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.DocumentEdit_40924
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(392, 308)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(184, 45)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'lblCodigoAutor
        '
        Me.lblCodigoAutor.AutoSize = True
        Me.lblCodigoAutor.Location = New System.Drawing.Point(482, 143)
        Me.lblCodigoAutor.Name = "lblCodigoAutor"
        Me.lblCodigoAutor.Size = New System.Drawing.Size(151, 26)
        Me.lblCodigoAutor.TabIndex = 31
        Me.lblCodigoAutor.Text = "Código Autor"
        '
        'btnImagen
        '
        Me.btnImagen.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.IMAGE
        Me.btnImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImagen.Location = New System.Drawing.Point(1014, 307)
        Me.btnImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(264, 44)
        Me.btnImagen.TabIndex = 30
        Me.btnImagen.Text = "Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(25, 191)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(171, 34)
        Me.txtTitulo.TabIndex = 21
        '
        'txCodigoEditorial
        '
        Me.txCodigoEditorial.Location = New System.Drawing.Point(735, 191)
        Me.txCodigoEditorial.Name = "txCodigoEditorial"
        Me.txCodigoEditorial.Size = New System.Drawing.Size(177, 34)
        Me.txCodigoEditorial.TabIndex = 27
        '
        'txtCodigoAutor
        '
        Me.txtCodigoAutor.Location = New System.Drawing.Point(487, 191)
        Me.txtCodigoAutor.Name = "txtCodigoAutor"
        Me.txtCodigoAutor.Size = New System.Drawing.Size(173, 34)
        Me.txtCodigoAutor.TabIndex = 23
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(487, 77)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(173, 34)
        Me.txtDescripcion.TabIndex = 25
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(25, 77)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(171, 34)
        Me.txtIsbn.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1076, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Imagen"
        '
        'PtbImagen
        '
        Me.PtbImagen.Image = CType(resources.GetObject("PtbImagen.Image"), System.Drawing.Image)
        Me.PtbImagen.Location = New System.Drawing.Point(1014, 68)
        Me.PtbImagen.Name = "PtbImagen"
        Me.PtbImagen.Size = New System.Drawing.Size(264, 218)
        Me.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbImagen.TabIndex = 6
        Me.PtbImagen.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGTablaLibros)
        Me.GroupBox3.Location = New System.Drawing.Point(132, 525)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1294, 261)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabla de Autores"
        '
        'DGTablaLibros
        '
        Me.DGTablaLibros.AllowUserToAddRows = False
        Me.DGTablaLibros.AllowUserToDeleteRows = False
        Me.DGTablaLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGTablaLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGTablaLibros.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGTablaLibros.CausesValidation = False
        Me.DGTablaLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGTablaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTablaLibros.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DGTablaLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTablaLibros.Location = New System.Drawing.Point(4, 36)
        Me.DGTablaLibros.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTablaLibros.Name = "DGTablaLibros"
        Me.DGTablaLibros.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTablaLibros.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTablaLibros.Size = New System.Drawing.Size(1286, 221)
        Me.DGTablaLibros.TabIndex = 0
        '
        'GestionLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1551, 811)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "GestionLibros"
        Me.Text = "GestionLibros"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGTablaLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigoCategorias As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCodigoAutor As System.Windows.Forms.Label
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txCodigoEditorial As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PtbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaLibros As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents txtNumeroPaginas As System.Windows.Forms.TextBox
End Class
