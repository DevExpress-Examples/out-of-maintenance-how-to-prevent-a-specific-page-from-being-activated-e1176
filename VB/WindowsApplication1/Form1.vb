Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub wizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles wizardControl1.SelectedPageChanging
			If e.Page Is wizardControl1.Pages(1) AndAlso checkEdit1.Checked Then
				Dim nextPageIndex As Integer
				If (e.Direction = DevExpress.XtraWizard.Direction.Forward) Then
					nextPageIndex = (1) + wizardControl1.Pages.IndexOf(e.Page)
				Else
					nextPageIndex = (-1) + wizardControl1.Pages.IndexOf(e.Page)
				End If
				e.Page = wizardControl1.Pages(nextPageIndex)
			End If
		End Sub
	End Class
End Namespace