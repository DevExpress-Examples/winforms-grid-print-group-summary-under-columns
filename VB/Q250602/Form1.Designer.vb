Imports Microsoft.VisualBasic
Imports System
Namespace Q250602
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
			Me.components = New System.ComponentModel.Container()
			Me.orderDetailsGrid = New DXSample.MyGridControl()
			Me.orderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q250602.nwindDataSet()
			Me.myGridView1 = New DXSample.MyGridView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.order_DetailsTableAdapter = New Q250602.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.orderDetailsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' orderDetailsGrid
			' 
			Me.orderDetailsGrid.DataSource = Me.orderDetailsBindingSource
			Me.orderDetailsGrid.Location = New System.Drawing.Point(0, 0)
			Me.orderDetailsGrid.MainView = Me.myGridView1
			Me.orderDetailsGrid.Name = "orderDetailsGrid"
			Me.orderDetailsGrid.Size = New System.Drawing.Size(400, 232)
			Me.orderDetailsGrid.TabIndex = 0
			Me.orderDetailsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1})
			' 
			' orderDetailsBindingSource
			' 
			Me.orderDetailsBindingSource.DataMember = "Order Details"
			Me.orderDetailsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' myGridView1
			' 
			Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colUnitPrice, Me.colQuantity, Me.colDiscount})
			Me.myGridView1.GridControl = Me.orderDetailsGrid
			Me.myGridView1.GroupCount = 1
			Me.myGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Min, "Quantity", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Discount", Nothing, "")})
			Me.myGridView1.Name = "myGridView1"
			Me.myGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrderID, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' colOrderID
			' 
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 0
			' 
			' colQuantity
			' 
			Me.colQuantity.FieldName = "Quantity"
			Me.colQuantity.Name = "colQuantity"
			Me.colQuantity.Visible = True
			Me.colQuantity.VisibleIndex = 1
			' 
			' colDiscount
			' 
			Me.colDiscount.FieldName = "Discount"
			Me.colDiscount.Name = "colDiscount"
			Me.colDiscount.Visible = True
			Me.colDiscount.VisibleIndex = 2
			' 
			' order_DetailsTableAdapter
			' 
			Me.order_DetailsTableAdapter.ClearBeforeFill = True
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 238)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(110, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Show Print Preview"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnShowPrintPreviewButtonClick);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(128, 238)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Export to XLS"
'			Me.simpleButton2.Click += New System.EventHandler(Me.OnExportToXlsButtonClick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(398, 273)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.orderDetailsGrid)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.orderDetailsGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private orderDetailsGrid As DXSample.MyGridControl
		Private nwindDataSet As nwindDataSet
		Private orderDetailsBindingSource As System.Windows.Forms.BindingSource
		Private order_DetailsTableAdapter As Q250602.nwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private myGridView1 As DXSample.MyGridView
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

