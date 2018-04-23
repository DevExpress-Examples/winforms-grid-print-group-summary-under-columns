namespace Q250602 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.orderDetailsGrid = new DXSample.MyGridControl();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Q250602.nwindDataSet();
            this.myGridView1 = new DXSample.MyGridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order_DetailsTableAdapter = new Q250602.nwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsGrid
            // 
            this.orderDetailsGrid.DataSource = this.orderDetailsBindingSource;
            this.orderDetailsGrid.Location = new System.Drawing.Point(0, 0);
            this.orderDetailsGrid.MainView = this.myGridView1;
            this.orderDetailsGrid.Name = "orderDetailsGrid";
            this.orderDetailsGrid.Size = new System.Drawing.Size(400, 232);
            this.orderDetailsGrid.TabIndex = 0;
            this.orderDetailsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colUnitPrice,
            this.colQuantity,
            this.colDiscount});
            this.myGridView1.GridControl = this.orderDetailsGrid;
            this.myGridView1.GroupCount = 1;
            this.myGridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Min, "Quantity", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Discount", null, "")});
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrderID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colOrderID
            // 
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 2;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 238);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Show Print Preview";
            this.simpleButton1.Click += new System.EventHandler(this.OnShowPrintPreviewButtonClick);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(128, 238);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Export to XLS";
            this.simpleButton2.Click += new System.EventHandler(this.OnExportToXlsButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 273);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.orderDetailsGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyGridControl orderDetailsGrid;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private Q250602.nwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DXSample.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;

    }
}

