Public Class GestionPaises
    ':::Creamos una varible para almacenar el valor del Id del registro::::::'
    Public Id As Integer = 0

    'Funcion cargar regitros de la tabla Usuarios'
    Function cargarRegistros()
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Paises"
        ':::Llamamos la funcion para cargar los registros de SQLite
        Cargar_TablaPaises(sql, DGTablaPaises)
    End Function
    'Al iniciar el formulario cargamos todos lo registros de la tabla Paises'
    Private Sub GestionPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRegistros() 'LLamamos al método cargar regitros'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnImagenPais.Enabled = False 'Desabilitamos el Botón'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        desabilitarCajas() 'Llamamos al método desabilitar'
    End Sub

    'Función Hablilitar cajas de texto'
    Function habilitarCajas()
        txtCodigoPais.Enabled = True
        txtNombre.Enabled = True
        txtContinente.Enabled = True
        PtbImagen.Enabled = True
    End Function

    'Función Desabilitar cajas de texto'
    Function desabilitarCajas()
        txtCodigoPais.Enabled = False
        txtNombre.Enabled = False
        txtContinente.Enabled = False
        PtbImagen.Enabled = True
    End Function

    'Funcion Limpiara Cajas de Texto'
    Function limpiarCajasDeTexto()
        txtCodigoPais.Clear()
        txtNombre.Clear()
        txtContinente.Clear()
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
    'Seleccionamos el Evento KeyPress para la caja de texto Código Pais que envia el foco a la caja de texto Nombre'
    Private Sub txtCodigoPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPais.KeyPress
        SoloNumeros(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtNombre.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Nombre que envia el foco a la caja de texto Continente'
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloLetra(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtContinente.Select()
        End If
    End Sub
    'Seleccionamos el Evento KeyPress para la caja de texto Continente que envia el foco al Botón Imagen'
    Private Sub txtContinente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinente.KeyPress
        SoloLetra(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnImagenPais.Select()
        End If
    End Sub

    'Método para cargar los datos de los campos de texto al hacer doble click en la tabla'
    Private Sub DGTablaUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles DGTablaPaises.DoubleClick
        Id = DGTablaPaises.CurrentRow.Cells("Id_Codigo_Pais").Value 'Cargamos los datos a la caja de texto'
        txtCodigoPais.Text = DGTablaPaises.CurrentRow.Cells("Id_Codigo_Pais").Value 'Cargamos los datos a la caja de texto'
        txtNombre.Text = DGTablaPaises.CurrentRow.Cells("Nombre_Pais").Value 'Cargamos los datos a la caja de texto'
        txtContinente.Text = DGTablaPaises.CurrentRow.Cells("Continente").Value 'Cargamos los datos a la caja de texto'
        PtbImagen.Image = DGTablaPaises.CurrentRow.Cells("Imagen").FormattedValue 'Cargamos los datos a la caja de texto'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = True 'Habilitamos el Botón'
        BtnModificar.Enabled = True 'Habilitamos el Botón'
        btnImagenPais.Enabled = True 'Habilitamos el Botón'
        btnCancelar.Enabled = True 'Hablitamos el Botón'
        BtnNuevo.Enabled = False 'Desabilitamos el Botón'
        habilitarCajas() 'Llamamos al metodo Habilitar'
        txtCodigoPais.Enabled = False 'Desabilitamos el txtRut'
        txtNombre.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Cancelar'
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        btnImagenPais.Enabled = False 'Desabilitamos el Botón'
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
        btnImagenPais.Enabled = True 'Habilitamos el Botón'
        habilitarCajas() 'Llamamos al método habilitar'
        limpiarCajasDeTexto() 'Llamamos al método limpiar'
        txtCodigoPais.Enabled = False 'Desabilitamos el txtRut'
        txtNombre.Select() 'Enviamos el foco al txt'
    End Sub

    'Botón Agregar'
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ':::Creamos nuestras variables para almacenar los datos a ingresar
        Dim Nombre As String = txtNombre.Text.ToUpper
        Dim Continente As String = txtContinente.Text.ToUpper

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "INSERT INTO Paises ( Nombre_Pais, Continente, Imagen) VALUES ('" & Nombre & "','" & Continente & "', @imagen)"
        ':::Llamamos la funcion para agregar un nuevo registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Pais(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        cargarRegistros() 'Llamamos al Método cargar regitro tabla'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar'
        desabilitarCajas() 'Llamamos al Método desabilitar'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Desabilitamos el Botón'
        btnImagenPais.Enabled = False 'Desabilitamos el Botón'
    End Sub

    'Botón Imagen'
    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagenPais.Click
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
        Dim Codigo As String = txtCodigoPais.Text
        Dim Nombre As String = txtNombre.Text.ToUpper
        Dim Continente As String = txtContinente.Text.ToUpper


        '::Validamos si se ha escogido un registro para ser editado
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para modificarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "UPDATE Paises SET Nombre_Pais ='" & Nombre & "', Continente ='" & Continente & "', Imagen = @imagen WHERE Id_Codigo_Pais = " & Codigo & ""
        ':::Llamamos la funcion para modificar un registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Pais(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
        limpiarCajasDeTexto() 'Llamamos al Método limpiar cajas de texto'
        cargarRegistros() 'Llamamos al Método cargar regitro tabla'
        limpiarCajasDeTexto() 'Llamamos al Método Limpiar'
        desabilitarCajas() 'Llamamos al Método cargar Desabilitar'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        btnCancelar.Enabled = False 'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagenPais.Enabled = False 'Habilitamos el Botón'


    End Sub

    'Botón Eliminar'
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As String = txtCodigoPais.Text
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para eliminarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If
        ':::Creamos una varible que almacenara nuestra consulta SQL
        Dim sql As String = "DELETE FROM Paises WHERE Id_Codigo_Pais=" & codigo & ""
        Operaciones_Pais(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
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
        btnImagenPais.Enabled = False 'Habilitamos el Botón'
    End Sub

End Class