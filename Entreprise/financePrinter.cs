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
    public partial class financePrinter : Form
    {
        public financePrinter()
        {
            InitializeComponent();
        }

        private void financePrinter_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.financementTableAdapter f = new DataSet1TableAdapters.financementTableAdapter();
            if (Program.type == null)
            {
                if(Program.year == 0 && Program.month == 0)
                {
                    f.FillAll(ds.financement);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
                else if (Program.year == 0)
                {
                    f.FillOnlyMonth(ds.financement, Program.month);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
                else if (Program.month == 0)
                {
                    f.FillOnlyYear(ds.financement, Program.year);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
                else
                {
                    f.FillMonthYear(ds.financement, Program.year, Program.month);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
            }
            else
            {
                if (Program.year == 0 && Program.month == 0)
                {
                    f.FillType(ds.financement, Program.type);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
                else if (Program.year == 0)
                {
                    f.FillMonthType(ds.financement, Program.month, Program.type);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
                else if (Program.month == 0)
                {
                    f.FillYearType(ds.financement, Program.year, Program.type);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
                else
                {
                    f.FillMonthYearType(ds.financement, Program.year, Program.month, Program.type);
                    CrystalReportFinance cr = new CrystalReportFinance();
                    cr.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = cr;
                }
            }
            Program.year = 0;
            Program.month = 0;
            Program.type = null;
        }
    }
}
