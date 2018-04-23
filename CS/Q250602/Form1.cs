using System;
using System.Windows.Forms;

namespace Q250602 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.nwindDataSet.Order_Details);

        }

        private void OnShowPrintPreviewButtonClick(object sender, EventArgs e) {
            orderDetailsGrid.ShowPrintPreview();
        }

        private void OnExportToXlsButtonClick(object sender, EventArgs e) {
            orderDetailsGrid.ExportToXls(@"..\..\order_details.xls");
            //orderDetailsGrid.ExportToHtml(@"..\..\order_details.html");
            //orderDetailsGrid.ExportToMht(@"..\..\order_details.mht");
            //orderDetailsGrid.ExportToPdf(@"..\..\order_details.pdf");
            //orderDetailsGrid.ExportToRtf(@"..\..\order_details.rtf");
            //orderDetailsGrid.ExportToText(@"..\..\order_details.txt");
            //orderDetailsGrid.ExportToPdf(@"..\..\order_details.pdf");
        }
    }
}
