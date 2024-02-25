using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepadik
{
    public partial class OpenDialog : Form
    {
        private static readonly Dictionary<string, Encoding> ENCODS = new Dictionary<string, Encoding>
        {
            ["UTF8"] = Encoding.UTF8,
            ["UTF7"] = Encoding.UTF7,
            ["UTF32"] = Encoding.UTF32,
            ["ASCII"] = Encoding.ASCII,
            ["Unicode"] = Encoding.Unicode,
            ["BigEndianUnicode"] = Encoding.BigEndianUnicode
        };

        public OpenDialog()
        {
            InitializeComponent();
            FormClosing += delegate { Main.MForm.Enabled = true; };
            if (ActiveForm != null) Main.MForm.Enabled = false;
            encodingCombobox.SelectedItem = "UTF8";
            encodingCombobox.SelectedText = "UTF8";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void SaveDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = nameBox.Text;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            try
            {
                byte[] strec = File.ReadAllBytes(openFileDialog.FileName);
                Main.MForm.textBox.Text = ENCODS[encodingCombobox.SelectedItem.ToString()].GetString(strec);
                Main.MForm.Enabled = true;
                Close();
            }
            catch (IOException exception)
            {
                MessageBox.Show($"Error while saving the file:\n{exception.Message}");
            }
        }

        private void saveFileLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}