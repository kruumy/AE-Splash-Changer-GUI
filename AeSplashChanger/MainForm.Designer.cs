namespace AeSplashChanger
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
            this.importbtn = new System.Windows.Forms.Button();
            this.exportbtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.aefolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splashLabel = new System.Windows.Forms.Label();
            this.defaultsbtn = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // importbtn
            // 
            this.importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.importbtn.FlatAppearance.BorderSize = 0;
            this.importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importbtn.Location = new System.Drawing.Point(11, 28);
            this.importbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(117, 194);
            this.importbtn.TabIndex = 0;
            this.importbtn.Text = "Import";
            this.importbtn.UseVisualStyleBackColor = false;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // exportbtn
            // 
            this.exportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.exportbtn.FlatAppearance.BorderSize = 0;
            this.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportbtn.Location = new System.Drawing.Point(499, 28);
            this.exportbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(120, 194);
            this.exportbtn.TabIndex = 0;
            this.exportbtn.Text = "Export";
            this.exportbtn.UseVisualStyleBackColor = false;
            this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(136, 28);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 245);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "importFileDialog";
            // 
            // splashLabel
            // 
            this.splashLabel.AutoSize = true;
            this.splashLabel.Location = new System.Drawing.Point(131, 3);
            this.splashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.splashLabel.Name = "splashLabel";
            this.splashLabel.Size = new System.Drawing.Size(206, 22);
            this.splashLabel.TabIndex = 1;
            this.splashLabel.Text = "Current Splash Screen:";
            // 
            // defaultsbtn
            // 
            this.defaultsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.defaultsbtn.FlatAppearance.BorderSize = 0;
            this.defaultsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultsbtn.Location = new System.Drawing.Point(499, 228);
            this.defaultsbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.defaultsbtn.Name = "defaultsbtn";
            this.defaultsbtn.Size = new System.Drawing.Size(120, 45);
            this.defaultsbtn.TabIndex = 0;
            this.defaultsbtn.Text = "Defaults";
            this.defaultsbtn.UseVisualStyleBackColor = false;
            this.defaultsbtn.Click += new System.EventHandler(this.defaultsbtn_click);
            // 
            // Github
            // 
            this.Github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Github.FlatAppearance.BorderSize = 0;
            this.Github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Github.Location = new System.Drawing.Point(11, 228);
            this.Github.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(117, 45);
            this.Github.TabIndex = 0;
            this.Github.Text = "Github";
            this.Github.UseVisualStyleBackColor = false;
            this.Github.Click += new System.EventHandler(this.githubbtn_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(635, 285);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.defaultsbtn);
            this.Controls.Add(this.splashLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.exportbtn);
            this.Controls.Add(this.importbtn);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "After Effects Splash Screen Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importbtn;
        private System.Windows.Forms.Button exportbtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FolderBrowserDialog aefolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Label splashLabel;
        private System.Windows.Forms.Button defaultsbtn;
        private System.Windows.Forms.Button Github;
    }
}

