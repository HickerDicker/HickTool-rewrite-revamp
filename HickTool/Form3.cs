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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var client = new WebClient();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi"), @"C:\HickTool\EpicGamesLauncherInstaller.msi");
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


private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://dl.google.com/android/repository/platform-tools-latest-windows.zip"), @"C:\HickTool\platform-tools-latest-windows.zip");
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
        private void siticoneTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                                                    client.DownloadFileAsync(new Uri("https://ubi.li/4vxt9"), @"C:\HickTool\ubisoft.exe");
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
                                                    client.DownloadFileAsync(new Uri("https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-620.exe"), @"C:\HickTool\winrar-x64-620.exe");
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
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip?__token__=exp=1675706232~acl=/*~hmac=6e548d7dc0bd2e9a49e70d689ebbc522245da53af410613ce82a9915c53e3b7f"), @"C:\HickTool\MSIAfterburnerSetup.zip");
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
        private void siticoneButton8_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://www.voicemod.net/downloadVoicemod.php?l=1"), @"C:\HickTool\Voicemod.exe");
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
        private void siticoneButton5_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://clownfish-translator.com/voicechanger/download/download64.php?v=170"), @"C:\HickTool\clownfish.exe");
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
        private void siticoneButton13_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://www.sac.sk/download/utildiag/hwi_736.exe"), @"C:\HickTool\hwi_736.exe");
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
        private void siticoneButton12_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://download.cpuid.com/hwmonitor/hwmonitor_1.49.exe"), @"C:\HickTool\hwmonitor_1.49.exe");
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
        private void siticoneButton11_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://net.geo.opera.com/opera/stable/windows?utm_tryagain=yes&utm_source=google&utm_medium=ose&utm_campaign=(none)&http_referrer=https%3A%2F%2Fwww.google.com%2F&utm_site=opera_com&&utm_lastpage=opera.com/"), @"C:\HickTool\Opera.exe");
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
        private void siticoneButton10_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://net.geo.opera.com/opera_gx/stable/windows?utm_tryagain=yes&utm_source=google&utm_medium=ose&utm_campaign=(none)&http_referrer=https%3A%2F%2Fwww.google.com%2F&utm_site=opera_com&&utm_lastpage=opera.com/gx"), @"C:\HickTool\Operagx.exe");
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
        private void siticoneButton9_Click(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://hickos.hickdick.workers.dev/0:/HickOS%201.0.1%20(no%20security%20updates).iso"), @"C:\HickTool\HickOS22H2.iso");
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
        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
