using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AeSplashChanger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string dllpath;
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckResourceHacker();
            dllpath = GetDllDirectroy();
            if (dllpath == "None")
            {
                dllpath = ShowSelectDir();
            }
            GetAeSplash();
            CreateBackup();
        }
        private string GetDllDirectroy()
        {
            string ae22dir = @"C:\Program Files\Adobe\Adobe After Effects 2022\Support Files\AfterFXLib.dll";
            string ae21dir = @"C:\Program Files\Adobe\Adobe After Effects 2021\Support Files\AfterFXLib.dll";
            string ae20dir = @"C:\Program Files\Adobe\Adobe After Effects 2020\Support Files\AfterFXLib.dll";
            string ae19dir = @"C:\Program Files\Adobe\Adobe After Effects 2019\Support Files\AfterFXLib.dll";
            string ae18dir = @"C:\Program Files\Adobe\Adobe After Effects 2018\Support Files\AfterFXLib.dll";
            string ae17dir = @"C:\Program Files\Adobe\Adobe After Effects 2017\Support Files\AfterFXLib.dll";
            string ae16dir = @"C:\Program Files\Adobe\Adobe After Effects 2016\Support Files\AfterFXLib.dll";

            if (File.Exists(ae22dir))
            {
                return ae22dir;
            }
            else if (File.Exists(ae21dir))
            {
                return ae21dir;
            }
            else if (File.Exists(ae20dir))
            {
                return ae20dir;
            }
            else if (File.Exists(ae19dir))
            {
                return ae19dir;
            }
            else if (File.Exists(ae18dir))
            {
                return ae18dir;
            }
            else if (File.Exists(ae17dir))
            {
                return ae17dir;
            }
            else if (File.Exists(ae16dir))
            {
                return ae16dir;
            }
            else
            {
                return "None";
            }
        }
        private string ShowSelectDir()
        {
            aefolderBrowserDialog.ShowDialog();
            string selectedPath = aefolderBrowserDialog.SelectedPath;
            if (selectedPath == null || selectedPath.Contains("Support Files") || !selectedPath.Contains("After Effects"))
            {
                MessageBox.Show("Please Select Valid Directory", "Error");
                Environment.Exit(0);
            }

            return selectedPath;
        }
        private void SetAeSplash()
        {
            SetPNGResourceHacker(dllpath);
        }
        private void GetAeSplash()
        {
            ExtractPNGResourceHacker(dllpath, "AE_SPLASH");

            if (!File.Exists("AE_SPLASH.png"))
            {
                while (!File.Exists("AE_SPLASH.png"))
                {
                    Console.WriteLine("Waiting For Splash");
                    System.Threading.Thread.Sleep(100);
                }
            }
            pictureBox.ImageLocation = "AE_SPLASH.png";
            pictureBox.Load();
        }
        private void CreateBackup()
        {
            if (!File.Exists(dllpath + ".original"))
            {
                File.Copy(dllpath, dllpath + ".original");
            }
        }
        private void CheckResourceHacker()
        {
            if (!File.Exists("ResourceHacker.exe"))
            {
                MessageBox.Show("Could Not Find ResourceHacker.exe", "Error");
                Environment.Exit(0);
            }
        }
        private void exportbtn_Click(object sender, EventArgs e)
        {
            SetAeSplash();
        }
        private void importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                importFileDialog.Filter = "PNG files (*.png)|*.png";
                importFileDialog.ShowDialog();
                string selectedPNG = importFileDialog.FileName;
                pictureBox.Image = Image.FromFile(selectedPNG);
                splashLabel.Text = "Selected Splash Screen";
            }
            catch { }

        }
        private void ExtractPNGResourceHacker(string inputName, string PNGNAME)
        {
            Process RH = new Process();

            RH.StartInfo.FileName = "ResourceHacker";
            RH.StartInfo.Arguments = "-open \"" + inputName + "\" -save " + PNGNAME + ".png -action extract -mask PNG," + PNGNAME;
            RH.Start();
        }
        private void SetPNGResourceHacker(string inputName)
        {
            pictureBox.Image.Save("output.png");

            Process RH = new Process();
            RH.StartInfo.FileName = "ResourceHacker";
            RH.StartInfo.UseShellExecute = true;
            RH.StartInfo.Arguments = "-open \"" + inputName + "\" -save \"AfterFXLib.dll\" -action addoverwrite -resource \"output.png\" -mask PNG,AE_SPLASH";
            RH.Start();

            if (!File.Exists("AfterFXLib.dll"))
            {
                while (!File.Exists("AfterFXLib.dll"))
                {
                    Console.WriteLine("Waiting For dll");
                    System.Threading.Thread.Sleep(100);
                }
            }

            System.Threading.Thread.Sleep(3000);

            //RH.Kill();

            File.Replace("AfterFXLib.dll", dllpath, dllpath + ".bak");

            MessageBox.Show("Exported New AfterFXLib.dll Successfully", "Notice");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox.Dispose();
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
            System.Threading.Thread.Sleep(100);
            File.Delete("AE_SPLASH.png");
            File.Delete("ResourceHacker.ini");
            File.Delete("output.png");
        }
        private void githubbtn_click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/kruumy/AE-Splash-Changer-GUI");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void defaultsbtn_click(object sender, EventArgs e)
        {
            File.Delete(dllpath);
            File.Copy(dllpath + ".original", dllpath);
            File.Delete("AE_SPLASH.png");
            MessageBox.Show("Restored Defaults\nPlease Restart Program", "Notice");
        }
    }
}
