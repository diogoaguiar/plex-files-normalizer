using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plex_files_normalizer
{
    public partial class FormMain : Form
    {
        String[] allowedExtensions = { ".mkv", ".avi", ".mp4", "wmv", ".flv", ".mov" };
        public FormMain()
        {
            InitializeComponent();
            bw_normalizer.WorkerReportsProgress = true;
            pb_progress.Maximum = 100;
        }

        private void b_browse_Click(object sender, EventArgs e)
        {
            if (fbd_browse.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = fbd_browse.SelectedPath;
            }
        }

        private void b_go_Click(object sender, EventArgs e)
        {
            if (bw_normalizer.IsBusy != true)
            {
                // Disable interface
                pb_progress.Visible = true;
                pb_progress.Value = 0;
                l_current_file.Text = "";

                // Start the asynchronous normalization.
                bw_normalizer.RunWorkerAsync();
            }
        }

        private void bw_normalizer_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            // Source path
            String path = fbd_browse.SelectedPath;

            // File in source
            String[] files;
            try
            {
                files = Directory.GetFiles(path);
            } catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            // Set progress step
            int step = 100 / files.Length;
            int remainder = 100 % files.Length;
            int progress = 0;

            ArrayList nFiles = new ArrayList();

            String season = tb_season.Text;

            foreach (String file in files)
            {

                String ext = Path.GetExtension(file);
                String normalized = Path.GetFileName(file);

                // Report progress
                progress += step + remainder;
                remainder = 0;
                worker.ReportProgress(progress, normalized);

                // Check format
                if (!allowedExtensions.Contains(ext))
                {
                    continue;
                }

                // Remove extension
                normalized = normalized.Substring(0, normalized.Length - ext.Length);

                // Remove stuff in brakets
                normalized = Regex.Replace(normalized, @"\[.*?\]", "").Trim();
                //Console.WriteLine(normalized);

                // Get show name
                String show = Regex.Replace(normalized, @"^([a-zA-Z0-9\s-_]+)\s?-\s?\d\d?\d?(\.\d)?$", "$1").Trim();
                //Console.WriteLine(show);

                // Get episode number
                String episode = Regex.Replace(normalized, @"^([a-zA-Z0-9\s-_]+)\s?-\s?(\d\d?\d?(\.\d)?)$", "$2").Trim();
                //Console.WriteLine(episode);

                // Final
                normalized = show + " - S" + season + "E" + (episode.Length == 1 ? "0" + episode : episode) + ext;
                Console.WriteLine(normalized);

                // Folder
                DirectoryInfo dirInfo = Directory.CreateDirectory(Path.Combine(path, show, "Season " + season));


                File.Copy(file, Path.Combine(dirInfo.FullName, normalized), true);
            }
        }

        private void bw_normalizer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_progress.Value = e.ProgressPercentage;
            l_current_file.Text = e.UserState as String;
        }

        private void bw_normalizer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Enable interface
            pb_progress.Visible = false;
            l_current_file.Text = "";
        }
    }
}
