Imports System.Web.Mvc

Public Class ContactController
    Inherits Controller

    Function Index() As ActionResult
        Return View("Contact") ' Ensures it looks in /Views/Contactt/Contact.vbhtml
    End Function

End Class
