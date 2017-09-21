<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.mezcla = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AGG1 = New System.Windows.Forms.TextBox()
        Me.AGG1Peso = New System.Windows.Forms.TextBox()
        Me.AGG1TPh = New System.Windows.Forms.TextBox()
        Me.AGG2TPh = New System.Windows.Forms.TextBox()
        Me.AGG2Peso = New System.Windows.Forms.TextBox()
        Me.AGG2 = New System.Windows.Forms.TextBox()
        Me.AGG3TPh = New System.Windows.Forms.TextBox()
        Me.AGG3Peso = New System.Windows.Forms.TextBox()
        Me.AGG3 = New System.Windows.Forms.TextBox()
        Me.AGG4TPh = New System.Windows.Forms.TextBox()
        Me.AGG4Peso = New System.Windows.Forms.TextBox()
        Me.AGG4 = New System.Windows.Forms.TextBox()
        Me.ACTPh = New System.Windows.Forms.TextBox()
        Me.AC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.editar = New System.Windows.Forms.Button()
        Me.grabar = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.ACPeso = New System.Windows.Forms.NumericUpDown()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status.SuspendLayout()
        CType(Me.ACPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mezcla
        '
        Me.mezcla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mezcla.FormattingEnabled = True
        Me.mezcla.Location = New System.Drawing.Point(89, 34)
        Me.mezcla.Name = "mezcla"
        Me.mezcla.Size = New System.Drawing.Size(472, 24)
        Me.mezcla.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Diseño:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tolva 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tolva 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tolva 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tolva 4:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "% de AC.:"
        '
        'AGG1
        '
        Me.AGG1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG1.Location = New System.Drawing.Point(89, 126)
        Me.AGG1.Name = "AGG1"
        Me.AGG1.Size = New System.Drawing.Size(258, 23)
        Me.AGG1.TabIndex = 7
        '
        'AGG1Peso
        '
        Me.AGG1Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG1Peso.Location = New System.Drawing.Point(354, 126)
        Me.AGG1Peso.Name = "AGG1Peso"
        Me.AGG1Peso.Size = New System.Drawing.Size(100, 23)
        Me.AGG1Peso.TabIndex = 8
        Me.AGG1Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AGG1TPh
        '
        Me.AGG1TPh.Enabled = False
        Me.AGG1TPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG1TPh.Location = New System.Drawing.Point(461, 126)
        Me.AGG1TPh.Name = "AGG1TPh"
        Me.AGG1TPh.Size = New System.Drawing.Size(100, 23)
        Me.AGG1TPh.TabIndex = 9
        '
        'AGG2TPh
        '
        Me.AGG2TPh.Enabled = False
        Me.AGG2TPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG2TPh.Location = New System.Drawing.Point(461, 161)
        Me.AGG2TPh.Name = "AGG2TPh"
        Me.AGG2TPh.Size = New System.Drawing.Size(100, 23)
        Me.AGG2TPh.TabIndex = 12
        '
        'AGG2Peso
        '
        Me.AGG2Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG2Peso.Location = New System.Drawing.Point(354, 161)
        Me.AGG2Peso.Name = "AGG2Peso"
        Me.AGG2Peso.Size = New System.Drawing.Size(100, 23)
        Me.AGG2Peso.TabIndex = 11
        Me.AGG2Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AGG2
        '
        Me.AGG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG2.Location = New System.Drawing.Point(89, 161)
        Me.AGG2.Name = "AGG2"
        Me.AGG2.Size = New System.Drawing.Size(258, 23)
        Me.AGG2.TabIndex = 10
        '
        'AGG3TPh
        '
        Me.AGG3TPh.Enabled = False
        Me.AGG3TPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG3TPh.Location = New System.Drawing.Point(461, 196)
        Me.AGG3TPh.Name = "AGG3TPh"
        Me.AGG3TPh.Size = New System.Drawing.Size(100, 23)
        Me.AGG3TPh.TabIndex = 15
        '
        'AGG3Peso
        '
        Me.AGG3Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG3Peso.Location = New System.Drawing.Point(354, 196)
        Me.AGG3Peso.Name = "AGG3Peso"
        Me.AGG3Peso.Size = New System.Drawing.Size(100, 23)
        Me.AGG3Peso.TabIndex = 14
        Me.AGG3Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AGG3
        '
        Me.AGG3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG3.Location = New System.Drawing.Point(89, 196)
        Me.AGG3.Name = "AGG3"
        Me.AGG3.Size = New System.Drawing.Size(258, 23)
        Me.AGG3.TabIndex = 13
        '
        'AGG4TPh
        '
        Me.AGG4TPh.Enabled = False
        Me.AGG4TPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG4TPh.Location = New System.Drawing.Point(461, 231)
        Me.AGG4TPh.Name = "AGG4TPh"
        Me.AGG4TPh.Size = New System.Drawing.Size(100, 23)
        Me.AGG4TPh.TabIndex = 18
        '
        'AGG4Peso
        '
        Me.AGG4Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG4Peso.Location = New System.Drawing.Point(354, 231)
        Me.AGG4Peso.Name = "AGG4Peso"
        Me.AGG4Peso.Size = New System.Drawing.Size(100, 23)
        Me.AGG4Peso.TabIndex = 17
        Me.AGG4Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AGG4
        '
        Me.AGG4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGG4.Location = New System.Drawing.Point(89, 231)
        Me.AGG4.Name = "AGG4"
        Me.AGG4.Size = New System.Drawing.Size(258, 23)
        Me.AGG4.TabIndex = 16
        '
        'ACTPh
        '
        Me.ACTPh.Enabled = False
        Me.ACTPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACTPh.Location = New System.Drawing.Point(461, 266)
        Me.ACTPh.Name = "ACTPh"
        Me.ACTPh.Size = New System.Drawing.Size(100, 23)
        Me.ACTPh.TabIndex = 21
        '
        'AC
        '
        Me.AC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC.Location = New System.Drawing.Point(89, 266)
        Me.AC.Name = "AC"
        Me.AC.Size = New System.Drawing.Size(258, 23)
        Me.AC.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Nombre del Agregado o Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(362, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "% en Peso"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(463, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "TPH Maxima"
        '
        'editar
        '
        Me.editar.BackColor = System.Drawing.Color.Green
        Me.editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar.ForeColor = System.Drawing.Color.White
        Me.editar.Location = New System.Drawing.Point(355, 304)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(100, 34)
        Me.editar.TabIndex = 25
        Me.editar.Text = "Editar"
        Me.editar.UseVisualStyleBackColor = False
        '
        'grabar
        '
        Me.grabar.BackColor = System.Drawing.Color.Green
        Me.grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grabar.ForeColor = System.Drawing.Color.White
        Me.grabar.Location = New System.Drawing.Point(461, 304)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(100, 34)
        Me.grabar.TabIndex = 26
        Me.grabar.Text = "Grabar"
        Me.grabar.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.label})
        Me.Status.Location = New System.Drawing.Point(0, 354)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(584, 22)
        Me.Status.TabIndex = 27
        Me.Status.Text = "StatusStrip1"
        '
        'ACPeso
        '
        Me.ACPeso.DecimalPlaces = 2
        Me.ACPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACPeso.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ACPeso.Location = New System.Drawing.Point(353, 266)
        Me.ACPeso.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.ACPeso.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.ACPeso.Name = "ACPeso"
        Me.ACPeso.Size = New System.Drawing.Size(101, 23)
        Me.ACPeso.TabIndex = 28
        Me.ACPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ACPeso.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 80)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(545, 3)
        Me.ProgressBar1.TabIndex = 29
        Me.ProgressBar1.Value = 100
        '
        'label
        '
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(121, 17)
        Me.label.Text = "ToolStripStatusLabel1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 376)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ACPeso)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.grabar)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ACTPh)
        Me.Controls.Add(Me.AC)
        Me.Controls.Add(Me.AGG4TPh)
        Me.Controls.Add(Me.AGG4Peso)
        Me.Controls.Add(Me.AGG4)
        Me.Controls.Add(Me.AGG3TPh)
        Me.Controls.Add(Me.AGG3Peso)
        Me.Controls.Add(Me.AGG3)
        Me.Controls.Add(Me.AGG2TPh)
        Me.Controls.Add(Me.AGG2Peso)
        Me.Controls.Add(Me.AGG2)
        Me.Controls.Add(Me.AGG1TPh)
        Me.Controls.Add(Me.AGG1Peso)
        Me.Controls.Add(Me.AGG1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mezcla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diseños de Mezcla Asfáltica"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        CType(Me.ACPeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mezcla As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AGG1 As TextBox
    Friend WithEvents AGG1Peso As TextBox
    Friend WithEvents AGG1TPh As TextBox
    Friend WithEvents AGG2TPh As TextBox
    Friend WithEvents AGG2Peso As TextBox
    Friend WithEvents AGG2 As TextBox
    Friend WithEvents AGG3TPh As TextBox
    Friend WithEvents AGG3Peso As TextBox
    Friend WithEvents AGG3 As TextBox
    Friend WithEvents AGG4TPh As TextBox
    Friend WithEvents AGG4Peso As TextBox
    Friend WithEvents AGG4 As TextBox
    Friend WithEvents ACTPh As TextBox
    Friend WithEvents AC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents editar As Button
    Friend WithEvents grabar As Button
    Friend WithEvents Status As StatusStrip
    Friend WithEvents ACPeso As NumericUpDown
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents label As ToolStripStatusLabel
End Class
