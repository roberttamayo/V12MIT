Public Class Tallas
    Private Sub Tallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        CargarTallas()
    End Sub
    Sub ResetCampos()
        TBNombre.Text = ""
        TBDesc.Text = ""
        TBAcot.Text = ""
        CTEstatus.Checked = True
        LID.Text = ""
    End Sub
    Sub CargarTallas()
        'Eliminamos el contenido de las filas del datagridview
        DGVTallas.Rows.Clear()
        Dim tallas = MySQL.SelectQuery($"select * from tallas where id_sucursal_FK = {SESION.IdSucursal}")
        While tallas.Read()
            Dim fechatallas As Date = tallas.Item("fecha_marcas")
            DGVTallas.Rows.Add(tallas.Item("id_tallas"), tallas.Item("nombre_talla"), tallas.Item("a_talla"), tallas.Item("anotaciones_tallas"), If(tallas.Item("estatus_tallas") = 1, "Activo", "Eliminado"))
        End While
        MySQL.NextResult()
    End Sub
End Class