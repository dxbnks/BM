﻿using SimpleJSON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BMBF_Manager
{
    /// <summary>
    /// Interaktionslogik für BPLists.xaml
    /// </summary>
    public partial class BPLists : Window
    {

        Boolean draggable = true;
        Boolean Running = false;
        String exe = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 1);


        public BPLists()
        {
            InitializeComponent();
            Quest.Text = MainWindow.IP;
            try
            {
                DownloadScrappedData();
            } catch { }
        }

        private void Drag(object sender, RoutedEventArgs e)
        {
            bool mouseIsDown = System.Windows.Input.Mouse.LeftButton == MouseButtonState.Pressed;


            if (mouseIsDown)
            {
                if (draggable)
                {
                    this.DragMove();
                }

            }

        }

        public void noDrag(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        public void doDrag(object sender, MouseEventArgs e)
        {
            draggable = true;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Mini(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ClearText(object sender, RoutedEventArgs e)
        {
            if (Quest.Text == "Quest IP")
            {
                Quest.Text = "";
            }

        }

        private void ClearTextMaxSongs(object sender, RoutedEventArgs e)
        {
            if (MaxSongs.Text == "Max Songs")
            {
                MaxSongs.Text = "";
            }

        }

        private void QuestIPCheck(object sender, RoutedEventArgs e)
        {
            if (Quest.Text == "")
            {
                Quest.Text = "Quest IP";
            }
        }

        private void MaxSongsCheck(object sender, RoutedEventArgs e)
        {
            if (MaxSongs.Text == "")
            {
                MaxSongs.Text = "Max Songs";
            }
        }

        public Boolean CheckIP()
        {
            getQuestIP();
            if (MainWindow.IP == "Quest IP")
            {
                return false;
            }
            MainWindow.IP = MainWindow.IP.Replace(":5000000", "");
            MainWindow.IP = MainWindow.IP.Replace(":500000", "");
            MainWindow.IP = MainWindow.IP.Replace(":50000", "");
            MainWindow.IP = MainWindow.IP.Replace(":5000", "");
            MainWindow.IP = MainWindow.IP.Replace(":500", "");
            MainWindow.IP = MainWindow.IP.Replace(":50", "");
            MainWindow.IP = MainWindow.IP.Replace(":5", "");
            MainWindow.IP = MainWindow.IP.Replace(":", "");
            MainWindow.IP = MainWindow.IP.Replace("/", "");
            MainWindow.IP = MainWindow.IP.Replace("https", "");
            MainWindow.IP = MainWindow.IP.Replace("http", "");
            MainWindow.IP = MainWindow.IP.Replace("Http", "");
            MainWindow.IP = MainWindow.IP.Replace("Https", "");

            int count = 0;
            for (int i = 0; i < MainWindow.IP.Length; i++)
            {
                if (MainWindow.IP.Substring(i, 1) == ".")
                {
                    count++;
                }
            }
            if (count != 3)
            {
                Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate
                {
                    Quest.Text = MainWindow.IP;
                }));
                return false;
            }
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate
            {
                Quest.Text = MainWindow.IP;
            }));
            return true;
        }

        public void getQuestIP()
        {
            MainWindow.IP = Quest.Text;
            return;
        }

        public Boolean DownloadScrappedData()
        {
            if (File.Exists(exe + "\\tmp\\scoreSaberScrappedData.json")) return true;
            txtbox.AppendText("Downloading Score Saber Data.");
            WebClient c = new WebClient();
            Uri uri = new Uri("https://github.com/andruzzzhka/BeatSaberScrappedData/raw/master/scoreSaberScrappedData.zip");
            try
            {
                c.DownloadFileCompleted += new AsyncCompletedEventHandler(finished_download);
                c.DownloadFileAsync(uri, exe + "\\tmp\\ScoreSaber.zip");
            } catch
            {
                txtbox.AppendText("\n\nError downloading ScoreSaber Data. Aborting.");
                return false;
            }
            return true;
        }

        private void finished_download(object sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory(exe + "\\tmp\\ScoreSaber.zip", exe + "\\tmp");
            txtbox.AppendText("\n\nFinished Downloading Data");
        }

        public void InstallRanked(object sender, RoutedEventArgs e)
        {
            if (!CheckIP())
            {
                txtbox.AppendText("\n\nChoose a valid IP.");
                return;
            }
            if (Running)
            {
                txtbox.AppendText("\n\nA BPList download");
                return;
            }
            if(!File.Exists(exe + "\\tmp\\scoreSaberScrappedData.json"))
            {
                txtbox.AppendText("\n\nPlease wait until the Scoresaber Data finished Downloading.");
                return;
            }
            Running = true;

            var json = JSON.Parse(File.ReadAllText(exe + "\\tmp\\scoreSaberScrappedData.json"));
            int Max = 0;
            try
            {
                Max = Convert.ToInt32(MaxSongs.Text);
            } catch
            {
                txtbox.AppendText("\nPlease Type in a valid number");
                Running = false;
                return;
            }
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate
            {
                txtbox.AppendText("\n\nCreating BPList with ranked Songs.");
            }));
            int Ranked = 0;
            var BPList = JSON.Parse("{}");
            BPList["playlistTitle"] = "ScoreSaber Ranked Songs " + DateTime.Now.Day.ToString("d2") + "." + DateTime.Now.Month.ToString("d2") + "." + DateTime.Now.Year.ToString("d4");
            BPList["playlistAuthor"] = "BMBF Manager";
            BPList["image"] = "data:image/png;base64,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";
            ArrayList hashes = new ArrayList();
            for (int i = 0; Ranked < Max && json[i]["name"] != null; i++)
            {
                if(json[i]["ranked"].AsBool)
                {
                    Boolean there = false;
                    try
                    {
                        for (int n = 0; hashes[n] != null; n++)
                        {
                            if (json[i]["id"].ToString().ToLower().Replace("\"", "") == hashes[n].ToString().Replace("\"", ""))
                            {
                                there = true;
                                break;
                            }
                        }
                    }
                    catch { }
                    if (there) continue;
                    hashes.Add(json[i]["id"].ToString().ToLower().Replace("\"", ""));
                    BPList["songs"][Ranked]["songName"] = json[i]["name"].ToString().Replace("\"", "");
                    BPList["songs"][Ranked]["hash"] = json[i]["id"].ToString().ToLower().Replace("\"", "");
                    Ranked++;
                }
            }
            File.WriteAllText(exe + "\\tmp\\ranked.bplist", BPList.ToString());
            upload(exe + "\\tmp\\ranked.bplist");
        }

        public void upload(String path)
        {
            getQuestIP();

            TimeoutWebClient client = new TimeoutWebClient();

            txtbox.AppendText("\n\nUploading BPList to BMBF");
            Uri uri = new Uri("http://" + MainWindow.IP + ":50000/host/beatsaber/upload?overwrite");
            try
            {
                Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate
                {
                    client.UploadFileCompleted += new UploadFileCompletedEventHandler(finished_upload);
                    client.UploadFileAsync(uri, path);
                }));
            }
            catch
            {
                txtbox.AppendText("\n\nA error Occured (Code: BMBF100)");
                Running = false;
            }
        }

        private void finished_upload(object sender, UploadFileCompletedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate
            {
                txtbox.AppendText("\n\nSyncing to Beat Saber");
            }));
            Process.Start("http://" + MainWindow.IP + ":50000/main/playlists");
            txtbox.AppendText("\n\nSynced to Beat Saber");
            Running = false;
        }

        public void Sync()
        {
            System.Threading.Thread.Sleep(2000);
            using (WebClient client = new WebClient())
            {
                client.QueryString.Add("foo", "foo");
                client.UploadValues("http://" + MainWindow.IP + ":50000/host/beatsaber/commitconfig", "POST", client.QueryString);
            }
        }
    }
}
