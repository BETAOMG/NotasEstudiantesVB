<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        TextBoxNumeroEstudiantes = New TextBox()
        TextBoxPromedio = New TextBox()
        ButtonCalcular = New Button()
        TextBoxSalida = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 15)
        Label1.TabIndex = 0
        Label1.Text = "Numero de estudiantes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 1
        Label2.Text = "Promedio"
        ' 
        ' TextBoxNumeroEstudiantes
        ' 
        TextBoxNumeroEstudiantes.Location = New Point(262, 37)
        TextBoxNumeroEstudiantes.Name = "TextBoxNumeroEstudiantes"
        TextBoxNumeroEstudiantes.Size = New Size(100, 23)
        TextBoxNumeroEstudiantes.TabIndex = 2
        ' 
        ' TextBoxPromedio
        ' 
        TextBoxPromedio.Location = New Point(262, 74)
        TextBoxPromedio.Name = "TextBoxPromedio"
        TextBoxPromedio.Size = New Size(100, 23)
        TextBoxPromedio.TabIndex = 3
        ' 
        ' ButtonCalcular
        ' 
        ButtonCalcular.Location = New Point(90, 132)
        ButtonCalcular.Name = "ButtonCalcular"
        ButtonCalcular.Size = New Size(75, 23)
        ButtonCalcular.TabIndex = 4
        ButtonCalcular.Text = "Calcular"
        ButtonCalcular.UseVisualStyleBackColor = True
        ' 
        ' TextBoxSalida
        ' 
        TextBoxSalida.Location = New Point(424, 37)
        TextBoxSalida.Multiline = True
        TextBoxSalida.Name = "TextBoxSalida"
        TextBoxSalida.Size = New Size(149, 194)
        TextBoxSalida.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(313, 132)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(205, 132)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Otro"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBoxSalida)
        Controls.Add(ButtonCalcular)
        Controls.Add(TextBoxPromedio)
        Controls.Add(TextBoxNumeroEstudiantes)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNumeroEstudiantes As TextBox
    Friend WithEvents TextBoxPromedio As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents TextBoxSalida As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
