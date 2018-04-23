Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
' ...

Namespace AutoScaling
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim printTool As New ReportPrintTool(New XtraReport1())
			printTool.Report.CreateDocument(False)
			AddHandler printTool.PreviewForm.Load, AddressOf PreviewForm_Load
			printTool.ShowPreviewDialog()
		End Sub

		Private Sub PreviewForm_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim frm As PrintPreviewFormEx = CType(sender, PrintPreviewFormEx)
			frm.PrintingSystem.ExecCommand(PrintingSystemCommand.Scale, New Object() { 0.7f })
		End Sub

	End Class
End Namespace

