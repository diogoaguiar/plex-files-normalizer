namespace plex_files_normalizer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fbd_browse = new System.Windows.Forms.FolderBrowserDialog();
            this.b_browse = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.b_go = new System.Windows.Forms.Button();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.l_current_file = new System.Windows.Forms.Label();
            this.l_source = new System.Windows.Forms.Label();
            this.l_season = new System.Windows.Forms.Label();
            this.tb_season = new System.Windows.Forms.TextBox();
            this.bw_normalizer = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // b_browse
            // 
            this.b_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_browse.Location = new System.Drawing.Point(352, 23);
            this.b_browse.Name = "b_browse";
            this.b_browse.Size = new System.Drawing.Size(75, 23);
            this.b_browse.TabIndex = 0;
            this.b_browse.Text = "Path...";
            this.b_browse.UseVisualStyleBackColor = true;
            this.b_browse.Click += new System.EventHandler(this.b_browse_Click);
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Location = new System.Drawing.Point(15, 25);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(334, 20);
            this.tb_path.TabIndex = 1;
            // 
            // b_go
            // 
            this.b_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_go.Location = new System.Drawing.Point(12, 89);
            this.b_go.Name = "b_go";
            this.b_go.Size = new System.Drawing.Size(75, 23);
            this.b_go.TabIndex = 2;
            this.b_go.Text = "Normalize";
            this.b_go.UseVisualStyleBackColor = true;
            this.b_go.Click += new System.EventHandler(this.b_go_Click);
            // 
            // pb_progress
            // 
            this.pb_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_progress.Location = new System.Drawing.Point(0, 119);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(439, 5);
            this.pb_progress.Step = 1;
            this.pb_progress.TabIndex = 3;
            this.pb_progress.Visible = false;
            // 
            // l_current_file
            // 
            this.l_current_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_current_file.AutoSize = true;
            this.l_current_file.Location = new System.Drawing.Point(93, 94);
            this.l_current_file.Name = "l_current_file";
            this.l_current_file.Size = new System.Drawing.Size(0, 13);
            this.l_current_file.TabIndex = 4;
            this.l_current_file.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_source
            // 
            this.l_source.AutoSize = true;
            this.l_source.Location = new System.Drawing.Point(12, 9);
            this.l_source.Name = "l_source";
            this.l_source.Size = new System.Drawing.Size(41, 13);
            this.l_source.TabIndex = 5;
            this.l_source.Text = "Source";
            // 
            // l_season
            // 
            this.l_season.AutoSize = true;
            this.l_season.Location = new System.Drawing.Point(12, 54);
            this.l_season.Name = "l_season";
            this.l_season.Size = new System.Drawing.Size(43, 13);
            this.l_season.TabIndex = 6;
            this.l_season.Text = "Season";
            // 
            // tb_season
            // 
            this.tb_season.Location = new System.Drawing.Point(61, 51);
            this.tb_season.Name = "tb_season";
            this.tb_season.Size = new System.Drawing.Size(100, 20);
            this.tb_season.TabIndex = 7;
            this.tb_season.Text = "01";
            // 
            // bw_normalizer
            // 
            this.bw_normalizer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_normalizer_DoWork);
            this.bw_normalizer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_normalizer_ProgressChanged);
            this.bw_normalizer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_normalizer_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 124);
            this.Controls.Add(this.tb_season);
            this.Controls.Add(this.l_season);
            this.Controls.Add(this.l_source);
            this.Controls.Add(this.l_current_file);
            this.Controls.Add(this.pb_progress);
            this.Controls.Add(this.b_go);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.b_browse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 163);
            this.MinimumSize = new System.Drawing.Size(455, 163);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plex Files Normalizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd_browse;
        private System.Windows.Forms.Button b_browse;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button b_go;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.Label l_current_file;
        private System.Windows.Forms.Label l_source;
        private System.Windows.Forms.Label l_season;
        private System.Windows.Forms.TextBox tb_season;
        private System.ComponentModel.BackgroundWorker bw_normalizer;
    }
}

