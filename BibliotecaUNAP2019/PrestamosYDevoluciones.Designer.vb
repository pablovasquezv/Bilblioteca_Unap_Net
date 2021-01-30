<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrestamosYDevoluciones
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
        Dim lblRutUsuario As System.Windows.Forms.Label
        Dim lblCodigoPrestamo As System.Windows.Forms.Label
        Dim lblIsbn As System.Windows.Forms.Label
        Dim lblFechaEdicion As System.Windows.Forms.Label
        Dim lblDescripcion As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrestamosYDevoluciones))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRutUsuarios = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.txtNumeroDias = New System.Windows.Forms.TextBox()
        Me.txtCodigoPrestamo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PtbImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGTablaPrestamos = New System.Windows.Forms.DataGridView()
        lblRutUsuario = New System.Windows.Forms.Label()
        lblCodigoPrestamo = New System.Windows.Forms.Label()
        lblIsbn = New System.Windows.Forms.Label()
        lblFechaEdicion = New System.Windows.Forms.Label()
        lblDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGTablaPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRutUsuario
        '
        lblRutUsuario.AutoSize = True
        lblRutUsuario.Location = New System.Drawing.Point(277, 35)
        lblRutUsuario.Name = "lblRutUsuario"
        lblRutUsuario.Size = New System.Drawing.Size(137, 26)
        lblRutUsuario.TabIndex = 36
        lblRutUsuario.Text = "Rut Usuario"
        '
        'lblCodigoPrestamo
        '
        lblCodigoPrestamo.AutoSize = True
        lblCodigoPrestamo.Location = New System.Drawing.Point(33, 35)
        lblCodigoPrestamo.Name = "lblCodigoPrestamo"
        lblCodigoPrestamo.Size = New System.Drawing.Size(197, 26)
        lblCodigoPrestamo.TabIndex = 18
        lblCodigoPrestamo.Text = "Código Prestamos"
        '
        'lblIsbn
        '
        lblIsbn.AutoSize = True
        lblIsbn.Location = New System.Drawing.Point(29, 143)
        lblIsbn.Name = "lblIsbn"
        lblIsbn.Size = New System.Drawing.Size(67, 26)
        lblIsbn.TabIndex = 20
        lblIsbn.Text = "ISBN"
        '
        'lblFechaEdicion
        '
        lblFechaEdicion.AutoSize = True
        lblFechaEdicion.Location = New System.Drawing.Point(255, 143)
        lblFechaEdicion.Name = "lblFechaEdicion"
        lblFechaEdicion.Size = New System.Drawing.Size(159, 26)
        lblFechaEdicion.TabIndex = 22
        lblFechaEdicion.Text = "Fecha Edición"
        '
        'lblDescripcion
        '
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New System.Drawing.Point(482, 35)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New System.Drawing.Size(146, 26)
        lblDescripcion.TabIndex = 24
        lblDescripcion.Text = "Número Dias"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lime
        Me.GroupBox2.Controls.Add(lblRutUsuario)
        Me.GroupBox2.Controls.Add(Me.txtRutUsuarios)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnImagen)
        Me.GroupBox2.Controls.Add(lblCodigoPrestamo)
        Me.GroupBox2.Controls.Add(lblIsbn)
        Me.GroupBox2.Controls.Add(Me.txtIsbn)
        Me.GroupBox2.Controls.Add(lblFechaEdicion)
        Me.GroupBox2.Controls.Add(Me.txtNumeroDias)
        Me.GroupBox2.Controls.Add(lblDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtCodigoPrestamo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PtbImagen)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1064, 431)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'txtRutUsuarios
        '
        Me.txtRutUsuarios.Location = New System.Drawing.Point(260, 77)
        Me.txtRutUsuarios.Name = "txtRutUsuarios"
        Me.txtRutUsuarios.Size = New System.Drawing.Size(177, 34)
        Me.txtRutUsuarios.TabIndex = 35
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.new_file_40454
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(25, 306)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(135, 47)
        Me.btnNuevo.TabIndex = 25
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
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
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.diskette_save_saveas_1514
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(197, 307)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(159, 46)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(616, 309)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(172, 43)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(260, 187)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(177, 34)
        Me.DtpFecha.TabIndex = 32
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.DocumentEdit_40924
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(392, 308)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(184, 45)
        Me.btnModificar.TabIndex = 27
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.IMAGE
        Me.btnImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImagen.Location = New System.Drawing.Point(496, 177)
        Me.btnImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(164, 44)
        Me.btnImagen.TabIndex = 30
        Me.btnImagen.Text = "Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(25, 191)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(171, 34)
        Me.txtIsbn.TabIndex = 21
        '
        'txtNumeroDias
        '
        Me.txtNumeroDias.Location = New System.Drawing.Point(487, 77)
        Me.txtNumeroDias.Name = "txtNumeroDias"
        Me.txtNumeroDias.Size = New System.Drawing.Size(173, 34)
        Me.txtNumeroDias.TabIndex = 25
        '
        'txtCodigoPrestamo
        '
        Me.txtCodigoPrestamo.Location = New System.Drawing.Point(25, 77)
        Me.txtCodigoPrestamo.Name = "txtCodigoPrestamo"
        Me.txtCodigoPrestamo.Size = New System.Drawing.Size(171, 34)
        Me.txtCodigoPrestamo.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(858, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Imagen"
        '
        'PtbImagen
        '
        Me.PtbImagen.Image = CType(resources.GetObject("PtbImagen.Image"), System.Drawing.Image)
        Me.PtbImagen.Location = New System.Drawing.Point(734, 67)
        Me.PtbImagen.Name = "PtbImagen"
        Me.PtbImagen.Size = New System.Drawing.Size(264, 218)
        Me.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbImagen.TabIndex = 6
        Me.PtbImagen.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGTablaPrestamos)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 505)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1065, 261)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabla de Autores"
        '
        'DGTablaPrestamos
        '
        Me.DGTablaPrestamos.AllowUserToAddRows = False
        Me.DGTablaPrestamos.AllowUserToDeleteRows = False
        Me.DGTablaPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGTablaPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGTablaPrestamos.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGTablaPrestamos.CausesValidation = False
        Me.DGTablaPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGTablaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTablaPrestamos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DGTablaPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTablaPrestamos.Location = New System.Drawing.Point(4, 24)
        Me.DGTablaPrestamos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTablaPrestamos.Name = "DGTablaPrestamos"
        Me.DGTablaPrestamos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTablaPrestamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGTablaPrestamos.Size = New System.Drawing.Size(1057, 233)
        Me.DGTablaPrestamos.TabIndex = 0
        '
        'PrestamosYDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1156, 779)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrestamosYDevoluciones"
        Me.Text = "PrestamosYDevoluciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGTablaPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRutUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroDias As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PtbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaPrestamos As System.Windows.Forms.DataGridView
End Class
