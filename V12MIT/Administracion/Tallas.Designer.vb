<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tallas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tallas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcotacionTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusTallas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BAgregar = New V12MIT.CyButton()
        Me.CyButton2 = New V12MIT.CyButton()
        Me.CyButton3 = New V12MIT.CyButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTallas, Me.NombreTallas, Me.AcotacionTallas, Me.DescTallas, Me.EstatusTallas})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(618, 217)
        Me.DataGridView1.TabIndex = 0
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
        Me.Panel1.Size = New System.Drawing.Size(176, 382)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.V12MIT.My.Resources.Resources.tallas_icon
        Me.PictureBox1.Location = New System.Drawing.Point(62, 301)
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
        'CyButton2
        '
        Me.CyButton2.ColorBorde = System.Drawing.Color.DarkViolet
        Me.CyButton2.FlatAppearance.BorderSize = 0
        Me.CyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyButton2.GrosorBorde = 1
        Me.CyButton2.Location = New System.Drawing.Point(530, 345)
        Me.CyButton2.Name = "CyButton2"
        Me.CyButton2.RedondeadoBorde = 0
        Me.CyButton2.Size = New System.Drawing.Size(100, 30)
        Me.CyButton2.TabIndex = 3
        Me.CyButton2.Text = "CyButton2"
        Me.CyButton2.UseVisualStyleBackColor = True
        '
        'CyButton3
        '
        Me.CyButton3.ColorBorde = System.Drawing.Color.DarkViolet
        Me.CyButton3.FlatAppearance.BorderSize = 0
        Me.CyButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyButton3.GrosorBorde = 1
        Me.CyButton3.Location = New System.Drawing.Point(530, 283)
        Me.CyButton3.Name = "CyButton3"
        Me.CyButton3.RedondeadoBorde = 0
        Me.CyButton3.Size = New System.Drawing.Size(100, 30)
        Me.CyButton3.TabIndex = 4
        Me.CyButton3.Text = "CyButton3"
        Me.CyButton3.UseVisualStyleBackColor = True
        '
        'Tallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 406)
        Me.Controls.Add(Me.CyButton3)
        Me.Controls.Add(Me.CyButton2)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tallas"
        Me.Text = "Administración de Tallas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents idTallas As DataGridViewTextBoxColumn
    Friend WithEvents NombreTallas As DataGridViewTextBoxColumn
    Friend WithEvents AcotacionTallas As DataGridViewTextBoxColumn
    Friend WithEvents DescTallas As DataGridViewTextBoxColumn
    Friend WithEvents EstatusTallas As DataGridViewTextBoxColumn
    Friend WithEvents BAgregar As CyButton
    Friend WithEvents CyButton2 As CyButton
    Friend WithEvents CyButton3 As CyButton
End Class
