using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HickTool
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var client = new WebClient();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://hickos.hickdick.workers.dev/0:/HickOS%20LTSC%202021.iso"), @"C:\HickTool\HickOS10LTSC2021.iso");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                siticoneProgressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            };
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            {
            };
            MessageBox.Show("Done");
        }

        private void siticoneProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://hickos.hickdick.workers.dev/0:/HickOS%201809%20LTSC.iso"), @"C:\HickTool\HickOSLTSC2019.iso");
                                                });
                                                thread.Start();
                                            }
                                            {
                                                {

                                                };
                                            }
                                            {
                                                {
                                                };
                                            }

                                        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            {
                Thread thread = new Thread(() =>
                {
                    WebClient client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(new Uri("https://laptop-updates.brave.com/latest/winx64"), @"C:\HickTool\BraveInstaller.exe");
                });
                thread.Start();
            }
            {
                {

                };
            }
            {
                {
                };
            }

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            {
                Thread thread = new Thread(() =>
                {
                    WebClient client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(new Uri("https://gitlab.com/librewolf-community/browser/windows/-/package_files/69100828/download"), @"C:\HickTool\LibreWolfInstaller.exe");
                });
                thread.Start();
            }
            {
                {

                };
            }
            {
                {
                };
            }
        }
    }
}
