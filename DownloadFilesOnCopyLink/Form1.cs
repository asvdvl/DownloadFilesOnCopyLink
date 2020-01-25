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
                        
                        if (Clipboard.ContainsText())
                        {
                            String receivedText = Clipboard.GetText();
                            listBoxCopyHistory.Items.Add(receivedText);
                            downloadFile(receivedText);
                        }
                        SendMessage(hWndNextWnd, m.Msg, m.WParam, m.LParam);// Посылаем сообщение о изменении бефера дальше по цепочке
                    }
                    break;
            }
            base.WndProc(ref m); //обращаемся к нашему методу
        }

        private void downloadFile(String url)
        {
            string desktopPath = textBoxPathToFolderSaveFiles.Text;
            string filename = "";
            try
            {
                Uri uri = new Uri(url);
                filename = System.IO.Path.GetFileName(uri.LocalPath);
            }
            catch(System.UriFormatException exp)
            {
                listBoxLog.Items.Add(exp.Message);
                return;
            }

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(url), desktopPath + "/" + filename);
            }
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                listBoxLog.Items.Add("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                listBoxLog.Items.Add("An error ocurred while trying to download file");

                return;
            }

            listBoxLog.Items.Add("File succesfully downloaded");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPathToFolderSaveFiles.Text = Application.StartupPath;
            listBoxCopyHistory.Items.Clear();
        }

        private void listBoxCopyHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
