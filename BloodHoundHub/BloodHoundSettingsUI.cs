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
    public partial class BloodHoundSettingsUI : Form
    {
        public BloodHoundSettingsUI()
        {
            InitializeComponent();
        }

        private void BloodHoundSettingsUI_Load(object sender, EventArgs e)
        {
            FormFadeLoad.ShowAsyc(this);
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            Hide();
            BloodHoundUI bloodHoundUI = new BloodHoundUI();
            bloodHoundUI.Show();
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitForm = MessageBox.Show("This is no-longer needed as it's now automatic. I'll remove this in the future.", "BloodHound confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void CircleButtonStyleExit_Click(object sender, EventArgs e)
        {
            ExitForm.Image = Properties.Resources.Simple_Exit_Form;
            BloodHoundUI bloodHoundUI = new BloodHoundUI();
            bloodHoundUI.ExitForm.Image = Properties.Resources.Simple_Exit_Form;
        }
    }
}
