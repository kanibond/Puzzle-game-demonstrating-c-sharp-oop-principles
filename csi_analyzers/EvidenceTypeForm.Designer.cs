namespace csi_analyzers
{
    partial class EvidenceTypeForm
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
            this.fingerprintsButton = new System.Windows.Forms.Button();
            this.DNAButton = new System.Windows.Forms.Button();
            this.bloodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(62, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1074, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "What type of evidence would you like to collect?";
            // 
            // fingerprintsButton
            // 
            this.fingerprintsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fingerprintsButton.BackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.fingerprintsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fingerprintsButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerprintsButton.ForeColor = System.Drawing.Color.White;
            this.fingerprintsButton.Location = new System.Drawing.Point(146, 422);
            this.fingerprintsButton.Name = "fingerprintsButton";
            this.fingerprintsButton.Size = new System.Drawing.Size(209, 55);
            this.fingerprintsButton.TabIndex = 1;
            this.fingerprintsButton.Text = "Fingerprints";
            this.fingerprintsButton.UseVisualStyleBackColor = false;
            this.fingerprintsButton.Click += new System.EventHandler(this.buttons_Click);
            this.fingerprintsButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.fingerprintsButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // DNAButton
            // 
            this.DNAButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DNAButton.BackColor = System.Drawing.Color.Transparent;
            this.DNAButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.DNAButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DNAButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DNAButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DNAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DNAButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNAButton.ForeColor = System.Drawing.Color.White;
            this.DNAButton.Location = new System.Drawing.Point(496, 422);
            this.DNAButton.Name = "DNAButton";
            this.DNAButton.Size = new System.Drawing.Size(209, 55);
            this.DNAButton.TabIndex = 1;
            this.DNAButton.Text = "DNA";
            this.DNAButton.UseVisualStyleBackColor = false;
            this.DNAButton.Click += new System.EventHandler(this.buttons_Click);
            this.DNAButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.DNAButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // bloodButton
            // 
            this.bloodButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bloodButton.BackColor = System.Drawing.Color.Transparent;
            this.bloodButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.bloodButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bloodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bloodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bloodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloodButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodButton.ForeColor = System.Drawing.Color.White;
            this.bloodButton.Location = new System.Drawing.Point(839, 422);
            this.bloodButton.Name = "bloodButton";
            this.bloodButton.Size = new System.Drawing.Size(209, 55);
            this.bloodButton.TabIndex = 1;
            this.bloodButton.Text = "Blood";
            this.bloodButton.UseVisualStyleBackColor = false;
            this.bloodButton.Click += new System.EventHandler(this.buttons_Click);
            this.bloodButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.bloodButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // EvidenceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::csi_analyzers.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 660);
            this.Controls.Add(this.bloodButton);
            this.Controls.Add(this.DNAButton);
            this.Controls.Add(this.fingerprintsButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvidenceTypeForm";
            this.Text = "EvidenceTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fingerprintsButton;
        private System.Windows.Forms.Button DNAButton;
        private System.Windows.Forms.Button bloodButton;
    }
}