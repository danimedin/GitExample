Namespace PatronObservador

    Public Class Sujeto
        Inherits System.Windows.Forms.Form
        Private mObservers As List(Of Observador)

        Public Property observers As List(Of Observador)
            Get
                If IsNothing(Me.mObservers) Then
                    mObservers = New List(Of Observador)


                End If

                Return mObservers
            End Get
            Set(value As List(Of Observador))
                Me.mObservers = value
            End Set
        End Property


        Public Sub attach(ByVal o As Observador)
            Me.observers.Add(o)
        End Sub
        Public Sub detach(ByVal o As Observador)
            Me.observers.Remove(o)
        End Sub

        Public Sub notify()
            For Each o As Observador In Me.observers
                o.actualizar()
            Next
        End Sub
    End Class
End Namespace