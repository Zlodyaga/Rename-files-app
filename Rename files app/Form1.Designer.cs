namespace Rename_files_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFolderPath = new TextBox();
            labelFileFolder = new Label();
            labelMaskLabel = new Label();
            txtFilePattern = new TextBox();
            label2 = new Label();
            txtRenamePattern = new TextBox();
            btnRename = new Button();
            btnBrowse = new Button();
            lstPreview = new ListBox();
            btnPreview = new Button();
            SuspendLayout();
            // 
            // txtFolderPath
            // 
            txtFolderPath.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFolderPath.Location = new Point(71, 64);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(590, 39);
            txtFolderPath.TabIndex = 0;
            // 
            // labelFileFolder
            // 
            labelFileFolder.AutoSize = true;
            labelFileFolder.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFileFolder.Location = new Point(277, 21);
            labelFileFolder.Name = "labelFileFolder";
            labelFileFolder.Size = new Size(167, 31);
            labelFileFolder.TabIndex = 1;
            labelFileFolder.Text = "Folder of files";
            // 
            // labelMaskLabel
            // 
            labelMaskLabel.AutoSize = true;
            labelMaskLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMaskLabel.Location = new Point(277, 223);
            labelMaskLabel.Name = "labelMaskLabel";
            labelMaskLabel.Size = new Size(172, 31);
            labelMaskLabel.TabIndex = 3;
            labelMaskLabel.Text = "Search pattern";
            // 
            // txtFilePattern
            // 
            txtFilePattern.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFilePattern.Location = new Point(71, 257);
            txtFilePattern.Name = "txtFilePattern";
            txtFilePattern.Size = new Size(590, 39);
            txtFilePattern.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(277, 322);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 5;
            label2.Text = "Replace pettern";
            // 
            // txtRenamePattern
            // 
            txtRenamePattern.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtRenamePattern.Location = new Point(71, 356);
            txtRenamePattern.Name = "txtRenamePattern";
            txtRenamePattern.Size = new Size(590, 39);
            txtRenamePattern.TabIndex = 4;
            // 
            // btnRename
            // 
            btnRename.Font = new Font("Times New Roman", 20.25F);
            btnRename.Location = new Point(243, 431);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(244, 44);
            btnRename.TabIndex = 6;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Times New Roman", 20.25F);
            btnBrowse.Location = new Point(243, 124);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(244, 44);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = "Choose folder";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lstPreview
            // 
            lstPreview.Font = new Font("Times New Roman", 20.25F);
            lstPreview.FormattingEnabled = true;
            lstPreview.ItemHeight = 31;
            lstPreview.Location = new Point(716, 21);
            lstPreview.Name = "lstPreview";
            lstPreview.Size = new Size(471, 376);
            lstPreview.TabIndex = 8;
            // 
            // btnPreview
            // 
            btnPreview.Font = new Font("Times New Roman", 20.25F);
            btnPreview.Location = new Point(835, 431);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(244, 44);
            btnPreview.TabIndex = 9;
            btnPreview.Text = "Show preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 511);
            Controls.Add(btnPreview);
            Controls.Add(lstPreview);
            Controls.Add(btnBrowse);
            Controls.Add(btnRename);
            Controls.Add(label2);
            Controls.Add(txtRenamePattern);
            Controls.Add(labelMaskLabel);
            Controls.Add(txtFilePattern);
            Controls.Add(labelFileFolder);
            Controls.Add(txtFolderPath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFolderPath;
        private Label labelFileFolder;
        private Label labelMaskLabel;
        private TextBox txtFilePattern;
        private Label label2;
        private TextBox txtRenamePattern;
        private Button btnRename;
        private Button btnBrowse;
        private ListBox lstPreview;
        private Button btnPreview;
    }
}
