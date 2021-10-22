
namespace dotNetAssignment2
{
    partial class TextEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.topToolStripNewBtn = new System.Windows.Forms.ToolStripButton();
            this.topToolStripOpenBtn = new System.Windows.Forms.ToolStripButton();
            this.topToolStripSaveBtn = new System.Windows.Forms.ToolStripButton();
            this.topToolStripSaveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.topToolStripBoldBtn = new System.Windows.Forms.ToolStripButton();
            this.topToolStripItalicBtn = new System.Windows.Forms.ToolStripButton();
            this.topToolStripUnderlineBtn = new System.Windows.Forms.ToolStripButton();
            this.topToolStripSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.userNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.sideToolStrip = new System.Windows.Forms.ToolStrip();
            this.sideToolStripCutBtn = new System.Windows.Forms.ToolStripButton();
            this.sideToolStripCopyBtn = new System.Windows.Forms.ToolStripButton();
            this.sideToolStripPasteBtn = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.topToolStrip.SuspendLayout();
            this.sideToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Tag = "";
            this.openToolStripMenuItem.Text = "New";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // topToolStrip
            // 
            this.topToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripNewBtn,
            this.topToolStripOpenBtn,
            this.topToolStripSaveBtn,
            this.topToolStripSaveAsBtn,
            this.toolStripSeparator3,
            this.topToolStripBoldBtn,
            this.topToolStripItalicBtn,
            this.topToolStripUnderlineBtn,
            this.topToolStripSizeComboBox,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.userNameLabel});
            this.topToolStrip.Location = new System.Drawing.Point(0, 28);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(800, 28);
            this.topToolStrip.TabIndex = 1;
            this.topToolStrip.Text = "toolStrip1";
            // 
            // topToolStripNewBtn
            // 
            this.topToolStripNewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripNewBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripNewBtn.Image")));
            this.topToolStripNewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripNewBtn.Name = "topToolStripNewBtn";
            this.topToolStripNewBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripNewBtn.Text = "New";
            this.topToolStripNewBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // topToolStripOpenBtn
            // 
            this.topToolStripOpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripOpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripOpenBtn.Image")));
            this.topToolStripOpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripOpenBtn.Name = "topToolStripOpenBtn";
            this.topToolStripOpenBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripOpenBtn.Text = "Open";
            this.topToolStripOpenBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // topToolStripSaveBtn
            // 
            this.topToolStripSaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripSaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripSaveBtn.Image")));
            this.topToolStripSaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripSaveBtn.Name = "topToolStripSaveBtn";
            this.topToolStripSaveBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripSaveBtn.Text = "Save";
            this.topToolStripSaveBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // topToolStripSaveAsBtn
            // 
            this.topToolStripSaveAsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripSaveAsBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripSaveAsBtn.Image")));
            this.topToolStripSaveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripSaveAsBtn.Name = "topToolStripSaveAsBtn";
            this.topToolStripSaveAsBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripSaveAsBtn.Text = "Save As";
            this.topToolStripSaveAsBtn.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // topToolStripBoldBtn
            // 
            this.topToolStripBoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripBoldBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripBoldBtn.Image")));
            this.topToolStripBoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripBoldBtn.Name = "topToolStripBoldBtn";
            this.topToolStripBoldBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripBoldBtn.Text = "Bold";
            this.topToolStripBoldBtn.Click += new System.EventHandler(this.topToolStripBoldBtn_Click);
            // 
            // topToolStripItalicBtn
            // 
            this.topToolStripItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripItalicBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripItalicBtn.Image")));
            this.topToolStripItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripItalicBtn.Name = "topToolStripItalicBtn";
            this.topToolStripItalicBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripItalicBtn.Text = "Italic";
            this.topToolStripItalicBtn.Click += new System.EventHandler(this.topToolStripItalicBtn_Click);
            // 
            // topToolStripUnderlineBtn
            // 
            this.topToolStripUnderlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topToolStripUnderlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("topToolStripUnderlineBtn.Image")));
            this.topToolStripUnderlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topToolStripUnderlineBtn.Name = "topToolStripUnderlineBtn";
            this.topToolStripUnderlineBtn.Size = new System.Drawing.Size(29, 25);
            this.topToolStripUnderlineBtn.Text = "Underline";
            this.topToolStripUnderlineBtn.Click += new System.EventHandler(this.topToolStripUnderlineBtn_Click);
            // 
            // topToolStripSizeComboBox
            // 
            this.topToolStripSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.topToolStripSizeComboBox.Name = "topToolStripSizeComboBox";
            this.topToolStripSizeComboBox.Size = new System.Drawing.Size(121, 28);
            this.topToolStripSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(85, 25);
            this.userNameLabel.Text = "User Name:";
            // 
            // sideToolStrip
            // 
            this.sideToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sideToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sideToolStripCutBtn,
            this.sideToolStripCopyBtn,
            this.sideToolStripPasteBtn});
            this.sideToolStrip.Location = new System.Drawing.Point(0, 56);
            this.sideToolStrip.Name = "sideToolStrip";
            this.sideToolStrip.Size = new System.Drawing.Size(30, 394);
            this.sideToolStrip.TabIndex = 2;
            this.sideToolStrip.Text = "toolStrip2";
            // 
            // sideToolStripCutBtn
            // 
            this.sideToolStripCutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sideToolStripCutBtn.Image = ((System.Drawing.Image)(resources.GetObject("sideToolStripCutBtn.Image")));
            this.sideToolStripCutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sideToolStripCutBtn.Name = "sideToolStripCutBtn";
            this.sideToolStripCutBtn.Size = new System.Drawing.Size(27, 24);
            this.sideToolStripCutBtn.Text = "Cut";
            this.sideToolStripCutBtn.Click += new System.EventHandler(this.sideToolStripCutBtn_Click);
            // 
            // sideToolStripCopyBtn
            // 
            this.sideToolStripCopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sideToolStripCopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("sideToolStripCopyBtn.Image")));
            this.sideToolStripCopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sideToolStripCopyBtn.Name = "sideToolStripCopyBtn";
            this.sideToolStripCopyBtn.Size = new System.Drawing.Size(27, 24);
            this.sideToolStripCopyBtn.Text = "Copy";
            this.sideToolStripCopyBtn.Click += new System.EventHandler(this.sideToolStripCopyBtn_Click);
            // 
            // sideToolStripPasteBtn
            // 
            this.sideToolStripPasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sideToolStripPasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("sideToolStripPasteBtn.Image")));
            this.sideToolStripPasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sideToolStripPasteBtn.Name = "sideToolStripPasteBtn";
            this.sideToolStripPasteBtn.Size = new System.Drawing.Size(27, 24);
            this.sideToolStripPasteBtn.Text = "Paste";
            this.sideToolStripPasteBtn.Click += new System.EventHandler(this.sideToolStripPasteBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 379);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sideToolStrip);
            this.Controls.Add(this.topToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorForm";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.sideToolStrip.ResumeLayout(false);
            this.sideToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox topToolStripSizeComboBox;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton topToolStripNewBtn;
        private System.Windows.Forms.ToolStripButton topToolStripOpenBtn;
        private System.Windows.Forms.ToolStripButton topToolStripSaveBtn;
        private System.Windows.Forms.ToolStripButton topToolStripSaveAsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton topToolStripBoldBtn;
        private System.Windows.Forms.ToolStripButton topToolStripItalicBtn;
        private System.Windows.Forms.ToolStripButton topToolStripUnderlineBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel userNameLabel;
        private System.Windows.Forms.ToolStrip sideToolStrip;
        private System.Windows.Forms.ToolStripButton sideToolStripCutBtn;
        private System.Windows.Forms.ToolStripButton sideToolStripCopyBtn;
        private System.Windows.Forms.ToolStripButton sideToolStripPasteBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}