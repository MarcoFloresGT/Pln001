Public Class Form2
    Dim mezclas As Collection = New Collection()
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim carpeta As String = "c:\planta" 'String.Format("{0}", Environment.CurrentDirectory)

        Using CN As New System.Data.SQLite.SQLiteConnection
            CN.ConnectionString = "DataSource=" + carpeta + "\Planta.db;Version=3;New=False;Compress=True;"
            CN.Open()
            Dim unamezcla As mezcla = New mezcla()

            Using CMD As New Data.SQLite.SQLiteCommand
                With CMD
                    .Connection = CN
                    .CommandText = "select * from mezclas order by case when modificada is null then creada else modificada end;"
                End With
                Using reader As SQLite.SQLiteDataReader = CMD.ExecuteReader()
                    Do While reader.NextResult
                        unamezcla.id = reader.GetInt32(1)
                        unamezcla.nombre = reader.GetInt32(2)
                        unamezcla.Agg1 = reader.GetInt32(3)
                        unamezcla.Agg2 = reader.GetInt32(4)
                        unamezcla.Agg3 = reader.GetInt32(5)
                        unamezcla.Agg4 = reader.GetInt32(6)
                        unamezcla.Ac = reader.GetInt32(7)
                        unamezcla.Agg1Peso = reader.GetFloat(8)
                        unamezcla.Agg2Peso = reader.GetFloat(9)
                        unamezcla.Agg3Peso = reader.GetFloat(10)
                        unamezcla.Agg4Peso = reader.GetFloat(11)
                        unamezcla.AcPeso = reader.GetFloat(12)
                        unamezcla.creada = reader.GetDateTime(13)
                        unamezcla.modificada = reader.GetDateTime(14)
                        unamezcla.enproceso = reader.GetBoolean(15)
                        mezclas.Add(unamezcla)
                        mezcla.Items.Add(unamezcla.nombre)
                        If unamezcla.enproceso Then
                            mezcla.SelectedIndex = mezcla.Items.Count
                        End If
                    Loop
                End Using
            End Using
        End Using
    End Sub

    Private Sub mezcla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mezcla.SelectedIndexChanged
        Dim valor As String = mezcla.Text
        If mezclas.Contains(valor) Then
            Dim unamezcla As mezcla = mezclas.Item(valor)
            AGG1.Text = unamezcla.Agg1
            AGG2.Text = unamezcla.Agg2
            AGG3.Text = unamezcla.Agg3
            AGG4.Text = unamezcla.Agg4
            AGG1Peso.Text = unamezcla.Agg1Peso
            AGG2Peso.Text = unamezcla.Agg2Peso
            AGG3Peso.Text = unamezcla.Agg3Peso
            AGG4Peso.Text = unamezcla.Agg4Peso
            ACPeso.Text = unamezcla.AcPeso
            AC.Text = unamezcla.Ac
            editar.Enabled = True
            grabar.Enabled = False
        End If
    End Sub

    Private Sub mezcla_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mezcla.Validating
        Dim valor As String = mezcla.Text
        Dim pos As Integer = mezcla.FindString(valor)
        If pos < 0 Then
            mezcla.Items.Add(valor)
            mezcla.Refresh()
            Application.DoEvents()
            mezcla.SelectedIndex = mezcla.Items.Count - 1
            Dim unamezcla As mezcla = New mezcla
            unamezcla.nombre = valor
            mezclas.Add(unamezcla, valor)
            AGG1.Text = ""
            AGG2.Text = ""
            AGG3.Text = ""
            AGG4.Text = ""
            AGG1Peso.Text = ""
            AGG2Peso.Text = ""
            AGG3Peso.Text = ""
            AGG4Peso.Text = ""
            AC.Text = ""
            AGG1.Enabled = True
            AGG2.Enabled = True
            AGG3.Enabled = True
            AGG4.Enabled = True
            AGG1Peso.Enabled = False
            AGG2Peso.Enabled = False
            AGG3Peso.Enabled = False
            AGG4Peso.Enabled = False
            ACPeso.Enabled = True
            editar.Enabled = False
            grabar.Enabled = False
        End If

    End Sub

    Private Sub AGG1Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AGG1Peso.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AGG2Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AGG2Peso.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub AGG3Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AGG3Peso.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub AGG4Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AGG4Peso.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub MuestraTotal()
        Dim AGG1P As Integer = 0
        Dim AGG2P As Integer = 0
        Dim AGG3P As Integer = 0
        Dim AGG4P As Integer = 0
        Integer.TryParse(AGG1Peso.Text, AGG1P)
        Integer.TryParse(AGG2Peso.Text, AGG2P)
        Integer.TryParse(AGG3Peso.Text, AGG3P)
        Integer.TryParse(AGG4Peso.Text, AGG4P)
        If AGG1P + AGG2P + AGG3P + AGG4P + ACPeso.Value > 100 Then
            Status.Items.Item(0).Text = "La suma de porcentajes sobrepasa el 100%, Suma: " + Convert.ToString(AGG1P + AGG2P + AGG3P + AGG4P + ACPeso.Value) + " %"
            Status.Items.Item(0).ForeColor = Color.Red
        Else
            Status.Items.Item(0).Text = Convert.ToString(AGG1P + AGG2P + AGG3P + AGG4P + ACPeso.Value) + " %"
            Status.Items.Item(0).ForeColor = Color.Black
        End If
        If AGG1P + AGG2P + AGG3P + AGG4P + ACPeso.Value = 100 Then
            grabar.Enabled = True
        End If
    End Sub
    Private Sub AGG1Peso_TextChanged(sender As Object, e As EventArgs) Handles AGG1Peso.TextChanged
        Dim intValue As Integer = 0
        If Not Integer.TryParse(AGG1Peso.Text, intValue) OrElse intValue < 0 OrElse intValue > 100 Then
            Status.Items.Item(0).Text = "El valor ingresado no es correcto"
            Status.Items.Item(0).ForeColor = Color.Red
        Else
            MuestraTotal()
        End If
    End Sub
    Private Sub AGG2Peso_TextChanged(sender As Object, e As EventArgs) Handles AGG2Peso.TextChanged
        Dim intValue As Integer = 0
        If Not Integer.TryParse(AGG2Peso.Text, intValue) OrElse intValue < 0 OrElse intValue > 100 Then
            Status.Items.Item(0).Text = "El valor ingresado no es correcto"
            Status.Items.Item(0).ForeColor = Color.Red
        Else
            MuestraTotal()
        End If
    End Sub

    Private Sub AGG3Peso_TextChanged(sender As Object, e As EventArgs) Handles AGG3Peso.TextChanged
        Dim intValue As Integer = 0
        If Not Integer.TryParse(AGG3Peso.Text, intValue) OrElse intValue < 0 OrElse intValue > 100 Then
            Status.Items.Item(0).Text = "El valor ingresado no es correcto"
            Status.Items.Item(0).ForeColor = Color.Red
        Else
            MuestraTotal()
        End If
    End Sub

    Private Sub AGG4Peso_TextChanged(sender As Object, e As EventArgs) Handles AGG4Peso.TextChanged
        Dim intValue As Integer = 0
        If Not Integer.TryParse(AGG4Peso.Text, intValue) OrElse intValue < 0 OrElse intValue > 100 Then
            Status.Items.Item(0).Text = "El valor ingresado no es correcto"
            Status.Items.Item(0).ForeColor = Color.Red
        Else
            MuestraTotal()
        End If
    End Sub

    Private Sub AGG1_TextChanged(sender As Object, e As EventArgs) Handles AGG1.TextChanged
        If AGG1.Text.Length > 0 Then
            AGG1Peso.Enabled = True
        Else
            AGG1Peso.Enabled = False
            AGG1Peso.Text = ""
        End If
    End Sub

    Private Sub AGG2_TextChanged(sender As Object, e As EventArgs) Handles AGG2.TextChanged
        If AGG2.Text.Length > 0 Then
            AGG2Peso.Enabled = True
        Else
            AGG2Peso.Enabled = False
            AGG2Peso.Text = ""
        End If

    End Sub

    Private Sub AGG3_TextChanged(sender As Object, e As EventArgs) Handles AGG3.TextChanged
        If AGG3.Text.Length > 0 Then
            AGG3Peso.Enabled = True
        Else
            AGG3Peso.Enabled = False
            AGG3Peso.Text = ""
        End If

    End Sub

    Private Sub AGG4_TextChanged(sender As Object, e As EventArgs) Handles AGG4.TextChanged
        If AGG4.Text.Length > 0 Then
            AGG4Peso.Enabled = True
        Else
            AGG4Peso.Enabled = False
            AGG4Peso.Text = ""
        End If

    End Sub

    Private Sub grabar_Click(sender As Object, e As EventArgs) Handles grabar.Click
        Dim carpeta As String = "c:\planta" 'String.Format("{0}", Environment.CurrentDirectory)
        Dim valor As String = mezcla.Text
        Dim AGG1P As Integer = 0
        Dim AGG2P As Integer = 0
        Dim AGG3P As Integer = 0
        Dim AGG4P As Integer = 0
        Integer.TryParse(AGG1Peso.Text, AGG1P)
        Integer.TryParse(AGG2Peso.Text, AGG2P)
        Integer.TryParse(AGG3Peso.Text, AGG3P)
        Integer.TryParse(AGG4Peso.Text, AGG4P)
        If mezclas.Contains(valor) Then
            Dim unamezcla As mezcla = mezclas.Item(valor)
            unamezcla.nombre = valor
            unamezcla.Agg1 = AGG1.Text
            unamezcla.Agg2 = AGG2.Text
            unamezcla.Agg3 = AGG3.Text
            unamezcla.Agg4 = AGG4.Text
            unamezcla.Ac = AC.Text
            unamezcla.Agg1Peso = AGG1P
            unamezcla.Agg2Peso = AGG2P
            unamezcla.Agg3Peso = AGG3P
            unamezcla.Agg4Peso = AGG4P
            unamezcla.AcPeso = ACPeso.Value
            Using CN As New System.Data.SQLite.SQLiteConnection
                CN.ConnectionString = "DataSource=" + carpeta + "\Planta.db;Version=3;New=False;Compress=True;"
                CN.Open()

                Using CMD As New Data.SQLite.SQLiteCommand
                    With CMD
                        .Connection = CN
                        .CommandText = "select * from mezclas order by case when modificada is null then creada else modificada end;"
                    End With
                End Using
            End Using
        End If
    End Sub
End Class