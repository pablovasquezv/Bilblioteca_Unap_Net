Public Class GestionAutores
    ':::Creamos una varible para almacenar el valor del Id del registro::::::'
    Public Id As Integer = 0

    'Funcion cargar regitros de la tabla Usuarios'
    Function RegistrosAutores()
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Autores"
        ':::Llamamos la funcion para cargar los registros de SQLite
        Cargar_TablaPaises(sql, DGTablaAutores)
    End Function
    'Función Hablilitar cajas de texto'
    Function habilitarCajas()
        txtCodigoAutor.Enabled = True
        txtNombre.Enabled = True
        txtApellidoPaterno.Enabled = True
        txtApellidoMaterno.Enabled = True
        DtpFecha.Enabled = True
        txtSexo.Enabled = True
        txtCodigoPais.Enabled = True

        PtbImagen.Enabled = True
    End Function

    'Función Desabilitar cajas de texto'
    Function desabilitarCajas()
        txtCodigoAutor.Enabled = False
        txtNombre.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        DtpFecha.Enabled = False
        txtSexo.Enabled = False
        txtCodigoPais.Enabled = False


        PtbImagen.Enabled = True
    End Function

    'Funcion Limpiara Cajas de Texto'
    Function limpiarCajasDeTexto()
        txtCodigoAutor.Clear()
        txtNombre.Clear()
        txtApellidoPaterno.Clear()
        txtApellidoMaterno.Clear()
        txtSexo.Clear()
        txtCodigoPais.Clear()
        PtbImagen.Image = Nothing
    End Function

    'Funcion cargar regitros de la tabla Autores'
    Function cargarRegistros()
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Autores"
        ':::Llamamos la funcion para cargar los registros de SQLite
        Cargar_TablaAutores(sql, DGTablaAutores)
    End Function

    'Al iniciar el formulario cargamos todos lo registros de la tabla Paises'
    Private Sub GestionPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros() 'LLamamos al método cargar regitros'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnImagen.Enabled = False 'Desabilitamos el Botón'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        desabilitarCajas() 'Llamamos al método desabilitar'
    End Sub

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
    Private Sub txtCodigoAutor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoAutor.KeyPress
        SoloNumeros(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtNombre.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Nombre que envia el foco a la caja de texto Apellido Paterno'
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtApellidoPaterno.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para  la caja de texto Apellido Paterno que envia el foco a la caja de texto Apellido Materno'
    Private Sub txtApellidoPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoPaterno.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtApellidoMaterno.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Apellido Materno que envia el foco a la caja de texto Email'
    Private Sub txtApellidoMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoMaterno.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtSexo.Select()
        End If
    End Sub
    'Seleccionamos el Evento KeyPress para la caja de texto Sexo que envia el foco a la caja de texto Celular'
    Private Sub txtSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSexo.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtCodigoPais.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Fecha que envia el foco a la caja de texto Sexo'
    Private Sub DtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpFecha.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            DtpFecha.Select()
        End If
    End Sub

   
    'Seleccionamos el Evento KeyPress para la caja de texto Email que envia el foco a la caja de texto Celular'
    Private Sub txtCodigoPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPais.KeyPress
        SoloNumeros(e)  'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnImagen.Select()
        End If
    End Sub

    'Método para cargar los datos delos campos de texto al hacer doble click en la tabla'
    Private Sub DGTablaAutores_DoubleClick(sender As Object, e As EventArgs) Handles DGTablaAutores.DoubleClick
        Id = DGTablaAutores.CurrentRow.Cells("Id_Codigo_Autor").Value 'Cargamos los datos a la caja de texto'
        txtCodigoAutor.Text = DGTablaAutores.CurrentRow.Cells("Id_Codigo_Autor").Value 'Cargamos los datos a la caja de texto'
        txtNombre.Text = DGTablaAutores.CurrentRow.Cells("Nombre").Value 'Cargamos los datos a la caja de texto'
        txtApellidoPaterno.Text = DGTablaAutores.CurrentRow.Cells("Apellido_Paterno").Value 'Cargamos los datos a la caja de texto'
        txtApellidoMaterno.Text = DGTablaAutores.CurrentRow.Cells("Apellido_Materno").Value 'Cargamos los datos a la caja de texto'
        txtSexo.Text = DGTablaAutores.CurrentRow.Cells("Sexo").Value 'Cargamos los datos a la caja de texto'
        DtpFecha.Value = DGTablaAutores.CurrentRow.Cells("Fecha_Nacimiento").Value 'Cargamos los datos a la caja de texto'
        txtCodigoPais.Text = DGTablaAutores.CurrentRow.Cells("Id_Codigo_Pais").Value 'Cargamos los datos a la caja de texto'
        PtbImagen.Image = DGTablaAutores.CurrentRow.Cells("Imagen").FormattedValue 'Cargamos los datos a la caja de texto'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = True 'Habilitamos el Botón'
        BtnModificar.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = True 'Habilitamos el Botón'
        btnCancelar.Enabled = True 'Hablitamos el Botón'
        BtnNuevo.Enabled = False 'Desabilitamos el Botón'
        habilitarCajas() 'Llamamos al metodo Habilitar'
        txtCodigoAutor.Enabled = False 'Desabilitamos el txtRut'
        txtNombre.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Imagen'
    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
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
        btnImagen.Enabled = False 'Desabilitamos el Botón'
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
        btnImagen.Enabled = True 'Habilitamos el Botón'
        habilitarCajas() 'Llamamos al método habilitar'
        limpiarCajasDeTexto() 'Llamamos al método limpiar'
        txtCodigoAutor.Enabled = False 'Desabilitamos el txtRut'
        txtNombre.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Agregar'
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ':::Creamos nuestras variables para almacenar los datos a ingresar
        Dim Codigo_Autor As String = txtCodigoAutor.Text
        Dim Nombre As String = txtNombre.Text.ToUpper
        Dim Apellido_Paterno As String = txtApellidoPaterno.Text.ToUpper
        Dim Apellido_Materno As String = txtApellidoMaterno.Text.ToUpper
        Dim Sexo As String = txtSexo.Text.ToUpper
        Dim FechaNacimiento As String = DtpFecha.Value.ToString("yyyy-MM-dd")
        Dim Codigo_Pais As String = txtCodigoPais.Text.ToUpper

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "INSERT INTO Autores (Nombre, Apellido_Paterno, Apellido_Materno,Sexo,Fecha_Nacimiento,Id_Codigo_Pais, Imagen) VALUES ('" & Nombre & "','" & Apellido_Paterno & "','" & Apellido_Materno & "','" & Sexo & "','" & FechaNacimiento & "'," & Codigo_Pais & ", @imagen)"
        ':::Llamamos la funcion para agregar un nuevo registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Usuario(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        cargarRegistros() 'Llamamos al Método cargar regitro tabla'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar'
        desabilitarCajas() 'Llamamos al Método desabilitar'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        btnImagen.Enabled = False 'Desabilitamos el Botón'
    End Sub

    'Botón Modificar'
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ':::Creamos nuestras variables para almacenar los datos a ingresar
        Dim Codigo_Autor As String = txtCodigoAutor.Text
        Dim Nombre As String = txtNombre.Text.ToUpper
        Dim Apellido_Paterno As String = txtApellidoPaterno.Text.ToUpper
        Dim Apellido_Materno As String = txtApellidoMaterno.Text.ToUpper
        Dim Sexo As String = txtSexo.Text.ToUpper
        Dim FechaNacimiento As String = DtpFecha.Value.ToString("yyyy-MM-dd")
        Dim Codigo_Pais As String = txtCodigoPais.Text.ToUpper
        

        '::Validamos si se ha escogido un registro para ser editado
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para modificarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "UPDATE Autores SET Nombre='" & Nombre & "', Apellido_Paterno ='" & Apellido_Paterno & "', Apellido_Materno = '" & Apellido_Materno & "',Sexo= '" & Sexo & "', Fecha_Nacimiento ='" & FechaNacimiento & "', Id_Codigo_Pais =" & Codigo_Pais & ", Imagen = @imagen WHERE Id_Codigo_Autor= " & Codigo_Autor & ""
        ':::Llamamos la funcion para modificar un registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Usuario(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar cajas de texto'
        cargarRegistros() 'Llamamos al Método cargar regitro tabla'
        limpiarCajasDeTexto() 'Llamamos al Método Limpiar'
        desabilitarCajas() 'Llamamos al Método cargar Desabilitar'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = False 'Habilitamos el Botón'


    End Sub

    'Botón Eliminar'
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Codigo_Autor As String = txtCodigoAutor.Text
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para eliminarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If
        ':::Creamos una varible que almacenara nuestra consulta SQL
        Dim sql As String = "DELETE FROM Autores WHERE Id_Codigo_Autor=" & Codigo_Autor & ""
        Operaciones_Usuario(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        cargarRegistros() 'Llamamos al Método cargar regitro tabla'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar cajas de texto'
        cargarRegistros() 'Llamamos al Método cargar regitro tabla'
        limpiarCajasDeTexto() 'Llamamos al Método Limpiar'
        desabilitarCajas() 'Llamamos al Método cargar Desabilitar'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = False 'Habilitamos el Botón'
    End Sub

    Private Sub cboCodigoPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoPais.SelectedIndexChanged
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Paises"
    End Sub
End Class