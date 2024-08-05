Public Class HomeController
    Inherits System.Web.Mvc.Controller

    ' Action method for the homepage
    Function Index() As ActionResult
        Return View("Home") ' Ensures it looks for Home.vbhtml in /Views/Home/
    End Function

    ' Action method for the About page
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."
        Return View() ' Looks for About.vbhtml in /Views/Home/
    End Function

    ' Action method for the Contact page
    Function Contact() As ActionResult
        ViewData("Message") = "Contact Information:"
        Return View() ' Looks for Contact.vbhtml in /Views/Home/
    End Function
End Class
