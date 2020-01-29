Namespace Structural
    Public Class FriendProxy
        Implements IFriend

        Private _friend As New AhBeng

        Public ReadOnly Property IsFriend As Boolean Implements IFriend.IsFriend
            Get
                Return _friend.IsFriend
            End Get
        End Property

        Public ReadOnly Property Posts As String() Implements IFriend.Posts
            Get
                Return If(_friend.IsFriend, _friend.Posts, {})
            End Get
        End Property
    End Class

    Interface IFriend
        ReadOnly Property IsFriend As Boolean
        ReadOnly Property Posts As String() 'Ignore best practise for this class
    End Interface

    Public Class AhBeng
        Implements IFriend

        Public ReadOnly Property IsFriend As Boolean Implements IFriend.IsFriend
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property Posts As String() Implements IFriend.Posts
            Get
                Return {"Post 1", "Post 2"}
            End Get
        End Property
    End Class
End Namespace