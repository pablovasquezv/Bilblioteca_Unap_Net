Public Class BilbliotecaUNAP
    'Opcion Salir'
    Private Sub opSalir_Click(sender As Object, e As EventArgs) Handles opSalir.Click
        Dim Respuesta As DialogResult
        Respuesta = MessageBox.Show("Desea Salir De la Aplicacion", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Respuesta = System.Windows.Forms.DialogResult.Yes Then
            End
        End If
        MsgBox("Salir")
    End Sub

    'Opción Gestión Autores'
    Private Sub opGestionAuto_Click(sender As Object, e As EventArgs) Handles opGestionAuto.Click
        Dim frm As New GestionAutores
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Opción Gestion Categorias'
    Private Sub GestiónCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónCategoriasToolStripMenuItem.Click
        Dim frm As New GestionCategorias
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Opción Gestión Editoriales'
    Private Sub opGestionEditorial_Click(sender As Object, e As EventArgs) Handles opGestionEditorial.Click
        Dim frm As New GestionEditoriales
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Opción Gestion Libros'
    Private Sub opGestionLibros_Click(sender As Object, e As EventArgs) Handles opGestionLibros.Click
        Dim frm As New GestionLibros
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Opcion Gestión Pais'
    Private Sub opGetsionPais_Click(sender As Object, e As EventArgs) Handles opGetsionPais.Click
        Dim frm As New GestionPaises
        frm.MdiParent = Me
        frm.Show()
    End Sub
   
    'Opcion Gestion Usuarios'
    Private Sub opGestionUsuarios_Click(sender As Object, e As EventArgs) Handles opGestionUsuarios.Click
        Dim frm As New GestionUsuarios
        frm.MdiParent = Me
        frm.Show()
    End Sub
    'Opción Prestamos y devoluciones'
    Private Sub opPrestamosDevoluciones_Click(sender As Object, e As EventArgs) Handles opPrestamosDevoluciones.Click
        Dim frm As New PrestamosYDevoluciones
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub opAcercaDe_Click(sender As Object, e As EventArgs) Handles opAcercaDe.Click

    End Sub

    Private Sub mnuPrestamos_Click(sender As Object, e As EventArgs) Handles mnuPrestamos.Click

    End Sub
End Class
