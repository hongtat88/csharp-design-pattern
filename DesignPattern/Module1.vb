Imports DesignPattern.Creational.Directer
Imports DesignPattern.Creational
Imports DesignPattern.Creational.AbstractFactory
Imports DesignPattern.Creational.SimpleFactory
Imports DesignPattern.Structural
Imports DesignPattern.Structural.Decorator

Module Module1

    Sub Main()
        'Singleton()
        'SimpleFactory()
        'FactoryMethod()
        'Builder()

        'Decorator()
        'Proxy()
        'Bridge()
        'Composite()
        'FlyWeight()
        'Adapter()

        Console.ReadLine()
    End Sub

    Public Sub Singleton()
        Dim singleton As Singleton = Singleton.Instance
        Console.WriteLine(singleton.Operation())
    End Sub

    Public Sub SimpleFactory()
        Dim badChocolate As New Chocolate
        badChocolate.Ingredient = " sour"
        Console.WriteLine("This chocolate tastes " & badChocolate.Taste())

        Dim chocolate As Chocolate = ChocolateFactory.CreateChocolate("Almond")
        Console.WriteLine("This chocolate tastes " & chocolate.Taste())
    End Sub

    Public Sub FactoryMethod()
        Dim fruitFactory As New FactoryMethod.FruitFactory

        For i As Integer = 1 To 12
            Dim fruit As FactoryMethod.IFruit = fruitFactory.GetFruit(i)
            Console.WriteLine("Fruit" & fruit.ShipFrom())
        Next
    End Sub

    Public Sub AbstractFactory()
        Dim factory As IFactory(Of Gucci) = New Factory(Of Gucci)
        Dim bag As IBag = factory.CreateBag
        Dim shoes As IShoes = factory.CreateShoes
        Console.WriteLine(("I bought a Bag which is made from " & bag.Material))
        Console.WriteLine(("I bought some shoes which cost " & shoes.Price))
    End Sub

    Public Sub Builder()
        Dim ahSeng As IRoutine = New Boy()
        Dim ahPhone As IRoutine = New Girl()

        Dim directer As New Directer()
        directer.Construct(ahSeng)
        directer.Construct(ahPhone)
    End Sub

    Public Sub Decorator()
        Dim newCar As New HondaCityVehicle
        Console.WriteLine("{0} {1} - {2}", newCar.Make, newCar.Model, newCar.Price)

        Dim usedCar As New UsedHondaVehicle(9)
        Console.WriteLine("{0} {1} - {2}", usedCar.Make, usedCar.Model, usedCar.GetUsedPrice())
    End Sub

    Public Sub Proxy()
        Dim proxy As New FriendProxy
        Console.WriteLine("IsFriend : " & proxy.IsFriend)
        Console.WriteLine("Posts : " & String.Join(", ", proxy.Posts))
    End Sub

    Public Sub Bridge()
        Dim tv As New SuperSmartTv(New IpTvService)
        tv.ShowTvGuide()
        tv.PlayTv()

        Dim tv2 As New SuperSmartTv(New LocalCableTv)
        tv2.ShowTvGuide()
        tv2.PlayTv()

        Dim tv3 As New SuperSmartTv(New LocalDishTv)
        tv3.ShowTvGuide()
        tv3.PlayTv()
    End Sub

    Public Sub Composite()
        Dim ahYing As New Employee
        Console.WriteLine(String.Format("Ah Ying {0}", ahYing.ApplyLeave(10)))

        Console.WriteLine("========================================================")
        Console.WriteLine("Team off")
        Console.WriteLine("========================================================")
        Dim development As New Team
        Console.WriteLine(development.ApplyLeave(10))
    End Sub

    Public Sub FlyWeight()
        Dim document As String = "AAZZBBZB"
        Dim chars As Char() = document.ToCharArray()

        Dim factory As New CharacterFactory
        Dim pointSize As Integer = 10

        For Each c As Char In chars
            pointSize += 1
            Dim character = factory.GetCharacter(c)
            character.Display(pointSize)
        Next
    End Sub

    Public Sub Adapter()
        Dim adapterA As ICalenderAdapter = New CalenderAAdapter()
        adapterA.Open()
        adapterA.Close()

        Dim adapterB As ICalenderAdapter = New CalenderBAdapter()
        adapterB.Open()
        adapterB.Close()
    End Sub

    Public Sub Facade()
        Dim homeFacade As New SmartHomeFacade
        Console.WriteLine("--------------- Leave Home for Office Control----------------")
        homeFacade.LeaveHomeforOffice()
        Console.WriteLine("--------------- Arrive Home From Office Control----------------")
        homeFacade.ArriveHomefromOffice()
    End Sub
End Module
