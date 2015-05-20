namespace InformixClient
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.itemConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.itemDB = new System.Windows.Forms.ToolStripMenuItem();
			this.itemAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.lstvPhones = new System.Windows.Forms.ListView();
			this.contextMenuPhones = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMain.SuspendLayout();
			this.contextMenuPhones.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemDB});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuMain.Size = new System.Drawing.Size(643, 24);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "menuMain";
			// 
			// itemFile
			// 
			this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConnect,
            this.itemExit});
			this.itemFile.Name = "itemFile";
			this.itemFile.Size = new System.Drawing.Size(48, 20);
			this.itemFile.Text = "Файл";
			// 
			// itemConnect
			// 
			this.itemConnect.Name = "itemConnect";
			this.itemConnect.Size = new System.Drawing.Size(156, 22);
			this.itemConnect.Text = "Подключиться";
			this.itemConnect.Click += new System.EventHandler(this.itemConnect_Click);
			// 
			// itemExit
			// 
			this.itemExit.Name = "itemExit";
			this.itemExit.Size = new System.Drawing.Size(156, 22);
			this.itemExit.Text = "Выход";
			this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
			// 
			// itemDB
			// 
			this.itemDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdd});
			this.itemDB.Name = "itemDB";
			this.itemDB.Size = new System.Drawing.Size(86, 20);
			this.itemDB.Text = "База данных";
			// 
			// itemAdd
			// 
			this.itemAdd.Name = "itemAdd";
			this.itemAdd.Size = new System.Drawing.Size(126, 22);
			this.itemAdd.Text = "Добавить";
			this.itemAdd.Click += new System.EventHandler(this.itemAdd_Click);
			// 
			// lstvPhones
			// 
			this.lstvPhones.ContextMenuStrip = this.contextMenuPhones;
			this.lstvPhones.Location = new System.Drawing.Point(12, 27);
			this.lstvPhones.Name = "lstvPhones";
			this.lstvPhones.Size = new System.Drawing.Size(619, 274);
			this.lstvPhones.TabIndex = 1;
			this.lstvPhones.UseCompatibleStateImageBehavior = false;
			this.lstvPhones.DoubleClick += new System.EventHandler(this.lstvPhones_DoubleClick);
			// 
			// contextMenuPhones
			// 
			this.contextMenuPhones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDelete});
			this.contextMenuPhones.Name = "contextMenuPhones";
			this.contextMenuPhones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuPhones.Size = new System.Drawing.Size(153, 48);
			// 
			// toolDelete
			// 
			this.toolDelete.Name = "toolDelete";
			this.toolDelete.Size = new System.Drawing.Size(152, 22);
			this.toolDelete.Text = "Удалить";
			this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 313);
			this.Controls.Add(this.lstvPhones);
			this.Controls.Add(this.menuMain);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IBM Informix клиент";
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.contextMenuPhones.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem itemFile;
		private System.Windows.Forms.ToolStripMenuItem itemConnect;
		private System.Windows.Forms.ListView lstvPhones;
		private System.Windows.Forms.ToolStripMenuItem itemExit;
		private System.Windows.Forms.ToolStripMenuItem itemDB;
		private System.Windows.Forms.ToolStripMenuItem itemAdd;
		private System.Windows.Forms.ContextMenuStrip contextMenuPhones;
		private System.Windows.Forms.ToolStripMenuItem toolDelete;
	}
}

