﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Notepadik
{
    public partial class Main : Form
    {
        private SoundPlayer Player = new SoundPlayer();
        public static Main MForm { get; private set; }
        public Main()
        {
            InitializeComponent();
            MForm = this;
            Player.SoundLocation = "../../Sourсe/amogus-bass-boost.wav";
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Roman", 3, FontStyle.Regular, GraphicsUnit.Millimeter);
            e.Graphics.DrawString(textBox.Text, printFont, Brushes.Black, new PointF(20, 3));
        }
        
        private void printTool_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = document;
            if (pDialog.ShowDialog() == DialogResult.OK) {
                document.Print();
            }
        }

        private void saveTool_Click(object sender, EventArgs e)
        {
            SaveDialog saveForm = new SaveDialog();
            saveForm.Show();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void openTool_Click(object sender, EventArgs e)
        {
            OpenDialog saveForm = new OpenDialog();
            saveForm.Show();
        }

        private void infoTool_Click(object sender, EventArgs e)
        {
            string info;
            try
            {
                Player.Play();
                info = File.ReadAllText("../../Sourсe/Info.txt");
            }
            catch (Exception exception)
            {
                info = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            }
            MessageBox.Show($"Powered by: Ilyusha\n{info}");
        }

        private void boldTool_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Bold ^ textBox.SelectionFont.Style);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Italic ^ textBox.SelectionFont.Style);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Strikeout ^ textBox.SelectionFont.Style);
        }

        private void regularTool_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Regular);

        }

        private void underlineTool_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Underline ^ textBox.SelectionFont.Style);
        }

        private void upTool_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionFont.Size < 50)
                textBox.SelectionFont = new Font(textBox.SelectedText, textBox.SelectionFont.Size + 2);
        }

        private void downTool_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionFont.Size > 2)
                textBox.SelectionFont = new Font(textBox.SelectedText, textBox.SelectionFont.Size - 2);
        }
        
        private void changeColorTool_Click_1(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            textBox.SelectionColor = colorDialog.Color;
        }

        private void openFontDialogTool_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            textBox.SelectionFont = fontDialog.Font;
            textBox.SelectionColor = fontDialog.Color;
        }

        private void copyTool_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.SelectedText);
            textBox.SelectedText = "";
        }

        private void saveWithFormatTool_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            textBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
        }

        private void openWithFormatTool_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            textBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
        }

        private void applyTool_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textSizeTexbox.Text, out int size) && size > 0 && size < 50)
            {
                textBox.SelectionFont = new Font(textBox.SelectedText, size);
                textSizeTexbox.ForeColor = Color.Black;
            }
            else
            {
                textSizeTexbox.ForeColor = Color.DarkRed;
            }
        }

        private void textSizeTexbox_Click(object sender, EventArgs e)
        {
            
        }
    }
}