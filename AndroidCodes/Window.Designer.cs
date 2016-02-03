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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mHttpMethodSelector = new System.Windows.Forms.ComboBox();
            this.mSplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mTextBoxSend = new System.Windows.Forms.TextBox();
            this.mTextBoxRecv = new System.Windows.Forms.TextBox();
            this.mTextBoxUrl = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer1)).BeginInit();
            this.mSplitContainer1.Panel1.SuspendLayout();
            this.mSplitContainer1.Panel2.SuspendLayout();
            this.mSplitContainer1.SuspendLayout();
            this.mTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer2)).BeginInit();
            this.mSplitContainer2.Panel1.SuspendLayout();
            this.mSplitContainer2.Panel2.SuspendLayout();
            this.mSplitContainer2.SuspendLayout();
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
            this.mTabControl.Controls.Add(this.tabPage2);
            this.mTabControl.Location = new System.Drawing.Point(12, 12);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(1240, 657);
            this.mTabControl.TabIndex = 4;
            this.mTabControl.SelectedIndexChanged += new System.EventHandler(this.mTabControl_SelectedIndexChanged);
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
            this.tabPage1.Text = "FindViews";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mHttpMethodSelector);
            this.tabPage2.Controls.Add(this.mSplitContainer2);
            this.tabPage2.Controls.Add(this.mTextBoxUrl);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Web Debugger";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mHttpMethodSelector
            // 
            this.mHttpMethodSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mHttpMethodSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mHttpMethodSelector.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mHttpMethodSelector.FormattingEnabled = true;
            this.mHttpMethodSelector.IntegralHeight = false;
            this.mHttpMethodSelector.ItemHeight = 13;
            this.mHttpMethodSelector.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.mHttpMethodSelector.Location = new System.Drawing.Point(6, 594);
            this.mHttpMethodSelector.Name = "mHttpMethodSelector";
            this.mHttpMethodSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mHttpMethodSelector.Size = new System.Drawing.Size(85, 21);
            this.mHttpMethodSelector.TabIndex = 1;
            this.mHttpMethodSelector.SelectedIndexChanged += new System.EventHandler(this.mHttpMethodSelector_SelectedIndexChanged);
            // 
            // mSplitContainer2
            // 
            this.mSplitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mSplitContainer2.IsSplitterFixed = true;
            this.mSplitContainer2.Location = new System.Drawing.Point(6, 6);
            this.mSplitContainer2.Name = "mSplitContainer2";
            // 
            // mSplitContainer2.Panel1
            // 
            this.mSplitContainer2.Panel1.Controls.Add(this.mTextBoxSend);
            // 
            // mSplitContainer2.Panel2
            // 
            this.mSplitContainer2.Panel2.Controls.Add(this.mTextBoxRecv);
            this.mSplitContainer2.Size = new System.Drawing.Size(1220, 582);
            this.mSplitContainer2.SplitterDistance = 405;
            this.mSplitContainer2.TabIndex = 3;
            // 
            // mTextBoxSend
            // 
            this.mTextBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextBoxSend.Location = new System.Drawing.Point(0, 0);
            this.mTextBoxSend.MaxLength = 0;
            this.mTextBoxSend.Multiline = true;
            this.mTextBoxSend.Name = "mTextBoxSend";
            this.mTextBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mTextBoxSend.Size = new System.Drawing.Size(405, 582);
            this.mTextBoxSend.TabIndex = 0;
            this.mTextBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTextBoxSend_KeyDown);
            // 
            // mTextBoxRecv
            // 
            this.mTextBoxRecv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextBoxRecv.Location = new System.Drawing.Point(0, 0);
            this.mTextBoxRecv.MaxLength = 0;
            this.mTextBoxRecv.Multiline = true;
            this.mTextBoxRecv.Name = "mTextBoxRecv";
            this.mTextBoxRecv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mTextBoxRecv.Size = new System.Drawing.Size(811, 582);
            this.mTextBoxRecv.TabIndex = 0;
            this.mTextBoxRecv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTextBoxRecv_KeyDown);
            // 
            // mTextBoxUrl
            // 
            this.mTextBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxUrl.Location = new System.Drawing.Point(97, 594);
            this.mTextBoxUrl.Name = "mTextBoxUrl";
            this.mTextBoxUrl.Size = new System.Drawing.Size(1011, 21);
            this.mTextBoxUrl.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(1114, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Do Request";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.mSplitContainer2.Panel1.ResumeLayout(false);
            this.mSplitContainer2.Panel1.PerformLayout();
            this.mSplitContainer2.Panel2.ResumeLayout(false);
            this.mSplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer2)).EndInit();
            this.mSplitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox mTextBoxUrl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer mSplitContainer2;
        private System.Windows.Forms.TextBox mTextBoxSend;
        private System.Windows.Forms.TextBox mTextBoxRecv;
        private System.Windows.Forms.ComboBox mHttpMethodSelector;
    }
}

