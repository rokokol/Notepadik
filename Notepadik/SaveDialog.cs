using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepadik
{
    public partial class SaveDialog : Form
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

        public SaveDialog()
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
            saveFileDialog.FileName = nameBox.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Encoding utf = Encoding.UTF8;
            byte[] strenc = Encoding.Convert(ENCODS[encodingCombobox.SelectedItem.ToString()],
                utf, utf.GetBytes(Main.MForm.textBox.Text));
            try
            {
                Main.MForm.Enabled = true;
                File.WriteAllBytes(saveFileDialog.FileName, strenc);
                Close();
            }
            catch (IOException exception)
            {
                MessageBox.Show($"Error while saving the file:\n{exception.Message}");
            }
        }
    }
}