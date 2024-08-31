using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDsGenerator
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        // Method to search for ID by file name
        public static int? FindListName(string fileName, string listfilePath)
        {
 
                // Check if the specified file exists
                if (!File.Exists(listfilePath))
                {
                    throw new FileNotFoundException("listfile.csv not found.", listfilePath);
                }

            fileName = fileName.ToLower();

            // Open the file for reading
            using (StreamReader reader = new StreamReader(listfilePath))
                {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');

                    if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out int id))
                    {
                        // Get only the file name (ignoring the path)
                        string fullFilePath = parts[1].Trim().ToLower();
                        string listFileName = Path.GetFileName(fullFilePath); // Extract only the file name

                        // Check if the file name matches
                        if (listFileName == fileName)
                        {
                            return id;
                        }
                    }
                }

                }
    


            // If nothing is found, return null
            return null;
        }
    }
}
