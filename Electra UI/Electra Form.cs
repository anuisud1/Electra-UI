using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace Electra_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes Program
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimizes the form
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Functions.Creditsandshit[0], "Credits");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = ""; //Clears the Script Box
        }

        private void button4_Click(object sender, EventArgs e) => Functions.Inject(); //injects 


        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadString("https://pastebin.com/raw/4LmEMrNW"); //gets the version of the exploit
            string value = "v.1.0";
            if (!webClient.DownloadString("https://pastebin.com/raw/4LmEMrNW").Contains(value)) //checks if the version is proper
            {
                if (MessageBox.Show("An update has been found, It is required to run the exploit", "Update Checker", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Process.Start("https://pastebin.com/raw/CZHCAnyW"); //goes to new download link
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0); //closes the outdated exploit exploit
                }
            }
            else
            {
                MessageBox.Show("The exploit is up to date!", "Update Checker"); 
            }
            {
                string gay = webClient.DownloadString("https://pastebin.com/raw/4LmEMrNW");//shows the version
                label2.Text = gay;
            }
            {
                bool homo = !Directory.Exists("Scripts");
                if (homo)
                {
                    Directory.CreateDirectory("Scripts");
                }
                string[] files = Directory.GetFiles("Scripts");
                foreach (string path in files)
                {
                    this.LuaScriptList.Items.Add(Path.GetFileName(path));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))//Checks the pipe
            {
                new Thread(() =>// running this in another thread so if roblox crashes the ui doesnt freeze or some shit
                {
                    NamedPipes.LuaPipe(ScriptBox.Text);//Uses lua pipe function and sends the script input
                }).Start();
            }
            else
            {
                MessageBox.Show("Inject " + Functions.exploitdllname + " before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if the pipe can't be found a messagebox will appear
                return;
            }
        }

        private void ColorSelect_Click(object sender, EventArgs e)
        {
            bool flag = this.colorDialog1.ShowDialog() == DialogResult.OK; //opens a color dialog form
            if (flag)
            {
                this.panel1.BackColor = this.colorDialog1.Color; //changes color of front panel
                this.RunScript.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.Clear.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.OpenFile.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.ColorSelect.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.Inject.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.Settings.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.button2.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.button3.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.button4.BackColor = this.colorDialog1.Color; //changes color of buttons
                this.button5.BackColor = this.colorDialog1.Color; //changes color of buttons
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)//check if the user clicked Ok/open
            {
                try
                {
                    ScriptBox.Text = File.ReadAllText(Functions.openfiledialog.FileName);//load all the text in the lua c rightextbox

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);//display if got error
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //allows panel to be dragged
            }
        }

        private void OpacityBar_Scroll(object sender, EventArgs e)
        {
            Opacity = OpacityBar.Value / (double)100;
            Properties.Settings.Default.OpacityValue = OpacityBar.Value;
            Properties.Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);// to go to the settings tab right click the panel at the top and press send to back. then you can go to ther panels. to get it back to normal press send to front.
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Functions.Creditsandshit[0], "Credits"); //credits 
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            bool flag = Directory.Exists("Roblox");
            if (flag)
            {
                Directory.Delete("Roblox", true);
            }
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            bool flag2 = Directory.Exists("Roblox");
            if (flag2)
            {
                Directory.Delete("Roblox", true);
            }
            bool flag3 = File.Exists("Installer.exe");
            if (flag3)
            {
                File.Delete("Installer.exe");
            }
            new WebClient().DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
            Process.Start("Installer.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
            {
                MessageBox.Show("Roblox is already Closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                try
                {
                    Process[] proc = Process.GetProcessesByName("RobloxPlayerBeta");
                    proc[0].Kill();
                    MessageBox.Show("Killed Roblox!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1); //brings you back to the executor
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LuaScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptBox.Text = File.ReadAllText("Scripts\\" + this.LuaScriptList.SelectedItem.ToString());
        }
    }
}
