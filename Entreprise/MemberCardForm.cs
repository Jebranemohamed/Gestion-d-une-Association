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
    public partial class MemberCardForm : Form
    {
        public MemberCardForm()
        {
            InitializeComponent();
        }

        private void MemberCardForm_Load(object sender, EventArgs e)
        {
            string ID = GestionAdherentForm.MemberID;
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.adherentTableAdapter ad = new DataSet1TableAdapters.adherentTableAdapter();
            ad.Fill(ds.adherent, ID);
            CrystalReport1 ar = new CrystalReport1();
            ar.SetDataSource(ds);
            crystalReportViewer1.ReportSource = ar;
        }
    }
}
