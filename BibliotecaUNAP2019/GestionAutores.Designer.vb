<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionAutores
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
        Dim lblSExo As System.Windows.Forms.Label
        Dim lblCodigoAutor As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim lblApellido_Paterno As System.Windows.Forms.Label
        Dim lblCodigoPais As System.Windows.Forms.Label
        Dim lblApellido_Materno As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionAutores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCodigoPais = New System.Windows.Forms.ComboBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNaci = New System.Windows.Forms.Label()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigoPais = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtCodigoAutor = New System.Windows.Forms.TextBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.PtbImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGTablaAutores = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        lblSExo = New System.Windows.Forms.Label()
        lblCodigoAutor = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        lblApellido_Paterno = New System.Windows.Forms.Label()
        lblCodigoPais = New System.Windows.Forms.Label()
        lblApellido_Materno = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGTablaAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSExo
        '
        lblSExo.AutoSize = True
        lblSExo.Location = New System.Drawing.Point(267, 143)
        lblSExo.Name = "lblSExo"
        lblSExo.Size = New System.Drawing.Size(68, 26)
        lblSExo.TabIndex = 33
        lblSExo.Text = "Sexo:"
        '
        'lblCodigoAutor
        '
        lblCodigoAutor.AutoSize = True
        lblCodigoAutor.Location = New System.Drawing.Point(29, 30)
        lblCodigoAutor.Name = "lblCodigoAutor"
        lblCodigoAutor.Size = New System.Drawing.Size(159, 26)
        lblCodigoAutor.TabIndex = 18
        lblCodigoAutor.Text = "Código Autor:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(29, 143)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(103, 26)
        NombresLabel.TabIndex = 20
        NombresLabel.Text = "Nombre:"
        '
        'lblApellido_Paterno
        '
        lblApellido_Paterno.AutoSize = True
        lblApellido_Paterno.Location = New System.Drawing.Point(6, 252)
        lblApellido_Paterno.Name = "lblApellido_Paterno"
        lblApellido_Paterno.Size = New System.Drawing.Size(195, 26)
        lblApellido_Paterno.TabIndex = 22
        lblApellido_Paterno.Text = "Apellido Paterno:"
        '
        'lblCodigoPais
        '
        lblCodigoPais.AutoSize = True
        lblCodigoPais.Location = New System.Drawing.Point(522, 30)
        lblCodigoPais.Name = "lblCodigoPais"
        lblCodigoPais.Size = New System.Drawing.Size(142, 26)
        lblCodigoPais.TabIndex = 26
        lblCodigoPais.Text = "Codigo Pais:"
        '
        'lblApellido_Materno
        '
        lblApellido_Materno.AutoSize = True
        lblApellido_Materno.Location = New System.Drawing.Point(263, 30)
        lblApellido_Materno.Name = "lblApellido_Materno"
        lblApellido_Materno.Size = New System.Drawing.Size(203, 26)
        lblApellido_Materno.TabIndex = 24
        lblApellido_Materno.Text = "Apellido Materno:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox2.Controls.Add(Me.cboCodigoPais)
        Me.GroupBox2.Controls.Add(Me.txtSexo)
        Me.GroupBox2.Controls.Add(lblSExo)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.lblFechaNaci)
        Me.GroupBox2.Controls.Add(Me.btnImagen)
        Me.GroupBox2.Controls.Add(lblCodigoAutor)
        Me.GroupBox2.Controls.Add(NombresLabel)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtCodigoPais)
        Me.GroupBox2.Controls.Add(lblApellido_Paterno)
        Me.GroupBox2.Controls.Add(lblCodigoPais)
        Me.GroupBox2.Controls.Add(Me.txtApellidoPaterno)
        Me.GroupBox2.Controls.Add(Me.txtApellidoMaterno)
        Me.GroupBox2.Controls.Add(lblApellido_Materno)
        Me.GroupBox2.Controls.Add(Me.txtCodigoAutor)
        Me.GroupBox2.Controls.Add(Me.lblImagen)
        Me.GroupBox2.Controls.Add(Me.PtbImagen)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(44, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1040, 391)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'cboCodigoPais
        '
        Me.cboCodigoPais.FormattingEnabled = True
        Me.cboCodigoPais.Location = New System.Drawing.Point(579, 144)
        Me.cboCodigoPais.Name = "cboCodigoPais"
        Me.cboCodigoPais.Size = New System.Drawing.Size(121, 33)
        Me.cboCodigoPais.TabIndex = 35
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(272, 191)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(178, 34)
        Me.txtSexo.TabIndex = 34
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(266, 303)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(177, 34)
        Me.DtpFecha.TabIndex = 32
        '
        'lblFechaNaci
        '
        Me.lblFechaNaci.AutoSize = True
        Me.lblFechaNaci.Location = New System.Drawing.Point(261, 252)
        Me.lblFechaNaci.Name = "lblFechaNaci"
        Me.lblFechaNaci.Size = New System.Drawing.Size(205, 26)
        Me.lblFechaNaci.TabIndex = 31
        Me.lblFechaNaci.Text = "Fecha Nacimiento:"
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(735, 303)
        Me.btnImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(264, 44)
        Me.btnImagen.TabIndex = 30
        Me.btnImagen.Text = "Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(25, 191)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(171, 34)
        Me.txtNombre.TabIndex = 21
        '
        'txtCodigoPais
        '
        Me.txtCodigoPais.Location = New System.Drawing.Point(514, 68)
        Me.txtCodigoPais.Name = "txtCodigoPais"
        Me.txtCodigoPais.Size = New System.Drawing.Size(177, 34)
        Me.txtCodigoPais.TabIndex = 27
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(25, 300)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(173, 34)
        Me.txtApellidoPaterno.TabIndex = 23
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(272, 68)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(173, 34)
        Me.txtApellidoMaterno.TabIndex = 25
        '
        'txtCodigoAutor
        '
        Me.txtCodigoAutor.Location = New System.Drawing.Point(25, 68)
        Me.txtCodigoAutor.Name = "txtCodigoAutor"
        Me.txtCodigoAutor.Size = New System.Drawing.Size(171, 34)
        Me.txtCodigoAutor.TabIndex = 19
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Location = New System.Drawing.Point(822, 30)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(88, 26)
        Me.lblImagen.TabIndex = 7
        Me.lblImagen.Text = "Imagen"
        '
        'PtbImagen
        '
        Me.PtbImagen.Image = CType(resources.GetObject("PtbImagen.Image"), System.Drawing.Image)
        Me.PtbImagen.Location = New System.Drawing.Point(735, 68)
        Me.PtbImagen.Name = "PtbImagen"
        Me.PtbImagen.Size = New System.Drawing.Size(264, 218)
        Me.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbImagen.TabIndex = 6
        Me.PtbImagen.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGTablaAutores)
        Me.GroupBox3.Location = New System.Drawing.Point(44, 491)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1040, 261)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabla de Autores"
        '
        'DGTablaAutores
        '
        Me.DGTablaAutores.AllowUserToAddRows = False
        Me.DGTablaAutores.AllowUserToDeleteRows = False
        Me.DGTablaAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGTablaAutores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGTablaAutores.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGTablaAutores.CausesValidation = False
        Me.DGTablaAutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGTablaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTablaAutores.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DGTablaAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTablaAutores.Location = New System.Drawing.Point(4, 31)
        Me.DGTablaAutores.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTablaAutores.Name = "DGTablaAutores"
        Me.DGTablaAutores.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTablaAutores.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTablaAutores.Size = New System.Drawing.Size(1032, 226)
        Me.DGTablaAutores.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Location = New System.Drawing.Point(1215, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(221, 391)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.cancel_stop_exit_1583
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(25, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(172, 43)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.DocumentEdit_40924
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 35)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(161, 46)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.del
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(25, 252)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(172, 52)
        Me.BtnEliminar.TabIndex = 28
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.new_add_user_16734
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(25, 105)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(161, 50)
        Me.BtnAgregar.TabIndex = 26
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.diskette_save_saveas_1514
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(25, 178)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(172, 47)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'GestionAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(1552, 839)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "GestionAutores"
        Me.Text = "GestionAutor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGTablaAutores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNaci As System.Windows.Forms.Label
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPais As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoAutor As System.Windows.Forms.TextBox
    Friend WithEvents lblImagen As System.Windows.Forms.Label
    Friend WithEvents PtbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaAutores As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents cboCodigoPais As System.Windows.Forms.ComboBox
End Class
