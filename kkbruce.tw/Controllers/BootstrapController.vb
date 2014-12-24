<OutputCache(CacheProfile:="Cache1Hour")>
Public Class BootstrapController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Bootstrap

    Function Index() As ActionResult
        Return View()
    End Function

    Function GettingStarted() As ActionResult
        Return View()
    End Function

    Function Scaffolding() As ActionResult
        Return View()
    End Function

    Function BaseCSS() As ActionResult
        Return View()
    End Function

    Function Components() As ActionResult
        Return View()
    End Function

    Overloads Function JavaScript() As ActionResult
        Return View()
    End Function

    Function Customize() As ActionResult
        Return View()
    End Function

    Function Extend() As ActionResult
        Return View()
    End Function

    Function Examples(sitename As String) As ActionResult
        Select Case sitename
            Case "starter-template"
                Return View("StarterTemplate")
            Case "hero"
                Return View("Hero")
            Case "fluid"
                Return View("Fluid")
            Case "marketing-narrow"
                Return View("MarketingNarrow")
            Case "justified-nav"
                Return View("JustifiedNav")
            Case "signin"
                Return View("Signin")
            Case "sticky-footer"
                Return View("StickyFooter")
            Case "carousel"
                Return View("Carousel")
            Case Else
                Return View("StarterTemplate")
        End Select
    End Function

End Class