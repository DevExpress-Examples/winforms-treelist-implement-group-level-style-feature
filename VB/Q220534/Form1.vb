Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo
Imports DevExpress.XtraTreeList.Nodes

Namespace Q220534

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnTreeListCustomDrawNodeIndent(ByVal sender As Object, ByVal e As CustomDrawNodeIndentEventArgs)
            e.Handled = True
            Dim tree As TreeList = CType(sender, TreeList)
            Dim groupLevelIndentRects As Dictionary(Of Integer, Rectangle) = New Dictionary(Of Integer, Rectangle)()
            CalcGroupLevelIndentRects(tree.ViewInfo, e.Node, e.Bounds, groupLevelIndentRects)
            For Each kvp As KeyValuePair(Of Integer, Rectangle) In groupLevelIndentRects
                e.Graphics.FillRectangle(e.Cache.GetSolidBrush(GetColorByLevel(kvp.Key)), kvp.Value)
            Next

            If e.Node.ParentNode Is Nothing Then
                Dim linePen As Pen = e.Cache.GetPen(tree.ViewInfo.PaintAppearance.HorzLine.BackColor)
                e.Graphics.DrawLine(linePen, e.Bounds.Location, New Point(e.Bounds.Right, e.Bounds.Y))
            End If
        End Sub

        Private Sub CalcGroupLevelIndentRects(ByVal viewInfo As TreeListViewInfo, ByVal currentNode As TreeListNode, ByVal bounds As Rectangle, ByVal rects As Dictionary(Of Integer, Rectangle))
            If currentNode Is Nothing Then Return
            If currentNode.HasChildren Then rects.Add(currentNode.Level, New Rectangle(bounds.Right - viewInfo.RC.LevelWidth, bounds.Y, viewInfo.RC.LevelWidth, bounds.Height))
            bounds = New Rectangle(bounds.Location, New Size(bounds.Width - viewInfo.RC.LevelWidth, bounds.Height))
            CalcGroupLevelIndentRects(viewInfo, currentNode.ParentNode, bounds, rects)
        End Sub

        Private Function GetColorByLevel(ByVal level As Integer) As Color
            Select Case level
                Case 0
                    Return Color.Red
                Case 1
                    Return Color.Yellow
                Case 2
                    Return Color.Green
                Case Else
                    Return Color.Black
            End Select
        End Function

        Private Sub OnTreeListNodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs)
            If Not e.Node.HasChildren Then Return
            e.Appearance.BackColor = GetColorByLevel(e.Node.Level)
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            treeList.ExpandAll()
        End Sub
    End Class
End Namespace
