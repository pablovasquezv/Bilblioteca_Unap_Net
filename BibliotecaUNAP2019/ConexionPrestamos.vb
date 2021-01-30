':::Libreria OleDb - Access::::::'
Imports System.Data.OleDb
':::Libreria necesaria para usar MemoryStream:::::'
Imports System.IO
Module ConexionPrestamos
    ':::Procedimiento para conexion a Access:::'
    Dim Conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + My.Computer.FileSystem.CurrentDirectory + "\BibliotecaUNAP.mdb")

    '===================================================================================================================================================='

    ':::Procedimiento para Cargar los registro de Access:::'
    Sub Cargar_TablaPrestamos(ByVal Sql As String, ByVal Tabla As DataGridView)
        Dim Da As New OleDbDataAdapter(Sql, Conexion)
        ':::Creamos nuestro DataTable para almacenar el resultado
        Dim Dt As New DataTable
        Try
            ':::Llenamos nuestro DataTable con el resultado de la consulta
            Da.Fill(Dt)
            ':::Asignamos a nuestro DataGridView el DataTable para mostrar los registros
            Tabla.DataSource = Dt
            ':::Damos color a las filas
            Tabla.RowsDefaultCellStyle.BackColor = Color.LightBlue
            Tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        Catch ex As Exception
            MsgBox("No se puede realizar la consulta por: " & ex.Message)
        End Try
    End Sub

    ':::Procedimiento para Cargar con formato de fecha los registro de Access
    Sub Cargar_TablaConFecha(ByVal Sql As String, ByVal Tabla As DataGridView)
        Dim Da As New OleDbDataAdapter(Sql, conexion)
        ':::Creamos nuestro DataTable para almacenar el resultado
        Dim Dt As New DataTable
        Try
            ':::Llenamos nuestro DataTable con el resultado de la consulta
            Da.Fill(Dt)
            ':::Asignamos a nuestro DataGridView el DataTable para mostrar los registros
            Tabla.DataSource = Dt
            ':::Damos color a las filas
            Tabla.RowsDefaultCellStyle.BackColor = Color.LightBlue
            Tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            Tabla.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
        Catch ex As Exception
            MsgBox("No se puede realizar la consulta por: " & ex.Message)
        End Try
    End Sub

    ':::Procedimiento para agregar, modificar y eliminar en Access:::'
    Sub Operaciones_Prestamos(ByVal sql As String, ByVal imagen As PictureBox)
        ':::Creamos una variable de tipo MemoryStram
        Dim MS As New MemoryStream
        ':::Guardamos en la variable MS el contenido del PictureBox
        imagen.Image.Save(MS, imagen.Image.RawFormat)
        ':::Pasamos a Byte nuestra imagen
        Dim Imagenes() As Byte = MS.GetBuffer

        ':::Declaramos nuestro objeto de tipo SQLiteCommand para ejecutar la consulta
        Dim cmd As New OleDbCommand(sql, Conexion)
        ':::Agregamos el parametro de nuestra varible imagenes que es de tipo Byte
        cmd.Parameters.AddWithValue("@imagen", Imagenes)
        Try
            ':::Abrimos nuestra conexion
            Conexion.Open()
            ':::Ejecutamos la consulta
            cmd.ExecuteNonQuery()
            ':::Cerramos nuestra conexion
            Conexion.Close()
            MsgBox("Operación realizada con exito", MsgBoxStyle.Information, ":::Información:::")
            GestionUsuarios.Id = 0
        Catch ex As Exception
            MsgBox("No se pueden guardar los registro por: " & ex.Message, MsgBoxStyle.Critical, ":::Información:::")
        End Try
    End Sub
End Module
