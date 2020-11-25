namespace csi_analyzers
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.mainMenuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 1);
            this.label2.TabIndex = 1;
            // 
            // mainMenuGroupBox
            // 
            this.mainMenuGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuGroupBox.Controls.Add(this.exitButton);
            this.mainMenuGroupBox.Controls.Add(this.settingsButton);
            this.mainMenuGroupBox.Controls.Add(this.instructionsButton);
            this.mainMenuGroupBox.Controls.Add(this.playButton);
            this.mainMenuGroupBox.Controls.Add(this.label2);
            this.mainMenuGroupBox.Controls.Add(this.label1);
            this.mainMenuGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuGroupBox.Location = new System.Drawing.Point(324, 124);
            this.mainMenuGroupBox.Name = "mainMenuGroupBox";
            this.mainMenuGroupBox.Size = new System.Drawing.Size(504, 333);
            this.mainMenuGroupBox.TabIndex = 0;
            this.mainMenuGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(203, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Quit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.buttons_OnMouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.buttons_OnMouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(203, 124);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(128, 30);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.buttons_OnMouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.buttons_OnMouseLeave);
            // 
            // instructionsButton
            // 
            this.instructionsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructionsButton.FlatAppearance.BorderSize = 0;
            this.instructionsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.instructionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.instructionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.instructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionsButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.ForeColor = System.Drawing.Color.White;
            this.instructionsButton.Location = new System.Drawing.Point(203, 88);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(128, 30);
            this.instructionsButton.TabIndex = 3;
            this.instructionsButton.Text = "How To Play";
            this.instructionsButton.UseVisualStyleBackColor = true;
            this.instructionsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            this.instructionsButton.MouseEnter += new System.EventHandler(this.buttons_OnMouseEnter);
            this.instructionsButton.MouseLeave += new System.EventHandler(this.buttons_OnMouseLeave);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(203, 55);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(128, 30);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Start Game";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.buttons_OnMouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.buttons_OnMouseLeave);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::csi_analyzers.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 609);
            this.Controls.Add(this.mainMenuGroupBox);
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.mainMenuGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mainMenuGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.Button playButton;
    }
}

