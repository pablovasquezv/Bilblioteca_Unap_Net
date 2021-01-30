Public Class GestionLibros
    ':::Creamos una varible para almacenar el valor del Id del registro::::::'
    Public Id As Integer = 0
    'Funcion cargar regitros de la tabla Usuarios'
    Function cargarRegistros()
        ':::Creamos una variable de tipo string que guardara nuestra consulta SQL
        Dim sql As String = "SELECT * FROM Libros"
        ':::Llamamos la funcion para cargar los registros de SQLite
        Cargar_TablaUsuarios(sql, DGTablaLibros)
    End Function

    'Al iniciar el formulario cargamos todos lo registros de la tabla Libros'
    Private Sub GestionLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtIsbn.Enabled = True
        txtTitulo.Enabled = True
        DtpFecha.Enabled = True
        txtNumeroPaginas.Enabled = True
        txtDescripcion.Enabled = True
        txtCodigoAutor.Enabled = True
        txtCodigoCategorias.Enabled = True
        txCodigoEditorial.Enabled = True
        PtbImagen.Enabled = True
    End Function

    'Función Desabilitar cajas de texto'
    Function desabilitarCajas()
        txtIsbn.Enabled = False
        txtTitulo.Enabled = False
        DtpFecha.Enabled = False
        txtNumeroPaginas.Enabled = False
        txtDescripcion.Enabled = False

        txtCodigoAutor.Enabled = False
        txtCodigoCategorias.Enabled = False
        txCodigoEditorial.Enabled = False
        PtbImagen.Enabled = True
    End Function

    'Funcion Limpiara Cajas de Texto'
    Function limpiarCajasDeTexto()
        txtIsbn.Clear()
        txtTitulo.Clear()
        txtNumeroPaginas.Clear()
        txtDescripcion.Clear()
        txtCodigoAutor.Clear()
        txtCodigoCategorias.Clear()
        txCodigoEditorial.Clear()
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
    'Seleccionamos el Evento KeyPress para la caja de texto Isbn que envia el foco a la caja de texto Título'
    Private Sub txtIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIsbn.KeyPress
        SoloNumeros(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtTitulo.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Título que envia el foco a la caja de texto Número Páginas'
    Private Sub txtTitulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTitulo.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtNumeroPaginas.Select()
        End If
    End Sub
    'Seleccionamos el Evento KeyPress para  la caja de texto Descripcion Paterno que envia el foco a la caja de texto Código Autor'
    Private Sub txtNumeroPaginas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroPaginas.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtDescripcion.Select()
        End If
    End Sub
    'Seleccionamos el Evento KeyPress para  la caja de texto Descripcion Paterno que envia el foco a la caja de texto Código Autor'
    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        SoloLetra(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtCodigoAutor.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Código Categorias que envia el foco al Botón Imagen'
    Private Sub txtCodigoAutor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoAutor.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtCodigoCategorias.Select()
        End If
    End Sub
    'Seleccionamos el Evento KeyPress para la caja de texto Código Categorias que envia el foco al Botón Imagen'
    Private Sub txtCodigoCategorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoCategorias.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txCodigoEditorial.Select()
        End If
    End Sub

    'Seleccionamos el Evento KeyPress para la caja de texto Sexo que envia el foco a la caja de texto Celular'
    Private Sub txtCodigoEditorial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodigoEditorial.KeyPress
        SoloNumeros(e) 'Llamamos al método  soló ingresar letras en la caja de texto'
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnImagen.Select()
        End If
    End Sub

    'Método para cargar los datos delos campos de texto al hacer doble click en la tabla'
    Private Sub DGTablaLibros_DoubleClick(sender As Object, e As EventArgs) Handles DGTablaLibros.DoubleClick
        Id = DGTablaLibros.CurrentRow.Cells("ISBN").Value 'Cargamos los datos a la caja de texto'
        txtIsbn.Text = DGTablaLibros.CurrentRow.Cells("ISBN").Value 'Cargamos los datos a la caja de texto'
        txtTitulo.Text = DGTablaLibros.CurrentRow.Cells("Titulo").Value 'Cargamos los datos a la caja de texto'
        DtpFecha.Value = DGTablaLibros.CurrentRow.Cells("Fecha_Edicion").Value 'Cargamos los datos a la caja de texto'
        txtNumeroPaginas.Text = DGTablaLibros.CurrentRow.Cells("Numero_Paginas").Value 'Cargamos los datos a la caja de texto'
        txtDescripcion.Text = DGTablaLibros.CurrentRow.Cells("Descripcion").Value 'Cargamos los datos a la caja de texto'
        txtCodigoAutor.Text = DGTablaLibros.CurrentRow.Cells("Id_Codigo_Autor").Value 'Cargamos los datos a la caja de texto'
        txtCodigoCategorias.Text = DGTablaLibros.CurrentRow.Cells("Id_Codigo_Categorias").Value 'Cargamos los datos a la caja de texto'
        txCodigoEditorial.Text = DGTablaLibros.CurrentRow.Cells("Id_Codigo_Editorial").Value 'Cargamos los datos a la caja de texto'
        PtbImagen.Image = DGTablaLibros.CurrentRow.Cells("Imagen").FormattedValue 'Cargamos los datos a la caja de texto'
        BtnAgregar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = True 'Habilitamos el Botón'
        BtnModificar.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = True 'Habilitamos el Botón'
        btnCancelar.Enabled = True 'Hablitamos el Botón'
        BtnNuevo.Enabled = False 'Desabilitamos el Botón'
        habilitarCajas() 'Llamamos al metodo Habilitar'
        txtIsbn.Enabled = False 'Desabilitamos el txtRut'
        txtTitulo.Select() 'Enviamos el foco al txt'
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
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BtnAgregar.Enabled = True  'Habilitamos el Botón'
        btnCancelar.Enabled = True  'Desabilitamos el Botón'
        BtnModificar.Enabled = False 'Desabilitamos el Botón'
        BtnEliminar.Enabled = False 'Desabilitamos el Botón'
        BtnNuevo.Enabled = True 'Habilitamos el Botón'
        btnImagen.Enabled = True 'Habilitamos el Botón'
        habilitarCajas() 'Llamamos al método habilitar'
        limpiarCajasDeTexto() 'Llamamos al método limpiar'
        txtIsbn.Enabled = False  'Bloqueamos el txt'
        txtTitulo.Select() 'Enviamo el foco a txt'

    End Sub

    'Botón Agregar'
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        'Creamos validaciones de picturebo
        If PtbImagen Is Nothing Then

        End If
        ':::Creamos nuestras variables para almacenar los datos a ingresar:::::'
        Dim Titulo As String = txtTitulo.Text.ToUpper
        Dim Fecha_Edicion As String = DtpFecha.Value.ToString("yyyy-MM-dd")
        Dim Numero_Paginas As String = txtNumeroPaginas.Text.ToUpper
        Dim Descripcion As String = txtDescripcion.Text.ToUpper
        Dim Codigo_Autor As String = txtCodigoAutor.Text.ToUpper
        Dim Codigo_Categorias As String = txtCodigoCategorias.Text.ToUpper
        Dim Codigo_Editorial As String = txCodigoEditorial.Text.ToUpper


        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "INSERT INTO Libros (Titulo, Fecha_Edicion,Numero_Paginas,Descripcion,Id_Codigo_Autor,Id_Codigo_Categorias,Id_Codigo_Editorial, Imagen) VALUES ('" & Titulo & "','" & Fecha_Edicion & "'," & Numero_Paginas & ",'" & Descripcion & "'," & Codigo_Autor & "," & Codigo_Categorias & "," & Codigo_Editorial & ", @imagen)"
        ':::Llamamos la funcion para agregar un nuevo registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Libros(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
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
        ':::Creamos nuestras variables para almacenar los datos a ingresar:::'
        Dim ISBN As String = txtIsbn.Text
        Dim Titulo As String = txtTitulo.Text.ToUpper
        Dim Fecha_Edicion As String = DtpFecha.Value.ToString("yyyy-MM-dd")
        Dim Numero_Paginas As String = txtNumeroPaginas.Text.ToUpper
        Dim Descripcion As String = txtDescripcion.Text.ToUpper
        Dim Codigo_Autor As String = txtCodigoAutor.Text.ToUpper
        Dim Codigo_Categorias As String = txtCodigoCategorias.Text.ToUpper
        Dim Codigo_Editorial As String = txCodigoEditorial.Text.ToUpper

        '::Validamos si se ha escogido un registro para ser editado
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para modificarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If

        ':::Creamos una varible que almacenara nuestra consulta SQL
        ':::Como podemos observar pasamos todos los valores menos el de la imagen, el cual le indicamos que es un parametro
        ':::Esto debido a que la imagen es de tipo Byte y la consulta SQL solo admite valores String, por esto debemos
        ':::Pasarlo como un parametro
        Dim sql As String = "UPDATE libros SET Titulo ='" & Titulo & "', Fecha_Edicion ='" & Fecha_Edicion & "', Numero_Paginas = " & Numero_Paginas & ", Descripcion ='" & Descripcion & "',Id_Codigo_Autor = " & Codigo_Autor & ",Id_Codigo_Categorias = " & Codigo_Categorias & ", Id_Codigo_Editorial = " & Codigo_Editorial & ", Imagen = @imagen WHERE ISBN = " & ISBN & ""
        ':::Llamamos la funcion para modificar un registro en Access y le pasamos el objeto PictureBox que llamamos PtbImagen
        Operaciones_Libros(sql, PtbImagen) 'Llamamos al funcion de la Conexion para que ejecute las consultas a la base de datos'
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
        ':::Creamos una variables para elminar los datos a ingresados:::'
        Dim Codigo As String = txtIsbn.Text
        If Id = 0 Then
            MsgBox("Por favor de doble click sobre un registro para eliminarlo", MsgBoxStyle.Exclamation, ":::Alerta:::")
            Exit Sub
        End If
        ':::Creamos una varible que almacenara nuestra consulta SQL
        Dim sql As String = "DELETE FROM Libros WHERE ISBN=" & Codigo & ""
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

 
End Class