Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar ComboBox de estado
        CmbEstado.Items.Add("Completado")
        CmbEstado.Items.Add("Pendiente")
        CmbEstado.Items.Add("En proceso")
        CmbEstado.SelectedIndex = 0 ' Seleccionar la primera opción por defecto

        ' Cargar datos en el DataGridView al iniciar
        CargarSolicitudes()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Obtener valores de los controles
        Dim solicitudID As Integer
        If Not Integer.TryParse(TxtSolicitudID.Text, solicitudID) Then
            MessageBox.Show("El ID de la solicitud debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim rut As String = TxtRut.Text.Trim()
        Dim descripcion As String = TxtDescripcion.Text.Trim()
        Dim estado As String = CmbEstado.SelectedItem.ToString()
        Dim fechaSolicitud As Date = DtpFecha.Value

        ' Validar campos
        If String.IsNullOrWhiteSpace(rut) OrElse String.IsNullOrWhiteSpace(descripcion) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Conexión y registro en la base de datos
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()
                Dim query As String = "INSERT INTO solicitudesservicio (SolicitudID, Rut, FechaSolicitud, DescripcionProblema, Estado) VALUES (@SolicitudID, @Rut, @FechaSolicitud, @DescripcionProblema, @Estado)"
                Using cmd As New MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@SolicitudID", solicitudID)
                    cmd.Parameters.AddWithValue("@Rut", rut)
                    cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud)
                    cmd.Parameters.AddWithValue("@DescripcionProblema", descripcion)
                    cmd.Parameters.AddWithValue("@Estado", estado)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Solicitud registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar campos después de guardar
            TxtSolicitudID.Clear()
            TxtRut.Clear()
            TxtDescripcion.Clear()
            CmbEstado.SelectedIndex = 0
            DtpFecha.Value = Date.Now

            ' Actualizar el DataGridView
            CargarSolicitudes()
        Catch ex As Exception
            MessageBox.Show("Error al guardar la solicitud: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarSolicitudes()
        Try
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()
                Dim query As String = "SELECT SolicitudID, Rut, FechaSolicitud, DescripcionProblema, Estado FROM solicitudesservicio"
                Using cmd As New MySqlCommand(query, conexion)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DgvSolicitudes.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las solicitudes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Validar que se haya seleccionado un registro
        If DgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un registro para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Obtener datos seleccionados
            Dim solicitudID As Integer = Convert.ToInt32(TxtSolicitudID.Text)
            Dim rut As String = TxtRut.Text.Trim()
            Dim descripcion As String = TxtDescripcion.Text.Trim()
            Dim estado As String = CmbEstado.SelectedItem.ToString()
            Dim fechaSolicitud As Date = DtpFecha.Value

            ' Actualizar datos en la base de datos
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()
                Dim query As String = "UPDATE solicitudesservicio SET Rut = @Rut, FechaSolicitud = @FechaSolicitud, DescripcionProblema = @DescripcionProblema, Estado = @Estado WHERE SolicitudID = @SolicitudID"
                Using cmd As New MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@SolicitudID", solicitudID)
                    cmd.Parameters.AddWithValue("@Rut", rut)
                    cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud)
                    cmd.Parameters.AddWithValue("@DescripcionProblema", descripcion)
                    cmd.Parameters.AddWithValue("@Estado", estado)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Solicitud actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Actualizar el DataGridView
            CargarSolicitudes()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la solicitud: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        ' Validar que se haya seleccionado un registro
        If DgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un registro para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmar eliminación
        If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            ' Obtener el ID de la solicitud seleccionada
            Dim solicitudID As Integer = Convert.ToInt32(DgvSolicitudes.SelectedRows(0).Cells("SolicitudID").Value)

            ' Eliminar el registro de la base de datos
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()
                Dim query As String = "DELETE FROM solicitudesservicio WHERE SolicitudID = @SolicitudID"
                Using cmd As New MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@SolicitudID", solicitudID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Solicitud eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Actualizar el DataGridView
            CargarSolicitudes()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar la solicitud: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ' Obtener el valor del ComboBox de estado y el valor del TextBox de RUT
        Dim estado As String = CmbEstado.SelectedItem.ToString()
        Dim rut As String = TxtRut.Text.Trim()

        ' Verificar si el ComboBox de estado tiene un valor seleccionado o si el TextBox de RUT tiene un valor
        If String.IsNullOrWhiteSpace(estado) AndAlso String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese un estado o un RUT para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Preparar la consulta dependiendo de si se ha seleccionado un estado o ingresado un RUT
            Dim query As String = "SELECT SolicitudID, Rut, FechaSolicitud, DescripcionProblema, Estado FROM solicitudesservicio WHERE "
            Dim conditions As New List(Of String)

            ' Si se ha seleccionado un estado, añadir condición de búsqueda por estado
            If Not String.IsNullOrWhiteSpace(estado) Then
                conditions.Add("Estado LIKE @Estado")
            End If

            ' Si se ha ingresado un RUT, añadir condición de búsqueda por RUT
            If Not String.IsNullOrWhiteSpace(rut) Then
                conditions.Add("Rut LIKE @Rut")
            End If

            ' Unir las condiciones con "AND" si es necesario
            query &= String.Join(" AND ", conditions)

            ' Consultar la base de datos para filtrar resultados
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()
                Using cmd As New MySqlCommand(query, conexion)
                    ' Agregar parámetros para las condiciones de búsqueda
                    If Not String.IsNullOrWhiteSpace(estado) Then
                        cmd.Parameters.AddWithValue("@Estado", "%" & estado & "%")
                    End If
                    If Not String.IsNullOrWhiteSpace(rut) Then
                        cmd.Parameters.AddWithValue("@Rut", "%" & rut & "%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        ' Mostrar los resultados en el DataGridView
                        DgvSolicitudes.DataSource = table
                    End Using
                End Using
            End Using

            ' Verificar si se encontraron resultados
            If DgvSolicitudes.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron resultados para el criterio ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar las solicitudes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ' Limpiar el ComboBox de estado y el TextBox de RUT
        CmbEstado.SelectedIndex = -1  ' Deseleccionar el ComboBox de estado (sin selección)
        TxtRut.Clear()                ' Limpiar el TextBox de RUT

        ' Cargar todas las solicitudes nuevamente en el DataGridView
        CargarSolicitudes()
    End Sub



End Class