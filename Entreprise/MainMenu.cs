using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        void ChangeColor()
        {
            btnUsers.BackColor = Color.FromArgb(178,8,55);
            btnUsers.ForeColor = Color.White;

            btnActivities.BackColor = Color.FromArgb(178, 8, 55);
            btnActivities.ForeColor = Color.White;

            btnAdherent.BackColor = Color.FromArgb(178, 8, 55);
            btnAdherent.ForeColor = Color.White;

            btnFinance.BackColor = Color.FromArgb(178, 8, 55);
            btnFinance.ForeColor = Color.White;

            btnLogOut.BackColor = Color.FromArgb(178, 8, 55);
            btnLogOut.ForeColor = Color.White;


        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Program.defaultUser.Profile != "Admin") panelusers.Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!panelContent.Controls.ContainsKey("GestionUsers"))
            {
                ChangeColor();
                btnUsers.ForeColor = Color.Black;
                btnUsers.BackColor = Color.BlueViolet;
                panelContent.Controls.Clear();
                GestionUsers gs = new GestionUsers();
                gs.TopLevel = false;
                panelContent.Controls.Add(gs);
                gs.Dock = DockStyle.Fill;
                gs.Show();
            }
        }
        private void btnActivities_Click(object sender, EventArgs e)
        {
            if (!panelContent.Controls.ContainsKey("GestionActivities"))
            {
                ChangeColor();
                btnActivities.ForeColor = Color.Black;
                btnActivities.BackColor = Color.BlueViolet;
                panelContent.Controls.Clear();
                GestionActivities gs = new GestionActivities();
                gs.TopLevel = false;
                panelContent.Controls.Add(gs);
                gs.Dock = DockStyle.Fill;
                gs.Show();
            }
        }
        private void btnAdherent_Click(object sender, EventArgs e)
        {
            if (!panelContent.Controls.ContainsKey("GestionAdherentForm"))
            {
                ChangeColor();
                btnAdherent.ForeColor = Color.Black;
                btnAdherent.BackColor = Color.BlueViolet;
                panelContent.Controls.Clear();
                GestionAdherentForm gs = new GestionAdherentForm();
                gs.TopLevel = false;
                panelContent.Controls.Add(gs);
                gs.Dock = DockStyle.Fill;
                gs.Show();
            }

        }
        private void btnFinance_Click(object sender, EventArgs e)
        {
            if (!panelContent.Controls.ContainsKey("FinancementForm"))
            {
                ChangeColor();
                btnFinance.ForeColor = Color.Black;
                btnFinance.BackColor = Color.BlueViolet;
                panelContent.Controls.Clear();
                FinancementForm gs = new FinancementForm();
                gs.TopLevel = false;
                panelContent.Controls.Add(gs);
                gs.Dock = DockStyle.Fill;
                gs.Show();
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("هل أنت متأكد أنك تريد تسجيل الخروج ، سيتم فقد أي عمل غير محفوظ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
