﻿namespace DownloadFilesOnCopyLink
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxStartAndActualIndex = new System.Windows.Forms.TextBox();
            this.listBoxCopyHistory = new System.Windows.Forms.ListBox();
            this.textBoxPathToFolderSaveFiles = new System.Windows.Forms.TextBox();
            this.labelDescriptionPathToSaveFiles = new System.Windows.Forms.Label();
            this.labelDescriptionStartIndex = new System.Windows.Forms.Label();
            this.buttonSelectDownloadingPath = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.listBoxSucsessfulDownloads = new System.Windows.Forms.ListBox();
            this.buttonClearAllListBox = new System.Windows.Forms.Button();
            this.listViewDownloads = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderStatius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxAllowDownload = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAutoScroll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxStartAndActualIndex
            // 
            this.textBoxStartAndActualIndex.Location = new System.Drawing.Point(291, 20);
            this.textBoxStartAndActualIndex.Name = "textBoxStartAndActualIndex";
            this.textBoxStartAndActualIndex.Size = new System.Drawing.Size(45, 20);
            this.textBoxStartAndActualIndex.TabIndex = 0;
            this.textBoxStartAndActualIndex.Text = "0";
            // 
            // listBoxCopyHistory
            // 
            this.listBoxCopyHistory.FormattingEnabled = true;
            this.listBoxCopyHistory.Location = new System.Drawing.Point(5, 47);
            this.listBoxCopyHistory.Name = "listBoxCopyHistory";
            this.listBoxCopyHistory.Size = new System.Drawing.Size(371, 95);
            this.listBoxCopyHistory.TabIndex = 1;
            this.listBoxCopyHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxCopyHistory_MouseDoubleClick);
            // 
            // textBoxPathToFolderSaveFiles
            // 
            this.textBoxPathToFolderSaveFiles.Location = new System.Drawing.Point(5, 19);
            this.textBoxPathToFolderSaveFiles.Name = "textBoxPathToFolderSaveFiles";
            this.textBoxPathToFolderSaveFiles.Size = new System.Drawing.Size(178, 20);
            this.textBoxPathToFolderSaveFiles.TabIndex = 0;
            this.textBoxPathToFolderSaveFiles.Text = "Path to save files";
            // 
            // labelDescriptionPathToSaveFiles
            // 
            this.labelDescriptionPathToSaveFiles.AutoSize = true;
            this.labelDescriptionPathToSaveFiles.Location = new System.Drawing.Point(5, 3);
            this.labelDescriptionPathToSaveFiles.Name = "labelDescriptionPathToSaveFiles";
            this.labelDescriptionPathToSaveFiles.Size = new System.Drawing.Size(73, 13);
            this.labelDescriptionPathToSaveFiles.TabIndex = 3;
            this.labelDescriptionPathToSaveFiles.Text = "Path to folder ";
            // 
            // labelDescriptionStartIndex
            // 
            this.labelDescriptionStartIndex.AutoSize = true;
            this.labelDescriptionStartIndex.Location = new System.Drawing.Point(289, 4);
            this.labelDescriptionStartIndex.Name = "labelDescriptionStartIndex";
            this.labelDescriptionStartIndex.Size = new System.Drawing.Size(33, 13);
            this.labelDescriptionStartIndex.TabIndex = 4;
            this.labelDescriptionStartIndex.Text = "Index";
            // 
            // buttonSelectDownloadingPath
            // 
            this.buttonSelectDownloadingPath.Location = new System.Drawing.Point(185, 18);
            this.buttonSelectDownloadingPath.Name = "buttonSelectDownloadingPath";
            this.buttonSelectDownloadingPath.Size = new System.Drawing.Size(69, 23);
            this.buttonSelectDownloadingPath.TabIndex = 5;
            this.buttonSelectDownloadingPath.Text = "Select path";
            this.buttonSelectDownloadingPath.UseVisualStyleBackColor = true;
            this.buttonSelectDownloadingPath.Click += new System.EventHandler(this.ButtonSelectDownloadingPath_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(5, 148);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(371, 95);
            this.listBoxLog.TabIndex = 7;
            // 
            // listBoxSucsessfulDownloads
            // 
            this.listBoxSucsessfulDownloads.FormattingEnabled = true;
            this.listBoxSucsessfulDownloads.Location = new System.Drawing.Point(5, 249);
            this.listBoxSucsessfulDownloads.Name = "listBoxSucsessfulDownloads";
            this.listBoxSucsessfulDownloads.Size = new System.Drawing.Size(371, 95);
            this.listBoxSucsessfulDownloads.TabIndex = 8;
            // 
            // buttonClearAllListBox
            // 
            this.buttonClearAllListBox.Location = new System.Drawing.Point(5, 398);
            this.buttonClearAllListBox.Name = "buttonClearAllListBox";
            this.buttonClearAllListBox.Size = new System.Drawing.Size(371, 23);
            this.buttonClearAllListBox.TabIndex = 10;
            this.buttonClearAllListBox.Text = "clear all lists";
            this.buttonClearAllListBox.UseVisualStyleBackColor = true;
            this.buttonClearAllListBox.Click += new System.EventHandler(this.ButtonClearAllListBox_Click);
            // 
            // listViewDownloads
            // 
            this.listViewDownloads.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.ColumnHeaderLink,
            this.ColumnHeaderStatius,
            this.columnHeaderName});
            this.listViewDownloads.GridLines = true;
            this.listViewDownloads.HoverSelection = true;
            this.listViewDownloads.Location = new System.Drawing.Point(382, 47);
            this.listViewDownloads.Name = "listViewDownloads";
            this.listViewDownloads.Size = new System.Drawing.Size(475, 351);
            this.listViewDownloads.TabIndex = 12;
            this.listViewDownloads.UseCompatibleStateImageBehavior = false;
            this.listViewDownloads.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 30;
            // 
            // ColumnHeaderLink
            // 
            this.ColumnHeaderLink.Text = "Link";
            this.ColumnHeaderLink.Width = 192;
            // 
            // ColumnHeaderStatius
            // 
            this.ColumnHeaderStatius.Text = "Status";
            this.ColumnHeaderStatius.Width = 66;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 143;
            // 
            // checkBoxAllowDownload
            // 
            this.checkBoxAllowDownload.AutoSize = true;
            this.checkBoxAllowDownload.Location = new System.Drawing.Point(338, 23);
            this.checkBoxAllowDownload.Name = "checkBoxAllowDownload";
            this.checkBoxAllowDownload.Size = new System.Drawing.Size(40, 17);
            this.checkBoxAllowDownload.TabIndex = 13;
            this.checkBoxAllowDownload.Text = "On";
            this.checkBoxAllowDownload.UseVisualStyleBackColor = true;
            this.checkBoxAllowDownload.CheckedChanged += new System.EventHandler(this.CheckBoxAllowDownload_CheckedChanged);
            // 
            // checkBoxEnableAutoScroll
            // 
            this.checkBoxEnableAutoScroll.AutoSize = true;
            this.checkBoxEnableAutoScroll.Location = new System.Drawing.Point(266, 350);
            this.checkBoxEnableAutoScroll.Name = "checkBoxEnableAutoScroll";
            this.checkBoxEnableAutoScroll.Size = new System.Drawing.Size(110, 17);
            this.checkBoxEnableAutoScroll.TabIndex = 14;
            this.checkBoxEnableAutoScroll.Text = "Enable auto scroll";
            this.checkBoxEnableAutoScroll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 456);
            this.Controls.Add(this.checkBoxEnableAutoScroll);
            this.Controls.Add(this.checkBoxAllowDownload);
            this.Controls.Add(this.listViewDownloads);
            this.Controls.Add(this.buttonClearAllListBox);
            this.Controls.Add(this.listBoxSucsessfulDownloads);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonSelectDownloadingPath);
            this.Controls.Add(this.labelDescriptionStartIndex);
            this.Controls.Add(this.labelDescriptionPathToSaveFiles);
            this.Controls.Add(this.listBoxCopyHistory);
            this.Controls.Add(this.textBoxPathToFolderSaveFiles);
            this.Controls.Add(this.textBoxStartAndActualIndex);
            this.Name = "Form1";
            this.Text = "Download";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStartAndActualIndex;
        private System.Windows.Forms.ListBox listBoxCopyHistory;
        private System.Windows.Forms.TextBox textBoxPathToFolderSaveFiles;
        private System.Windows.Forms.Label labelDescriptionPathToSaveFiles;
        private System.Windows.Forms.Label labelDescriptionStartIndex;
        private System.Windows.Forms.Button buttonSelectDownloadingPath;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ListBox listBoxSucsessfulDownloads;
        private System.Windows.Forms.Button buttonClearAllListBox;
        private System.Windows.Forms.ListView listViewDownloads;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader ColumnHeaderLink;
        private System.Windows.Forms.ColumnHeader ColumnHeaderStatius;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.CheckBox checkBoxAllowDownload;
        private System.Windows.Forms.CheckBox checkBoxEnableAutoScroll;
    }
}

