namespace Visual_ContactList
{
    partial class frmContactList
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
            this.grbContactList = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblContactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataDataSet = new Visual_ContactList.ContactListDataDataSet();
            this.grbEditData = new System.Windows.Forms.GroupBox();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.labelContactID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneWork = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstNameSearch = new System.Windows.Forms.TextBox();
            this.tblContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastNameSearch = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.tbl_ContactTableAdapter = new Visual_ContactList.ContactListDataDataSetTableAdapters.tbl_ContactTableAdapter();
            this.tblContactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataDataSet2 = new Visual_ContactList.ContactListDataDataSet2();
            this.tblContactBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ContactTableAdapter1 = new Visual_ContactList.ContactListDataDataSet2TableAdapters.tbl_ContactTableAdapter();
            this.grbContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet)).BeginInit();
            this.grbEditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // grbContactList
            // 
            this.grbContactList.Controls.Add(this.dgvContacts);
            this.grbContactList.Font = new System.Drawing.Font("Calibri", 12F);
            this.grbContactList.Location = new System.Drawing.Point(25, 13);
            this.grbContactList.Name = "grbContactList";
            this.grbContactList.Size = new System.Drawing.Size(922, 252);
            this.grbContactList.TabIndex = 0;
            this.grbContactList.TabStop = false;
            this.grbContactList.Text = "List of contacts";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telephoneHomeDataGridViewTextBoxColumn,
            this.telephoneWorkDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvContacts.DataSource = this.tblContactBindingSource3;
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.Location = new System.Drawing.Point(3, 28);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(1);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 20;
            this.dgvContacts.Size = new System.Drawing.Size(916, 221);
            this.dgvContacts.TabIndex = 0;
            this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellClick);
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneHomeDataGridViewTextBoxColumn
            // 
            this.telephoneHomeDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Home";
            this.telephoneHomeDataGridViewTextBoxColumn.HeaderText = "Telephone_Home";
            this.telephoneHomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneHomeDataGridViewTextBoxColumn.Name = "telephoneHomeDataGridViewTextBoxColumn";
            this.telephoneHomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneWorkDataGridViewTextBoxColumn
            // 
            this.telephoneWorkDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Work";
            this.telephoneWorkDataGridViewTextBoxColumn.HeaderText = "Telephone_Work";
            this.telephoneWorkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneWorkDataGridViewTextBoxColumn.Name = "telephoneWorkDataGridViewTextBoxColumn";
            this.telephoneWorkDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblContactBindingSource2
            // 
            this.tblContactBindingSource2.DataMember = "tbl_Contact";
            this.tblContactBindingSource2.DataSource = this.contactListDataDataSet;
            // 
            // contactListDataDataSet
            // 
            this.contactListDataDataSet.DataSetName = "ContactListDataDataSet";
            this.contactListDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbEditData
            // 
            this.grbEditData.Controls.Add(this.txtContactID);
            this.grbEditData.Controls.Add(this.labelContactID);
            this.grbEditData.Controls.Add(this.btnCancel);
            this.grbEditData.Controls.Add(this.btnSave);
            this.grbEditData.Controls.Add(this.txtAddress);
            this.grbEditData.Controls.Add(this.label8);
            this.grbEditData.Controls.Add(this.txtMobile);
            this.grbEditData.Controls.Add(this.txtLastname);
            this.grbEditData.Controls.Add(this.label7);
            this.grbEditData.Controls.Add(this.label2);
            this.grbEditData.Controls.Add(this.txtPhoneWork);
            this.grbEditData.Controls.Add(this.txtFirstName);
            this.grbEditData.Controls.Add(this.label6);
            this.grbEditData.Controls.Add(this.label3);
            this.grbEditData.Controls.Add(this.txtPhoneHome);
            this.grbEditData.Controls.Add(this.label4);
            this.grbEditData.Controls.Add(this.label5);
            this.grbEditData.Controls.Add(this.txtEmail);
            this.grbEditData.Enabled = false;
            this.grbEditData.Font = new System.Drawing.Font("Calibri", 12F);
            this.grbEditData.Location = new System.Drawing.Point(25, 391);
            this.grbEditData.Name = "grbEditData";
            this.grbEditData.Size = new System.Drawing.Size(922, 266);
            this.grbEditData.TabIndex = 2;
            this.grbEditData.TabStop = false;
            this.grbEditData.Text = "Contact Info";
            this.grbEditData.Enter += new System.EventHandler(this.grbEditData_Enter);
            // 
            // txtContactID
            // 
            this.txtContactID.Location = new System.Drawing.Point(233, 33);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(178, 32);
            this.txtContactID.TabIndex = 0;
            this.txtContactID.TextChanged += new System.EventHandler(this.txtContactID_TextChanged_1);
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Location = new System.Drawing.Point(99, 41);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(102, 24);
            this.labelContactID.TabIndex = 15;
            this.labelContactID.Text = "Contact ID:";
            this.labelContactID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(336, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(159, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(597, 151);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(277, 66);
            this.txtAddress.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address:";
            // 
            // txtMobile
            // 
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "Mobile", true));
            this.txtMobile.Location = new System.Drawing.Point(597, 111);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(189, 32);
            this.txtMobile.TabIndex = 7;
            // 
            // txtLastname
            // 
            this.txtLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "LastName", true));
            this.txtLastname.Location = new System.Drawing.Point(233, 109);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(178, 32);
            this.txtLastname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mobile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name:";
            // 
            // txtPhoneWork
            // 
            this.txtPhoneWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "Telephone_Work", true));
            this.txtPhoneWork.Location = new System.Drawing.Point(597, 71);
            this.txtPhoneWork.Name = "txtPhoneWork";
            this.txtPhoneWork.Size = new System.Drawing.Size(189, 32);
            this.txtPhoneWork.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(233, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 32);
            this.txtFirstName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Work:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // txtPhoneHome
            // 
            this.txtPhoneHome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "Telephone_Home", true));
            this.txtPhoneHome.Location = new System.Drawing.Point(597, 33);
            this.txtPhoneHome.Name = "txtPhoneHome";
            this.txtPhoneHome.Size = new System.Drawing.Size(189, 32);
            this.txtPhoneHome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(458, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Home:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource2, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(233, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 32);
            this.txtEmail.TabIndex = 4;
            // 
            // btnNewContact
            // 
            this.btnNewContact.BackColor = System.Drawing.Color.Silver;
            this.btnNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewContact.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnNewContact.ForeColor = System.Drawing.Color.Black;
            this.btnNewContact.Location = new System.Drawing.Point(128, 680);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(126, 39);
            this.btnNewContact.TabIndex = 1;
            this.btnNewContact.Text = "&New";
            this.btnNewContact.UseVisualStyleBackColor = false;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(281, 680);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 39);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(431, 680);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "First Name:";
            // 
            // txtFirstNameSearch
            // 
            this.txtFirstNameSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource, "FirstName", true));
            this.txtFirstNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFirstNameSearch.Location = new System.Drawing.Point(124, 42);
            this.txtFirstNameSearch.Name = "txtFirstNameSearch";
            this.txtFirstNameSearch.Size = new System.Drawing.Size(200, 32);
            this.txtFirstNameSearch.TabIndex = 0;
            // 
            // tblContactBindingSource
            // 
            this.tblContactBindingSource.DataMember = "tbl_Contact";
            this.tblContactBindingSource.DataSource = this.contactListDataDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(357, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Last Name:";
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContactBindingSource, "LastName", true));
            this.txtLastNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLastNameSearch.Location = new System.Drawing.Point(469, 47);
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(200, 32);
            this.txtLastNameSearch.TabIndex = 1;
            // 
            // grbSearch
            // 
            this.grbSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.txtLastNameSearch);
            this.grbSearch.Controls.Add(this.txtFirstNameSearch);
            this.grbSearch.Controls.Add(this.label9);
            this.grbSearch.Controls.Add(this.label10);
            this.grbSearch.Font = new System.Drawing.Font("Calibri", 12F);
            this.grbSearch.Location = new System.Drawing.Point(28, 291);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(919, 94);
            this.grbSearch.TabIndex = 6;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            this.grbSearch.Enter += new System.EventHandler(this.grbSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(738, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.Silver;
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnListAll.ForeColor = System.Drawing.Color.Black;
            this.btnListAll.Location = new System.Drawing.Point(584, 680);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(126, 39);
            this.btnListAll.TabIndex = 5;
            this.btnListAll.Text = "View";
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // tbl_ContactTableAdapter
            // 
            this.tbl_ContactTableAdapter.ClearBeforeFill = true;
            // 
            // tblContactBindingSource1
            // 
            this.tblContactBindingSource1.DataMember = "tbl_Contact";
            this.tblContactBindingSource1.DataSource = this.contactListDataDataSet;
            // 
            // contactListDataDataSet2
            // 
            this.contactListDataDataSet2.DataSetName = "ContactListDataDataSet2";
            this.contactListDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblContactBindingSource3
            // 
            this.tblContactBindingSource3.DataMember = "tbl_Contact";
            this.tblContactBindingSource3.DataSource = this.contactListDataDataSet2;
            // 
            // tbl_ContactTableAdapter1
            // 
            this.tbl_ContactTableAdapter1.ClearBeforeFill = true;
            // 
            // frmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 752);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.grbEditData);
            this.Controls.Add(this.grbContactList);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContactList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmContactList_Load);
            this.grbContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet)).EndInit();
            this.grbEditData.ResumeLayout(false);
            this.grbEditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContactList;
        private System.Windows.Forms.GroupBox grbEditData;
        private System.Windows.Forms.DataGridView dgvContacts;
        private ContactListDataDataSet contactListDataDataSet;
        private System.Windows.Forms.BindingSource tblContactBindingSource;
        private ContactListDataDataSetTableAdapters.tbl_ContactTableAdapter tbl_ContactTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneWork;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstNameSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastNameSearch;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Label labelContactID;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.BindingSource tblContactBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblContactBindingSource2;
        private ContactListDataDataSet2 contactListDataDataSet2;
        private System.Windows.Forms.BindingSource tblContactBindingSource3;
        private ContactListDataDataSet2TableAdapters.tbl_ContactTableAdapter tbl_ContactTableAdapter1;
    }
}

