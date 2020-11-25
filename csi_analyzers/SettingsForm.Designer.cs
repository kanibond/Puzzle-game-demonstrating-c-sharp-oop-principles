namespace csi_analyzers
{
    partial class SettingsForm
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
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.mediumCheckbox = new System.Windows.Forms.GroupBox();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.importCheckBox = new System.Windows.Forms.CheckBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            this.mediumCheckbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.settingsGroupBox.Controls.Add(this.mediumCheckbox);
            this.settingsGroupBox.Controls.Add(this.groupBox1);
            this.settingsGroupBox.Controls.Add(this.descriptionLabel);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.settingsLabel);
            this.settingsGroupBox.Location = new System.Drawing.Point(324, 124);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(585, 536);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            // 
            // mediumCheckbox
            // 
            this.mediumCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediumCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.mediumCheckbox.Controls.Add(this.hardRadioButton);
            this.mediumCheckbox.Controls.Add(this.mediumRadioButton);
            this.mediumCheckbox.Controls.Add(this.easyRadioButton);
            this.mediumCheckbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumCheckbox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mediumCheckbox.Location = new System.Drawing.Point(6, 328);
            this.mediumCheckbox.Name = "mediumCheckbox";
            this.mediumCheckbox.Size = new System.Drawing.Size(569, 85);
            this.mediumCheckbox.TabIndex = 8;
            this.mediumCheckbox.TabStop = false;
            this.mediumCheckbox.Text = "Difficulty";
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Location = new System.Drawing.Point(497, 36);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(66, 22);
            this.hardRadioButton.TabIndex = 2;
            this.hardRadioButton.TabStop = true;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            this.hardRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(248, 36);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(86, 22);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Location = new System.Drawing.Point(6, 36);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(66, 22);
            this.easyRadioButton.TabIndex = 0;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            this.easyRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.uploadButton);
            this.groupBox1.Controls.Add(this.importCheckBox);
            this.groupBox1.Controls.Add(this.pathLabel);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(6, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import";
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.Transparent;
            this.uploadButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uploadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uploadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.ForeColor = System.Drawing.Color.White;
            this.uploadButton.Location = new System.Drawing.Point(6, 71);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(89, 28);
            this.uploadButton.TabIndex = 7;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            this.uploadButton.MouseEnter += new System.EventHandler(this.button_OnMouseEnter);
            this.uploadButton.MouseLeave += new System.EventHandler(this.button_OnMouseLeave);
            // 
            // importCheckBox
            // 
            this.importCheckBox.AutoSize = true;
            this.importCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCheckBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.importCheckBox.Location = new System.Drawing.Point(6, 34);
            this.importCheckBox.Name = "importCheckBox";
            this.importCheckBox.Size = new System.Drawing.Size(94, 22);
            this.importCheckBox.TabIndex = 5;
            this.importCheckBox.Text = "Enabled";
            this.importCheckBox.UseVisualStyleBackColor = true;
            this.importCheckBox.CheckedChanged += new System.EventHandler(this.importCheckBox_CheckedChanged);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pathLabel.Location = new System.Drawing.Point(101, 76);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(78, 18);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "FILE:  ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 58);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(573, 62);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Use random crime scenes or import your own. If you do not import crime scenes, ra" +
    "ndom ones will be generated with random sizes. Your settings will NOT be lost if" +
    " you exit the game.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 1);
            this.label2.TabIndex = 3;
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Location = new System.Drawing.Point(254, 16);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(99, 23);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Settings";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(1079, 702);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(128, 30);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.backButtons_Click);
            this.okButton.MouseEnter += new System.EventHandler(this.button_OnMouseEnter);
            this.okButton.MouseLeave += new System.EventHandler(this.button_OnMouseLeave);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(1079, 750);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.backButtons_Click);
            this.cancelButton.MouseEnter += new System.EventHandler(this.button_OnMouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.button_OnMouseLeave);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::csi_analyzers.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 812);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.settingsGroupBox);
            this.DoubleBuffered = true;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.settingsGroupBox.ResumeLayout(false);
            this.mediumCheckbox.ResumeLayout(false);
            this.mediumCheckbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox importCheckBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.GroupBox mediumCheckbox;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Button cancelButton;
    }
}