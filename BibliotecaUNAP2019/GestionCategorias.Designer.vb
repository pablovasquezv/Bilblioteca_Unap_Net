<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCategorias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionCategorias))
        Me.grboxIngreseDatos = New System.Windows.Forms.GroupBox()
        Me.btnImagenCategorias = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigoCategorias = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.CodigoCategorias = New System.Windows.Forms.Label()
        Me.grboxCategorias = New System.Windows.Forms.GroupBox()
        Me.DGTablaCategorias = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.PtbImagen = New System.Windows.Forms.PictureBox()
        Me.grboxIngreseDatos.SuspendLayout()
        Me.grboxCategorias.SuspendLayout()
        CType(Me.DGTablaCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grboxIngreseDatos
        '
        Me.grboxIngreseDatos.BackColor = System.Drawing.Color.Yellow
        Me.grboxIngreseDatos.Controls.Add(Me.btnImagenCategorias)
        Me.grboxIngreseDatos.Controls.Add(Me.Label5)
        Me.grboxIngreseDatos.Controls.Add(Me.PtbImagen)
        Me.grboxIngreseDatos.Controls.Add(Me.txtDescripcion)
        Me.grboxIngreseDatos.Controls.Add(Me.txtNombre)
        Me.grboxIngreseDatos.Controls.Add(Me.txtCodigoCategorias)
        Me.grboxIngreseDatos.Controls.Add(Me.lblDescripcion)
        Me.grboxIngreseDatos.Controls.Add(Me.lblImagen)
        Me.grboxIngreseDatos.Controls.Add(Me.CodigoCategorias)
        Me.grboxIngreseDatos.Location = New System.Drawing.Point(171, 38)
        Me.grboxIngreseDatos.Name = "grboxIngreseDatos"
        Me.grboxIngreseDatos.Size = New System.Drawing.Size(1065, 349)
        Me.grboxIngreseDatos.TabIndex = 1
        Me.grboxIngreseDatos.TabStop = False
        Me.grboxIngreseDatos.Text = "Ingresar Datos"
        '
        'btnImagenCategorias
        '
        Me.btnImagenCategorias.Location = New System.Drawing.Point(711, 293)
        Me.btnImagenCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImagenCategorias.Name = "btnImagenCategorias"
        Me.btnImagenCategorias.Size = New System.Drawing.Size(264, 44)
        Me.btnImagenCategorias.TabIndex = 33
        Me.btnImagenCategorias.Text = "Imagen"
        Me.btnImagenCategorias.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(790, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Imagen"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(364, 225)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(208, 39)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(364, 141)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 39)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodigoCategorias
        '
        Me.txtCodigoCategorias.Location = New System.Drawing.Point(364, 53)
        Me.txtCodigoCategorias.Name = "txtCodigoCategorias"
        Me.txtCodigoCategorias.Size = New System.Drawing.Size(208, 39)
        Me.txtCodigoCategorias.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(171, 232)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(165, 32)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Location = New System.Drawing.Point(208, 144)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(119, 32)
        Me.lblImagen.TabIndex = 1
        Me.lblImagen.Text = "Nombre:"
        '
        'CodigoCategorias
        '
        Me.CodigoCategorias.AutoSize = True
        Me.CodigoCategorias.Location = New System.Drawing.Point(82, 53)
        Me.CodigoCategorias.Name = "CodigoCategorias"
        Me.CodigoCategorias.Size = New System.Drawing.Size(245, 32)
        Me.CodigoCategorias.TabIndex = 0
        Me.CodigoCategorias.Text = "Código Categorias:"
        '
        'grboxCategorias
        '
        Me.grboxCategorias.Controls.Add(Me.DGTablaCategorias)
        Me.grboxCategorias.Location = New System.Drawing.Point(263, 572)
        Me.grboxCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.grboxCategorias.Name = "grboxCategorias"
        Me.grboxCategorias.Padding = New System.Windows.Forms.Padding(4)
        Me.grboxCategorias.Size = New System.Drawing.Size(770, 261)
        Me.grboxCategorias.TabIndex = 41
        Me.grboxCategorias.TabStop = False
        Me.grboxCategorias.Text = "Tabla de Categorias"
        '
        'DGTablaCategorias
        '
        Me.DGTablaCategorias.AllowUserToAddRows = False
        Me.DGTablaCategorias.AllowUserToDeleteRows = False
        Me.DGTablaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGTablaCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.DGTablaCategorias.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DGTablaCategorias.CausesValidation = False
        Me.DGTablaCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGTablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTablaCategorias.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DGTablaCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTablaCategorias.Location = New System.Drawing.Point(4, 36)
        Me.DGTablaCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTablaCategorias.Name = "DGTablaCategorias"
        Me.DGTablaCategorias.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTablaCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTablaCategorias.Size = New System.Drawing.Size(762, 221)
        Me.DGTablaCategorias.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 417)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1065, 126)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.generallyremove_engeneral_13084
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(843, 35)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(179, 47)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.DocumentEdit_40924
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(27, 37)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(149, 45)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.del
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(632, 37)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(186, 43)
        Me.BtnEliminar.TabIndex = 28
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.new_add_user_16734
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(222, 35)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(169, 46)
        Me.BtnAgregar.TabIndex = 26
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Image = Global.BibliotecaUNAP2019.My.Resources.Resources.diskette_save_saveas_1514
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(414, 37)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(194, 43)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'PtbImagen
        '
        Me.PtbImagen.Image = CType(resources.GetObject("PtbImagen.Image"), System.Drawing.Image)
        Me.PtbImagen.Location = New System.Drawing.Point(711, 53)
        Me.PtbImagen.Name = "PtbImagen"
        Me.PtbImagen.Size = New System.Drawing.Size(264, 218)
        Me.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbImagen.TabIndex = 31
        Me.PtbImagen.TabStop = False
        '
        'GestionCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(1415, 834)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grboxCategorias)
        Me.Controls.Add(Me.grboxIngreseDatos)
        Me.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "GestionCategorias"
        Me.Text = "GestionCategorias"
        Me.grboxIngreseDatos.ResumeLayout(False)
        Me.grboxIngreseDatos.PerformLayout()
        Me.grboxCategorias.ResumeLayout(False)
        CType(Me.DGTablaCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PtbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grboxIngreseDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnImagenCategorias As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PtbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCategorias As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblImagen As System.Windows.Forms.Label
    Friend WithEvents CodigoCategorias As System.Windows.Forms.Label
    Friend WithEvents grboxCategorias As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
End Class
