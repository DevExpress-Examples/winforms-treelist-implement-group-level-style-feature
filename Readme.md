<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637818/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2368)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q220534/Form1.cs) (VB: [Form1.vb](./VB/Q220534/Form1.vb))
<!-- default file list end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-implement-group-level-style-feature&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-implement-group-level-style-feature&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
