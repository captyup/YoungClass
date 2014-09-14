namespace YoungClass
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.法寶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資本資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.物ToolStripMenuItem,
            this.人ToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1082, 32);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // 物ToolStripMenuItem
            // 
            this.物ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.法寶ToolStripMenuItem});
            this.物ToolStripMenuItem.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.物ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("物ToolStripMenuItem.Image")));
            this.物ToolStripMenuItem.Name = "物ToolStripMenuItem";
            this.物ToolStripMenuItem.Size = new System.Drawing.Size(57, 28);
            this.物ToolStripMenuItem.Text = "物";
            // 
            // 法寶ToolStripMenuItem
            // 
            this.法寶ToolStripMenuItem.Name = "法寶ToolStripMenuItem";
            this.法寶ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.法寶ToolStripMenuItem.Text = "法寶";
            this.法寶ToolStripMenuItem.Click += new System.EventHandler(this.法寶ToolStripMenuItem_Click);
            // 
            // 人ToolStripMenuItem
            // 
            this.人ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.學生資本資料ToolStripMenuItem});
            this.人ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("人ToolStripMenuItem.Image")));
            this.人ToolStripMenuItem.Name = "人ToolStripMenuItem";
            this.人ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.人ToolStripMenuItem.Text = "人";
            // 
            // 學生資本資料ToolStripMenuItem
            // 
            this.學生資本資料ToolStripMenuItem.Name = "學生資本資料ToolStripMenuItem";
            this.學生資本資料ToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.學生資本資料ToolStripMenuItem.Text = "學生資本資料";
            this.學生資本資料ToolStripMenuItem.Click += new System.EventHandler(this.學生資本資料ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 663);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新竹支苑文教小組 資料管理系統";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem 物ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 法寶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 學生資本資料ToolStripMenuItem;
    }
}