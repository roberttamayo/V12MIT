<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tallas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tallas))
        Me.DGVTallas = New System.Windows.Forms.DataGridView()
        Me.idTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcotacionTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BAgregar = New V12MIT.CyButton()
        Me.BCancelar = New V12MIT.CyButton()
        Me.BActualizar = New V12MIT.CyButton()
        Me.TBNombre = New V12MIT.CyTextBox()
        Me.TBDesc = New V12MIT.CyTextBox()
        Me.TBAcot = New V12MIT.CyTextBox()
        Me.CTEstatus = New V12MIT.CyTogle_()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LDesc = New System.Windows.Forms.Label()
        Me.LAcot = New System.Windows.Forms.Label()
        Me.LEstatus = New System.Windows.Forms.Label()
        Me.LID = New System.Windows.Forms.Label()
        CType(Me.DGVTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTallas
        '
        Me.DGVTallas.AllowUserToAddRows = False
        Me.DGVTallas.AllowUserToDeleteRows = False
        Me.DGVTallas.AllowUserToOrderColumns = True
        Me.DGVTallas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DGVTallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTallas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTallas, Me.NombreTallas, Me.AcotacionTallas, Me.DescTallas, Me.EstatusTallas})
        Me.DGVTallas.Location = New System.Drawing.Point(12, 12)
        Me.DGVTallas.Name = "DGVTallas"
        Me.DGVTallas.ReadOnly = True
        Me.DGVTallas.RowTemplate.Height = 25
        Me.DGVTallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTallas.Size = New System.Drawing.Size(618, 217)
        Me.DGVTallas.TabIndex = 0
        '
        'idTallas
        '
        Me.idTallas.HeaderText = "IdTallas"
        Me.idTallas.Name = "idTallas"
        Me.idTallas.ReadOnly = True
        Me.idTallas.Visible = False
        '
        'NombreTallas
        '
        Me.NombreTallas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreTallas.HeaderText = "Nombre"
        Me.NombreTallas.Name = "NombreTallas"
        Me.NombreTallas.ReadOnly = True
        '
        'AcotacionTallas
        '
        Me.AcotacionTallas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AcotacionTallas.HeaderText = "Acotacion"
        Me.AcotacionTallas.Name = "AcotacionTallas"
        Me.AcotacionTallas.ReadOnly = True
        '
        'DescTallas
        '
        Me.DescTallas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescTallas.HeaderText = "Descripcion"
        Me.DescTallas.Name = "DescTallas"
        Me.DescTallas.ReadOnly = True
        '
        'EstatusTallas
        '
        Me.EstatusTallas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EstatusTallas.HeaderText = "Estatus"
        Me.EstatusTallas.Name = "EstatusTallas"
        Me.EstatusTallas.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(636, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 382)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.V12MIT.My.Resources.Resources.tallas_icon
        Me.PictureBox1.Location = New System.Drawing.Point(95, 290)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAgregar.ColorBorde = System.Drawing.Color.DarkBlue
        Me.BAgregar.FlatAppearance.BorderSize = 0
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAgregar.GrosorBorde = 1
        Me.BAgregar.Location = New System.Drawing.Point(530, 247)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.RedondeadoBorde = 0
        Me.BAgregar.Size = New System.Drawing.Size(100, 30)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.ColorBorde = System.Drawing.Color.Maroon
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.GrosorBorde = 1
        Me.BCancelar.Location = New System.Drawing.Point(530, 345)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.RedondeadoBorde = 0
        Me.BCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BCancelar.TabIndex = 3
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BActualizar
        '
        Me.BActualizar.BackColor = System.Drawing.Color.Fuchsia
        Me.BActualizar.ColorBorde = System.Drawing.Color.Purple
        Me.BActualizar.FlatAppearance.BorderSize = 0
        Me.BActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BActualizar.GrosorBorde = 1
        Me.BActualizar.Location = New System.Drawing.Point(530, 283)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.RedondeadoBorde = 0
        Me.BActualizar.Size = New System.Drawing.Size(100, 30)
        Me.BActualizar.TabIndex = 4
        Me.BActualizar.Text = "Actualizar"
        Me.BActualizar.UseVisualStyleBackColor = False
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBNombre.BordeSubrrayado = True
        Me.TBNombre.ColorBorde = System.Drawing.Color.Blue
        Me.TBNombre.ColorFocus = System.Drawing.Color.Red
        Me.TBNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBNombre.GrosorBorde = 1
        Me.TBNombre.Location = New System.Drawing.Point(24, 267)
        Me.TBNombre.MultilineText = False
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Padding = New System.Windows.Forms.Padding(7)
        Me.TBNombre.PassWordChar = False
        Me.TBNombre.PlaceHolder = ""
        Me.TBNombre.Size = New System.Drawing.Size(200, 34)
        Me.TBNombre.TabIndex = 12
        Me.TBNombre.Texts = ""
        '
        'TBDesc
        '
        Me.TBDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBDesc.BordeSubrrayado = True
        Me.TBDesc.ColorBorde = System.Drawing.Color.Blue
        Me.TBDesc.ColorFocus = System.Drawing.Color.Red
        Me.TBDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBDesc.GrosorBorde = 1
        Me.TBDesc.Location = New System.Drawing.Point(279, 267)
        Me.TBDesc.MultilineText = False
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Padding = New System.Windows.Forms.Padding(7)
        Me.TBDesc.PassWordChar = False
        Me.TBDesc.PlaceHolder = ""
        Me.TBDesc.Size = New System.Drawing.Size(200, 34)
        Me.TBDesc.TabIndex = 13
        Me.TBDesc.Texts = ""
        '
        'TBAcot
        '
        Me.TBAcot.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBAcot.BordeSubrrayado = True
        Me.TBAcot.ColorBorde = System.Drawing.Color.Blue
        Me.TBAcot.ColorFocus = System.Drawing.Color.Red
        Me.TBAcot.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBAcot.GrosorBorde = 1
        Me.TBAcot.Location = New System.Drawing.Point(24, 338)
        Me.TBAcot.MultilineText = False
        Me.TBAcot.Name = "TBAcot"
        Me.TBAcot.Padding = New System.Windows.Forms.Padding(7)
        Me.TBAcot.PassWordChar = False
        Me.TBAcot.PlaceHolder = ""
        Me.TBAcot.Size = New System.Drawing.Size(41, 34)
        Me.TBAcot.TabIndex = 14
        Me.TBAcot.Texts = ""
        '
        'CTEstatus
        '
        Me.CTEstatus.AutoSize = True
        Me.CTEstatus.Checked = True
        Me.CTEstatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CTEstatus.ColorFondoOff = System.Drawing.Color.Gray
        Me.CTEstatus.ColorFondoOn = System.Drawing.Color.SpringGreen
        Me.CTEstatus.ColorSolido = True
        Me.CTEstatus.ColorToggleOff = System.Drawing.Color.Gainsboro
        Me.CTEstatus.ColorToggleOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CTEstatus.Location = New System.Drawing.Point(172, 350)
        Me.CTEstatus.MinimumSize = New System.Drawing.Size(52, 22)
        Me.CTEstatus.Name = "CTEstatus"
        Me.CTEstatus.Size = New System.Drawing.Size(52, 22)
        Me.CTEstatus.TabIndex = 15
        Me.CTEstatus.UseVisualStyleBackColor = True
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(12, 245)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(62, 19)
        Me.LNombre.TabIndex = 17
        Me.LNombre.Text = "Nombre:"
        '
        'LDesc
        '
        Me.LDesc.AutoSize = True
        Me.LDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LDesc.ForeColor = System.Drawing.Color.White
        Me.LDesc.Location = New System.Drawing.Point(279, 245)
        Me.LDesc.Name = "LDesc"
        Me.LDesc.Size = New System.Drawing.Size(82, 19)
        Me.LDesc.TabIndex = 18
        Me.LDesc.Text = "Descripción:"
        '
        'LAcot
        '
        Me.LAcot.AutoSize = True
        Me.LAcot.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LAcot.ForeColor = System.Drawing.Color.White
        Me.LAcot.Location = New System.Drawing.Point(12, 316)
        Me.LAcot.Name = "LAcot"
        Me.LAcot.Size = New System.Drawing.Size(72, 19)
        Me.LAcot.TabIndex = 19
        Me.LAcot.Text = "Acotación:"
        '
        'LEstatus
        '
        Me.LEstatus.AutoSize = True
        Me.LEstatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LEstatus.ForeColor = System.Drawing.Color.White
        Me.LEstatus.Location = New System.Drawing.Point(172, 328)
        Me.LEstatus.Name = "LEstatus"
        Me.LEstatus.Size = New System.Drawing.Size(56, 19)
        Me.LEstatus.TabIndex = 20
        Me.LEstatus.Text = "Estatus:"
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LID.ForeColor = System.Drawing.Color.White
        Me.LID.Location = New System.Drawing.Point(304, 345)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(84, 19)
        Me.LID.TabIndex = 21
        Me.LID.Text = "ID no visible"
        Me.LID.Visible = False
        '
        'Tallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 406)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.LEstatus)
        Me.Controls.Add(Me.LAcot)
        Me.Controls.Add(Me.LDesc)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.CTEstatus)
        Me.Controls.Add(Me.TBAcot)
        Me.Controls.Add(Me.TBDesc)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.BActualizar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVTallas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tallas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Tallas"
        CType(Me.DGVTallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVTallas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents idTallas As DataGridViewTextBoxColumn
    Friend WithEvents NombreTallas As DataGridViewTextBoxColumn
    Friend WithEvents AcotacionTallas As DataGridViewTextBoxColumn
    Friend WithEvents DescTallas As DataGridViewTextBoxColumn
    Friend WithEvents EstatusTallas As DataGridViewTextBoxColumn
    Friend WithEvents BAgregar As CyButton
    Friend WithEvents BCancelar As CyButton
    Friend WithEvents BActualizar As CyButton
    Friend WithEvents TBNombre As CyTextBox
    Friend WithEvents TBDesc As CyTextBox
    Friend WithEvents TBAcot As CyTextBox
    Friend WithEvents CTEstatus As CyTogle_
    Friend WithEvents LNombre As Label
    Friend WithEvents LDesc As Label
    Friend WithEvents LAcot As Label
    Friend WithEvents LEstatus As Label
    Friend WithEvents LID As Label
End Class
