using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodHoundHub
{
    public partial class BloodHoundUI : Form
    {
        public BloodHoundUI()
        {
            InitializeComponent();
        }

        private void BloodHoundUI_Load(object sender, EventArgs e)
        {
            FormFadeLoadUp.ShowAsyc(this);
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs  e)
        {
            Hide();
            BloodHoundSettingsUI bloodHoundSettingsUI = new BloodHoundSettingsUI();
            bloodHoundSettingsUI.Show();
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
