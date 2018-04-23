Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace Q250602
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
			Me.order_DetailsTableAdapter.Fill(Me.nwindDataSet.Order_Details)

		End Sub

		Private Sub OnShowPrintPreviewButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			orderDetailsGrid.ShowPrintPreview()
		End Sub

		Private Sub OnExportToXlsButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			orderDetailsGrid.ExportToXls("..\..\order_details.xls")
			'orderDetailsGrid.ExportToHtml(@"..\..\order_details.html");
			'orderDetailsGrid.ExportToMht(@"..\..\order_details.mht");
			'orderDetailsGrid.ExportToPdf(@"..\..\order_details.pdf");
			'orderDetailsGrid.ExportToRtf(@"..\..\order_details.rtf");
			'orderDetailsGrid.ExportToText(@"..\..\order_details.txt");
			'orderDetailsGrid.ExportToPdf(@"..\..\order_details.pdf");
		End Sub
	End Class
End Namespace
