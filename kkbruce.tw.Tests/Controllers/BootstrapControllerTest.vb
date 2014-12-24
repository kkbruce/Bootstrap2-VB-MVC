Imports System.Text
Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports kkbruce.tw

<TestClass()> Public Class BootstrapControllerTest

    <TestMethod()>
    Public Sub Index()
        ' Arrange
        Dim controller As New BootstrapController

        ' Act
        Dim result As ViewResult = DirectCast(controller.Index, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub GettingStarted()
        ' Arrange 
        Dim controller As New BootstrapController

        ' Act
        Dim result As ViewResult = DirectCast(controller.GettingStarted, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub Scaffolding()
        ' Arrange
        Dim controller As New BootstrapController

        ' Act
        Dim result As ViewResult = DirectCast(controller.Scaffolding, ViewResult)

        ' Assert 
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub BaseCSS()
        ' Arrange
        Dim controller As New BootstrapController

        ' Act 
        Dim result As ViewResult = DirectCast(controller.BaseCSS, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub Components()
        ' Arrange 
        Dim controller As New BootstrapController

        ' Act
        Dim result As ViewResult = DirectCast(controller.Components, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub JavaScript()
        ' Arrange
        Dim controller As New BootstrapController

        ' Act
        Dim result As ViewResult = DirectCast(controller.JavaScript, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub Customize()
        ' Arrange
        Dim controller As New BootstrapController

        ' Act 
        Dim result As ViewResult = DirectCast(controller.Customize, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub Extend()
        ' Arrange 
        Dim controller As New BootstrapController

        ' Act
        Dim result As ViewResult = DirectCast(controller.Extend, ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod>
    Public Sub Examples()
        ' Arrange
        Dim controller As New BootstrapController
        Dim starter As String = "starter-template"
        Dim hero As String = "hero"
        Dim fluid As String = "fluid"
        Dim marketing As String = "marketing-narrow"
        Dim justified As String = "justified-nav"
        Dim signin As String = "signin"
        Dim sticky As String = "sticky-footer"
        Dim carousel As String = "carousel"

        ' Act
        Dim starterResult As ViewResult = DirectCast(controller.Examples(starter), ViewResult)
        Dim heroResult As ViewResult = DirectCast(controller.Examples(hero), ViewResult)
        Dim fluidResult As ViewResult = DirectCast(controller.Examples(fluid), ViewResult)
        Dim marketingResult As ViewResult = DirectCast(controller.Examples(marketing), ViewResult)
        Dim justifiedResult As ViewResult = DirectCast(controller.Examples(justified), ViewResult)
        Dim signinResult As ViewResult = DirectCast(controller.Examples(signin), ViewResult)
        Dim stickyResult As ViewResult = DirectCast(controller.Examples(sticky), ViewResult)
        Dim carouselResult As ViewResult = DirectCast(controller.Examples(carousel), ViewResult)

        ' Assert
        Assert.AreEqual("StarterTemplate", starterResult.ViewName)
        Assert.AreEqual("Hero", heroResult.ViewName)
        Assert.AreEqual("Fluid", fluidResult.ViewName)
        Assert.AreEqual("MarketingNarrow", marketingResult.ViewName)
        Assert.AreEqual("JustifiedNav", justifiedResult.ViewName)
        Assert.AreEqual("Signin", signinResult.ViewName)
        Assert.AreEqual("StickyFooter", stickyResult.ViewName)
        Assert.AreEqual("Carousel", carouselResult.ViewName)
    End Sub

End Class