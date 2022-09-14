Public Class UsuariosAdmin
    Sub CargarUsuarios()
        Dim usuariosInfo = MySQL.SelectQuery($"SELECT * FROM usuarios u inner join rol_usuarios r on u.id_rol_usuarios_FK = r.id_rol_usuarios where u.id_sucursal_FK = {SESION.IdSucursal}")
        DGVUsuarios.Rows.Clear()
        While usuariosInfo.Read()
            DGVUsuarios.Rows.Add(usuariosInfo.Item("id_usuarios"), usuariosInfo.Item("nombre_usuarios"), usuariosInfo.Item("apellidos_usuarios"), usuariosInfo.Item("nick_usuarios"), usuariosInfo.Item("email_usuarios"), usuariosInfo.Item("telefono_usuarios"),
                                 If(usuariosInfo.Item("estatus") = 1, "Activo", "Eliminado"), usuariosInfo.Item("contra_usuarios"), usuariosInfo.Item("fecha_c_usuarios"),
                                 usuariosInfo.Item("fecha_m_usuarios"), usuariosInfo.Item("hora_c_usuarios"), usuariosInfo.Item("hora_m_usuarios"), usuariosInfo.Item("nombre_rol_usuarios"))
        End While
        MySQL.NextResult()
    End Sub
    Sub Resetcampos()
        CyTextBoxNombre.Texts = ""
        CyTextBoxApellidos.Texts = ""
        CyTextBoxEmail.Texts = ""
        CyTextBoxNick.Texts = ""
        CyTextBoxTelefono.Texts = ""
        CyTextBoxContra.Texts = ""
        CyComboBoxRol.SelectedItem = Nothing
        CyComboBoxRol.SelectedText = ""
        CyTogleEstatus.Checked = True
        CyTextBoxFechaC.Texts = ""
        CyTextBoxHoraC.Texts = ""
        CyTextBoxFechaM.Texts = ""
        CyTextBoxHoraM.Texts = ""
        LabelIdUsuario.Text = ""
    End Sub
    Private Sub UsuariosAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        CargarUsuarios()
        'cargamos los roles de usuario
        Dim roles = MySQL.SelectQuery($"SELECT * FROM rol_usuarios where id_sucursal_FK = {SESION.IdSucursal}")
        While roles.Read
            CyComboBoxRol.Items.Add(roles("nombre_rol_usuarios"))
        End While
        MySQL.NextResult()
    End Sub
    Private Sub DGVUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.CellDoubleClick
        'colocamos la informacion de cell seleccionado en los textbox y campos
        LabelIdUsuario.Text = DGVUsuarios.CurrentRow.Cells(0).Value
        CyTextBoxNombre.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(1).Value
        CyTextBoxApellidos.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(2).Value
        CyTextBoxNick.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(3).Value
        CyTextBoxEmail.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(4).Value
        CyTextBoxTelefono.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(5).Value
        CyTextBoxContra.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(7).Value
        CyComboBoxRol.SelectedItem = DGVUsuarios.Rows(e.RowIndex).Cells(12).Value
        CyTogleEstatus.Checked = DGVUsuarios.Rows(e.RowIndex).Cells(6).Value = "Activo"
        Dim fecha As Date = DGVUsuarios.Rows(e.RowIndex).Cells(8).Value
        CyTextBoxFechaC.Texts = fecha.ToString("yyyy-MM-dd")
        CyTextBoxHoraC.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(10).Value.ToString()
        fecha = DGVUsuarios.Rows(e.RowIndex).Cells(9).Value.ToString()
        CyTextBoxFechaM.Texts = fecha.ToString("yyyy-MM-dd")
        CyTextBoxHoraM.Texts = DGVUsuarios.Rows(e.RowIndex).Cells(11).Value.ToString()
    End Sub
    Private Sub CyButtonCancelar_Click(sender As Object, e As EventArgs) Handles CyButtonCancelar.Click
        Close()
    End Sub
    Private Sub CyButtonAgregar_Click(sender As Object, e As EventArgs) Handles CyButtonAgregar.Click
        'verificamos que los campos no esten vacios
        If CyTextBoxNombre.Texts.Length < 4 Or CyTextBoxApellidos.Texts.Length < 8 Or CyTextBoxNick.Texts.Length < 5 Or CyTextBoxEmail.Texts.Length < 10 Or CyTextBoxTelefono.Texts.Length < 10 Or CyTextBoxContra.Texts.Length < 8 Then
            Alertas.Alerta("Campos vacíos o muy cortos", "Los campos no pueden estar vacios o los campos deben tener al menos 4 caracteres")
            Exit Sub
        Else
            If CyComboBoxRol.SelectedItem Is Nothing Then
                Alertas.Alerta("Se debe seleccionar un rol para el usuario", "Se debe seleccionar un rol para el usuario para poder agregar un nuevo usuario")
                Exit Sub
            Else
                'si no hay campos vacios y se selecciono un rol de usuario continuamos con el proceso
                Dim duplicados = MySQL.NumRows($"SELECT * FROM usuarios where nick_usuarios like '{CyTextBoxNick.Texts}' or email_usuarios like '{CyTextBoxEmail.Texts}' and id_sucursal_FK = {SESION.IdSucursal}")
                If duplicados > 0 Then
                    'si hay datos duplicados mandamos alertas
                    Alertas.Alerta("Ya hay un usuario con estos datos", "No es posible agregar el usuario ya ue su nick y su email ya estan siendo utilizados")
                    Exit Sub
                Else
                    'si no estan duplicados los datos agregamos al usuario nuevo
                    Dim nforol = MySQL.SelectQuery($"select * from rol_usuarios where id_sucursal_FK = {SESION.IdSucursal} and nombre_rol_usuarios = '{CyComboBoxRol.SelectedItem}'")
                    nforol.Read()
                    Dim idrol = nforol.Item("id_rol_usuarios")
                    MySQL.NextResult()
                    Dim query = "INSERT INTO `usuarios` (`nombre_usuarios`, `apellidos_usuarios`, `nick_usuarios`, `contra_usuarios`, `telefono_usuarios`, `email_usuarios`, `estatus`, `fecha_c_usuarios`, `fecha_m_usuarios`, `hora_c_usuarios`, `hora_m_usuarios`, `id_sucursal_FK`, `id_rol_usuarios_FK`)" +
                                $"VALUES ('{CyTextBoxNombre.Texts()}', '{CyTextBoxApellidos.Texts()}', '{CyTextBoxNick.Texts()}', '{CyTextBoxContra.Texts()}', '{CyTextBoxTelefono.Texts()}'," +
                                $" '{CyTextBoxEmail.Texts()}', '{If(CyTogleEstatus.Checked, "1", "0")}', '{MySQL.FechaMySQL()}', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{MySQL.HoraMySQL()}', '{SESION.IdSucursal}', '{idrol}');"
                    If MySQL.InsertQuery(query) Then
                        CargarUsuarios()
                        Resetcampos()
                        Alertas.Check("Usuario Agregado", "el usuario ha sido agregado correctamente")
                    Else
                        Alertas.Bug("Ocurrio un error al tratar de agregar al usuario", "Ocurrio un error al tratar de agregar al usuario contacte al administrador del sistema")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub CyButtonActualizar_Click(sender As Object, e As EventArgs) Handles CyButtonActualizar.Click
        If LabelIdUsuario.Text.Length < 1 Then
            'si no hay un usuario seleccionado mandamos alertas
            Alertas.Alerta("No hay usuario seleccionado", "No hay usuario seleccionado para poder actualizar")
        Else
            'si hay un usuario seleccionado continuamos con el proceso
            If CyTextBoxNombre.Texts.Length < 4 Or CyTextBoxApellidos.Texts.Length < 8 Or CyTextBoxNick.Texts.Length < 5 Or CyTextBoxEmail.Texts.Length < 10 Or CyTextBoxTelefono.Texts.Length < 10 Or CyTextBoxContra.Texts.Length < 8 Then
                'si hay campos vacios o cortos mandamos alertas
                Alertas.Alerta("Campos vacíos o muy cortos", "Los campos no pueden estar vacios o los campos siempre deben tener al menos 4 caracteres")
            Else
                'verificamos que no esten datos duplicados
                If MySQL.NumRows($"select * from usuarios where nick_usuarios like '{CyTextBoxNick.Texts()}' and email_usuarios like '{CyTextBoxEmail.Texts()}' and id_sucursal_FK = {SESION.IdSucursal} and id_usuarios != {LabelIdUsuario.Text()}") > 0 Then
                    Alertas.Alerta("Ya hay un usuario con estos datos", "No es posible actualizar el usuario ya ue su nick y su email ya estan siendo utilizados")
                Else
                    'si no hay datos duplicados actualizamos
                    Dim nforol = MySQL.SelectQuery($"select * from rol_usuarios where id_sucursal_FK = {SESION.IdSucursal} and nombre_rol_usuarios = '{CyComboBoxRol.SelectedItem}'")
                    nforol.Read()
                    Dim idrol = nforol.Item("id_rol_usuarios")
                    MySQL.NextResult()
                    If MySQL.UpdateQuery($"UPDATE `usuarios` SET `nombre_usuarios` = '{CyTextBoxNombre.Texts()}', `apellidos_usuarios` = '{CyTextBoxApellidos.Texts()}', `nick_usuarios` = '{CyTextBoxNick.Texts()}', `contra_usuarios` = '{CyTextBoxContra.Texts()}', `telefono_usuarios` = '{CyTextBoxTelefono.Texts()}', `email_usuarios` = '{CyTextBoxEmail.Texts()}', `estatus` = '{If(CyTogleEstatus.Checked, "1", "0")}', `fecha_m_usuarios` = '{MySQL.FechaMySQL()}', `hora_m_usuarios` = '{MySQL.HoraMySQL()}', `id_rol_usuarios_FK` = '{idrol}' WHERE (`id_usuarios` = '{LabelIdUsuario.Text()}');") Then
                        CargarUsuarios()
                        Resetcampos()
                        Alertas.Check("Usuario Actualizado", "el usuario ha sido actualizado correctamente")
                    Else
                        Alertas.Bug("Ocurrio un error al tratar de actualizar al usuario", "Ocurrio un error al tratar de actualizar al usuario contacte al administrador del sistema")
                    End If
                End If
            End If
        End If
    End Sub
End Class