using System;
using System.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
using System.Collections.Generic;

namespace DXSample {
    public class MyGridControl :GridControl {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridView :GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl grid) : base(grid) { }

        internal const string MyGridViewName = "MyGridView";
        protected override string ViewName { get { return MyGridViewName; } }

        protected override BaseViewPrintInfo CreatePrintInfoInstance(PrintInfoArgs args) {
            return new MyGridViewPrintInfo(args);
        }
    }

    public class MyGridViewInfoRegistrator :GridInfoRegistrator {
        public MyGridViewInfoRegistrator() : base() { }

        public override string ViewName { get { return MyGridView.MyGridViewName; } }

        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid); }
    }

    public class MyGridViewPrintInfo :GridViewPrintInfo {
        public MyGridViewPrintInfo(PrintInfoArgs args) : base(args) { }

        protected virtual void DrawGroupTextBrick(BrickGraphics graph, Rectangle bounds,
            int rowHandle) {
            string prefFormat = View.GroupFormat;
            View.GroupFormat = "{0}:{1}";
            string groupText = View.GetGroupRowDisplayText(rowHandle);
            View.GroupFormat = prefFormat;
            Rectangle groupTextBounds =
                new Rectangle(bounds.X + Indent, bounds.Y, ((PrintColumnInfo)Columns[0]).Bounds.Width / 2 - Indent, bounds.Height);
            DrawTextBrick(graph, groupText, groupTextBounds, false);
            for (int i = 0; i < Columns.Count; i++) {
                PrintColumnInfo col = (PrintColumnInfo)Columns[i];
                Rectangle groupCellBounds = col.Bounds;
                groupCellBounds.Y = bounds.Y;
                groupCellBounds.Height = bounds.Height;
                if (i == 0) {
                    groupCellBounds.X = groupCellBounds.Width / 2;
                    groupCellBounds.Width -= groupCellBounds.Width / 2;
                }
                GridGroupSummaryItem summary;
                string summaryText = string.Empty;
                if (printSummaryInfo.TryGetValue(col.Column.FieldName, out summary)) 
                    summaryText = View.GetGroupSummaryDisplayText(rowHandle, summary);
                TextBrick summaryBrick = (TextBrick)DrawTextBrick(graph, summaryText, groupCellBounds, false);
                if (summary != null && View.Columns[summary.FieldName].VisibleIndex == 0)
                    summaryBrick.HorzAlignment = HorzAlignment.Far;
                summaryBrick.Padding = new PaddingInfo(5, 2, 0, 0);
            }
        }

        protected override void PrintGroupRow(int rowHandle, int level) {
            Rectangle r = Rectangle.Empty;
            r.X = Indent + level * ViewViewInfo.LevelIndent;
            r.Width = this.fMaxRowWidth - r.Left;
            r.Y = Y;
            r.Height = CurrentRowHeight;
            SetDefaultBrickStyle(Graph, Bricks["GroupRow"]);
            DrawGroupTextBrick(Graph, r, rowHandle);
            Y += r.Height;
        }

        public override void PrintRows(BrickGraphics graph) {
            PreparePrintSummaryInfo();
            base.PrintRows(graph);
        }

        private Dictionary<string, GridGroupSummaryItem> printSummaryInfo = new Dictionary<string, GridGroupSummaryItem>();
        private void PreparePrintSummaryInfo() {
            printSummaryInfo.Clear();
            foreach (GridGroupSummaryItem item in View.GroupSummary)
                if (item.ShowInGroupColumnFooter == null && string.IsNullOrEmpty(item.ShowInGroupColumnFooterName))
                    printSummaryInfo.Add(item.FieldName, item);
        }
    }
}
