Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CinemaVBApp

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub Adult_Before_5_Test()
        Dim form1 As Form = New Form
        Dim adult_before_5 = form1.Adult_Before_5(1, "person", "tuesday", 6)

        Assert.AreEqual(14.5, adult_before_5)
    End Sub

End Class