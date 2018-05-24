Namespace Q220534
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
			Me.treeList = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList
			' 
			Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList.Location = New System.Drawing.Point(0, 0)
			Me.treeList.Name = "treeList"
			Me.treeList.BeginUnboundLoad()
			Me.treeList.AppendNode(New Object() { Nothing}, -1)
			Me.treeList.AppendNode(New Object() { Nothing}, 0)
			Me.treeList.AppendNode(New Object() { Nothing}, 1)
			Me.treeList.AppendNode(New Object() { Nothing}, 1)
			Me.treeList.AppendNode(New Object() { Nothing}, 0)
			Me.treeList.AppendNode(New Object() { Nothing}, 4)
			Me.treeList.AppendNode(New Object() { Nothing}, 4)
			Me.treeList.AppendNode(New Object() { Nothing}, -1)
			Me.treeList.AppendNode(New Object() { Nothing}, 7)
			Me.treeList.AppendNode(New Object() { Nothing}, 8)
			Me.treeList.AppendNode(New Object() { Nothing}, 8)
			Me.treeList.AppendNode(New Object() { Nothing}, 7)
			Me.treeList.AppendNode(New Object() { Nothing}, 11)
			Me.treeList.AppendNode(New Object() { Nothing}, 11)
			Me.treeList.EndUnboundLoad()
			Me.treeList.Size = New System.Drawing.Size(399, 268)
			Me.treeList.TabIndex = 0
			Me.treeList.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeList.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.OnTreeListNodeCellStyle);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeList.CustomDrawNodeIndent += new DevExpress.XtraTreeList.CustomDrawNodeIndentEventHandler(this.OnTreeListCustomDrawNodeIndent);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.MinWidth = 56
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(399, 268)
			Me.Controls.Add(Me.treeList)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.OnFormLoad);
			CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace

