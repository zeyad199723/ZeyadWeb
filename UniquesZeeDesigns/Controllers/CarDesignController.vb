Imports System.Web.Mvc


Namespace Controllers
    Public Class CarDesignController
        Inherits Controller

        ' GET: CarDesign
        Function Index() As ActionResult
            Dim designs As New List(Of CarDesign) From {
                New CarDesign With {.Id = 1, .Name = "Sporty", .Description = "A sporty car design", .ImageUrl = "/images/sporty.jpg"},
                New CarDesign With {.Id = 2, .Name = "Classic", .Description = "A classic car design", .ImageUrl = "/images/classic.jpg"}
            }
            Return View(designs)
        End Function
    End Class
End Namespace
