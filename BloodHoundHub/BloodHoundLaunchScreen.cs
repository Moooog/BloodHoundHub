using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodHoundHub
{
    public partial class BloodHoundLaunchScreen : Form
    {
        public BloodHoundLaunchScreen()
        {
            InitializeComponent();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    WebClient webclient = new WebClient();
                    string InternetCheck = null;
                    InternetCheck = Encoding.ASCII.GetString((webclient.DownloadData("https://www.google.com")));
                    {
                        Hide();
                        BloodHoundUI bloodHoundUI = new BloodHoundUI();
                        bloodHoundUI.Show();
                    }
                }
                catch
                {
                    DialogResult OfflineDialog = MessageBox.Show("Launch Error! You need internet connection to launch BloodHound! If you think this is false, please DM Moog_#7778 on discord for assistance!", "Invalid Launch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BloodHoundLaunchScreen_Load(object sender, EventArgs e)
        {
            FormFadeLoad.ShowAsyc(this);
            LabelText.Location = new Point(33, 115);
            LabelText.Font = new Font("Microsoft Sans Serif", 10);
            try
            {
                WebClient webclient = new WebClient();
                string LabelTextPasteBin = null;
                LabelTextPasteBin = Encoding.ASCII.GetString((webclient.DownloadData("https://pastebin.com/raw/Mw9Tp4Er")));
                LabelText.Text = (LabelTextPasteBin);
            }
            catch
            {
                //Moog <3
            }
        }
            

        private void FormPanelUI_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelText_Click(object sender, EventArgs e)
        {
        }

        private void FormClosingUI(object sender, FormClosingEventArgs e)
        {
            FormFadeLoad.ShowAsyc(this);
        }
    }
}
