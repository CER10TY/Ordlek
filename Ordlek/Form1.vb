Public Class formMain
    ' Global vars
    Const antal_ord = 815 - 1
    Dim alla_ord(antal_ord) As String
    Dim ord_index As Integer
    Dim poang_ord As Integer
    Dim grans As Integer
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Variabler
        Dim fil As String = (Application.StartupPath & "\ordlista.txt") ' StartupPath is \Ordlek\bin\Debug
        Dim ord As String
        Dim index As Integer

        ' Koden kommer endast kör om filen finns
        If Dir(fil) <> "" Then
            ' Öppna filen
            FileOpen(1, fil, OpenMode.Input)
            Do While Not EOF(1)
                ord = LineInput(1)
                alla_ord(index) = ord
                index += 1
            Loop
            FileClose(1)
        Else
            Beep()
            MsgBox("Kan inte hitta filen!", vbExclamation, "Fel!")
        End If

        ' Init randomizer
        Randomize()
    End Sub
    Sub Nytt_ord()
        ' Vars
        Dim slump As Integer
        Dim slump_max As Integer
        Dim slump_min As Integer
        Dim krypto As String
        Dim temp As String

        ' Nytt index för att välja ut ordet
        ord_index = antal_ord * Rnd()

        ' Tilldela ordet till temp
        temp = Trim(alla_ord(ord_index))

        ' Sätt min/max gräns på vart ordet ska skäras och slumpas
        slump_min = 2
        slump_max = Len(temp) - 1

        ' Slumpa fram vart ordet ska skäras
        slump = Int((slump_max - slump_min + 1) * Rnd() + slump_min)

        ' Skär ordet, vänd på det och tilldela till var krypto
        krypto = Microsoft.VisualBasic.Mid(temp, slump) + Microsoft.VisualBasic.Left(temp, slump - 1) ' Måste använda Microsoft.VisualBasic.Left eftersom bara Left är en annan funktion

        ' Visa ordet
        lblOrd.Text = krypto.ToString()
        txtGissa.Text = ""
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Init vars
        poang_ord = 0
        grans = 20
        lblGrans.Text = "20"
        lblPoang.Text = "0"
        lblTid.Text = "60"

        ' Enable buttons
        btnKontroll.Enabled = True
        btnHoppa.Enabled = True

        ' Starta timern
        timTid.Enabled = True

        ' Visa nytt ord
        Nytt_ord()
    End Sub

    Private Sub btnAvsluta_Click(sender As Object, e As EventArgs) Handles btnAvsluta.Click
        Application.Exit()
    End Sub

    Private Sub btnHoppa_Click(sender As Object, e As EventArgs) Handles btnHoppa.Click
        Nytt_ord()
    End Sub

    Private Sub btnKontroll_Click(sender As Object, e As EventArgs) Handles btnKontroll.Click
        If LCase(Trim(alla_ord(ord_index))) = LCase(Trim(txtGissa.Text)) Then
            ' Om lika så visa vi ett nytt ord och öka poängen
            Nytt_ord()
            ' Öka poängen
            poang_ord += Len(Trim(alla_ord(ord_index)))
            ' Visa nya poängen
            lblPoang.Text = Str(poang_ord)
        Else
            Beep() ' Om inte lika
        End If
    End Sub

    Private Sub timTid_Tick(sender As Object, e As EventArgs) Handles timTid.Tick
        ' Visa nya tiden varje tick
        lblTid.Text = Str(Val(lblTid.Text) - 1)

        ' Kolla om tiden = 0
        If Val(lblTid.Text) = 0 Then
            ' Öka med 10 poäng och ger 60 sek om spelaren har 20 eller mer poäng (dvs bonusgränsen är nådd)
            If poang_ord >= Val(lblGrans.Text) Then
                grans += 10
                lblGrans.Text = Str(grans + poang_ord)
                lblTid.Text = "60"
            Else
                ' Om spelaren inte har >=20 poäng avslutas spelet.
                btnKontroll.Enabled = False
                btnHoppa.Enabled = False
                timTid.Enabled = False
                Beep()
                MsgBox("Spelet har avslutats eftersom du inte nådde gränsen!", vbInformation, "Avslutat Spelet!")
            End If
        End If
    End Sub
End Class
