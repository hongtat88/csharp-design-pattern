Namespace Creational
    Public Class AbstractFactory
        ' Uses generics to simplify the creation of factories
        Interface IFactory(Of TBrand As IBrand)

            Function CreateBag() As IBag

            Function CreateShoes() As IShoes
        End Interface

        ' Concrete Factories (both in the same one)
        Class Factory(Of TBrand As {New, IBrand})
            Implements IFactory(Of TBrand)

            Public Function CreateBag() As IBag Implements IFactory(Of TBrand).CreateBag
                Return New Bag(Of TBrand)
            End Function

            Public Function CreateShoes() As IShoes Implements IFactory(Of TBrand).CreateShoes
                Return New Shoes(Of TBrand)
            End Function
        End Class

        ' Interface IProductA
        Interface IBag

            ReadOnly Property Material As String
        End Interface

        ' Interface IProductB
        Interface IShoes

            ReadOnly Property Price As Integer
        End Interface

        ' All concrete ProductA's
        Class Bag(Of TBrand As {New, IBrand})
            Implements IBag

            Private ReadOnly _myBrand As TBrand

            Public Sub New()
                MyBase.New
                Me._myBrand = New TBrand
            End Sub

            Public ReadOnly Property Material As String Implements IBag.Material
                Get
                    Return Me._myBrand.Material
                End Get
            End Property
        End Class

        ' All concrete ProductB's
        Class Shoes(Of TBrand As {New, IBrand})
            Implements IShoes

            Private ReadOnly _myBrand As TBrand

            Public Sub New()
                MyBase.New
                Me._myBrand = New TBrand
            End Sub

            Public ReadOnly Property Price As Integer Implements IShoes.Price
                Get
                    Return Me._myBrand.Price
                End Get
            End Property

        End Class

        ' An interface for all Brands
        Interface IBrand

            ReadOnly Property Price As Integer

            ReadOnly Property Material As String
        End Interface

        Class Gucci
            Implements IBrand

            Public ReadOnly Property Price As Integer Implements IBrand.Price
                Get
                    Return 1000
                End Get
            End Property

            Public ReadOnly Property Material As String Implements IBrand.Material
                Get
                    Return "Crocodile skin"
                End Get
            End Property
        End Class

        Class Poochy
            Implements IBrand

            Public ReadOnly Property Price As Integer Implements IBrand.Price
                Get
                    Return (New Gucci().Price / 3)
                End Get
            End Property

            Public ReadOnly Property Material As String Implements IBrand.Material
                Get
                    Return "Plastic"
                End Get
            End Property
        End Class

        Class Groundcover
            Implements IBrand

            Public ReadOnly Property Price As Integer Implements IBrand.Price
                Get
                    Return 2000
                End Get
            End Property

            Public ReadOnly Property Material As String Implements IBrand.Material
                Get
                    Return "South African leather"
                End Get
            End Property
        End Class
    End Class

End Namespace