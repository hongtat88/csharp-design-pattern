Imports System.Text

Namespace Structural

    Public Interface IEmployee
        Function ApplyLeave(days As Integer) As String
    End Interface

    Public Class Employee
        Implements IEmployee

        Public Function ApplyLeave(days As Integer) As String Implements IEmployee.ApplyLeave
            Return String.Format("Leave application approved - {0} days.", days)
        End Function
    End Class

    Public Class Team
        Implements IEmployee

        Public Property TeamMembers As New Dictionary(Of String, IEmployee)

        Public Sub New()
            TeamMembers.Add("Sum", New Employee)
            TeamMembers.Add("SiongYuen", New Employee)
        End Sub

        Public Function ApplyLeave(days As Integer) As String Implements IEmployee.ApplyLeave
            Dim messages As New StringBuilder
            For Each member In TeamMembers
                Dim name As String = member.Key
                Dim employee As IEmployee = member.Value

                messages.AppendLine(String.Format("{0} - {1}", name, employee.ApplyLeave(days)))
            Next
            Return messages.ToString
        End Function
    End Class
End Namespace