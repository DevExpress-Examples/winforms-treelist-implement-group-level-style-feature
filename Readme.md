# How to implement the Group Level Style feature in the TreeList


<p>In XtraGrid, it's possible to specify custom styles for group rows and corresponding indents by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_GroupLevelStyletopic">GridView.GroupLevelStyle</a> event. In the TreeList, row indents are not divided groups. Therefore, it isn't a trivial task to implement the same feature in the TreeList. However, it's possible to obtain all information necessary to calculate bounds of group indents via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_ViewInfotopic">TreeList.ViewInfo</a> property.</p><p>Basically, all that one needs to know in order to properly divide a node indent into groups is the width of the group indent. This value can be obtained via the TreeListViewInfo.RC.LevelWidth property. So, the group indent bounds can be easily calculated within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_CustomDrawNodeIndenttopic">TreeList.CustomDrawNodeIndent</a> event handler.</p>

```cs
<newline/>
Rectangle groupIndentRect = new Rectangle(e.Bounds.Right - viewInfo.RC.LevelWidth, e.Bounds.Y, viewInfo.RC.LevelWidth, e.Bounds.Height);<newline/>

```



```vb
<newline/>
Dim groupIndentRect As New Rectangle(e.Bounds.Right - viewInfo.RC.LevelWidth, e.Bounds.Y, viewInfo.RC.LevelWidth, e.Bounds.Height)<newline/>

```

<p>So, the last group indent bounds are calculated. Another group indent bounds can be calculated in the same manner, and shifted to the left by the level width.</p><p>Apart from node indents, it's also necessary to change the appearance of node cells, according to the node level. This can be done within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_NodeCellStyletopic">TreeList.NodeCellStyle</a> event handler.</p><p>Finally, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_TreeLineStyletopic">TreeList.TreeLineStyle</a> property should be set to LineStyle.None, to hide the tree line.</p>

<br/>


