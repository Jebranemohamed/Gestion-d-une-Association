
namespace Entreprise
{
    partial class FinancementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnSortie = new System.Windows.Forms.RadioButton();
            this.btnEntre = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFinance = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInsertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caisseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEntreSearch = new System.Windows.Forms.RadioButton();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSortieSearch = new System.Windows.Forms.RadioButton();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financementBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnAddMoney);
            this.tabPage1.Controls.Add(this.txtMoney);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtp);
            this.tabPage1.Controls.Add(this.btnSortie);
            this.tabPage1.Controls.Add(this.btnEntre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(985, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الحسابات";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMoney.FlatAppearance.BorderSize = 0;
            this.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMoney.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMoney.ForeColor = System.Drawing.Color.White;
            this.btnAddMoney.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMoney.Image")));
            this.btnAddMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMoney.Location = new System.Drawing.Point(362, 251);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(356, 34);
            this.btnAddMoney.TabIndex = 19;
            this.btnAddMoney.Text = "إضافة";
            this.btnAddMoney.UseVisualStyleBackColor = false;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(362, 175);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(233, 30);
            this.txtMoney.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(666, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "المبلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(656, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "التاريخ";
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "MM/dd/yyyy";
            this.dtp.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(362, 105);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(233, 30);
            this.dtp.TabIndex = 15;
            this.dtp.Value = new System.DateTime(2022, 1, 26, 0, 0, 0, 0);
            // 
            // btnSortie
            // 
            this.btnSortie.AutoSize = true;
            this.btnSortie.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortie.Location = new System.Drawing.Point(259, 35);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(99, 29);
            this.btnSortie.TabIndex = 14;
            this.btnSortie.TabStop = true;
            this.btnSortie.Text = "مصاريف";
            this.btnSortie.UseVisualStyleBackColor = true;
            // 
            // btnEntre
            // 
            this.btnEntre.AutoSize = true;
            this.btnEntre.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntre.Location = new System.Drawing.Point(719, 35);
            this.btnEntre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(83, 29);
            this.btnEntre.TabIndex = 13;
            this.btnEntre.TabStop = true;
            this.btnEntre.Text = "مداخيل";
            this.btnEntre.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.dgvFinance);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(985, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "كشف الحساب";
            // 
            // dgvFinance
            // 
            this.dgvFinance.AllowUserToAddRows = false;
            this.dgvFinance.AutoGenerateColumns = false;
            this.dgvFinance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinance.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFinance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFinance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinance.ColumnHeadersHeight = 45;
            this.dgvFinance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFinance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateInsertDataGridViewTextBoxColumn,
            this.moneyTypeDataGridViewTextBoxColumn,
            this.caisseDataGridViewTextBoxColumn});
            this.dgvFinance.DataSource = this.financementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFinance.EnableHeadersVisualStyles = false;
            this.dgvFinance.Location = new System.Drawing.Point(3, 188);
            this.dgvFinance.Name = "dgvFinance";
            this.dgvFinance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFinance.RowHeadersVisible = false;
            this.dgvFinance.RowTemplate.Height = 40;
            this.dgvFinance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinance.Size = new System.Drawing.Size(979, 386);
            this.dgvFinance.TabIndex = 25;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateInsertDataGridViewTextBoxColumn
            // 
            this.dateInsertDataGridViewTextBoxColumn.DataPropertyName = "DateInsert";
            this.dateInsertDataGridViewTextBoxColumn.HeaderText = "تاريخ العملية";
            this.dateInsertDataGridViewTextBoxColumn.Name = "dateInsertDataGridViewTextBoxColumn";
            // 
            // moneyTypeDataGridViewTextBoxColumn
            // 
            this.moneyTypeDataGridViewTextBoxColumn.DataPropertyName = "MoneyType";
            this.moneyTypeDataGridViewTextBoxColumn.HeaderText = "نوع";
            this.moneyTypeDataGridViewTextBoxColumn.Name = "moneyTypeDataGridViewTextBoxColumn";
            // 
            // caisseDataGridViewTextBoxColumn
            // 
            this.caisseDataGridViewTextBoxColumn.DataPropertyName = "caisse";
            this.caisseDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.caisseDataGridViewTextBoxColumn.Name = "caisseDataGridViewTextBoxColumn";
            // 
            // financementBindingSource
            // 
            this.financementBindingSource.DataSource = typeof(Entreprise.financement);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblMoney);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Location = new System.Drawing.Point(106, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 56);
            this.panel1.TabIndex = 24;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMoney.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.lblMoney.Location = new System.Drawing.Point(637, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(85, 27);
            this.lblMoney.TabIndex = 27;
            this.lblMoney.Text = "Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(722, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "الأموال المتاحة:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(332, 56);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEntreSearch);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnSortieSearch);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 184);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btnEntreSearch
            // 
            this.btnEntreSearch.AutoSize = true;
            this.btnEntreSearch.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntreSearch.Location = new System.Drawing.Point(792, 22);
            this.btnEntreSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntreSearch.Name = "btnEntreSearch";
            this.btnEntreSearch.Size = new System.Drawing.Size(83, 29);
            this.btnEntreSearch.TabIndex = 15;
            this.btnEntreSearch.TabStop = true;
            this.btnEntreSearch.Text = "مداخيل";
            this.btnEntreSearch.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Century", 14.25F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cmbMonth.Location = new System.Drawing.Point(158, 71);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(233, 31);
            this.cmbMonth.TabIndex = 20;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAll.Location = new System.Drawing.Point(103, 131);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(352, 42);
            this.btnShowAll.TabIndex = 23;
            this.btnShowAll.Text = "عرض الكل";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(429, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "الشهر";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(603, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(341, 42);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSortieSearch
            // 
            this.btnSortieSearch.AutoSize = true;
            this.btnSortieSearch.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortieSearch.Location = new System.Drawing.Point(385, 22);
            this.btnSortieSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortieSearch.Name = "btnSortieSearch";
            this.btnSortieSearch.Size = new System.Drawing.Size(99, 29);
            this.btnSortieSearch.TabIndex = 16;
            this.btnSortieSearch.TabStop = true;
            this.btnSortieSearch.Text = "مصاريف";
            this.btnSortieSearch.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(559, 73);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(233, 30);
            this.txtYear.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(827, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "السنة";
            // 
            // FinancementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 599);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FinancementForm";
            this.Text = "FinancementForm";
            this.Load += new System.EventHandler(this.FinancementForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financementBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton btnSortie;
        private System.Windows.Forms.RadioButton btnEntre;
        private System.Windows.Forms.RadioButton btnSortieSearch;
        private System.Windows.Forms.RadioButton btnEntreSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFinance;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource financementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInsertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caisseDataGridViewTextBoxColumn;
    }
}