Namespace Creational
    Public Class SimpleFactory
        Public Class Chocolate
            Public Property Ingredient As String

            Public Function Taste() As String
                Return "Sweet with " & Ingredient
            End Function
        End Class

        Public Class ChocolateFactory
            Public Shared Function CreateChocolate(ingredient As String) As Chocolate
                Return New Chocolate() With {
                        .Ingredient = ingredient
                    }
            End Function
        End Class
    End Class
End Namespace