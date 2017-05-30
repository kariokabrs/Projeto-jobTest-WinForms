Namespace Animais
    Public Class Irracional
        Public nome As String
        Public qualidade As String
        Public Property nome_a() As String
            Get
                Return nome
            End Get
            Set(ByVal value As String)
                nome = value
            End Set
        End Property
        Public Property qualidade_a() As String
            Get
                Return qualidade
            End Get
            Set(ByVal value As String)
                qualidade = value
            End Set
        End Property
    End Class
End Namespace
