Public Class MainForm
    Public paso As Integer
    Public banda As Boolean
    Public bomba As Boolean
    Public barril As Boolean
    Public ventilador As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.ShowDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banda = False
        bomba = False
        Dim carpeta As String
        carpeta = "c:\Planta" '  String.Format("{0}", Environment.CurrentDirectory)
        If Not My.Computer.FileSystem.FileExists(carpeta + "\Planta.db") Then
            System.Data.SQLite.SQLiteConnection.CreateFile(carpeta + "\Planta.db")
            Using CN As New SQLite.SQLiteConnection
                CN.ConnectionString = "DataSource=" + carpeta + "\Planta.db;Version=3;New=False;Compress=True;"
                CN.Open()
                Using CMD As New Data.SQLite.SQLiteCommand
                    With CMD
                        .Connection = CN
                        .CommandText = "Create table mezclas(nombre varchar(50), AGG1 varchar(50), AGG2 varchar(50), AGG3 varchar(50), AGG4 varchar(50),AC varchar(50), AGG1Peso real, AGG2Peso real, AGG3Peso real, AGG4Peso real, ACPeso real,creada integer,modificada integer,enproceso integer);"
                    End With
                    CMD.ExecuteNonQuery()
                    CMD.CommandText = "Create table humedades(mezcla integer,hora integer,AGG1 real,AGG2 real,AGG3 real,AGG4 real);"
                    CMD.ExecuteNonQuery()
                End Using
                CN.Close()
            End Using
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        paso = paso + 1
        If paso = 6 Then paso = 1
        If bomba Then
            If paso = 1 Then PictureBox13.Image = Planta.My.Resources.Pump_b_sm_f1
            If paso = 2 Then PictureBox13.Image = Planta.My.Resources.Pump_b_sm_f2
            If paso = 3 Then PictureBox13.Image = Planta.My.Resources.Pump_b_sm_f3
            If paso = 4 Then PictureBox13.Image = Planta.My.Resources.Pump_b_sm_f4
            If paso = 5 Then PictureBox13.Image = Planta.My.Resources.Pump_b_sm_f5
        End If

        If banda Then
            If paso = 1 Then PictureBox14.Image = Planta.My.Resources.Celda1
            If paso = 2 Then PictureBox14.Image = Planta.My.Resources.Celda2
            If paso = 3 Then PictureBox14.Image = Planta.My.Resources.Celda3
            If paso = 4 Then PictureBox14.Image = Planta.My.Resources.Celda4
            If paso = 5 Then PictureBox14.Image = Planta.My.Resources.Celda5
        End If
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = 112) Then
            Form1.Show()
        End If
        If (e.KeyCode = 113) Then
            Form2.Show()
        End If
        If (e.KeyCode = 114) Then
            Form3.Show()
        End If
        If (e.KeyCode = 115) Then
            Form4.Show()
        End If
        If (e.KeyCode = 116) Then
            Form1.Show()
        End If
        If (e.KeyCode = 117) Then
            Form1.Show()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("ADVERTENCIA: Desea poner los valores acumulados de producción en cero?", MsgBoxStyle.YesNoCancel)
    End Sub
End Class
