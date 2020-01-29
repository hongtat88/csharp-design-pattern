Namespace Creational
    Public Class FactoryMethod
        Interface IFruit
            Function ShipFrom() As String
        End Interface
        
        Public Class FruitA
            Implements IFruit

            Public Function ShipFrom() As String Implements IFruit.ShipFrom
                Return " from South Africa"
            End Function
        End Class

        Public Class FruitB
            Implements IFruit

            Public Function ShipFrom() As String Implements IFruit.ShipFrom
                Return " from Spain"
            End Function
        End Class

        Public Class DefaultFruit
            Implements IFruit

            Public Function ShipFrom() As String Implements IFruit.ShipFrom
                Return " not available"
            End Function
        End Class

        Public Class FruitFactory
            Public Function GetFruit(month As Integer) As IFruit
                If month >= 4 AndAlso month <= 11 Then
                    Return New FruitA
                ElseIf month = 1 OrElse month = 2 OrElse month = 12 Then
                    Return New FruitB
                End If

                Return New DefaultFruit
            End Function
        End Class
    End Class
End Namespace