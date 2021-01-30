<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Dim RutLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim Apellido_PaternoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Apellido_MaternoLabel As System.Windows.Forms.Label
        Dim lblSExo As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNaci = New System.Windows.Forms.Label()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PtbImagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGTablaUsuarios = New System.Windows.Forms.DataGridView()
        RutLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        Apellido_PaternoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Apellido_MaternoLabel = New System.Windows.Forms.Label()
        lblSExo = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGTablaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RutLabel
        '
        RutLabel.AutoSize = True
        RutLabel.Location = New System.Drawing.Point(63, 35)
        RutLabel.Name = "RutLabel"
        RutLabel.Size = New System.Drawing.Size(58, 26)
        RutLabel.TabIndex = 18
        RutLabel.Text = "Rut:"
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
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(544, 260)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(98, 26)
        CelularLabel.TabIndex = 28
        CelularLabel.Text = "Celular:"
        '
        'Apellido_PaternoLabel
        '
        Apellido_PaternoLabel.AutoSize = True
        Apellido_PaternoLabel.Location = New System.Drawing.Point(6, 252)
        Apellido_PaternoLabel.Name = "Apellido_PaternoLabel"
        Apellido_PaternoLabel.Size = New System.Drawing.Size(195, 26)
        Apellido_PaternoLabel.TabIndex = 22
        Apellido_PaternoLabel.Text = "Apellido Paterno:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(522, 30)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(81, 26)
        EmailLabel.TabIndex = 26
        EmailLabel.Text = "Email:"
        '
        'Apellido_MaternoLabel
        '
        Apellido_MaternoLabel.AutoSize = True
        Apellido_MaternoLabel.Location = New System.Drawing.Point(263, 30)
        Apellido_MaternoLabel.Name = "Apellido_MaternoLabel"
        Apellido_MaternoLabel.Size = New System.Drawing.Size(203, 26)
        Apellido_MaternoLabel.TabIndex = 24
        Apellido_MaternoLabel.Text = "Apellido Materno:"
        '
        'lblSExo
        '
        lblSExo.AutoSize = True
        lblSExo.Location = New System.Drawing.Point(267, 252)
        lblSExo.Name = "lblSExo"
        lblSExo.Size = New System.Drawing.Size(68, 26)
        lblSExo.TabIndex = 33
        lblSExo.Text = "Sexo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(544, 143)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(120, 26)
        Label1.TabIndex = 35
        Label1.Text = "Dirección:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.txtSexo)
        Me.GroupBox2.Controls.Add(lblSExo)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.lblFechaNaci)
        Me.GroupBox2.Controls.Add(Me.btnImagen)
        Me.GroupBox2.Controls.Add(RutLabel)
        Me.GroupBox2.Controls.Add(Me.txtCelular)
        Me.GroupBox2.Controls.Add(NombresLabel)
        Me.GroupBox2.Controls.Add(CelularLabel)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Apellido_PaternoLabel)
        Me.GroupBox2.Controls.Add(EmailLabel)
        Me.GroupBox2.Controls.Add(Me.txtApellidoPaterno)
        Me.GroupBox2.Controls.Add(Me.txtApellidoMaterno)
        Me.GroupBox2.Controls.Add(Apellido_MaternoLabel)
        Me.GroupBox2.Controls.Add(Me.txtRut)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PtbImagen)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1040, 391)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(514, 195)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(177, 34)
        Me.txtDireccion.TabIndex = 36
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(267, 307)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(178, 34)
        Me.txtSexo.TabIndex = 34
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(267, 191)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(177, 34)
        Me.DtpFecha.TabIndex = 32
        '
        'lblFechaNaci
        '
        Me.lblFechaNaci.AutoSize = True
        Me.lblFechaNaci.Location = New System.Drawing.Point(263, 143)
        Me.lblFechaNaci.Name = "lblFechaNaci"
        Me.lblFechaNaci.Size = New System.Drawing.Size(205, 26)
        Me.lblFechaNaci.TabIndex = 31
        Me.lblFechaNaci.Text = "Fecha Nacimiento:"
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(735, 300)
        Me.btnImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(264, 44)
        Me.btnImagen.TabIndex = 30
        Me.btnImagen.Text = "Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(514, 307)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(177, 34)
        Me.txtCelular.TabIndex = 29
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(25, 191)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(171, 34)
        Me.txtNombre.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(514, 68)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 34)
        Me.txtEmail.TabIndex = 27
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
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(25, 68)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(171, 34)
        Me.txtRut.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(822, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Imagen"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Location = New System.Drawing.Point(1115, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(220, 391)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.generallyremove_engeneral_13084
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(25, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(178, 43)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.DocumentEdit_40924
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 35)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(178, 46)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.del
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(25, 252)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(178, 52)
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
        Me.BtnAgregar.Size = New System.Drawing.Size(178, 50)
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
        Me.BtnModificar.Size = New System.Drawing.Size(178, 47)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGTablaUsuarios)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 446)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1040, 261)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabla de usuarios"
        '
        'DGTablaUsuarios
        '
        Me.DGTablaUsuarios.AllowUserToAddRows = False
        Me.DGTablaUsuarios.AllowUserToDeleteRows = False
        Me.DGTablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGTablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGTablaUsuarios.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGTablaUsuarios.CausesValidation = False
        Me.DGTablaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTablaUsuarios.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DGTablaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTablaUsuarios.Location = New System.Drawing.Point(4, 36)
        Me.DGTablaUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTablaUsuarios.Name = "DGTablaUsuarios"
        Me.DGTablaUsuarios.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTablaUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTablaUsuarios.Size = New System.Drawing.Size(1032, 221)
        Me.DGTablaUsuarios.TabIndex = 0
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1348, 718)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "GestionUsuarios"
        Me.Text = "Gestion Usuarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGTablaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNaci As System.Windows.Forms.Label
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PtbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
