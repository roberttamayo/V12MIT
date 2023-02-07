Public Class Marcas
    Sub ResetCampos()
        'regresamos todos los campos a su estado natural
        TBFecha.Texts = ""
        TBHora.Texts = ""
        TBNombre.Texts = ""
        CTEstatus.Checked = True
        LID.Text = ""
    End Sub
    Sub LlenarMarcasDGV()
        'eliminamos el contenido de las filas del DataGridView
        DGVMarcas.Rows.Clear()
        Dim marcas = MySQL.SelectQuery($"select * from marcas where id_sucursal_FK = {SESION.IdSucursal}")
        While marcas.Read()
            Dim fechamarcas As Date = marcas.Item("fecha_marcas")
            DGVMarcas.Rows.Add(marcas.Item("id_marcas"), marcas.Item("nombre_marcas"), If(marcas.Item("estatus_marcas") = 1, "Activo", "Eliminado"), fechamarcas.ToString("yyyy-MM-dd"), marcas.Item("hora_marcas"))
        End While
        MySQL.NextResult()
    End Sub
    Private Sub Marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        LlenarMarcasDGV()
    End Sub
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Close()
    End Sub
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If TBNombre.Texts.Length < 4 Then
            Alertas.Alerta("Los Campos estan vacios o son nulos", "El nombre de la marca no debe estar vacio y debe de tener por lo menos 4 letras")
        Else
            If MySQL.NumRows($"SELECT * FROM marcas where id_sucursal_FK = {SESION.IdSucursal} and nombre_marcas like '{TBNombre.Texts}'") > 0 Then
                'si la busqueda tiene uno o mas resultados el nombre esta duplicado
                Alertas.Alerta("Al parecer los datos estan duplicados", "No e posible continuar ya que el nombre de la marca ya esta en uso o existe otra marca con ese nombre")
            Else
                'si no hay amrcas duplicadas insertamos la marca en la abse de datos
                If MySQL.InsertQuery("INSERT INTO `marcas` (`nombre_marcas`, `estatus_marcas`, `fecha_marcas`, `hora_marcas`, `id_sucursal_FK`) VALUES " +
                                     $"('{TBNombre.Texts}', '{If(CTEstatus.Checked, "1", "0")}', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{SESION.IdSucursal}');") Then
                    'si se inserto correctamente mostramos un mensaje de exito y llenamos el DataGridView
                    Alertas.Check("Marca insertada correctamente", "Se ha insertado correctamente la marca")
                    LlenarMarcasDGV()
                    ResetCampos()
                Else
                    'si no se inserto correctamente mostramos un mensaje de error
                    Alertas.Bug("Error al ratar de insertar la marca", "No se ha podido insertar la marca, ocurrio un error en el servidor")
                End If
            End If
        End If
    End Sub
    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        'verificamos que este una marca seleccionada
        If LID.Text.Length < 1 Then
            'si no hay una marca seleccionada mostramos un mensaje de error
            Alertas.Alerta("No hay ninguna marca seleccionada", "Por favor seleccione una marca para poder actualizar, haciendo doble click sobre ella")
        Else
            'si existe marca seleccionada verificamos que no el campo de  nombre no este vacio
            If TBNombre.Texts.Length < 4 Then
                Alertas.Alerta("los campos estan vacios o son nulos", "Al parecer el campo de nombre de sucursal esta vacio o es nulo, por favor verifique que tenga mas de 4 letras")
            Else
                'si no esta vacio verificamos que no exista una marca con el mismo nombre
                If MySQL.NumRows($"SELECT * FROM marcas where id_sucursal_FK = {SESION.IdSucursal} and nombre_marcas like '{TBNombre.Texts}'") > 0 Then
                    'si la busqueda tiene uno o mas resultados el nombre esta duplicado
                    Alertas.Alerta("Al parecer los datos estan duplicados", "No e posible continuar ya que el nombre de la marca ya esta en uso o existe otra marca con ese nombre")
                Else
                    'si no hay amrcas duplicadas actualizamos la marca en la abse de datos
                    If MySQL.UpdateQuery($"UPDATE `marcas` SET `nombre_marcas` = '{TBNombre.Texts}', `estatus_marcas` = '{If(CTEstatus.Checked, "1", "0")}' WHERE (`id_marcas` = '{LID.Text}');") Then
                        'si se actualizo correctamente mostramos un mensaje de exito y llenamos el DataGridView
                        Alertas.Check("Marca actualizada correctamente", "Se ha actualizado correctamente la marca")
                        LlenarMarcasDGV()
                        ResetCampos()
                    Else
                        'si no se actualizo correctamente mostramos un mensaje de error
                        Alertas.Bug("Error al ratar de actualizar la marca", "No se ha podido actualizar la marca, ocurrio un error en el servidor")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub DGVMarcas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMarcas.CellDoubleClick
        TBNombre.Texts = DGVMarcas.CurrentRow.Cells(1).Value
        TBFecha.Texts = DGVMarcas.CurrentRow.Cells(3).Value
        TBHora.Texts = DGVMarcas.CurrentRow.Cells(4).Value.ToString()
    End Sub
End Class