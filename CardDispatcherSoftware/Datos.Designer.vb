<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Datos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTarjetasDataSet = New CardDispatcherSoftware.UsuariosTarjetasDataSet()
        Me.UsuariosTableAdapter = New CardDispatcherSoftware.UsuariosTarjetasDataSetTableAdapters.UsuariosTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosTarjetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(917, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 33)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(247, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 458)
        Me.DataGridView1.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox3.Location = New System.Drawing.Point(22, 236)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 22)
        Me.TextBox3.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox2.Location = New System.Drawing.Point(22, 186)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 22)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(22, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(18, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 22)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Última escritura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "CI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(44, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 52)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(44, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 52)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Exportar Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton1.FlatAppearance.BorderSize = 5
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(399, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 26)
        Me.RadioButton1.TabIndex = 30
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nombre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton2.FlatAppearance.BorderSize = 5
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(399, 60)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(103, 26)
        Me.RadioButton2.TabIndex = 31
        Me.RadioButton2.Text = "Apellido"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton3.FlatAppearance.BorderSize = 5
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(533, 22)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(48, 26)
        Me.RadioButton3.TabIndex = 32
        Me.RadioButton3.Text = "CI"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton4.FlatAppearance.BorderSize = 5
        Me.RadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RadioButton4.Location = New System.Drawing.Point(533, 60)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(176, 26)
        Me.RadioButton4.TabIndex = 33
        Me.RadioButton4.Text = "Última Escritura"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(243, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 22)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Búsqueda Por:"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.UsuariosTarjetasDataSet
        '
        'UsuariosTarjetasDataSet
        '
        Me.UsuariosTarjetasDataSet.DataSetName = "UsuariosTarjetasDataSet"
        Me.UsuariosTarjetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(22, 287)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 607)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosTarjetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UsuariosTarjetasDataSet As UsuariosTarjetasDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As UsuariosTarjetasDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
