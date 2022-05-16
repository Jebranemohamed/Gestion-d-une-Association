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
    public partial class FinancementForm : Form
    {
        public FinancementForm()
        {
            InitializeComponent();
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            DateTime d;
            string type;
            double money;
            if(txtMoney.Text == "" || (!btnEntre.Checked && !btnSortie.Checked))
            {
                MessageBox.Show("المرجو ملأ جميع البيانات");
                return;
            }
            try
            {
                d = DateTime.Parse(dtp.Text);
                if (btnEntre.Checked) type = "entre";
                else if (btnSortie.Checked) type = "sortie";
                else type = "";
                money = double.Parse(txtMoney.Text);
                financement.Add_Money(d, type, money);
            }
            catch (Exception) { }
            MessageBox.Show("تمت إضافة المبلغ بنجاح");
            Money();

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            financementBindingSource.DataSource = financement.getAllFinance();
            Money();
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            string type = null;
            if (btnEntreSearch.Checked)
            {
                type = "entre";
            }
            if (btnSortieSearch.Checked)
            {
                type = "sortie";
            }
            Program.type = type;
            if (type == null)
            {
                if(txtYear.Text == "" && cmbMonth.SelectedIndex == -1)
                {
                    month = 0;
                    year = 0;
                }
                else if(txtYear.Text == "")
                {
                    month = Convert.ToInt32(cmbMonth.SelectedValue);

                }
                else if (cmbMonth.SelectedIndex == -1)
                {
                    year = Convert.ToInt32(txtYear.Text);
                }
                else
                {
                    month = Convert.ToInt32(cmbMonth.SelectedValue);
                    year = Convert.ToInt32(txtYear.Text);
                }
            }
            else
            {
                if(txtYear.Text == "" && cmbMonth.SelectedIndex == -1)
                {
                    month = 0;
                    year = 0;
                }
                else if (txtYear.Text == "")
                {
                    month = Convert.ToInt32(cmbMonth.SelectedValue);

                }
                else if (cmbMonth.SelectedIndex == -1)
                {
                    year = Convert.ToInt32(txtYear.Text);
                }
                else
                {
                    month = Convert.ToInt32(cmbMonth.SelectedValue);
                    year = Convert.ToInt32(txtYear.Text);
                }
            }
            Program.month = month;
            Program.year = year;
            financementBindingSource.DataSource = financement.searchFinancement(year,month,type);
            Money();
        }

        private void FinancementForm_Load(object sender, EventArgs e)
        {
            

            DataSet1 ds = new DataSet1();
            DataRow r1 = ds.DataTable1.NewRow();
            r1["nom"] = "يناىر";
            DataRow r2 = ds.DataTable1.NewRow();
            r2["nom"] = "فبراير";
            DataRow r3 = ds.DataTable1.NewRow();
            r3["nom"] = "مارس";
            DataRow r4 = ds.DataTable1.NewRow();
            r4["nom"] = "أبريل";
            DataRow r5 = ds.DataTable1.NewRow();
            r5["nom"] = "ماي";
            DataRow r6 = ds.DataTable1.NewRow();
            r6["nom"] = "يونيو";
            DataRow r7 = ds.DataTable1.NewRow();
            r7["nom"] = "يوليوز";
            DataRow r8 = ds.DataTable1.NewRow();
            r8["nom"] = "غشت";
            DataRow r9 = ds.DataTable1.NewRow();
            r9["nom"] = "شتنبر";
            DataRow r10 = ds.DataTable1.NewRow();
            r10["nom"] = "أكتوبر";
            DataRow r11 = ds.DataTable1.NewRow();
            r11["nom"] = "نونبر";
            DataRow r12 = ds.DataTable1.NewRow();
            r12["nom"] = "دجنبر";
            ds.DataTable1.Rows.Add(r1);
            ds.DataTable1.Rows.Add(r2);
            ds.DataTable1.Rows.Add(r3);
            ds.DataTable1.Rows.Add(r4);
            ds.DataTable1.Rows.Add(r5);
            ds.DataTable1.Rows.Add(r6);
            ds.DataTable1.Rows.Add(r7);
            ds.DataTable1.Rows.Add(r8);
            ds.DataTable1.Rows.Add(r9);
            ds.DataTable1.Rows.Add(r10);
            ds.DataTable1.Rows.Add(r11);
            ds.DataTable1.Rows.Add(r12);
            cmbMonth.DataSource = ds.DataTable1;
            cmbMonth.DisplayMember = "nom";
            cmbMonth.ValueMember = "id";
            cmbMonth.SelectedIndex = -1;
            Money();
        }

        void Money()
        {
            double ammount = financement.GetCaisse();
            lblMoney.Text = ammount.ToString();
            lblMoney.ForeColor = Color.Green;
            if (ammount <= 100) lblMoney.ForeColor = Color.Red;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            financePrinter fp = new financePrinter();
            fp.Show();
        }
    }
}
