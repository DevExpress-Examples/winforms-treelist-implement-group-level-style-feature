<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637818/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2368)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms TreeList - Implement the Group Level Style feature

The WinForms Data Grid allows you to specify custom styles for group rows and corresponding indents by handling the [GridView.GroupLevelStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.GroupLevelStyle) event. This example demonstrates how to implement this feature in the WinForms TreeList control.

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-implement-the-group-level-style-feature-in-the-treelist-e2368/18.1.3%2B/media/winforms-treelist-level-indents.png)

* Use the [TreeList.ViewInfo](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.ViewInfo) property to obtain information required to calculate bounds of group indents.
* Use the `TreeListViewInfo.RC.LevelWidth` property to get the width of a group indent to properly divide the node indent into groups.
* Handle the [TreeList.CustomDrawNodeIndent](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CustomDrawNodeIndent) event to calculate group indent bounds.

```csharp
Rectangle groupIndentRect = new Rectangle(e.Bounds.Right - viewInfo.RC.LevelWidth, e.Bounds.Y, viewInfo.RC.LevelWidth, e.Bounds.Height);
```

So, the last group indent bounds are calculated. Another group indent bounds can be calculated in the same manner, and shifted to the left by the level width. Apart from node indents, it's also necessary to change the appearance of node cells according to the node level. This can be done within the [TreeList.NodeCellStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.NodeCellStyle) event handler.

Finally, set the [TreeList.TreeLineStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.TreeLineStyle) property `LineStyle.None` to hide the tree line.</p>




