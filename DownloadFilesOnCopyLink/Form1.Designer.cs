namespace DownloadFilesOnCopyLink
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxPathToFolderSaveFiles = new System.Windows.Forms.TextBox();
            this.labelDescriptionPathToSaveFiles = new System.Windows.Forms.Label();
            this.labelDescriptionStartIndex = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
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
            this.listBoxCopyHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCopyHistory_MouseDoubleClick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(338, 18);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(38, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select path";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(5, 148);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(371, 95);
            this.listBoxLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 433);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescriptionStartIndex);
            this.Controls.Add(this.labelDescriptionPathToSaveFiles);
            this.Controls.Add(this.buttonStart);
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
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxPathToFolderSaveFiles;
        private System.Windows.Forms.Label labelDescriptionPathToSaveFiles;
        private System.Windows.Forms.Label labelDescriptionStartIndex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

