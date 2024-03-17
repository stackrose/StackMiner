using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StackMiner
{
    public partial class AlgorithmSelection
    {
        public AlgorithmSelection()
        {
            InitializeComponent();
        }

        public Builder F;

        private void algorithmSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string algo = "";
            try
            {
                algo = comboAlgorithm.Text.Split(new string[] { "(", ")" }, StringSplitOptions.None)[1];
            }
            catch {}

            if (ReferenceEquals(algo, ""))
            {
                MessageBox.Show("Incorrect Algorithm");
                return;
            }

            Type minertype;

            switch (algo)
            {
                case "ethash":
                case "etchash":
                case "ubqhash":
                case "kawpow":
                case "firopow":
                case "progpow":
                case "progpowz":
                case "evrprogpow":
                    minertype = typeof(MinerETH);
                    break;
                default:
                    minertype = typeof(MinerXMR);
                    break;
            }

            Error(F.listMiners.Items.OfType<MinerXMR>().Any() && minertype == typeof(MinerXMR), "Error: Maximum amount of 1 CPU miner reached.");
            Error(F.listMiners.Items.OfType<MinerETH>().Any() && minertype == typeof(MinerETH), "Error: Maximum amount of 1 GPU miner reached.");

            dynamic miner = Activator.CreateInstance(minertype);
            miner.comboAlgorithm.Text = algo;
            if (F.listMiners.Items.Count > 0)
            {
                miner.nid = ((dynamic)F.listMiners.Items[F.listMiners.Items.Count - 1]).nid + 1;
            }
            miner.F = F;
            miner.Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            F.listMiners.Items.Add(miner);
            F.TranslateForms();
            ((dynamic)F.listMiners.Items[F.listMiners.Items.Count-1]).Show();
            
            Hide();
        }
        public bool Error(bool condition, string message)
        {
            if (condition)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}