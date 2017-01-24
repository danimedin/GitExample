Namespace PatronObservador
    Public Class Observador
        Inherits Form




        Private mSujeto As Sujeto
        Public Property sujeto() As Sujeto
            Get
                Return mSujeto
            End Get
            Set(ByVal value As Sujeto)
                mSujeto = value
            End Set
        End Property



        Public Overridable Sub actualizar()

        End Sub
    End Class
End Namespace