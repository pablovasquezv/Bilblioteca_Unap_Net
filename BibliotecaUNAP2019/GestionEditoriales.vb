Public Class GestionEditoriales
    ':::Creamos una varible para almacenar el valor del Id del registro::::::'
    Public Id As Integer = 0

    'Funcion cargar regitros de la tabla Usuarios'
    Function RegistrosEditoriales()
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Editoriales"
        ':::Llamamos la funcion para cargar los registros de SQLite
        Cargar_TablaPaises(sql, DGTablaEditoriales)
    End Function

    'Al iniciar el formulario cargamos todos lo registros de la tabla Editoriales'
    Private Sub GestionEditoriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegistrosEditoriales() 'LLamamos al método cargar regitros'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnImagenEditoriales.Enabled = False 'Desabilitamos el Botón'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        desabilitarCajas() 'Llamamos al método desabilitar'
    End Sub

    'Función Hablilitar cajas de texto'
    Function habilitarCajas()
        txtCodigoEditorial.Enabled = True
        txtNombre.Enabled = True
        txtEmail.Enabled = True
        txtTelefono.Enabled = True
        PtbImagen.Enabled = True
    End Function

    'Función Desabilitar cajas de texto'
    Function desabilitarCajas()
        txtCodigoEditorial.Enabled = False
        txtNombre.Enabled = False
        txtEmail.Enabled = False
        txtTelefono.Enabled = False
        PtbImagen.Enabled = True
    End Function

    'Funcion Limpiara Cajas de Texto'
    Function limpiarCajasDeTexto()
        txtCodigoEditorial.Clear()
        txtNombre.Clear()
        txtEmail.Clear()
        txtTelefono.Clear()
        PtbImagen.Image = Nothing
    End Function

    '::::::::Creamos Funciones  para las cajas de texto para ingresar solo letras o solo números :::::::::::'
    ':::::Funcion para que solo permite el ingreso de caracteres tipo numerico:::::'
    Public Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    ':::::Función que soló permite el ingreso de letras:::::'
    Public Sub SoloLetra(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    ':::::::::Eventos KeyPress de la cajas de texto del formulario Usuario::::::::::::::'
    'Seleccionamos el Evento KeyPress para la caja de texto Rut que envia el foco a la caja de texto Nombre'
    Private Sub txtCodigoEditorial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoEditorial.KeyPress
        SoloNumeros(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtNombre.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Nombre que envia el foco a la caja de texto Apellido Paterno'
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtEmail.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para  la caja de texto Apellido Paterno que envia el foco a la caja de texto Apellido Materno'
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtTelefono.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Apellido Materno que envia el foco a la caja de texto Email'
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnImagenEditoriales.Select()
        End If
    End Sub

    'Método para cargar los datos delos campos de texto al hacer doble click en la tabla'
    Private Sub DGTablaEditoriales_DoubleClick(sender As Object, e As EventArgs) Handles DGTablaEditoriales.DoubleClick
        Id = DGTablaEditoriales.CurrentRow.Cells("Id_Codigo_Editorial").Value 'Cargamos los datos a la caja de texto'
        txtCodigoEditorial.Text = DGTablaEditoriales.CurrentRow.Cells("Id_Codigo_Editorial").Value 'Cargamos los datos a la caja de texto'
        txtNombre.Text = DGTablaEditoriales.CurrentRow.Cells("Nombre_Editorial").Value 'Cargamos los datos a la caja de texto'
        txtEmail.Text = DGTablaEditoriales.CurrentRow.Cells("Email_Editorial").Value 'Cargamos los datos a la caja de texto'
        txtTelefono.Text = DGTablaEditoriales.CurrentRow.Cells("Telefono").Value 'Cargamos los datos a la caja de texto'
        PtbImagen.Image = DGTablaEditoriales.CurrentRow.Cells("Imagen").FormattedValue 'Cargamos los datos a la caja de texto'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = True 'Habilitamos el Botón'
        BtnModificar.Enabled = True 'Habilitamos el Botón'
        btnImagenEditoriales.Enabled = True 'Habilitamos el Botón'
        btnCancelar.Enabled = True 'Hablitamos el Botón'
        BtnNuevo.Enabled = False 'Desabilitamos el Botón'
        habilitarCajas() 'Llamamos al metodo Habilitar'
        txtCodigoEditorial.Enabled = False 'Desabilitamos el txtRut'
        txtNombre.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Imagen'
    Private Sub btnImagenEditoriales_Click(sender As Object, e As EventArgs) Handles btnImagenEditoriales.Click
        ':::Creamos un nuevo objeto de tipo OpenFileDialog
        Dim Open As New OpenFileDialog
        Open.Title = "Seleccione una Imagen del Autor"
        ':::Le asignamos un filtro para que solo admita arhivos de imagen con extension jpg, jpeg y png
        Open.Filter = "Imagenes JPG|*.jpg|Imagenes JPEG|*.jpeg|Imagenes PNG|*.png"

        If Open.ShowDialog = DialogResult.OK Then
            ':::Pasamos la imagen seleccionada al PictureBox
            PtbImagen.ImageLocation = Open.FileName
            ':::Le indicamos que ajuste la imagen al tamaño del control
            PtbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    'Botón Cancelar'
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        btnImagenEditoriales.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        desabilitarCajas() 'Llamamos al método Desabilitar'
        limpiarCajasDeTexto() 'Llamamos al método limpiar'
    End Sub

    'Botón Nuevo'
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BtnAgregar.Enabled = True  'Habilitamos el Botón'
        btnCancelar.Enabled = True  'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagenEditoriales.Enabled = True 'Habilitamos el Botón'
        habilitarCajas() 'Llamamos al método habilitar'
        limpiarCajasDeTexto() 'Llamamos al método limpiar'
        txtCodigoEditorial.Enabled = False 'Desabilitamos el txtRut'
        txtNombre.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Agregar'
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ':::Creamos nuestras variables para almacenar los datos a ingresar
        Dim Nombre As String = txtNombre.Text.ToUpper
        Dim Email As String = txtEmail.Text.ToUpper
        Dim Telefono As String = txtTelefono.Text.ToUpper
        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "INSERT INTO Editoriales ( Nombre_Editorial, Email_Editorial,Telefono, Imagen) VALUES ('" & Nombre & "','" & Email & "'," & Telefono & ", @imagen)"
        ':::Llamamos la funcion para agregar un nuevo registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Editoriales(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar'
        desabilitarCajas() 'Llamamos al Método desabilitar'
        RegistrosEditoriales() 'Llamamos al Método cargar regitros de la tabla'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        btnImagenEditoriales.Enabled = False 'Desabilitamos el Botón'
    End Sub

    'Botón Imagen'
    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagenEditoriales.Click
        ':::Creamos un nuevo objeto de tipo OpenFileDialog
        Dim Open As New OpenFileDialog
        Open.Title = "Seleccione una imagen"
        ':::Le asignamos un filtro para que solo admita arhivos de imagen con extension jpg, jpeg y png
        Open.Filter = "Imagenes JPG|*.jpg|Imagenes JPEG|*.jpeg|Imagenes PNG|*.png"

        If Open.ShowDialog = DialogResult.OK Then
            ':::Pasamos la imagen seleccionada al PictureBox
            PtbImagen.ImageLocation = Open.FileName
            ':::Le indicamos que ajuste la imagen al tamaño del control
            PtbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    'Botón Modificar'
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ':::Creamos nuestras variables para almacenar los datos a ingresar
        Dim Codigo As String = txtCodigoEditorial.Text
        Dim Nombre As String = txtNombre.Text.ToUpper
        Dim Email As String = txtEmail.Text.ToUpper
        Dim Telefono As String = txtTelefono.Text.ToUpper


        '::Validamos si se ha escogido un registro para ser editado
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para modificarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "UPDATE Editoriales SET Nombre_Editorial ='" & Nombre & "', Email_Editorial='" & Email & "', Telefono = " & Telefono & ",Imagen = @imagen WHERE Id_Codigo_Editorial = " & Codigo & ""
        ':::Llamamos la funcion para modificar un registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Pais(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar cajas de texto'
        desabilitarCajas() 'Llamamos al Método cargar Desabilitar'
        RegistrosEditoriales() 'Llamamos al Método cargar regitros de la tabla'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagenEditoriales.Enabled = False 'Habilitamos el Botón'
    End Sub

    'Botón Eliminar'
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As String = txtCodigoEditorial.Text
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para eliminarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If
        ':::Creamos una varible que almacenara nuestra consulta SQL
        Dim sql As String = "DELETE FROM Editoriales WHERE Id_Codigo_Editorial=" & codigo & ""
        Operaciones_Pais(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar cajas de texto'
        desabilitarCajas() 'Llamamos al Método cargar Desabilitar'
        RegistrosEditoriales() 'Llamamos al Método cargar regitro tabla'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagenEditoriales.Enabled = False 'Habilitamos el Botón'
    End Sub
End Class