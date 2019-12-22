namespace LastWrok
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btOpen = new System.Windows.Forms.Button();
            this.txDir = new System.Windows.Forms.TextBox();
            this.lsbFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(411, 80);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 39);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // txDir
            // 
            this.txDir.Location = new System.Drawing.Point(12, 12);
            this.txDir.Multiline = true;
            this.txDir.Name = "txDir";
            this.txDir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txDir.Size = new System.Drawing.Size(359, 107);
            this.txDir.TabIndex = 1;
            this.txDir.WordWrap = false;
            this.txDir.TextChanged += new System.EventHandler(this.txDir_TextChanged);
            // 
            // lsbFiles
            // 
            this.lsbFiles.FormattingEnabled = true;
            this.lsbFiles.ItemHeight = 15;
            this.lsbFiles.Location = new System.Drawing.Point(12, 172);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(392, 154);
            this.lsbFiles.TabIndex = 2;
            this.lsbFiles.SelectedIndexChanged += new System.EventHandler(this.lsbFiles_SelectedIndexChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 338);
            this.Controls.Add(this.lsbFiles);
            this.Controls.Add(this.txDir);
            this.Controls.Add(this.btOpen);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox txDir;
        private System.Windows.Forms.ListBox lsbFiles;
    }
}

