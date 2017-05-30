Imports jogoDosAnimais.Animais
Module Module1
    Public animal1 As Irracional = New Irracional()
    Public animal2 As Irracional = New Irracional()
    Public tipoDados As Integer
    Public Sub Main()
        EntraDados()
    End Sub
    Public Sub EntraDados()
        Select Case tipoDados
            Case 1
                Dim pergunta1 As Object = InputBox("Qual o animal que você pensou?", "Desisto")
                Dim pergunta2 As Object = InputBox("Um(a) " & pergunta1 & "_____ mas um(a) " & animal1.nome & " não.", "Complete")
                animal1.nome = pergunta1
                animal1.qualidade = pergunta2
            Case 2
                Dim pergunta1 As Object = InputBox("Qual o animal que você pensou?", "Desisto")
                Dim pergunta2 As Object = InputBox("Um(a) " & pergunta1 & "_____ mas um(a) " & animal2.nome & " não.", "Complete")
                animal2.nome = pergunta1
                animal2.qualidade = pergunta2
        End Select

    End Sub
    Public Sub DadosInicias()
        animal1.nome = "Tubarão"
        animal2.nome = "Macaco"
        animal1.qualidade = ""
        animal2.qualidade = ""
    End Sub
End Module
