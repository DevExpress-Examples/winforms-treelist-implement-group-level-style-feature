<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637818/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2368)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms TreeList - Implement the Group Level Style feature

The WinForms Data Grid allows you to specify custom styles for group rows and corresponding indents by handling the [GridView.GroupLevelStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.GroupLevelStyle) event. This example demonstrates how to implement this feature in the WinForms TreeList control.

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-the-group-level-style-feature-in-the-treelist-e2368/18.1.3%2B/media/winforms-treelist-level-indents.png)

* Use the [TreeList.ViewInfo](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.ViewInfo) property to obtain information required to calculate bounds of group indents.
* Use the `TreeListViewInfo.RC.LevelWidth` property to get the width of a group indent to properly divide the node indent into groups.
* Handle the [TreeList.CustomDrawNodeIndent](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CustomDrawNodeIndent) event to calculate group indent bounds.
  
  ```csharp
  private void OnTreeListCustomDrawNodeIndent(object sender, CustomDrawNodeIndentEventArgs e) {
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
  ```
* Set the [TreeList.TreeLineStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.TreeLineStyle) property to `LineStyle.None` to hide tree lines.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-implement-group-level-style-feature&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-implement-group-level-style-feature&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
