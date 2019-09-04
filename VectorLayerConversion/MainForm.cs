using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorLayerConversion
{
    public partial class MainForm : Form
    {
        Converter converter = new Converter();
        string format = "geojson";
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectInputFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        inputFileTextBox.Text = openFileDialog.FileName;
                        outputFileTextBox.Text = Directory.GetParent(inputFileTextBox.Text).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Big terrible error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                }
            }
        }

        private void SelectOutputFileDirectoryButton_Click(object sender, EventArgs e)
        {
            outputFileTextBox.Text = Cataloguer.FolderBrowser.ChooseFolder(this);
        }

        private void DeleteInputFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Проверяет правильность заполнения формы и вызывает метод конвертирования формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            convertButton.Enabled = false;
            if (!Directory.Exists(outputFileTextBox.Text.ToString()))
            {
                MessageBox.Show("Указанная директория выходного файла не существует");
                convertButton.Enabled = true;
                return;
            }
            if (!File.Exists(inputFileTextBox.Text))
            {
                MessageBox.Show("Указаный путь входного файла не существует");
                convertButton.Enabled = true;
                return;
            }
            string input = inputFileTextBox.Text;
            if (!(input.EndsWith(".shp")||input.EndsWith(".TAB")||input.EndsWith(".MID") || input.EndsWith(".MIF")))
            {
                MessageBox.Show("Входной файл неверного формата");
                convertButton.Enabled = true;
                return;
            }
            string output = outputFileTextBox.Text + inputFileTextBox.Text.Substring(inputFileTextBox.Text.LastIndexOf(@"\"));
            output = output.Replace(output.Substring(output.LastIndexOf(".") + 1), format);
            Console.WriteLine(output);
            converter.ConvertFileFormat(inputFileTextBox.Text, output, format);

            convertButton.Enabled = true;

        }

        private void GeojsonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (geojsonRadioButton.Checked)
            {
                format = "geojson";
            }
            
        }

        private void GmlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gmlRadioButton.Checked)
            {
                format = "GML";
            }
        }
        
    }
}
