Namespace Structural
    Public Class Decorator
        Interface IVehicle
            ReadOnly Property Make As String
            ReadOnly Property Model As String
            ReadOnly Property Price As Decimal
        End Interface

        Public Class HondaCityVehicle
            Implements IVehicle

            Public ReadOnly Property Make As String Implements IVehicle.Make
                Get
                    Return "Honda"
                End Get
            End Property

            Public ReadOnly Property Model As String Implements IVehicle.Model
                Get
                    Return "City"
                End Get
            End Property

            Public ReadOnly Property Price As Decimal Implements IVehicle.Price
                Get
                    Return 89000
                End Get
            End Property
        End Class

        Public Class UsedHondaVehicle
            Implements IVehicle

            Private _hondaCity As New HondaCityVehicle
            Private _age As Integer

            Public Sub New(age As Integer)
                _age = age
            End Sub

            Public ReadOnly Property Make As String Implements IVehicle.Make
                Get
                    Return _hondaCity.Make
                End Get
            End Property

            Public ReadOnly Property Model As String Implements IVehicle.Model
                Get
                    Return _hondaCity.Model
                End Get
            End Property

            Public ReadOnly Property Price As Decimal Implements IVehicle.Price
                Get
                    Return _hondaCity.Price 
                End Get
            End Property

            Public Function GetUsedPrice() As Decimal
                Return Price - (_age * 10000)
            End Function
        End Class
    End Class
End Namespace