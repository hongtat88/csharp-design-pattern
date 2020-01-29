Namespace Structural
    Class CharacterFactory

        Private ReadOnly _characters As New Dictionary(Of Char, Character) 

        Public Function GetCharacter(ByVal key As Char) As Character
            Dim character As Character = Nothing
            If _characters.ContainsKey(key) Then
                character = _characters(key)
            Else
                Select Case key
                    Case "A"c
                        character = New CharacterA()
                    Case "B"c
                        character = New CharacterB()
                    Case "Z"c
                        character = New CharacterZ()
                End Select

                _characters.Add(key, character)
            End If

            Return character
        End Function
    End Class

    MustInherit Class Character

        Protected Symbol As Char

        Protected Width As Integer

        Protected Height As Integer

        Protected Ascent As Integer

        Protected Descent As Integer

        Protected PointSize As Integer

        Public MustOverride Sub Display(ByVal pointSize As Integer)
    End Class

    Class CharacterA
        Inherits Character

        Public Sub New()
            Me.symbol = "A"c
            Me.height = 100
            Me.width = 120
            Me.ascent = 70
            Me.descent = 0
        End Sub

        Public Overrides Sub Display(ByVal pointSize As Integer)
            Me.pointSize = pointSize
            Console.WriteLine(Me.symbol & " (Point size " & Me.pointSize & ")")
        End Sub
    End Class

    Class CharacterB
        Inherits Character

        Public Sub New()
            Me.symbol = "B"c
            Me.height = 100
            Me.width = 140
            Me.ascent = 72
            Me.descent = 0
        End Sub

        Public Overrides Sub Display(ByVal pointSize As Integer)
            Me.pointSize = pointSize
            Console.WriteLine(Me.symbol & " (Point size " & Me.pointSize & ")")
        End Sub
    End Class

    Class CharacterZ
        Inherits Character

        Public Sub New()
            Me.symbol = "Z"c
            Me.height = 100
            Me.width = 100
            Me.ascent = 68
            Me.descent = 0
        End Sub

        Public Overrides Sub Display(ByVal pointSize As Integer)
            Me.pointSize = pointSize
            Console.WriteLine(Me.symbol & " (Point size " & Me.pointSize & ")")
        End Sub
    End Class
End Namespace