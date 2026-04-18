Imports Microsoft.EntityFrameworkCore

Namespace Context
    Public Class ClienteContext
        Inherits DbContext

        Public Sub New(options As DbContextOptions(Of ClienteContext))
            MyBase.New(options)
        End Sub

        ' DbSet para el modelo Cliente
        Public Property Clientes As DbSet(Of Cliente)
    End Class
End Namespace
