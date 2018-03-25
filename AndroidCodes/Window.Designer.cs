namespace AndroidCodes
{
    partial class Window
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
            this.mSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mTextBox1 = new System.Windows.Forms.TextBox();
            this.mGenActivityCodeBtn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mGenAdapterCodeBtn = new System.Windows.Forms.Button();
            this.mGenFragmentCodeBtn = new System.Windows.Forms.Button();
            this.mTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer1)).BeginInit();
            this.mSplitContainer1.Panel1.SuspendLayout();
            this.mSplitContainer1.Panel2.SuspendLayout();
            this.mSplitContainer1.SuspendLayout();
            this.mTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSplitContainer1
            // 
            this.mSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mSplitContainer1.IsSplitterFixed = true;
            this.mSplitContainer1.Location = new System.Drawing.Point(6, 6);
            this.mSplitContainer1.Name = "mSplitContainer1";
            // 
            // mSplitContainer1.Panel1
            // 
            this.mSplitContainer1.Panel1.Controls.Add(this.mTextBox1);
            // 
            // mSplitContainer1.Panel2
            // 
            this.mSplitContainer1.Panel2.Controls.Add(this.mGenActivityCodeBtn);
            this.mSplitContainer1.Size = new System.Drawing.Size(1220, 590);
            this.mSplitContainer1.SplitterDistance = 405;
            this.mSplitContainer1.TabIndex = 0;
            // 
            // mTextBox1
            // 
            this.mTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextBox1.Location = new System.Drawing.Point(0, 0);
            this.mTextBox1.MaxLength = 0;
            this.mTextBox1.Multiline = true;
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mTextBox1.Size = new System.Drawing.Size(405, 590);
            this.mTextBox1.TabIndex = 0;
            this.mTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTextBox1_KeyDown);
            // 
            // mGenActivityCodeBtn
            // 
            this.mGenActivityCodeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGenActivityCodeBtn.Location = new System.Drawing.Point(0, 0);
            this.mGenActivityCodeBtn.MaxLength = 0;
            this.mGenActivityCodeBtn.Multiline = true;
            this.mGenActivityCodeBtn.Name = "mGenActivityCodeBtn";
            this.mGenActivityCodeBtn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mGenActivityCodeBtn.Size = new System.Drawing.Size(811, 590);
            this.mGenActivityCodeBtn.TabIndex = 0;
            this.mGenActivityCodeBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTextBox2_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(6, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.mGenActivityCodeBtn_Click);
            // 
            // mGenAdapterCodeBtn
            // 
            this.mGenAdapterCodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mGenAdapterCodeBtn.Location = new System.Drawing.Point(258, 602);
            this.mGenAdapterCodeBtn.Name = "mGenAdapterCodeBtn";
            this.mGenAdapterCodeBtn.Size = new System.Drawing.Size(120, 23);
            this.mGenAdapterCodeBtn.TabIndex = 2;
            this.mGenAdapterCodeBtn.Text = "Adapter";
            this.mGenAdapterCodeBtn.UseVisualStyleBackColor = true;
            this.mGenAdapterCodeBtn.Click += new System.EventHandler(this.mGenAdapterCodeBtn_Click);
            // 
            // mGenFragmentCodeBtn
            // 
            this.mGenFragmentCodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mGenFragmentCodeBtn.Location = new System.Drawing.Point(132, 602);
            this.mGenFragmentCodeBtn.Name = "mGenFragmentCodeBtn";
            this.mGenFragmentCodeBtn.Size = new System.Drawing.Size(120, 23);
            this.mGenFragmentCodeBtn.TabIndex = 3;
            this.mGenFragmentCodeBtn.Text = "Fragment";
            this.mGenFragmentCodeBtn.UseVisualStyleBackColor = true;
            this.mGenFragmentCodeBtn.Click += new System.EventHandler(this.mGenFragmentCodeBtn_Click);
            // 
            // mTabControl
            // 
            this.mTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTabControl.Controls.Add(this.tabPage1);
            this.mTabControl.Location = new System.Drawing.Point(12, 12);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(1240, 657);
            this.mTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mSplitContainer1);
            this.tabPage1.Controls.Add(this.mGenFragmentCodeBtn);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.mGenAdapterCodeBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate FindViews";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mTabControl);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Codes";
            this.Load += new System.EventHandler(this.Window_Load);
            this.SizeChanged += new System.EventHandler(this.Window_SizeChanged);
            this.mSplitContainer1.Panel1.ResumeLayout(false);
            this.mSplitContainer1.Panel1.PerformLayout();
            this.mSplitContainer1.Panel2.ResumeLayout(false);
            this.mSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer1)).EndInit();
            this.mSplitContainer1.ResumeLayout(false);
            this.mTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mSplitContainer1;
        private System.Windows.Forms.TextBox mTextBox1;
        private System.Windows.Forms.TextBox mGenActivityCodeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mGenAdapterCodeBtn;
        private System.Windows.Forms.Button mGenFragmentCodeBtn;
        private System.Windows.Forms.TabControl mTabControl;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

