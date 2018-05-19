Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.ASPxUploadControl

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxUploadControl1_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs)
		e.CallbackData = SaveFile(e.UploadedFile)
	End Sub
	Protected Function SaveFile(ByVal uploadedFile As UploadedFile) As String
		Dim fileName As String = String.Empty
		If uploadedFile.IsValid Then
			fileName = String.Format("{0}{1}", MapPath("~/"), uploadedFile.FileName)
			If File.Exists(fileName) Then
				File.Delete(fileName)
			End If
			'uploadedFile.SaveAs(fileName); //uncomment this line
		End If
		Return uploadedFile.FileName
	End Function
End Class