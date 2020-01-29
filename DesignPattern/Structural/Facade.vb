Namespace Structural
    Public Class Lights

        Public Sub SwitchOnLights()
            Console.WriteLine("Lights - Switched ON")
        End Sub

        Public Sub SwitchOffLights()
            Console.WriteLine("Lights - Switched OFF")
        End Sub
    End Class

    Public Class MusicSystem

        Public Sub SwitchOnMusicSystem()
            Console.WriteLine("Music System - Switched ON")
        End Sub

        Public Sub SwitchOffMusicSystem()
            Console.WriteLine("Music System - Switched OFF")
        End Sub
    End Class

    Public Class Tv

        Public Sub SwitchOnTv()
            Console.WriteLine("TV - Switched ON")
        End Sub

        Public Sub SwitchOffTv()
            Console.WriteLine("TV - Switched OFF")
        End Sub
    End Class

    Public Class HomeSecuritySystem

        Public Sub EnableSecuritySystem()
            Console.WriteLine("Security System - Enabled")
        End Sub

        Public Sub DisableSecuritySystem()
            Console.WriteLine("Security System - Disabled")
        End Sub
    End Class

    Public Class PhoneAnsweringSystem

        Public Sub SetHomeMessage()
            Console.WriteLine("Phone Answering System - Home custom Message set")
        End Sub

        Public Sub SetAwayMessage()
            Console.WriteLine("Phone Answering System - Away custom Message set")
        End Sub
    End Class

    Public Class SmartHomeFacade

        Private _light As Lights

        Private _musicSystem As MusicSystem

        Private _tv As Tv

        Private _securitySystem As HomeSecuritySystem

        Private _phoneAnsweringSystem As PhoneAnsweringSystem

        Public Sub New()
            _light = New Lights()
            _musicSystem = New MusicSystem()
            _tv = New Tv()
            _securitySystem = New HomeSecuritySystem()
            _phoneAnsweringSystem = New PhoneAnsweringSystem()
        End Sub

        Public Sub LeaveHomeforOffice()
            _light.SwitchOffLights()
            _musicSystem.SwitchOffMusicSystem()
            _tv.SwitchOffTv()
            _securitySystem.EnableSecuritySystem()
            _phoneAnsweringSystem.SetAwayMessage()
        End Sub

        Public Sub ArriveHomefromOffice()
            _light.SwitchOnLights()
            _musicSystem.SwitchOnMusicSystem()
            _tv.SwitchOnTv()
            _securitySystem.DisableSecuritySystem()
            _phoneAnsweringSystem.SetHomeMessage()
        End Sub
    End Class

End Namespace