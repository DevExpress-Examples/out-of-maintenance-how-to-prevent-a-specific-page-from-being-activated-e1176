Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
			Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
			Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
			Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
			Me.wizardPage2 = New DevExpress.XtraWizard.WizardPage()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.wizardControl1.SuspendLayout()
			Me.welcomeWizardPage1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' wizardControl1
			' 
			Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage1)
			Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage2)
			Me.wizardControl1.Name = "wizardControl1"
			Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.wizardPage2, Me.completionWizardPage1})
'			Me.wizardControl1.SelectedPageChanging += New DevExpress.XtraWizard.WizardPageChangingEventHandler(Me.wizardControl1_SelectedPageChanging);
			' 
			' welcomeWizardPage1
			' 
			Me.welcomeWizardPage1.Controls.Add(Me.checkEdit1)
			Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
			Me.welcomeWizardPage1.Size = New System.Drawing.Size(548, 286)
			' 
			' wizardPage1
			' 
			Me.wizardPage1.Name = "wizardPage1"
			Me.wizardPage1.Size = New System.Drawing.Size(733, 274)
			Me.wizardPage1.Text = "This is the first page "
			' 
			' completionWizardPage1
			' 
			Me.completionWizardPage1.Name = "completionWizardPage1"
			Me.completionWizardPage1.Size = New System.Drawing.Size(548, 286)
			' 
			' wizardPage2
			' 
			Me.wizardPage2.Name = "wizardPage2"
			Me.wizardPage2.Size = New System.Drawing.Size(733, 274)
			Me.wizardPage2.Text = "This is the second page "
			' 
			' checkEdit1
			' 
			Me.checkEdit1.EditValue = True
			Me.checkEdit1.Location = New System.Drawing.Point(12, 49)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Skip the first page "
			Me.checkEdit1.Size = New System.Drawing.Size(244, 19)
			Me.checkEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(765, 419)
			Me.Controls.Add(Me.wizardControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.wizardControl1.ResumeLayout(False)
			Me.welcomeWizardPage1.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents wizardControl1 As DevExpress.XtraWizard.WizardControl
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wizardPage1 As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private wizardPage2 As DevExpress.XtraWizard.WizardPage
	End Class
End Namespace

