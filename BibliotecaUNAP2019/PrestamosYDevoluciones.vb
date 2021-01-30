Public Class PrestamosYDevoluciones
    ':::Creamos una varible para almacenar el valor del Id del registro::::::'
    Public Id As Integer = 0
    'Funcion cargar regitros de la tabla Usuarios'
    Function cargarRegistros()
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Prestamos"
        ':::Llamamos la funcion para cargar los registros de SQLite
        Cargar_TablaUsuarios(sql, DGTablaPrestamos)
    End Function

    'Al iniciar el formulario cargamos todos lo registros de la tabla Libros'
    Private Sub PrestasmosYDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros()
    End Sub
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros() 'LLamamos al método cargar regitros'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnImagen.Enabled = False 'Desabilitamos el Botón'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        desabilitarCajas() 'Llamamos al método desabilitar'
    End Sub

    'Función Hablilitar cajas de texto'
    Function habilitarCajas()
        txtCodigoPrestamo.Enabled = True
        txtIsbn.Enabled = True
        DtpFecha.Enabled = True
        txtNumeroDias.Enabled = True
        txtRutUsuarios.Enabled = True
        PtbImagen.Enabled = True
    End Function

    'Función Desabilitar cajas de texto'
    Function desabilitarCajas()
        txtIsbn.Enabled = False
        txtCodigoPrestamo.Enabled = False
        DtpFecha.Enabled = False
        txtRutUsuarios.Enabled = False
        txtNumeroDias.Enabled = False
        PtbImagen.Enabled = True
    End Function

    'Funcion Limpiara Cajas de Texto'
    Function limpiarCajasDeTexto()
        txtIsbn.Clear()
        txtCodigoPrestamo.Clear()
        txtRutUsuarios.Clear()
        txtNumeroDias.Clear()
        PtbImagen.Image = Nothing
    End Function

    '::::::::Creamos Funciones  para las cajas de texto para ingresar solo letras o solo números :::::::::::'
    ':::::Funcion para que solo permite el ingreso de caracteres tipo numerico:::::'
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
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
    Sub SoloLetra(ByRef e As System.Windows.Forms.KeyPressEventArgs)
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
    'Selecionamos el Evento KeyPress para  la caja de texto Código prestamos que envia el foco a la caja de texto Isbn'
    Private Sub txtCodigoPrestamo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPrestamo.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtIsbn.Select()
        End If
    End Sub
    'Seleccionamos el Evento KeyPress para la caja de texto Isbn que envia el foco a la caja de texto rut Usuarios'
    Private Sub txtIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIsbn.KeyPress
        SoloNumeros(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtRutUsuarios.Select()
        End If
    End Sub
  
    'Seleccionamos el Evento KeyPress para  la caja de texto rut Usuarios Paterno que envia el foco a la caja de texto Número de dias'
    Private Sub txtRutUsuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutUsuarios.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtNumeroDias.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Numero Dias que envia el foco al Botón Imagen'
    Private Sub txtNumeroDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroDias.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnImagen.Select()
        End If
    End Sub

    'Método para cargar los datos delos campos de texto al hacer doble click en la tabla'
    Private Sub DGTablaPrestasmos_DoubleClick(sender As Object, e As EventArgs) Handles DGTablaPrestamos.DoubleClick
        Id = DGTablaPrestamos.CurrentRow.Cells("Id_Codigo_Prestamos").Value 'Cargamos los datos a la caja de texto'
        txtCodigoPrestamo.Text = DGTablaPrestamos.CurrentRow.Cells("Id_Codigo_Prestamos").Value 'Cargamos los datos a la caja de texto'
        txtIsbn.Text = DGTablaPrestamos.CurrentRow.Cells("ISBN").Value 'Cargamos los datos a la caja de texto'
        txtRutUsuarios.Text = DGTablaPrestamos.CurrentRow.Cells("Rut").Value 'Cargamos los datos a la caja de texto'
        DtpFecha.Value = DGTablaPrestamos.CurrentRow.Cells("Fecha_Prestamo").Value 'Cargamos los datos a la caja de texto'
        txtNumeroDias.Text = DGTablaPrestamos.CurrentRow.Cells("Numero_Dias").Value 'Cargamos los datos a la caja de texto'
        PtbImagen.Image = DGTablaPrestamos.CurrentRow.Cells("Imagen").FormattedValue 'Cargamos los datos a la caja de texto'
        btnAgregar.Enabled = False 'Desabilitamos el Botón'
        btnEliminar.Enabled = True 'Habilitamos el Botón'
        btnModificar.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = True 'Habilitamos el Botón'
        btnCancelar.Enabled = True 'Hablitamos el Botón'
        btnNuevo.Enabled = False 'Desabilitamos el Botón'
        habilitarCajas() 'Llamamos al metodo Habilitar'
        txtCodigoPrestamo.Enabled = False 'Desabilitamos el txtCódigoPrestamos'
        txtIsbn.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Imagen'
    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
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
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        BtnAgregar.Enabled = True  'Habilitamos el Botón'
        btnCancelar.Enabled = True  'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = True 'Habilitamos el Botón'
        habilitarCajas() 'Llamamos al método habilitar'
        limpiarCajasDeTexto() 'Llamamos al método limpiar'
        txtIsbn.Enabled = True   'Bloqueamos el txt'
        txtCodigoPrestamo.Select() 'Enviamo el foco a txt'
    End Sub
    'Botón Agregar'
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Creamos validaciones de picturebo
        If PtbImagen Is Nothing Then

        End If
        ':::Creamos nuestras variables para almacenar los datos a ingresar:::'
        Dim CodigoPrestamos As String = txtCodigoPrestamo.Text.ToUpper
        Dim ISBN As String = txtIsbn.Text
        Dim RutUsuario As String = txtRutUsuarios.Text.ToUpper
        Dim Fecha_Prestamos As String = DtpFecha.Value.ToString("yyyy-MM-dd")
        Dim NumeroDias As String = txtNumeroDias.Text.ToUpper


        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "INSERT INTO Prestamos (Id_Codigo_Prestamos,ISBN,Rut,Fecha_Prestamo,Numero_Dias, Imagen) VALUES (" & CodigoPrestamos & "," & ISBN & "," & RutUsuario & ",'" & Fecha_Prestamos & "'," & NumeroDias & ", @imagen)"
        ':::Llamamos la funcion para agregar un nuevo registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Prestamos(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
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
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ':::Creamos nuestras variables para almacenar los datos a ingresar:::'
        Dim CodigoPrestamos As String = txtCodigoPrestamo.Text.ToUpper
        Dim ISBN As String = txtIsbn.Text
        Dim RutUsuario As String = txtRutUsuarios.Text.ToUpper
        Dim Fecha_Prestamos As String = DtpFecha.Value.ToString("yyyy-MM-dd")
        Dim NumeroDias As String = txtNumeroDias.Text.ToUpper
        '::Validamos si se ha escogido un registro para ser editado
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para modificarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "UPDATE Prestamos SET ISBN =" & ISBN & ",Rut=" & RutUsuario & ", Fecha_Prestamo ='" & Fecha_Prestamos & "', Numero_Dias = " & NumeroDias & ", Imagen = @imagen WHERE Id_Codigo_Prestamos = " & CodigoPrestamos & ""
        ':::Llamamos la funcion para modificar un registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Prestamos(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
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
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ':::Creamos una variables para elminar los datos a ingresados:::'
        Dim Codigo As String = txtCodigoPrestamo.Text
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para eliminarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If
        ':::Creamos una varible que almacenara nuestra consulta SQL
        Dim sql As String = "DELETE FROM Prestamos WHERE Id_Codigo_Prestamos=" & Codigo & ""
        Operaciones_Prestamos(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
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

    End Class