using System.ComponentModel;

namespace Notepadik
{
    partial class Main
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openTool = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldTool = new System.Windows.Forms.ToolStripMenuItem();
            this.italicTool = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.regularTool = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineTool = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upTool = new System.Windows.Forms.ToolStripMenuItem();
            this.downTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openFontDialogTool = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.printTool = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox.Location = new System.Drawing.Point(0, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(526, 284);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.printTool, this.infoTool });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.saveTool, this.openTool });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTool
            // 
            this.saveTool.Name = "saveTool";
            this.saveTool.ShortcutKeyDisplayString = "Ctrl + S";
            this.saveTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTool.Size = new System.Drawing.Size(166, 22);
            this.saveTool.Text = "Save as";
            this.saveTool.ToolTipText = "Save file";
            this.saveTool.Click += new System.EventHandler(this.saveTool_Click);
            // 
            // openTool
            // 
            this.openTool.Name = "openTool";
            this.openTool.ShortcutKeyDisplayString = "Ctrl + O";
            this.openTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTool.Size = new System.Drawing.Size(166, 22);
            this.openTool.Text = "Open as";
            this.openTool.ToolTipText = "Open file";
            this.openTool.Click += new System.EventHandler(this.openTool_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.textFormatToolStripMenuItem, this.textSizeToolStripMenuItem, this.openFontDialogTool, this.changeColorTool });
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // textFormatToolStripMenuItem
            // 
            this.textFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.boldTool, this.italicTool, this.strikeoutTool, this.regularTool, this.underlineTool });
            this.textFormatToolStripMenuItem.Name = "textFormatToolStripMenuItem";
            this.textFormatToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.textFormatToolStripMenuItem.Text = "Font  format";
            this.textFormatToolStripMenuItem.ToolTipText = "Change font formatof selection";
            // 
            // boldTool
            // 
            this.boldTool.Name = "boldTool";
            this.boldTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.B)));
            this.boldTool.Size = new System.Drawing.Size(206, 22);
            this.boldTool.Text = "Bold";
            this.boldTool.ToolTipText = "Make text bold";
            this.boldTool.Click += new System.EventHandler(this.boldTool_Click);
            // 
            // italicTool
            // 
            this.italicTool.Name = "italicTool";
            this.italicTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.I)));
            this.italicTool.Size = new System.Drawing.Size(206, 22);
            this.italicTool.Text = "Italic";
            this.italicTool.ToolTipText = "Make text italic";
            this.italicTool.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // strikeoutTool
            // 
            this.strikeoutTool.Name = "strikeoutTool";
            this.strikeoutTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.strikeoutTool.Size = new System.Drawing.Size(206, 22);
            this.strikeoutTool.Text = "Strikeout";
            this.strikeoutTool.ToolTipText = "Make text bold";
            this.strikeoutTool.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // regularTool
            // 
            this.regularTool.Name = "regularTool";
            this.regularTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.R)));
            this.regularTool.Size = new System.Drawing.Size(206, 22);
            this.regularTool.Text = "Regular";
            this.regularTool.ToolTipText = "Make text bold";
            this.regularTool.Click += new System.EventHandler(this.regularTool_Click);
            // 
            // underlineTool
            // 
            this.underlineTool.Name = "underlineTool";
            this.underlineTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.U)));
            this.underlineTool.Size = new System.Drawing.Size(206, 22);
            this.underlineTool.Text = "Underlined";
            this.underlineTool.ToolTipText = "Make text ";
            this.underlineTool.Click += new System.EventHandler(this.underlineTool_Click);
            // 
            // textSizeToolStripMenuItem
            // 
            this.textSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.upTool, this.downTool });
            this.textSizeToolStripMenuItem.Name = "textSizeToolStripMenuItem";
            this.textSizeToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.textSizeToolStripMenuItem.Text = "Text size";
            this.textSizeToolStripMenuItem.ToolTipText = "Resize selection";
            // 
            // upTool
            // 
            this.upTool.Name = "upTool";
            this.upTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.U)));
            this.upTool.Size = new System.Drawing.Size(170, 22);
            this.upTool.Text = "Up";
            this.upTool.ToolTipText = "Make bigger";
            this.upTool.Click += new System.EventHandler(this.upTool_Click);
            // 
            // downTool
            // 
            this.downTool.Name = "downTool";
            this.downTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.D)));
            this.downTool.Size = new System.Drawing.Size(170, 22);
            this.downTool.Text = "Down";
            this.downTool.ToolTipText = "Make smaller";
            this.downTool.Click += new System.EventHandler(this.downTool_Click);
            // 
            // openFontDialogTool
            // 
            this.openFontDialogTool.Name = "openFontDialogTool";
            this.openFontDialogTool.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.F)));
            this.openFontDialogTool.Size = new System.Drawing.Size(259, 22);
            this.openFontDialogTool.Text = "Open font dialog";
            this.openFontDialogTool.Click += new System.EventHandler(this.openFontDialogTool_Click);
            // 
            // changeColorTool
            // 
            this.changeColorTool.Name = "changeColorTool";
            this.changeColorTool.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.C)));
            this.changeColorTool.Size = new System.Drawing.Size(259, 22);
            this.changeColorTool.Text = "Change color";
            this.changeColorTool.ToolTipText = "Change selected text color";
            this.changeColorTool.Click += new System.EventHandler(this.changeColorTool_Click_1);
            // 
            // printTool
            // 
            this.printTool.Name = "printTool";
            this.printTool.ShortcutKeyDisplayString = "Ctrl + P";
            this.printTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printTool.Size = new System.Drawing.Size(44, 20);
            this.printTool.Text = "Print";
            this.printTool.ToolTipText = "Print file";
            this.printTool.Click += new System.EventHandler(this.printTool_Click);
            // 
            // infoTool
            // 
            this.infoTool.Name = "infoTool";
            this.infoTool.ShortcutKeyDisplayString = "Ctrl + I";
            this.infoTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infoTool.Size = new System.Drawing.Size(40, 20);
            this.infoTool.Text = "Info";
            this.infoTool.ToolTipText = "About program";
            this.infoTool.Click += new System.EventHandler(this.infoTool_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 311);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "NOTEPADICK";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem openFontDialogTool;

        private System.Windows.Forms.ColorDialog colorDialog;

        private System.Windows.Forms.ToolStripMenuItem changeColorTool;

        private System.Windows.Forms.ToolStripMenuItem textSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upTool;
        private System.Windows.Forms.ToolStripMenuItem downTool;

        private System.Windows.Forms.ToolStripMenuItem regularTool;

        private System.Windows.Forms.ToolStripMenuItem strikeoutTool;

        private System.Windows.Forms.ToolStripMenuItem italicTool;
        private System.Windows.Forms.ToolStripMenuItem underlineTool;

        private System.Windows.Forms.ToolStripMenuItem textFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldTool;

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTool;
        private System.Windows.Forms.ToolStripMenuItem openTool;

        private System.Windows.Forms.ToolStripMenuItem infoTool;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printTool;

        public System.Windows.Forms.RichTextBox textBox;

        #endregion
    }
}