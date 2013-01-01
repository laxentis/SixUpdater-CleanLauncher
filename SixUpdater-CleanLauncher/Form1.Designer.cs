namespace SixUpdater_CleanLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suPath = new System.Windows.Forms.TextBox();
            this.cfgPath = new System.Windows.Forms.TextBox();
            this.launch_noClear = new System.Windows.Forms.Button();
            this.launch_clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.FindSu = new System.Windows.Forms.FolderBrowserDialog();
            this.suPathb = new System.Windows.Forms.Button();
            this.findCfg = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // suPath
            // 
            resources.ApplyResources(this.suPath, "suPath");
            this.suPath.Name = "suPath";
            // 
            // cfgPath
            // 
            resources.ApplyResources(this.cfgPath, "cfgPath");
            this.cfgPath.Name = "cfgPath";
            // 
            // launch_noClear
            // 
            resources.ApplyResources(this.launch_noClear, "launch_noClear");
            this.launch_noClear.Name = "launch_noClear";
            this.launch_noClear.UseVisualStyleBackColor = true;
            this.launch_noClear.Click += new System.EventHandler(this.launch_noClear_Click);
            // 
            // launch_clear
            // 
            resources.ApplyResources(this.launch_clear, "launch_clear");
            this.launch_clear.Name = "launch_clear";
            this.launch_clear.UseVisualStyleBackColor = true;
            this.launch_clear.Click += new System.EventHandler(this.launch_clear_Click);
            // 
            // save
            // 
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // FindSu
            // 
            resources.ApplyResources(this.FindSu, "FindSu");
            this.FindSu.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FindSu.ShowNewFolderButton = false;
            // 
            // suPathb
            // 
            resources.ApplyResources(this.suPathb, "suPathb");
            this.suPathb.Name = "suPathb";
            this.suPathb.UseVisualStyleBackColor = true;
            this.suPathb.Click += new System.EventHandler(this.suPathb_Click);
            // 
            // findCfg
            // 
            resources.ApplyResources(this.findCfg, "findCfg");
            this.findCfg.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.findCfg.ShowNewFolderButton = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.launch_clear;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suPathb);
            this.Controls.Add(this.save);
            this.Controls.Add(this.launch_clear);
            this.Controls.Add(this.launch_noClear);
            this.Controls.Add(this.cfgPath);
            this.Controls.Add(this.suPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suPath;
        private System.Windows.Forms.TextBox cfgPath;
        private System.Windows.Forms.Button launch_noClear;
        private System.Windows.Forms.Button launch_clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.FolderBrowserDialog FindSu;
        private System.Windows.Forms.Button suPathb;
        private System.Windows.Forms.FolderBrowserDialog findCfg;
        private System.Windows.Forms.Button button1;
    }
}

