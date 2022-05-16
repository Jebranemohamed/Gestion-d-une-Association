using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Entreprise
{
    public partial class GestionAdherentForm : Form
    {
        public GestionAdherentForm()
        {
            InitializeComponent();
        }

        void clear()
        {
            cintxt.Clear();
            nametxt.Clear();
            phonetxt.Clear();
            adressetxt.Clear();
            emailtxt.Clear();
            memberPicture.Image = null;
            dtpJoin.Text = default;
        }
        string imagePath;
        private void downloadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            open.Title = "إختر الصورة الشخصية للعضو";
            if (open.ShowDialog() == DialogResult.OK)
            {
                memberPicture.ImageLocation = open.FileName;
                imagePath = open.FileName;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            adherentBindingSource.DataSource = adherent.getAllAdherents();
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
                adherentBindingSource.DataSource = adherent.searchAdherent_CIN(searchtxt.Text);
            }
            if (cmbRecheche.Text == "الإسم الشخصي")
            {
                adherentBindingSource.DataSource = adherent.searchAdherent_UserName(searchtxt.Text);
            }
            if (dgvAdherent.Rows.Count == 0)
            {
                clear();
                MessageBox.Show("يبدو أن العضو الذي تبحث عنه غير موجود أو البيانات غير صحيحة");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(" سيتم حذف هدا العضو,أنت متأكد؟", "confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            if (confirm == DialogResult.No) return;
            bool validate = adherent.Delete_Adherent(cintxt.Text);
            if (validate == true)
            {
                MessageBox.Show("تم حذف العضو بنجاح");
                clear();
                adherentBindingSource.DataSource = adherent.getAllAdherents();
                
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات ");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string cin, nom, phone, email, adresse;
            DateTime inscipt;
            byte[] photo = null;
            FileStream file;
            BinaryReader br;
            try
            {
                cin = cintxt.Text;
                nom = nametxt.Text;
                inscipt = DateTime.Parse(dtpJoin.Value.ToString());
                phone = phonetxt.Text;
                email = emailtxt.Text;
                adresse = adressetxt.Text;
                file = new FileStream(imagePath, FileMode.Open);
                br = new BinaryReader(file);
            }
            catch (Exception) { return; }
            
            photo = br.ReadBytes((int)file.Length);
            file.Close();
            bool validate = adherent.Modify_Adherent(cin, cin, nom, inscipt, phone, email, adresse, photo);
            if (validate == true)
            {
                MessageBox.Show("تم تعديل البيانات بنجاح");
                clear();
                adherentBindingSource.DataSource = adherent.getAllAdherents();
                
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات الجديدة");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cin, nom, phone, email, adresse;
            DateTime inscipt;
            byte[] photo;
            try
            {
                cin = cintxt.Text;
                nom = nametxt.Text;
                inscipt = DateTime.Parse(dtpJoin.Value.ToString());
                phone = phonetxt.Text;
                email = emailtxt.Text;
                adresse = adressetxt.Text;
                photo = null;
                FileStream file = new FileStream(imagePath, FileMode.Open);
                BinaryReader br = new BinaryReader(file);
                photo = br.ReadBytes((int)file.Length);
                file.Close();
            }
            catch (Exception) { return; }
            bool validate = adherent.Add_Adherent( cin,  nom,  inscipt,  phone,  email,  adresse,  photo);
            if (validate == true)
            {
                MessageBox.Show("تم إضافة العضو بنجاح");
                clear();
                adherentBindingSource.DataSource = adherent.getAllAdherents();
                
            }
            if (validate == false) MessageBox.Show("المرجو التحقق من البيانات ");
        }

        private void dgvAdherent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            cintxt.Text = dgvAdherent.Rows[e.RowIndex].Cells[1].Value.ToString();
            nametxt.Text = dgvAdherent.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpJoin.Text = dgvAdherent.Rows[e.RowIndex].Cells[3].Value.ToString();
            phonetxt.Text = dgvAdherent.Rows[e.RowIndex].Cells[4].Value.ToString();
            emailtxt.Text = dgvAdherent.Rows[e.RowIndex].Cells[5].Value.ToString();
            adressetxt.Text = dgvAdherent.Rows[e.RowIndex].Cells[6].Value.ToString();
            byte[] memberPic = adherent.recoverPhoto(dgvAdherent.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (memberPic == null) 
            {
                memberPicture.Image = null;
                return;
            }
            MemoryStream ms = new MemoryStream(memberPic);
            memberPicture.Image = Image.FromStream(ms);
        }

        private void GestionAdherentForm_Load(object sender, EventArgs e)
        {
            adherentBindingSource.DataSource = adherent.getAllAdherents();
        }
        public static string MemberID;
        private void btnMemberCard_Click(object sender, EventArgs e)
        {
            if (cintxt.Text == "")
            {
                MessageBox.Show("المرجو إدخال بيانات العضو");
                return;
            }
            MemberID = cintxt.Text;
            MemberCardForm m = new MemberCardForm();
            m.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void memberPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
