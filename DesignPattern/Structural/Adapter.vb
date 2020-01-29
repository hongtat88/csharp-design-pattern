Namespace Structural
    Public Class CalenderA
        Public Sub Start()
            ' Do something
        End Sub

        Public Sub [End]()
            ' Do something
        End Sub
    End Class

    Public Class CalenderB
        Public Sub Begin()
            ' Do something
        End Sub

        Public Sub Terminte()
            ' Do something
        End Sub
    End Class

    Public Interface ICalenderAdapter
        Sub Open()
        Sub Close()
    End Interface

    Public Class CalenderAAdapter
        Implements ICalenderAdapter

        Private ReadOnly _calenderA As CalenderA

        Public Sub New
            _calenderA = New CalenderA()
        End Sub

        Public Sub Open() Implements ICalenderAdapter.Open
            _calenderA.Start()
        End Sub

        Public Sub Close() Implements ICalenderAdapter.Close
            _calenderA.End()
        End Sub
    End Class

    Public Class CalenderBAdapter
        Implements ICalenderAdapter

        Private ReadOnly _calenderB As CalenderB

        Public Sub New
            _calenderB = New CalenderB()
        End Sub

        Public Sub Open() Implements ICalenderAdapter.Open
            _calenderB.Begin()
        End Sub

        Public Sub Close() Implements ICalenderAdapter.Close
            _calenderB.Terminte()
        End Sub
    End Class
End Namespace