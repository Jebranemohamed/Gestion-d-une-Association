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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("يرجى ملء جميع المناطق الفارغة بمعلومات المستخدم الخاصة بك");
                return;
            }
            utilisateur user = new utilisateur();
            user = utilisateur.ValidateUser(usertxt.Text, passwordtxt.Text);
            if (user != null) 
            {
               // MessageBox.Show(user.Nom.ToString() + " مرحبًا بك  ");
                Program.defaultUser = new User();
                Program.defaultUser.Nom = user.Nom;
                Program.defaultUser.Pass = user.Pass;
                Program.defaultUser.Profile = user.userRole;
                MainMenu mm = new MainMenu();
                this.Hide();
                mm.Show();
            }
            else
            {
                MessageBox.Show("يبدو انه يوجد خطأ في المعلومات التي ادخلت");
                usertxt.Clear();
                usertxt.Focus();
                passwordtxt.Clear();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
