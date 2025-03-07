using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Rename_files_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            lstPreview.Items.Clear();
            string folderPath = txtFolderPath.Text;
            string filePattern = txtFilePattern.Text;
            string renamePattern = txtRenamePattern.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Указанная папка не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string regexPattern = Regex.Escape(filePattern).Replace("\\#", "(\\d{1,4})");
                Regex regex = new Regex(regexPattern);
                string[] files = Directory.GetFiles(folderPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    Match match = regex.Match(fileName);
                    if (match.Success)
                    {
                        string episodeNumber = match.Groups[1].Value;
                        string newFileName = renamePattern.Replace("#", episodeNumber);
                        lstPreview.Items.Add($"{fileName} -> {newFileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ошибка: " + ex.Message);
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text;
            string filePattern = txtFilePattern.Text;
            string renamePattern = txtRenamePattern.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Указанная папка не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string regexPattern = Regex.Escape(filePattern).Replace("\\#", "(\\d{1,4})");
                Regex regex = new Regex(regexPattern);
                string[] files = Directory.GetFiles(folderPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    Match match = regex.Match(fileName);
                    if (match.Success)
                    {
                        string episodeNumber = match.Groups[1].Value;
                        string newFileName = renamePattern.Replace("#", episodeNumber);
                        string newFilePath = Path.Combine(folderPath, newFileName);

                        if (fileName != newFileName)
                        {
                            File.Move(file, newFilePath);
                        }
                    }
                }

                MessageBox.Show("Файлы успешно переименованы!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
