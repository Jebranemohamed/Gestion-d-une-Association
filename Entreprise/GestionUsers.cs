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
    public partial class GestionUsers : Form
    {
        public GestionUsers()
        {
            InitializeComponent();
        }

        void clear()
        {
            cintxt.Clear();
            userNametxt.Clear();
            passtxt.Clear();
            cmbUserRole.SelectedIndex = -1;
        }
        private void GestionUsers_Load(object sender, EventArgs e)
        {
            utilisateurBindingSource.DataSource = utilisateur.getAllUsers();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.DataSource = utilisateur.getAllUsers();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbRecheche.SelectedIndex == -1 || searchtxt.Text == "")
            {
                MessageBox.Show("المرجو إدخال بيانات البحث");
                return;
            }
            if (cmbRecheche.Text == "رقم البطاقة الوطنية")
            {
                utilisateurBindingSource.DataSource = utilisateur.searchUser_CIN(searchtxt.Text);
            }
            if (cmbRecheche.Text == "اسم الدخول")
            {
                utilisateurBindingSource.DataSource = utilisateur.searchUser_UserName(searchtxt.Text);
            }
            if (cmbRecheche.Text == "المسمى الوظيفي")
            {
                utilisateurBindingSource.DataSource = utilisateur.searchUser_UserRole(searchtxt.Text);
            }
            if (dgvUsers.Rows.Count == 0)
            {
                clear();
                MessageBox.Show("يبدو أن المستخدم الذي تبحث عنه غير موجود أو البيانات غير صحيحة");
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            cintxt.Text = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            userNametxt.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            passtxt.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbUserRole.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string cin, user, pass, role;
            try 
            { 
                cin = cintxt.Text;
                user = userNametxt.Text;
                pass = passtxt.Text;
                role = cmbUserRole.Text;
            }
            catch(Exception){ return;}
            bool validate = utilisateur.Modify_User(cin,cin,user,pass,role);
            if (validate == true)
            {
                MessageBox.Show("تم تعديل البيانات بنجاح");
                clear();
                utilisateurBindingSource.DataSource = utilisateur.getAllUsers();
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات الجديدة");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(" سيتم حذف هدا المستخدم,أنت متأكد؟", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            bool validate = utilisateur.Delete_User(cintxt.Text);
            if (validate == true)
            {
                MessageBox.Show("تم حذف المستخدم بنجاح");
                clear();
                utilisateurBindingSource.DataSource = utilisateur.getAllUsers();
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات ");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool validate = utilisateur.Add_User(cintxt.Text, userNametxt.Text, passtxt.Text, cmbUserRole.Text);
            if (validate == true)
            {
                MessageBox.Show("تم إضافة المستخدم بنجاح");
                clear();
                utilisateurBindingSource.DataSource = utilisateur.getAllUsers();
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbRecheche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
