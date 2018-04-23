Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Data
Imports DevExpress.Web.Mvc

Namespace MvcApp_Q367963
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            ViewData("ComboBoxValue") = 5
            Return View()
        End Function

        Public Function ComboBoxPartial() As ActionResult
            Return PartialView("_PartialPage1")
        End Function
    End Class
End Namespace
