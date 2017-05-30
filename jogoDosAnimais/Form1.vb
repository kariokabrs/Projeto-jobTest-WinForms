Imports jogoDosAnimais.Animais
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Focus()
        DadosInicias()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msgbox_acertei As String = "Acertei de novo!"
        Dim msgbox_titulo As String = "jogoDosAnimais"
        Dim confirm As String = "Confirm"
        Dim valid As Integer = 0
        Do Until valid = 1
            If MessageBox.Show("O animal que você pensou vive na água ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = vbYes Then
                tipoDados = 1
                If animal1.qualidade = "" Then
                    If MessageBox.Show("O animal que você pensou é " & animal1.nome & " ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        MessageBox.Show(msgbox_acertei, msgbox_titulo, MessageBoxButtons.OK)
                        valid = 1
                    Else
                        valid = 1
                        Main()
                    End If
                Else
                    If MessageBox.Show("O animal que você pensou " & animal1.qualidade & " ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If MessageBox.Show("O animal que você pensou é " & animal1.nome & " ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            MessageBox.Show(msgbox_acertei, msgbox_titulo, MessageBoxButtons.OK)
                            valid = 1
                        Else
                            valid = 1
                            Main()
                        End If
                    Else
                        If MessageBox.Show("O animal que você pensou é Tubarão?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            MessageBox.Show(msgbox_acertei, msgbox_titulo, MessageBoxButtons.OK)
                            valid = 1
                        Else
                            valid = 1
                            Main()
                        End If
                    End If
                End If
            Else
                tipoDados = 2
                If animal2.qualidade = "" Then
                    If MessageBox.Show("O animal que você pensou é " & animal2.nome & " ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        MessageBox.Show(msgbox_acertei, msgbox_titulo, MessageBoxButtons.OK)
                        valid = 1
                    Else
                        valid = 1
                        Main()
                    End If
                Else
                    If MessageBox.Show("O animal que você pensou " & animal2.qualidade & " ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If MessageBox.Show("O animal que você pensou é " & animal2.nome & " ?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            MessageBox.Show(msgbox_acertei, msgbox_titulo, MessageBoxButtons.OK)
                            valid = 1
                        Else
                            valid = 1
                            Main()
                        End If
                    Else
                        If MessageBox.Show("O animal que você pensou é Macaco?", confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                            MessageBox.Show(msgbox_acertei, msgbox_titulo, MessageBoxButtons.OK)
                            valid = 1
                        Else
                            valid = 1
                            Main()
                        End If
                    End If
                End If
            End If
        Loop
    End Sub
End Class



