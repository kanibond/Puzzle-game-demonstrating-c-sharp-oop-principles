namespace csi_analyzers
{
    partial class GameForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.hurryLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.caseInformation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caseInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.timerProgressBar = new csi_analyzers.CustomProgressBar();
            this.caseInformationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.cluesFoundLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.caseInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = global::csi_analyzers.Properties.Resources.room3;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(989, 156);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 866);
            this.panel.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(982, 92);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(238, 42);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time Left:";
            // 
            // hurryLabel
            // 
            this.hurryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hurryLabel.AutoSize = true;
            this.hurryLabel.BackColor = System.Drawing.Color.Transparent;
            this.hurryLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurryLabel.ForeColor = System.Drawing.Color.White;
            this.hurryLabel.Location = new System.Drawing.Point(1739, 92);
            this.hurryLabel.Name = "hurryLabel";
            this.hurryLabel.Size = new System.Drawing.Size(150, 42);
            this.hurryLabel.TabIndex = 1;
            this.hurryLabel.Text = "Hurry!";
            this.hurryLabel.Visible = false;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLeftLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftLabel.Location = new System.Drawing.Point(1226, 92);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(110, 42);
            this.timeLeftLabel.TabIndex = 1;
            // 
            // timerBackgroundWorker
            // 
            this.timerBackgroundWorker.WorkerReportsProgress = true;
            this.timerBackgroundWorker.WorkerSupportsCancellation = true;
            this.timerBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.timerBackgroundWorker_DoWork);
            this.timerBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.timerBackgroundWorker_ProgressChanged);
            this.timerBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.timerBackgroundWorker_Completed);
            // 
            // caseInformation
            // 
            this.caseInformation.AutoSize = true;
            this.caseInformation.BackColor = System.Drawing.Color.Transparent;
            this.caseInformation.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseInformation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.caseInformation.Location = new System.Drawing.Point(32, 34);
            this.caseInformation.Name = "caseInformation";
            this.caseInformation.Size = new System.Drawing.Size(678, 42);
            this.caseInformation.TabIndex = 1;
            this.caseInformation.Text = "Officer Max Payne Murder Scene";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cluesFoundLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.guessesLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(39, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // caseInformationGroupBox
            // 
            this.caseInformationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.caseInformationGroupBox.Controls.Add(this.caseInformationLabel);
            this.caseInformationGroupBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseInformationGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.caseInformationGroupBox.Location = new System.Drawing.Point(39, 156);
            this.caseInformationGroupBox.Name = "caseInformationGroupBox";
            this.caseInformationGroupBox.Size = new System.Drawing.Size(434, 277);
            this.caseInformationGroupBox.TabIndex = 3;
            this.caseInformationGroupBox.TabStop = false;
            this.caseInformationGroupBox.Text = "Case Information";
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abortButton.BackColor = System.Drawing.Color.Transparent;
            this.abortButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.abortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.abortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortButton.ForeColor = System.Drawing.Color.Red;
            this.abortButton.Location = new System.Drawing.Point(39, 979);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(211, 43);
            this.abortButton.TabIndex = 8;
            this.abortButton.Text = "Abort Mission";
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.MenuButtons_Click);
            this.abortButton.MouseEnter += new System.EventHandler(this.button_OnMouseEnter);
            this.abortButton.MouseLeave += new System.EventHandler(this.button_OnMouseLeave);
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(275, 979);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(238, 43);
            this.restartButton.TabIndex = 9;
            this.restartButton.Text = "Restart Mission";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.MenuButtons_Click);
            this.restartButton.MouseEnter += new System.EventHandler(this.button_OnMouseEnter);
            this.restartButton.MouseLeave += new System.EventHandler(this.button_OnMouseLeave);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.timerProgressBar.ForeColor = System.Drawing.Color.Red;
            this.timerProgressBar.Location = new System.Drawing.Point(1342, 92);
            this.timerProgressBar.Name = "timerProgressBar";
            this.timerProgressBar.Size = new System.Drawing.Size(329, 42);
            this.timerProgressBar.Step = 1;
            this.timerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timerProgressBar.TabIndex = 2;
            this.timerProgressBar.Value = 100;
            // 
            // caseInformationLabel
            // 
            this.caseInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caseInformationLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseInformationLabel.Location = new System.Drawing.Point(17, 56);
            this.caseInformationLabel.Name = "caseInformationLabel";
            this.caseInformationLabel.Size = new System.Drawing.Size(396, 205);
            this.caseInformationLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guesses";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clues Found";
            // 
            // guessesLabel
            // 
            this.guessesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guessesLabel.Location = new System.Drawing.Point(260, 74);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(153, 33);
            this.guessesLabel.TabIndex = 0;
            this.guessesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cluesFoundLabel
            // 
            this.cluesFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cluesFoundLabel.Location = new System.Drawing.Point(260, 178);
            this.cluesFoundLabel.Name = "cluesFoundLabel";
            this.cluesFoundLabel.Size = new System.Drawing.Size(153, 39);
            this.cluesFoundLabel.TabIndex = 1;
            this.cluesFoundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::csi_analyzers.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.caseInformationGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timerProgressBar);
            this.Controls.Add(this.hurryLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.caseInformation);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.caseInformationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label hurryLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.ComponentModel.BackgroundWorker timerBackgroundWorker;
        private CustomProgressBar timerProgressBar;
        private System.Windows.Forms.Label caseInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox caseInformationGroupBox;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label caseInformationLabel;
        private System.Windows.Forms.Label cluesFoundLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label label1;
    }
}