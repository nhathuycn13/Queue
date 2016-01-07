namespace Queue
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
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.khungChucnang = new System.Windows.Forms.FlowLayoutPanel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.statusStack = new System.Windows.Forms.StatusStrip();
            this.statusQueue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbResult = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.khungChucnang.SuspendLayout();
            this.statusStack.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMain.Location = new System.Drawing.Point(0, 24);
            this.containerMain.Name = "containerMain";
            this.containerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.Controls.Add(this.khungChucnang);
            this.containerMain.Panel2.Controls.Add(this.statusStack);
            this.containerMain.Panel2.Controls.Add(this.lbResult);
            this.containerMain.Size = new System.Drawing.Size(573, 366);
            this.containerMain.SplitterDistance = 100;
            this.containerMain.TabIndex = 0;
            // 
            // khungChucnang
            // 
            this.khungChucnang.Controls.Add(this.txtInput);
            this.khungChucnang.Controls.Add(this.btnEnqueue);
            this.khungChucnang.Controls.Add(this.btnDequeue);
            this.khungChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.khungChucnang.Location = new System.Drawing.Point(0, 0);
            this.khungChucnang.Name = "khungChucnang";
            this.khungChucnang.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.khungChucnang.Size = new System.Drawing.Size(573, 117);
            this.khungChucnang.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(203, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(309, 3);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnqueue.TabIndex = 0;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(390, 3);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(75, 23);
            this.btnDequeue.TabIndex = 1;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // statusStack
            // 
            this.statusStack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusQueue});
            this.statusStack.Location = new System.Drawing.Point(0, 240);
            this.statusStack.Name = "statusStack";
            this.statusStack.Size = new System.Drawing.Size(573, 22);
            this.statusStack.TabIndex = 0;
            this.statusStack.Text = "statusStrip1";
            // 
            // statusQueue
            // 
            this.statusQueue.Name = "statusQueue";
            this.statusQueue.Size = new System.Drawing.Size(0, 17);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(194, 134);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 51);
            this.lbResult.TabIndex = 3;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(573, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(152, 22);
            this.menuOpen.Text = "Mở";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(152, 22);
            this.menuSave.Text = "Lưu";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 390);
            this.Controls.Add(this.containerMain);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.containerMain.Panel2.ResumeLayout(false);
            this.containerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.khungChucnang.ResumeLayout(false);
            this.khungChucnang.PerformLayout();
            this.statusStack.ResumeLayout(false);
            this.statusStack.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.StatusStrip statusStack;
        private System.Windows.Forms.ToolStripStatusLabel statusQueue;
        private System.Windows.Forms.FlowLayoutPanel khungChucnang;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Label lbResult;
    }
}

