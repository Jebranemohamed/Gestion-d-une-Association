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
    public partial class GestionActivities : Form
    {
        public GestionActivities()
        {
            InitializeComponent();
        }

        void clear()
        {
            idtxt.Clear();
            datedebut.Text = default;
            datefin.Text = default;
            frais.Clear();
            revenu.Clear();
            description.Clear();
        }

        private void GestionActivities_Load(object sender, EventArgs e)
        {
            activiteBindingSource.DataSource = activite.getAllActivities();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            activiteBindingSource.DataSource = activite.getAllActivities();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                MessageBox.Show("المرجو إدخال بيانات البحث");
                return;
            }
            
            activiteBindingSource.DataSource = activite.searchActivity(searchtxt.Text);
            if (dgvActivities.Rows.Count == 0)
            {
                clear();
                MessageBox.Show("يبدو أن النشاط الذي تبحث عنه غير موجود أو البيانات غير صحيحة");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(" سيتم حذف هدا النشاط,أنت متأكد؟", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            bool validate = activite.Delete_Activiti(idtxt.Text);
            if (validate == true)
            {
                MessageBox.Show("تم حذف النشاط بنجاح");
                clear();
                activiteBindingSource.DataSource = activite.getAllActivities();
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات ");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string id, desc;
            DateTime dd,df;
            double fr, rv;
            try
            {
                id = idtxt.Text;
                dd = DateTime.Parse(datedebut.Text);
                df = DateTime.Parse(datefin.Text);
                fr = double.Parse(frais.Text);
                rv = double.Parse(revenu.Text);
                desc = description.Text;
            }
            catch(Exception) { return; }
            bool validate = activite.Modify_Activiti(id, id, dd, df , fr, rv, desc);
            if (validate == true)
            {
                MessageBox.Show("تم تعديل البيانات بنجاح");
                clear();
                activiteBindingSource.DataSource = activite.getAllActivities();
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات الجديدة");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAddActivit_Click(object sender, EventArgs e)
        {
            bool validate = false;
            try
            {
                string id = idtxt.Text;
                DateTime dd = DateTime.Parse(datedebut.Value.ToString());
                DateTime df = DateTime.Parse(datefin.Value.ToString());
                double fr = double.Parse(frais.Text);
                double rv = double.Parse(revenu.Text);
                string desc = description.Text;
                validate = activite.Add_Activiti(id, dd, df, fr, rv, desc);
            }
            catch (Exception) { }
            if (validate == true)
            {
                MessageBox.Show("تم إضافة النشاط بنجاح");
                clear();
                activiteBindingSource.DataSource = activite.getAllActivities();
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات ");
        }

        private void dgvActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idtxt.Text = dgvActivities.Rows[e.RowIndex].Cells[0].Value.ToString();
            datedebut.Text = dgvActivities.Rows[e.RowIndex].Cells[1].Value.ToString();
            datefin.Text = dgvActivities.Rows[e.RowIndex].Cells[2].Value.ToString();
            frais.Text = dgvActivities.Rows[e.RowIndex].Cells[3].Value.ToString();
            revenu.Text = dgvActivities.Rows[e.RowIndex].Cells[4].Value.ToString();
            description.Text = activite.ActivitieDescription(idtxt.Text);
        }
    }
}
