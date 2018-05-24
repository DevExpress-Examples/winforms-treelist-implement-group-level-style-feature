using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.XtraTreeList.Nodes;

namespace Q220534
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnTreeListCustomDrawNodeIndent(object sender, CustomDrawNodeIndentEventArgs e)
        {
            e.Handled = true;
            TreeList tree = (TreeList)sender;
            Dictionary<int, Rectangle> groupLevelIndentRects = new Dictionary<int, Rectangle>();
            CalcGroupLevelIndentRects(tree.ViewInfo, e.Node, e.Bounds, groupLevelIndentRects);
            foreach (KeyValuePair<int, Rectangle> kvp in groupLevelIndentRects)                
                e.Cache.FillRectangle(e.Cache.GetSolidBrush(GetColorByLevel(kvp.Key)), kvp.Value);
            if (e.Node.ParentNode == null) {
                Pen linePen = e.Cache.GetPen(tree.ViewInfo.PaintAppearance.HorzLine.BackColor);                
                e.Cache.DrawLine(linePen, e.Bounds.Location, new Point(e.Bounds.Right, e.Bounds.Y));
            }
        }

        private void CalcGroupLevelIndentRects(TreeListViewInfo viewInfo, TreeListNode currentNode, Rectangle bounds,
            Dictionary<int, Rectangle> rects)
        {
            if (currentNode == null) return;
            if (currentNode.HasChildren)
                rects.Add(currentNode.Level, new Rectangle(bounds.Right - viewInfo.RC.LevelWidth, bounds.Y, viewInfo.RC.LevelWidth, bounds.Height));
            bounds = new Rectangle(bounds.Location, new Size(bounds.Width - viewInfo.RC.LevelWidth, bounds.Height));
            CalcGroupLevelIndentRects(viewInfo, currentNode.ParentNode, bounds, rects);
        }

        private Color GetColorByLevel(int level)
        {
            switch (level) {
                case 0: return Color.Red;
                case 1: return Color.Yellow;
                case 2: return Color.Green;
                default: return Color.Black;
            }
        }

        private void OnTreeListNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (!e.Node.HasChildren) return;
            e.Appearance.BackColor = GetColorByLevel(e.Node.Level);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            treeList.ExpandAll();
        }
    }
}