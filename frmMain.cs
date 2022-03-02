using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace ChromeProfilesCreator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ReadSettings();
            CountExistProfiles();
            PathAppdataCheck();
            this.Icon = Properties.Resources.SAS;
            notifyIcon1.Icon = Properties.Resources.SAS;
        }
        private void ExitMainForm()
        {
            if (MessageBox.Show("Close ChromeProfilesCreator？", "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }
        private void HideMainForm()
        {
            this.Hide();
        }
        private void ShowMainForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideMainForm();
            }
        }
        private void notifyIcon1_DoubleClick_1(object sender, EventArgs e)
        {
            ShowMainForm();
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            // HideMainForm();
        }
        private void SaveAll_btn(object sender, EventArgs e)
        {
            if (!File.Exists("settings.xml"))
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);
                XmlElement settings = doc.CreateElement("settings");
                doc.AppendChild(settings);
                XmlElement appdatapath = doc.CreateElement("appdatapath");
                appdatapath.InnerText = (AppDataTextBox.Text);
                XmlElement amountset = doc.CreateElement("amount");
                amountset.InnerText = (AmountTextBox.Text);
                XmlElement exportset = doc.CreateElement("exportfilename");
                exportset.InnerText = (ExportFileNameTextBox.Text);
                XmlElement urlset = doc.CreateElement("urls");
                urlset.InnerText = (StartChromeWithUrlTextBox.Text);
                settings.AppendChild(amountset);
                settings.AppendChild(appdatapath);
                settings.AppendChild(exportset);
                settings.AppendChild(urlset);
                doc.Save("settings.xml");
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);
                XmlElement settings = doc.CreateElement("settings");
                doc.AppendChild(settings);
                XmlElement appdatapath = doc.CreateElement("appdatapath");
                appdatapath.InnerText = (AppDataTextBox.Text);
                XmlElement amountset = doc.CreateElement("amount");
                amountset.InnerText = (AmountTextBox.Text);
                XmlElement exportset = doc.CreateElement("exportfilename");
                exportset.InnerText = (ExportFileNameTextBox.Text);
                XmlElement urlset = doc.CreateElement("urls");
                urlset.InnerText = (StartChromeWithUrlTextBox.Text);
                settings.AppendChild(amountset);
                settings.AppendChild(appdatapath);
                settings.AppendChild(exportset);
                settings.AppendChild(urlset);
                doc.Save("settings.xml");
            }
            ReadSettings();
            CountExistProfiles();
            PathAppdataCheck();
            MessageBox.Show("Сделано!");
        }
        
        private void PathAppdataCheck()
        {
            if (Directory.Exists(AppDataTextBox.Text))
            {
                CountExistProfiles();
            }
            else
            {
                CounterExistProfiles.Text = "Укажите путь к appdata";
            }
        }
        private void CountExistProfiles()
        {
            try
            {
                string[] allfolders = Directory.GetDirectories(AppDataTextBox.Text.ToString());
                int counter = 0;
                int counterr = 0;
                foreach (string folder in allfolders)
                {
                    if (folder.Contains("Profile") == true || folder.Contains("Profile ") == true)
                    {
                        Regex regex = new Regex(@"([0-9]+)");
                        foreach (Match match in regex.Matches(folder))
                        {
                            int a = int.Parse(match.Value);
                            counter++;
                        }
                    }
                    else
                    {
                        counterr++;
                    }
                }
                CounterExistProfiles.Text = "Всего профилей: " + counter;
            }
            catch
            {
                MessageBox.Show("Проверьте путь к appdata!");
            }
        }
        private void ReadSettings()
        {
            string FileName = "settings.xml";
            if (File.Exists(FileName))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(FileName);
                XmlNode node = xmlDoc.SelectSingleNode("settings");
                if (node == null)
                    return;
                string amountset, appdatapathset, exportset, urlset;
                for (int i = 0; i <= xmlDoc.SelectSingleNode("settings").ChildNodes.Count - 1; i++)
                {
                    amountset = xmlDoc.SelectSingleNode("//amount").InnerText;
                    appdatapathset = xmlDoc.SelectSingleNode("//appdatapath").InnerText;
                    exportset = xmlDoc.SelectSingleNode("//exportfilename").InnerText;
                    urlset = xmlDoc.SelectSingleNode("//urls").InnerText;
                    AmountTextBox.Text = amountset;
                    ExportFileNameTextBox.Text = exportset;
                    StartChromeWithUrlTextBox.Text = urlset;
                    AppDataTextBox.Text = appdatapathset;
                }
            }
        }
        private void CloseAllChromeProcessesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("chrome"))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Сделано!");
        }
        private void ImportProfilesBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(AppDataTextBox.Text))
            {
                string[] allfolders = Directory.GetDirectories(AppDataTextBox.Text);
                string[] stroka = StartChromeWithUrlTextBox.Text.Split(' ');
                Random randonNum = new Random();
                Process pr = new Process();
                if (Importer.ShowDialog() != DialogResult.OK) return;
                string file = Importer.FileName;
                string[] chromeids = File.ReadAllLines(file);
                CheckForIllegalCrossThreadCalls = false;
                string s = String.Empty;
                int numbers;
                if (chromeids.Count() == 0)
                {
                    MessageBox.Show("Файл пуст");
                }
                else
                {
                    new Thread(() =>
                    {
                        Console.WriteLine("Процесс начат...");
                        for (int i = 0; i < chromeids.Count(); i++)
                        {
                            bool success = int.TryParse(chromeids[i], out numbers);
                            if (success)
                            {
                                string profnumbers = String.Empty;
                                string pattern = @"([0-9])+";
                                Regex regex = new Regex(pattern);
                                List<int> nums = new List<int>();
                                List<int> numrealtwo = new List<int>();
                                int clearnumb = 0;
                                foreach (string folder in allfolders)
                                {
                                    foreach (Match match in regex.Matches(folder))
                                    {
                                        if (folder.Contains("Profile"))
                                        {
                                            nums.Add(Convert.ToInt32(match.Value));
                                        }
                                    }
                                }
                                for (int j = 0; j < nums.Count(); j++)
                                {
                                    int numbersprof = nums[j];
                                    if (numbersprof != 0)
                                    {
                                        if (numbers != numbersprof)
                                        {
                                            break;
                                        }
                                        else if (numbers == numbersprof)
                                        {
                                            clearnumb = numbers;
                                        }
                                        else
                                        {
                                            return;
                                        }
                                    }
                                }
                                pr.StartInfo.FileName = "chrome.exe";
                                string profnumb = "--profile-directory=Profile" + clearnumb;
                                for (int o = 0; o < stroka.Count(); o++)
                                {
                                    string rootDir = AppDataTextBox.Text;
                                    pr.StartInfo.Arguments = profnumb + " " + stroka[o];
                                    pr.Start();
                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                s = "bad";
                                if (s == "bad")
                                {
                                    Console.WriteLine("ПЛОХОЙ ФАЙЛ");
                                }
                            }
                            CountExistProfiles();
                            MessageBox.Show("Сделано!");
                            Console.WriteLine("Процесс закончен...");
                        }
                    }).Start();
                }
            }
            else
            {
                MessageBox.Show("Проверьте путь к appdata!");
            }
        }

        private void CreateChromeProfilebtn_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(AmountTextBox.Text);
            int min = 1;
            int max = 2147483647;
            string localDate = DateTime.Now.Date.ToShortDateString();
            string localtime = DateTime.Now.ToLocalTime().ToString();
            string lts = localtime.Split(' ')[1].Replace(':', '_');
            if (Directory.Exists(AppDataTextBox.Text))
            {
            string[] allfolders = Directory.GetDirectories(AppDataTextBox.Text);
            string[] stroka = StartChromeWithUrlTextBox.Text.Split(' ');
            Random randonNum = new Random();
            Process pr = new Process();
            if (Browsec.ShowDialog() != DialogResult.OK) return;
            string path = Browsec.SelectedPath, temp = path + "/output/";
            if (!Directory.Exists(path)) return;
            if (!Directory.Exists(temp))
                Directory.CreateDirectory(temp);
            TextWriter writer = new StreamWriter
                (
                temp + ExportFileNameTextBox.Text + " " + localDate + " " + lts + ".txt"
                );
            CheckForIllegalCrossThreadCalls = false;
            new Thread(() =>
            {
                Console.WriteLine("Процесс начат...");
                for (int i = 0; i < amount; i++)
                {
                    int numbers = randonNum.Next(min, max);
                    string profnumbers = String.Empty;
                    string pattern = @"([0-9])+";
                    Regex regex = new Regex(pattern);
                    List<int> nums = new List<int>();
                    List<int> numrealtwo = new List<int>();
                    int clearnumb = 0;
                    foreach (string folder in allfolders)
                    {
                        foreach (Match match in regex.Matches(folder))
                        {
                            if (folder.Contains("Profile"))
                            {
                                nums.Add(Convert.ToInt32(match.Value));
                            }
                        }
                    }
                    for (int j = 0; j < nums.Count(); j++)
                    {
                        int numbersprof = nums[j];
                        if (numbersprof != 0)
                        {
                            if (numbers != numbersprof)
                            {
                                clearnumb = numbers;
                            }
                            else if (numbers == numbersprof)
                            {
                                MessageBox.Show("Такой профиль уже существует" + numbers);
                                break;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            clearnumb = numbers;
                        }
                    }
                    pr.StartInfo.FileName = "chrome.exe";
                    string profnumb = "--profile-directory=Profile" + clearnumb;
                    for (int o = 0; o < stroka.Count(); o++)
                    {
                        string rootDir = AppDataTextBox.Text;
                        if (!Directory.Exists(Path.Combine(rootDir, "Profile" + clearnumb.ToString())))
                            Directory.CreateDirectory(Path.Combine(rootDir, "Profile" + clearnumb.ToString()));
                        pr.StartInfo.Arguments = profnumb + " " + stroka[o];
                        pr.Start();
                        Console.WriteLine("Создан профиль за номером " + clearnumb);
                        Thread.Sleep(1000);
                    }
                    writer.WriteLine(clearnumb);
                }
                writer.Close();
                CountExistProfiles();
                MessageBox.Show("Сделано!");
            }).Start();
            }
            else
            {
                MessageBox.Show("Проверьте путь к appdata!");
            }
        }
        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitMainForm();
        }
        }
 }



       
    
 
