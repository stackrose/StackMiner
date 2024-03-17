using System;
using System.Windows.Forms;

namespace StackMiner
{
    public partial class AdministratorOptions
    {
        public AdministratorOptions()
        {
            InitializeComponent();
            Codedom.FAO = this;
        }

        public Builder F;
        private void chkBlockWebsites_CheckedChanged(object sender)
        {
            txtBlockWebsites.Enabled = chkBlockWebsites.Checked;
        }
        private void advancedOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}