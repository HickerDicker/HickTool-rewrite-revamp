using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HickTool
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Download_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://dl.google.com/chrome/install/chrome_installer.exe"), @"C:\HickTool\GoogleChrome.exe");
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

        private void siticoneButton8_Click(object sender, EventArgs e)

                        {
                            {
                                Thread thread = new Thread(() =>
                                {
                                    WebClient client = new WebClient();
                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                    client.DownloadFileAsync(new Uri("https://github.com/Chuyu-Team/Dism-Multi-language/releases/download/v10.1.1002.1/Dism++10.1.1002.1.zip"), @"C:\HickTool\Dism++10.1.1002.1.zip");
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
        private void siticoneButton7_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            {
                Thread thread = new Thread(() =>
                {
                    WebClient client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(new Uri("https://download.mozilla.org/?product=firefox-stub&os=win&lang=en-US&attribution_code=c291cmNlPXd3dy5nb29nbGUuY29tJm1lZGl1bT1yZWZlcnJhbCZjYW1wYWlnbj0obm90IHNldCkmY29udGVudD0obm90IHNldCkmZXhwZXJpbWVudD0obm90IHNldCkmdmFyaWF0aW9uPShub3Qgc2V0KSZ1YT1maXJlZm94JnZpc2l0X2lkPShub3Qgc2V0KQ..&attribution_sig=ff7c8baaa0aab01235ab049918ca8061692d23fb1096daa24caae29f806e392c"), @"C:\HickTool\Firefox.exe");
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
                        client.DownloadFileAsync(new Uri("https://www.7-zip.org/a/7z2201-x64.exe"), @"C:\HickTool\7z2201-x64.exe");
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

        private void siticoneButton2_Click(object sender, EventArgs e)

                {
                    {
                        Thread thread = new Thread(() =>
                        {
                            WebClient client = new WebClient();
                            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                            client.DownloadFileAsync(new Uri("https://cdn-fastly.obsproject.com/downloads/OBS-Studio-29.0.2-Full-Installer-x64.exe"), @"C:\HickTool\OBS-Studio-29.0.2-Full-Installer-x64.exe");
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
                                client.DownloadFileAsync(new Uri("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.4.9/npp.8.4.9.Installer.x64.exe"), @"C:\HickTool\npp.8.4.9.Installer.x64.exe");
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
        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)

                            {
                                {
                                    Thread thread = new Thread(() =>
                                    {
                                        WebClient client = new WebClient();
                                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                        client.DownloadFileAsync(new Uri("https://startisback.sfo3.cdn.digitaloceanspaces.com/StartIsBackPlusPlus_setup.exe"), @"C:\HickTool\StartIsBackPlusPlus_setup.exe");
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

        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton12_Click(object sender, EventArgs e)

                                    {
                                        {
                                            Thread thread = new Thread(() =>
                                            {
                                                WebClient client = new WebClient();
                                                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                client.DownloadFileAsync(new Uri("https://github.com/Open-Shell/Open-Shell-Menu/releases/download/v4.4.170/OpenShellSetup_4_4_170.exe"), @"C:\HickTool\OpenShellSetup_4_4_170.exe");
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
                                            client.DownloadFileAsync(new Uri("https://github.com/Open-Shell/Open-Shell-Menu/releases/download/v4.4.170/OpenShellSetup_4_4_170.exe"), @"C:\HickTool\OpenShellSetup_4_4_170.exe");
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


        private void siticoneTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton12_Click_1(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://download.teamviewer.com/download/TeamViewer_Setup_x64.exe"), @"C:\HickTool\TeamViewer_Setup_x64.exe");
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
        private void siticoneButton11_Click_1(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://mirrors.netix.net/vlc/vlc/3.0.18/win64/vlc-3.0.18-win64.exe"), @"C:\HickTool\vlc-3.0.18-win64.exe");
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
        private void siticoneButton10_Click_1(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://www.vmware.com/go/getworkstation-win"), @"C:\HickTool\vmwa.exe");
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
        private void siticoneButton9_Click_1(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://hickos.hickdick.workers.dev/0:/NVCleanstall_1.15.1.exe"), @"C:\HickTool\NVCleanstall_1.15.1.exe");
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
        private void siticoneButton6_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void siticoneButton5_Click_1(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://startisback.sfo3.cdn.digitaloceanspaces.com/StartIsBackPlusPlus_setup.exe"), @"C:\HickTool\StartIsBackPlusPlus_setup.exe");
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
        private void siticoneButton13_Click_1(object sender, EventArgs e)

                                        {
                                            {
                                                Thread thread = new Thread(() =>
                                                {
                                                    WebClient client = new WebClient();
                                                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                                                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                                                    client.DownloadFileAsync(new Uri("https://github.com/Open-Shell/Open-Shell-Menu/releases/download/v4.4.170/OpenShellSetup_4_4_170.exe"), @"C:\HickTool\OpenShellSetup_4_4_170.exe");
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
