Namespace Structural
    Public Interface IVideoSource
        Function GetTvGuide() As String
        Function PlayVideo() As String
    End Interface

    Class LocalCableTv
        Implements IVideoSource

        Const SourceName As String = "Local Cable TV"

        Private Function GetTvGuide() As String Implements IVideoSource.GetTvGuide
            Return String.Format("Getting TV guide from - {0}", SourceName)
        End Function

        Private Function PlayVideo() As String Implements IVideoSource.PlayVideo
            Return String.Format("Playing - {0}", SourceName)
        End Function
    End Class

    Class LocalDishTv
        Implements IVideoSource

        Const SourceName As String = "Local Dish TV"

        Private Function GetTvGuide() As String Implements IVideoSource.GetTvGuide
            Return String.Format("Getting TV guide from - {0}", SourceName)
        End Function

        Private Function PlayVideo() As String Implements IVideoSource.PlayVideo
            Return String.Format("Playing - {0}", SourceName)
        End Function
    End Class

    Class IpTvService
        Implements IVideoSource

        Const SourceName As String = "IP TV"

        Private Function GetTvGuide() As String Implements IVideoSource.GetTvGuide
            Return String.Format("Getting TV guide from - {0}", SourceName)
        End Function

        Private Function PlayVideo() As String Implements IVideoSource.PlayVideo
            Return String.Format("Playing - {0}", SourceName)
        End Function
    End Class

    ''' <summary>
    ''' Abstracter
    ''' </summary>
    Public Class SuperSmartTv
        Private Readonly _source As IVideoSource
        public Sub New(source As IVideoSource)
            _source = source
        End Sub

        public Sub ShowTvGuide
            Console.WriteLine(_source.GetTvGuide())
        End Sub

        Public Sub PlayTv
            Console.WriteLine(_source.PlayVideo())
        End Sub
    End Class
End Namespace