using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FilenamesToNumbers
{
    public partial class FormMain : Form
    {
        public int startCount;
        public string prefix;

        public FormMain()
        {
            InitializeComponent();
            startCount = 1;
            prefix = "";
        }

        private void buttonRenameFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiles = new OpenFileDialog();
            openFiles.Filter = ".JPG Files|*.JPG;*.JPEG|Image Files|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG;*.DDS|All files|*.*";
            openFiles.Multiselect = true;

            DialogResult ofDResult = openFiles.ShowDialog();
            if (ofDResult != DialogResult.OK) return;
            for (int i = 1; i <= openFiles.FileNames.Count(); i++)
            {
                string oldFullFileName = openFiles.FileNames[i - 1];
                string fileExtension = Path.GetExtension(oldFullFileName);
                string filepath = Path.GetDirectoryName(oldFullFileName);

                string newFullFileName = Path.Combine(filepath, prefix + (i + startCount - 1));

                if (File.Exists(newFullFileName + fileExtension) && !oldFullFileName.Equals(newFullFileName + fileExtension))
                {
                    int existingCount = 1;
                    while (File.Exists(string.Format("{0} ({1}){2}", newFullFileName, existingCount, fileExtension)))
                        existingCount++;

                    File.Move(newFullFileName + fileExtension, string.Format("{0} ({1}){2}", newFullFileName, existingCount, fileExtension));
                }
                File.Move(oldFullFileName, newFullFileName + fileExtension);
            }
            MessageBox.Show("Done!");
        }

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {
            prefix = textBoxPrefix.Text;
            labelExample.Text = string.Format("{0}{1}.jpg", prefix, startCount);
        }

        private void numericUpDownBeginCount_ValueChanged(object sender, EventArgs e)
        {
            startCount = (int)numericUpDownBeginCount.Value;
            labelExample.Text = string.Format("{0}{1}.jpg", prefix, startCount);
        }

        private void textBoxPrefix_Leave(object sender, EventArgs e)
        {
            string invalidchars = "[\\/\\?\\\\\\|\\*\\:\\\"\\<\\>]";
            string replacement = " ";
            Regex fileNameFixer = new Regex(invalidchars);
            textBoxPrefix.Text = fileNameFixer.Replace(textBoxPrefix.Text, replacement);

            prefix = textBoxPrefix.Text;
            labelExample.Text = string.Format("{0}{1}.jpg", prefix, startCount);
        }
    }
}
