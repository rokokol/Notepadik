using System.ComponentModel;

namespace Notepadik
{
    partial class OpenDialog
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
            this.saveFileLabel = new System.Windows.Forms.Label();
            this.encodingCombobox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // saveFileLabel
            // 
            this.saveFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileLabel.Location = new System.Drawing.Point(12, 8);
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(156, 35);
            this.saveFileLabel.TabIndex = 1;
            this.saveFileLabel.Text = "Enter file name and pick the encoding:";
            this.saveFileLabel.Click += new System.EventHandler(this.saveFileLabel_Click);
            // 
            // encodingCombobox
            // 
            this.encodingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingCombobox.FormattingEnabled = true;
            this.encodingCombobox.Items.AddRange(new object[] { "UTF8", "ASCII", "UTF7", "UTF32", "Unicode", "BigEndianUnicode" });
            this.encodingCombobox.Location = new System.Drawing.Point(11, 71);
            this.encodingCombobox.Name = "encodingCombobox";
            this.encodingCombobox.Size = new System.Drawing.Size(156, 21);
            this.encodingCombobox.TabIndex = 2;
            this.encodingCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(11, 98);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(157, 24);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(156, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "YourFileName";
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // OpenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(180, 134);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.encodingCombobox);
            this.Controls.Add(this.saveFileLabel);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SaveDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.TextBox nameBox;

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ComboBox encodingCombobox;
        private System.Windows.Forms.Label saveFileLabel;

        #endregion
    }
}