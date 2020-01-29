Namespace Creational
    Interface IRoutine

        Sub WakeUp()

        Sub GoToSchool()

        Sub ListenToMusic()

        Sub Sleep()

    End Interface

    Class Boy
        Implements IRoutine

        Public Sub GoToSchool() Implements IRoutine.GoToSchool
            Console.WriteLine("Skip school")
        End Sub

        Public Sub ListenToMusic() Implements IRoutine.ListenToMusic
            Console.WriteLine("listening to Jay Z")
        End Sub

        Public Sub Sleep() Implements IRoutine.Sleep
            Console.WriteLine("Don't sleep... Play Game")
        End Sub

        Public Sub WakeUp() Implements IRoutine.WakeUp
            Console.WriteLine("Sleepy... Fishing !!!")
        End Sub
    End Class

    Class Girl
        Implements IRoutine

        Public Sub GoToSchool() Implements IRoutine.GoToSchool
            Console.WriteLine("Go to school")
        End Sub

        Public Sub ListenToMusic() Implements IRoutine.ListenToMusic
            Console.WriteLine("Listen to Alicia Key")
        End Sub

        Public Sub Sleep() Implements IRoutine.Sleep
            Console.WriteLine("Trying to sleep")
        End Sub

        Public Sub WakeUp() Implements IRoutine.WakeUp
            Console.WriteLine("Good morning !!!")
        End Sub
    End Class

    Class Directer
        Public Sub Construct(ByVal routine As IRoutine)
            routine.WakeUp()
            routine.GoToSchool()
            routine.ListenToMusic()
            routine.Sleep()
        End Sub
    End Class
End Namespace