namespace DesktopFoto
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTimerIntervalInSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTargetDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectoryBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.FotoTimer = new System.Windows.Forms.Timer(this.components);
            this.fbdStoreDirectory = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerIntervalInSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tijd tussen de Foto\'s";
            // 
            // nudTimerIntervalInSeconds
            // 
            this.nudTimerIntervalInSeconds.Location = new System.Drawing.Point(123, 11);
            this.nudTimerIntervalInSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimerIntervalInSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerIntervalInSeconds.Name = "nudTimerIntervalInSeconds";
            this.nudTimerIntervalInSeconds.Size = new System.Drawing.Size(53, 20);
            this.nudTimerIntervalInSeconds.TabIndex = 1;
            this.nudTimerIntervalInSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "seconden (1-60)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Map waar de Foto\'s worden opgeslagen";
            // 
            // tbTargetDirectory
            // 
            this.tbTargetDirectory.Location = new System.Drawing.Point(19, 62);
            this.tbTargetDirectory.Name = "tbTargetDirectory";
            this.tbTargetDirectory.Size = new System.Drawing.Size(211, 20);
            this.tbTargetDirectory.TabIndex = 4;
            // 
            // btnDirectoryBrowse
            // 
            this.btnDirectoryBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectoryBrowse.Location = new System.Drawing.Point(237, 62);
            this.btnDirectoryBrowse.Name = "btnDirectoryBrowse";
            this.btnDirectoryBrowse.Size = new System.Drawing.Size(30, 20);
            this.btnDirectoryBrowse.TabIndex = 5;
            this.btnDirectoryBrowse.Text = "...";
            this.btnDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnDirectoryBrowse.Click += new System.EventHandler(this.btnDirectoryBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FotoTimer
            // 
            this.FotoTimer.Tick += new System.EventHandler(this.FotoTimer_Tick);
            // 
            // fbdStoreDirectory
            // 
            this.fbdStoreDirectory.Description = "Directorie om de Desktop plaatjes op te slaan";
            this.fbdStoreDirectory.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDirectoryBrowse);
            this.Controls.Add(this.tbTargetDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTimerIntervalInSeconds);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "MainForm";
            this.Text = "Desktop Foto";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerIntervalInSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTimerIntervalInSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTargetDirectory;
        private System.Windows.Forms.Button btnDirectoryBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer FotoTimer;
        private System.Windows.Forms.FolderBrowserDialog fbdStoreDirectory;
    }
}

