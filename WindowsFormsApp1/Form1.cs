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

namespace IDsGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneratePatch_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse ID
                int id = int.Parse(textBoxID.Text);

              
                string folderPath = textBoxPath.Text;
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("Path dont exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Get files from path
                string[] files = Directory.GetFiles(folderPath);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string listfilePath = saveFileDialog.FileName;

       
                        using (StreamWriter writer = new StreamWriter(listfilePath, false))
                        {
                            foreach (string file in files)
                            {
                    
                                string fileName = Path.GetFileName(file);

      
                                string line = $"{{\"file\":\"{fileName}\",\"id\":{id}}},";
                                writer.WriteLine(line);

                                // Adding to ID 1 
                                id++;
                            }
                        }

                        MessageBox.Show("List succesfully generated!", "Luck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
      
                MessageBox.Show($"Got error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonGenerateListfile_Click(object sender, EventArgs e)
        {

            try
            {
                // Parse ID
                int id = int.Parse(textBoxID.Text);

                // Check path
                string folderPath = textBoxPath.Text;
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("Path dont exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Get all files
                string[] files = Directory.GetFiles(folderPath);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {


                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string listfilePath = saveFileDialog.FileName;


                        using (StreamWriter writer = new StreamWriter(listfilePath, false))
                        {
                            foreach (string file in files)
                            {
                                // Get FileName with small letters
                                string fileName = Path.GetFileName(file).ToLower();

     
                                string line = $"{id};world/wmo/klanxaoc/doodads/{fileName}";
                                writer.WriteLine(line);

                                // Adding to ID 1
                                id++;
                            }
                        }

                        MessageBox.Show("List succesfully generated!", "Luck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
   
                MessageBox.Show($"Got Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindPath_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Choose files folder";
                folderBrowserDialog.ShowNewFolderButton = true;

                
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

       
    }
}
