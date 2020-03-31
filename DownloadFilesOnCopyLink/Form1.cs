using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DownloadFilesOnCopyLink
{


    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetClipboardViewer(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ChangeClipboardChain(IntPtr hWndDel, IntPtr hWndNext);

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wparam1, IntPtr lparam);

        IntPtr hWndNextWnd; //Для хранения указателя на следующее окно

        protected override void WndProc(ref Message m) // переопределяем метод 
        {
            switch (m.Msg) //Анализируем сообщение Windows
            {
                case (0x0001): // Код WM_CREATE наше окно создано
                    hWndNextWnd = SetClipboardViewer(this.Handle); // Помещаем наше окно в цепочку и сохраняем указатель на следующее 
                    break;
                case (0x0002): // Код WM_DESTROY окно будет разрушено, нужно удалитmся из цепочки буфера обмена
                    ChangeClipboardChain(this.Handle, hWndNextWnd); // Удаляем наше окно и передаём указатель на следующее окно
                    break;
                case (0x030D): // Код WM_CHANGECBCHAIN одно из окон удаено из цепочки, нужно востоновить цепочку
                    if (m.WParam == hWndNextWnd) // Если удаляемое окно это следующие окно в цепочке
                        hWndNextWnd = m.LParam; //Следующим окном делаем окно идущее в цепочке за удаляемым 
                    else if (hWndNextWnd != IntPtr.Zero) // Если дескриптор следующего окна определён
                        SendMessage(hWndNextWnd, m.Msg, m.WParam, m.LParam);// Посылаем сообщение этому окну
                    break;
                case (0x0308): //Код WM_DRAWCLIPBOARD содержимое буфера изменилось можно работать
                    {
                        CheckAndStartDownload();
                        SendMessage(hWndNextWnd, m.Msg, m.WParam, m.LParam);// Посылаем сообщение о изменении буфера дальше по цепочке
                    }
                    break;
            }
            base.WndProc(ref m); //обращаемся к нашему методу
        }

        ///////////////////////////////////////////////////////
        
        //Set in Form1_load function
        public Int32 lvDwnID;
        public Int32 lvDwnLink;
        public Int32 lvDwnStatus;
        public Int32 lvDwnDownloadPath;
        

        private void CheckAndStartDownload()
        {
            if (checkBoxAllowDownload.Checked && Clipboard.ContainsText() && Uri.IsWellFormedUriString(Clipboard.GetText(), UriKind.Absolute))
            {
                String receivedText = Clipboard.GetText();
                var userIndex = AddPlusOneAndGetIndex();
                var downloadRow = new string[] {"", userIndex.ToString(), receivedText, "Prepairing", ""};
                var listViewIndex = listViewDownloads.Items.Add(new ListViewItem(downloadRow)).Index;  
                DownloadFile(receivedText, userIndex, listViewIndex);
            }
        }

        private void DownloadFile(String url, Int32 userIndex, Int32 listViewIndex)
        {
            string downloadPath = textBoxPathToFolderSaveFiles.Text;
            string filename = "";
            try
            {
                Uri uri = new Uri(url);
                filename = userIndex + "_" + System.IO.Path.GetFileName(uri.LocalPath);
                listViewDownloads.Items[listViewIndex].SubItems[lvDwnDownloadPath].Text = filename;
            }
            catch(System.UriFormatException exp)
            {
                listViewDownloads.Items[listViewIndex].SubItems[lvDwnStatus].Text = exp.Message;
                return;
            }
            
            using (WebClient wc = new WebClient())
            {
                listViewDownloads.Items[listViewIndex].SubItems[lvDwnStatus].Text = "In queue";
                wc.DownloadFileCompleted += (sender, e) => WC_DownloadFileCompleted(sender, e, listViewIndex);
                wc.DownloadProgressChanged += (sender, e) => WC_DownloadProgressChanged(sender, e, listViewIndex);
                wc.DownloadFileAsync(new Uri(url), downloadPath + "/" + filename);
            }
        }

        private void WC_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e, int listViewIndex)
        {
            listViewDownloads.Items[listViewIndex].SubItems[lvDwnStatus].Text = e.ProgressPercentage.ToString() + "%";
        }

        private Int32 AddPlusOneAndGetIndex()
        {
            if (Int32.TryParse(textBoxStartAndActualIndex.Text, out Int32 actualIndex))
            {
                actualIndex += 1;
                textBoxStartAndActualIndex.Text = actualIndex.ToString();
                return actualIndex - 1;
            }
            else
            {
                return 0;
            }
        }

        private Int32 GetCurrentIndex()
        {
            if (Int32.TryParse(textBoxStartAndActualIndex.Text, out Int32 actualIndex))
            {
                return actualIndex;
            }
            else
            {
                return 0;
            }
        }

        private void WC_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e, int listViewIndex)
        {
            
            if (e.Cancelled)
            {
                listViewDownloads.Items[listViewIndex].SubItems[lvDwnStatus].Text = "The download has been cancelled";
                return;
            }

            if (e.Error != null)
            {
                listViewDownloads.Items[listViewIndex].SubItems[lvDwnStatus].Text = e.Error.Message;
                return;
            }
            
            listViewDownloads.Items[listViewIndex].SubItems[lvDwnStatus].Text = "File succesfully downloaded";
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPathToFolderSaveFiles.Text = Application.StartupPath;
            lvDwnID = columnHeaderID.DisplayIndex;
            lvDwnLink = ColumnHeaderLink.DisplayIndex;
            lvDwnDownloadPath = columnHeaderNameInFS.DisplayIndex;
            lvDwnStatus = ColumnHeaderStatius.DisplayIndex;
        }

        private void ScrollListViewDownloadsToDown()
        {
            listViewDownloads.Items[listViewDownloads.Items.Count - 1].EnsureVisible();
        }

        private void ButtonSelectDownloadingPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog
            {
                SelectedPath = textBoxPathToFolderSaveFiles.Text
            };
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBoxPathToFolderSaveFiles.Text = FBD.SelectedPath;
            }
        }

        private void CheckBoxAllowDownload_CheckedChanged(object sender, EventArgs e)
        {
            textBoxStartAndActualIndex.ReadOnly = checkBoxAllowDownload.Checked;
        }

        private void CheckBoxEnableAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
