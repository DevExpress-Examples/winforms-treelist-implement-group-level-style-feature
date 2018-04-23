namespace Q220534 {
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
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.BeginUnboundLoad();
            this.treeList.AppendNode(new object[] {
            null}, -1);
            this.treeList.AppendNode(new object[] {
            null}, 0);
            this.treeList.AppendNode(new object[] {
            null}, 1);
            this.treeList.AppendNode(new object[] {
            null}, 1);
            this.treeList.AppendNode(new object[] {
            null}, 0);
            this.treeList.AppendNode(new object[] {
            null}, 4);
            this.treeList.AppendNode(new object[] {
            null}, 4);
            this.treeList.AppendNode(new object[] {
            null}, -1);
            this.treeList.AppendNode(new object[] {
            null}, 7);
            this.treeList.AppendNode(new object[] {
            null}, 8);
            this.treeList.AppendNode(new object[] {
            null}, 8);
            this.treeList.AppendNode(new object[] {
            null}, 7);
            this.treeList.AppendNode(new object[] {
            null}, 11);
            this.treeList.AppendNode(new object[] {
            null}, 11);
            this.treeList.EndUnboundLoad();
            this.treeList.Size = new System.Drawing.Size(399, 268);
            this.treeList.TabIndex = 0;
            this.treeList.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.treeList.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.OnTreeListNodeCellStyle);
            this.treeList.CustomDrawNodeIndent += new DevExpress.XtraTreeList.CustomDrawNodeIndentEventHandler(this.OnTreeListCustomDrawNodeIndent);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 56;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 268);
            this.Controls.Add(this.treeList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}

