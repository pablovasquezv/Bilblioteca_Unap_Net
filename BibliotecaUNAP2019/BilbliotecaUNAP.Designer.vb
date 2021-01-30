<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BilbliotecaUNAP
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.opSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMantenedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.opGestionAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.opGestionEditorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.opGestionLibros = New System.Windows.Forms.ToolStripMenuItem()
        Me.opGetsionPais = New System.Windows.Forms.ToolStripMenuItem()
        Me.opGestionUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrestamos = New System.Windows.Forms.ToolStripMenuItem()
        Me.opPrestamosDevoluciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.opAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuMantenedores, Me.mnuPrestamos, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1385, 43)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opSalir})
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(107, 39)
        Me.mnuArchivo.Text = "Ayuda"
        '
        'opSalir
        '
        Me.opSalir.Name = "opSalir"
        Me.opSalir.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.opSalir.Size = New System.Drawing.Size(312, 40)
        Me.opSalir.Text = "Salir"
        '
        'mnuMantenedores
        '
        Me.mnuMantenedores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opGestionAuto, Me.GestiónCategoriasToolStripMenuItem, Me.opGestionEditorial, Me.opGestionLibros, Me.opGetsionPais, Me.opGestionUsuarios})
        Me.mnuMantenedores.Name = "mnuMantenedores"
        Me.mnuMantenedores.Size = New System.Drawing.Size(181, 39)
        Me.mnuMantenedores.Text = "Mantenedor"
        '
        'opGestionAuto
        '
        Me.opGestionAuto.Name = "opGestionAuto"
        Me.opGestionAuto.Size = New System.Drawing.Size(340, 40)
        Me.opGestionAuto.Text = "Gestión Autores"
        '
        'GestiónCategoriasToolStripMenuItem
        '
        Me.GestiónCategoriasToolStripMenuItem.Name = "GestiónCategoriasToolStripMenuItem"
        Me.GestiónCategoriasToolStripMenuItem.Size = New System.Drawing.Size(340, 40)
        Me.GestiónCategoriasToolStripMenuItem.Text = "Gestión Categorias"
        '
        'opGestionEditorial
        '
        Me.opGestionEditorial.Name = "opGestionEditorial"
        Me.opGestionEditorial.Size = New System.Drawing.Size(340, 40)
        Me.opGestionEditorial.Text = "Gestion Editoriales"
        '
        'opGestionLibros
        '
        Me.opGestionLibros.Name = "opGestionLibros"
        Me.opGestionLibros.Size = New System.Drawing.Size(340, 40)
        Me.opGestionLibros.Text = "Gestión Libros"
        '
        'opGetsionPais
        '
        Me.opGetsionPais.Name = "opGetsionPais"
        Me.opGetsionPais.Size = New System.Drawing.Size(340, 40)
        Me.opGetsionPais.Text = "Gestión Paises"
        '
        'opGestionUsuarios
        '
        Me.opGestionUsuarios.Name = "opGestionUsuarios"
        Me.opGestionUsuarios.Size = New System.Drawing.Size(340, 40)
        Me.opGestionUsuarios.Text = "Gestión Usuarios"
        '
        'mnuPrestamos
        '
        Me.mnuPrestamos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opPrestamosDevoluciones})
        Me.mnuPrestamos.Name = "mnuPrestamos"
        Me.mnuPrestamos.Size = New System.Drawing.Size(157, 39)
        Me.mnuPrestamos.Text = "Prestamos"
        '
        'opPrestamosDevoluciones
        '
        Me.opPrestamosDevoluciones.Name = "opPrestamosDevoluciones"
        Me.opPrestamosDevoluciones.Size = New System.Drawing.Size(423, 40)
        Me.opPrestamosDevoluciones.Text = "Prestamos y Devoluciones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opAcercaDe})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(107, 39)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'opAcercaDe
        '
        Me.opAcercaDe.Name = "opAcercaDe"
        Me.opAcercaDe.Size = New System.Drawing.Size(230, 40)
        Me.opAcercaDe.Text = "Acerca De"
        '
        'BilbliotecaUNAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(26.0!, 49.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BibliotecaUNAP2019.My.Resources.Resources.DSC_07051
        Me.ClientSize = New System.Drawing.Size(1385, 712)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.Name = "BilbliotecaUNAP"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMantenedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opGestionUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrestamos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opGestionAuto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opGestionEditorial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opGestionLibros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opGetsionPais As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opPrestamosDevoluciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opAcercaDe As System.Windows.Forms.ToolStripMenuItem

End Class
