using System;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;

namespace ThreadUITest
{
    public partial class Form1 : Form
    {
        int value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxUI.Text = value.ToString();

            // attach async anonymous function to event so the click event would not block the UI
            downloadBigFileAsync2.Click += async (o, e) =>
            {
                textBoxDownloadBigFileAsync.Text += "Downloading.." + Environment.NewLine;
                var webClient = new WebClient();
                var b = await webClient.DownloadDataTaskAsync("https://link.testfile.org/zwj7WO");
                textBoxDownloadBigFileAsync.Text += $"Finished {b.Length}" + Environment.NewLine;
            };
        }

        private void uiPlus1_Click(object sender, EventArgs e)
        {
            value++;
            textBoxUI.Text = value.ToString();
        }

        private void uiMinus1_Click(object sender, EventArgs e)
        {
            value--;
            textBoxUI.Text = value.ToString();
        }

        private void functionInThread_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DoFunctionInThread);

            textBoxFunctionInThread.Text += "Starting" + Environment.NewLine;
            t.Start();
            textBoxFunctionInThread.Text += "Started" + Environment.NewLine;
            t.Join();
            textBoxFunctionInThread.Text += "Joined" + Environment.NewLine;
        }
        public static void DoFunctionInThread()
        {
            Thread.Sleep(5000);
        }

        private async void asyncReadJsonFile_Click(object sender, EventArgs e)
        {
            textBoxReadJsonFile.Text += "Starting" + Environment.NewLine;
            await DoReadJsonFile();
            textBoxReadJsonFile.Text += "Started" + Environment.NewLine;
            textBoxReadJsonFile.Text += "Joined" + Environment.NewLine;
        }
        public static async Task DoReadJsonFile()
        {
            Thread.Sleep(5000);
        }

        private void donwloadBigFile_Click(object sender, EventArgs e)
        {
            textBoxDownloadBigFile.Text += "DownloadBigFile s" + Environment.NewLine;
            DownloadBigFile("https://link.testfile.org/zwj7WO");
            textBoxDownloadBigFile.Text += "DownloadBigFile d" + Environment.NewLine;
        }
        public void DownloadBigFile(string url)
        {
            textBoxDownloadBigFile.Text += "Downloading.." + Environment.NewLine;
            var webClient = new WebClient();
            var b = webClient.DownloadData(url);
            textBoxDownloadBigFile.Text += $"Finished {b.Length}" + Environment.NewLine;
        }

        private async void downloadBigFileAsync_Click(object sender, EventArgs e)
        {
            textBoxDownloadBigFileAsync.Text += "DownloadBigFileAsync s" + Environment.NewLine;
            var t = DownloadBigFileAsync("https://link.testfile.org/zwj7WO");
            textBoxDownloadBigFileAsync.Text += $"DownloadBigFileAsync b" + Environment.NewLine;
            var str = await t;
            textBoxDownloadBigFileAsync.Text += $"DownloadBigFileAsync d {str}" + Environment.NewLine;
        }
        public async Task<string> DownloadBigFileAsync(string url)
        {
            textBoxDownloadBigFileAsync.Text += "Downloading.." + Environment.NewLine;
            var webClient = new WebClient();
            var b = await webClient.DownloadDataTaskAsync(url);
            textBoxDownloadBigFileAsync.Text += $"Finished {b.Length}" + Environment.NewLine;
            return b.Length.ToString();
        }
    }
}
