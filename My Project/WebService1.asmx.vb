Imports System.ComponentModel
Imports System.Web.Services
Imports WebApplication1.WebApplicationClient
Imports System.Web.Services.Protocols

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _

<System.Web.Services.WebService(Namespace:="https://localhost:44393/MyProject/WebService1.asmx")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class WebService1
    Inherits System.Web.Services.WebService
    <WebMethod()>
    Public Function Suma(Numero1 As Double, Numero2 As Double) As Double
        Return Numero1 + Numero2
    End Function
    <WebMethod()>
    Public Function Resta(Numero1 As Double, Numero2 As Double) As Double
        Return Numero1 - Numero2
    End Function
    <WebMethod()>
    Public Function Division(Numero1 As Double, Numero2 As Double) As Double
        Return Numero1 / Numero2
    End Function
    <WebMethod()>
    Public Function Multiplicacion(Numero1 As Double, Numero2 As Double) As Double
        Return Numero1 * Numero2
    End Function
End Class