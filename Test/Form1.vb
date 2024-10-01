Public Class Form1
    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim NumeroEstudiantes As Integer
        Dim Nota, Suma, Promedio As Single
        Dim NombreEstudiante As String

        NumeroEstudiantes = TextBoxNumeroEstudiantes.Text

        For i = 1 To NumeroEstudiantes Step 1
            NombreEstudiante = CStr(InputBox("Ingrese el nombre del estudiante " & i))
            Nota = CStr(InputBox("Ingrese la nota del estudiante " & NombreEstudiante))
            Suma += Nota
        Next
        Promedio = Suma / NumeroEstudiantes
        TextBoxPromedio.Text = Promedio

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxNumeroEstudiantes.Text = ""
        TextBoxPromedio.Text = ""
        TextBoxNumeroEstudiantes.Focus()
    End Sub
End Class
