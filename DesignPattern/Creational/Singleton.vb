Namespace Creational

    Public NotInheritable Class Singleton

        Private Sub New()

        End Sub

        Private Shared _instance As Singleton

        Public Shared ReadOnly Property Instance As Singleton
            Get
                If _instance Is Nothing Then
                    _instance = New Singleton()
                End If

                Return _instance
            End Get
        End Property

        Public Function Operation() As String
            Return "Singleton rock!!"
        End Function
    End Class
End Namespace