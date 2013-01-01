using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SixUpdater_CleanLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegWorker reg = new RegWorker();
            findCfg.RootFolder = Environment.SpecialFolder.LocalApplicationData;
            cfgPath.Text = reg.getCfgPath();
            suPath.Text = reg.getSuPath();
            //cfgPath.Text = Environment.GetEnvironmentVariable("LocalAppData") + "\\SIX_Projects";
            //suPath.Text = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Six Updater\\Six Updater GUI.exe";
        }

        private void suPathb_Click(object sender, EventArgs e)
        {
            FindSu.ShowDialog();
            suPath.Text = FindSu.SelectedPath + "\\Six Updater GUI.exe";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findCfg.ShowDialog();
            cfgPath.Text = findCfg.SelectedPath + "\\user.config";
        }

        private void save_Click(object sender, EventArgs e)
        {
            RegWorker reg = new RegWorker();
            reg.saveCfgPath(cfgPath.Text);
            reg.saveSuPath(suPath.Text);
        }

        private void launch_clear_Click(object sender, EventArgs e)
        {
            File.Delete(cfgPath.Text);
            System.Diagnostics.Process.Start(suPath.Text);
            //this.Close();
        }

        private void launch_noClear_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(suPath.Text);
            //this.Close();
        }
    }
}
