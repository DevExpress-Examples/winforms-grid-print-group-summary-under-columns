Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Drawing
Imports System.Collections.Generic

Namespace DXSample
	Public Class MyGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class

	Public Class MyGridView
		Inherits GridView
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Friend Const MyGridViewName As String = "MyGridView"
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return MyGridViewName
			End Get
		End Property

		Protected Overrides Function CreatePrintInfoInstance(ByVal args As PrintInfoArgs) As BaseViewPrintInfo
			Return New MyGridViewPrintInfo(args)
		End Function
	End Class

	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return MyGridView.MyGridViewName
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(grid)
		End Function
	End Class

	Public Class MyGridViewPrintInfo
		Inherits GridViewPrintInfo
		Public Sub New(ByVal args As PrintInfoArgs)
			MyBase.New(args)
		End Sub

		Protected Overridable Sub DrawGroupTextBrick(ByVal graph As IBrickGraphics, ByVal bounds As Rectangle, ByVal rowHandle As Integer)
			Dim prefFormat As String = View.GroupFormat
			View.GroupFormat = "{0}:{1}"
			Dim groupText As String = View.GetGroupRowDisplayText(rowHandle)
			View.GroupFormat = prefFormat
			Dim groupTextBounds As New Rectangle(bounds.X + Indent, bounds.Y, (CType(Columns(0), PrintColumnInfo)).Bounds.Width \ 2 - Indent, bounds.Height)
			DrawTextBrick(graph, groupText, groupTextBounds, False)
			For i As Integer = 0 To Columns.Count - 1
				Dim col As PrintColumnInfo = CType(Columns(i), PrintColumnInfo)
				Dim groupCellBounds As Rectangle = col.Bounds
				groupCellBounds.Y = bounds.Y
				groupCellBounds.Height = bounds.Height
				If i = 0 Then
					groupCellBounds.X = groupCellBounds.Width \ 2
					groupCellBounds.Width -= groupCellBounds.Width \ 2
				End If
				Dim summary As GridGroupSummaryItem
				Dim summaryText As String = String.Empty
				If printSummaryInfo.TryGetValue(col.Column.FieldName, summary) Then
					summaryText = View.GetGroupSummaryDisplayText(rowHandle, summary)
				End If
				Dim summaryBrick As ITextBrick = CType(DrawTextBrick(graph, summaryText, groupCellBounds, False), ITextBrick)
				If summary IsNot Nothing AndAlso View.Columns(summary.FieldName).VisibleIndex = 0 Then
					summaryBrick.HorzAlignment = HorzAlignment.Far
				End If
				summaryBrick.Padding = New PaddingInfo(5, 2, 0, 0)
			Next i
		End Sub

		Protected Overrides Sub PrintGroupRow(ByVal rowHandle As Integer, ByVal level As Integer)
			Dim r As Rectangle = Rectangle.Empty
			r.X = Indent + level * ViewViewInfo.LevelIndent
			r.Width = Me.fMaxRowWidth - r.Left
			r.Y = Y
			r.Height = CurrentRowHeight
			SetDefaultBrickStyle(Graph, Bricks("GroupRow"))
			DrawGroupTextBrick(Graph, r, rowHandle)
			Y += r.Height
		End Sub

		Public Overrides Sub PrintRows(ByVal graph As BrickGraphics)
			PreparePrintSummaryInfo()
			MyBase.PrintRows(graph)
		End Sub

		Private printSummaryInfo As New Dictionary(Of String, GridGroupSummaryItem)()
		Private Sub PreparePrintSummaryInfo()
			printSummaryInfo.Clear()
			For Each item As GridGroupSummaryItem In View.GroupSummary
				If item.ShowInGroupColumnFooter Is Nothing AndAlso String.IsNullOrEmpty(item.ShowInGroupColumnFooterName) Then
					printSummaryInfo.Add(item.FieldName, item)
				End If
			Next item
		End Sub
	End Class
End Namespace
