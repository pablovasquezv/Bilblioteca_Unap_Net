<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionPaises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionPaises))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImagenPais = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PtbImagen = New System.Windows.Forms.PictureBox()
        Me.txtContinente = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigoPais = New System.Windows.Forms.TextBox()
        Me.lblContinente = New System.Windows.Forms.Label()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.CodigoPais = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGTablaPaises = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGTablaPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.btnImagenPais)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PtbImagen)
        Me.GroupBox1.Controls.Add(Me.txtContinente)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCodigoPais)
        Me.GroupBox1.Controls.Add(Me.lblContinente)
        Me.GroupBox1.Controls.Add(Me.lblImagen)
        Me.GroupBox1.Controls.Add(Me.CodigoPais)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 349)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'btnImagenPais
        '
        Me.btnImagenPais.Location = New System.Drawing.Point(494, 291)
        Me.btnImagenPais.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImagenPais.Name = "btnImagenPais"
        Me.btnImagenPais.Size = New System.Drawing.Size(264, 44)
        Me.btnImagenPais.TabIndex = 33
        Me.btnImagenPais.Text = "Imagen"
        Me.btnImagenPais.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(561, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 26)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Imagen"
        '
        'PtbImagen
        '
        Me.PtbImagen.Image = CType(resources.GetObject("PtbImagen.Image"), System.Drawing.Image)
        Me.PtbImagen.Location = New System.Drawing.Point(494, 52)
        Me.PtbImagen.Name = "PtbImagen"
        Me.PtbImagen.Size = New System.Drawing.Size(264, 218)
        Me.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbImagen.TabIndex = 31
        Me.PtbImagen.TabStop = False
        '
        'txtContinente
        '
        Me.txtContinente.Location = New System.Drawing.Point(215, 236)
        Me.txtContinente.Name = "txtContinente"
        Me.txtContinente.Size = New System.Drawing.Size(208, 34)
        Me.txtContinente.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(215, 143)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 34)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodigoPais
        '
        Me.txtCodigoPais.Location = New System.Drawing.Point(215, 52)
        Me.txtCodigoPais.Name = "txtCodigoPais"
        Me.txtCodigoPais.Size = New System.Drawing.Size(208, 34)
        Me.txtCodigoPais.TabIndex = 3
        '
        'lblContinente
        '
        Me.lblContinente.AutoSize = True
        Me.lblContinente.Location = New System.Drawing.Point(59, 239)
        Me.lblContinente.Name = "lblContinente"
        Me.lblContinente.Size = New System.Drawing.Size(133, 26)
        Me.lblContinente.TabIndex = 2
        Me.lblContinente.Text = "Continente:"
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Location = New System.Drawing.Point(89, 151)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(103, 26)
        Me.lblImagen.TabIndex = 1
        Me.lblImagen.Text = "Nombre:"
        '
        'CodigoPais
        '
        Me.CodigoPais.AutoSize = True
        Me.CodigoPais.Location = New System.Drawing.Point(50, 60)
        Me.CodigoPais.Name = "CodigoPais"
        Me.CodigoPais.Size = New System.Drawing.Size(142, 26)
        Me.CodigoPais.TabIndex = 0
        Me.CodigoPais.Text = "Código Pais:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGTablaPaises)
        Me.GroupBox3.Location = New System.Drawing.Point(189, 442)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(770, 261)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabla de Paises"
        '
        'DGTablaPaises
        '
        Me.DGTablaPaises.AllowUserToAddRows = False
        Me.DGTablaPaises.AllowUserToDeleteRows = False
        Me.DGTablaPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGTablaPaises.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.DGTablaPaises.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGTablaPaises.CausesValidation = False
        Me.DGTablaPaises.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGTablaPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTablaPaises.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DGTablaPaises.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTablaPaises.Location = New System.Drawing.Point(4, 31)
        Me.DGTablaPaises.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTablaPaises.Name = "DGTablaPaises"
        Me.DGTablaPaises.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTablaPaises.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTablaPaises.Size = New System.Drawing.Size(762, 226)
        Me.DGTablaPaises.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(1069, 25)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(202, 391)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.generallyremove_engeneral_13084
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(25, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 43)
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
        Me.BtnNuevo.Size = New System.Drawing.Size(152, 46)
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
        Me.BtnEliminar.Size = New System.Drawing.Size(152, 52)
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
        Me.BtnAgregar.Size = New System.Drawing.Size(152, 50)
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
        Me.BtnModificar.Size = New System.Drawing.Size(152, 47)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'GestionPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(1424, 716)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "GestionPaises"
        Me.Text = "GestionPais"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGTablaPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContinente As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPais As System.Windows.Forms.TextBox
    Friend WithEvents lblContinente As System.Windows.Forms.Label
    Friend WithEvents lblImagen As System.Windows.Forms.Label
    Friend WithEvents CodigoPais As System.Windows.Forms.Label
    Friend WithEvents btnImagenPais As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PtbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaPaises As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
End Class
