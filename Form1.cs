using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaScanner
{
    public partial class Form1 : Form
    {
        bool cheatFound = false;
        int totalFiles = 0;
        int scannedFiles = 0;

        string[] cheatKeywords =
        {
            "wurst","meteor","aristois","liquidbounce","impact","future",
            "kami","phobos","rusherhack","konas","lambda","bleachhack",
            "gamesense","inertia","salhack","vape","vapev4",
            "ghostclient","doomsday"
        };

        string[] ignoreKeywords =
        {
            "setup","install","installer","unins","update","updater",
            "vpn","hotspot","antivirus","steam","epic","riot","launcher",
            "fabric","forge","optifine","sodium","lithium","iris",
            "windows","microsoft","driver","runtime","framework",
            "discord","spotify","obs","vlc","chrome","edge","firefox",
            "java","jdk","jre","openjdk","visualstudio","vscode",
            "nvidia","amd","intel","logitech","razer","corsair",
            "temp","cache","logs","crash","dump","service","helper"
        };

        public Form1()
        {
            InitializeComponent();
            LoadDrives();
        }

        void LoadDrives()
        {
            comboDrives.Items.Clear();
            foreach (var d in DriveInfo.GetDrives())
            {
                if (d.IsReady)
                    comboDrives.Items.Add(d.Name);
            }
            if (comboDrives.Items.Count > 0)
                comboDrives.SelectedIndex = 0;
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            btnScan.Enabled = false;
            lstFindings.Items.Clear();
            cheatFound = false;
            scannedFiles = 0;
            totalFiles = 0;

            lblResult.Text = "Hazýrlanýyor...";
            progressBar1.Value = 0;

            string drive = comboDrives.SelectedItem.ToString();

            string[] targets =
            {
                Path.Combine(drive, "Users"),
            };

            await Task.Run(() =>
            {
                foreach (string t in targets)
                    CountFiles(t);

                foreach (string t in targets)
                {
                    if (cheatFound) break;
                    ScanDirectory(t);
                }
            });

            if (!cheatFound)
                lblResult.Text = "TEMÝZ";

            btnScan.Enabled = true;
        }

        void CountFiles(string path)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    if (IsTargetFile(file))
                        totalFiles++;
                }

                foreach (string dir in Directory.GetDirectories(path))
                    CountFiles(dir);
            }
            catch { }
        }

        void ScanDirectory(string path)
        {
            if (cheatFound) return;

            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    if (!IsTargetFile(file)) continue;

                    scannedFiles++;
                    UpdateProgress();

                    string name = Path.GetFileName(file).ToLower();

                    if (ignoreKeywords.Any(x => name.Contains(x)))
                        continue;

                    if (cheatKeywords.Any(x => name.Contains(x)))
                    {
                        cheatFound = true;
                        Invoke(new Action(() =>
                        {
                            lstFindings.Items.Add(file);
                            lblResult.Text = "HÝLE BULUNDU";
                            progressBar1.Value = 100;
                        }));
                        return;
                    }
                }

                foreach (string dir in Directory.GetDirectories(path))
                {
                    if (cheatFound) return;
                    ScanDirectory(dir);
                }
            }
            catch { }
        }

        bool IsTargetFile(string file)
        {
            string ext = Path.GetExtension(file).ToLower();
            return ext == ".exe" || ext == ".dll" || ext == ".jar";
        }

        void UpdateProgress()
        {
            if (totalFiles == 0) return;

            int percent = (int)((scannedFiles / (double)totalFiles) * 100);
            if (percent > 100) percent = 100;

            Invoke(new Action(() =>
            {
                progressBar1.Value = percent;
                lblResult.Text = $"Taranýyor %{percent}";
            }));
        }
    }
}
