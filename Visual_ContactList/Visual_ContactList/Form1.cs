using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_ContactList
{
    public partial class frmContactList : Form
    {
        //-----------------------------------------------------------------------------------------
        public enum DataBaseOperation
        {
            Create = 0,
            Read = 1,
            Update = 2,
            Delete = 3
        };
        DataBaseOperation _currentOperation;
        
        public frmContactList()
        {
            InitializeComponent();
        }

        private void frmContactList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactListDataDataSet2.tbl_Contact' table. You can move, or remove it, as needed.
            this.tbl_ContactTableAdapter1.Fill(this.contactListDataDataSet2.tbl_Contact);
            // TODO: This line of code loads data into the 'contactListDataDataSet.tbl_Contact' table. You can move, or remove it, as needed.
            this.tbl_ContactTableAdapter.Fill(this.contactListDataDataSet.tbl_Contact);
            _currentOperation = DataBaseOperation.Read;
            this.Text = Properties.Resources.EnglishProgramTitle;
        }

        private void clear_entry()
        {
            TextBox t = new TextBox();
            foreach (var item in grbEditData.Controls)
            {
                if (item.GetType() == t.GetType())
                {
                    t = (TextBox)item;
                    t.Clear();
                }//if it is a text box
            }

            foreach (var item in grbSearch.Controls)
            {
                if (item.GetType() == t.GetType())
                {
                    t = (TextBox)item;
                    t.Clear();
                }//if it is a text box
            }
        }

        private bool check_data_entry()
        {
            bool result = false;
            if ((txtFirstName.Text.Length > 0) && (txtLastname.Text.Length > 0))
            {
                result = true;
            }//if
            return result;
        }

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContacts.CurrentRow.Cells[1].Value.ToString() != "")
            {
                txtContactID.Text = dgvContacts.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                txtLastname.Text = dgvContacts.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvContacts.CurrentRow.Cells[3].Value.ToString();
                txtPhoneHome.Text = dgvContacts.CurrentRow.Cells[4].Value.ToString();
                txtPhoneWork.Text = dgvContacts.CurrentRow.Cells[5].Value.ToString();
                txtMobile.Text = dgvContacts.CurrentRow.Cells[6].Value.ToString();
                txtAddress.Text = dgvContacts.CurrentRow.Cells[7].Value.ToString();
            }//if


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear_entry();
            grbEditData.Enabled = false;
            _currentOperation = DataBaseOperation.Read;
            btnNewContact.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            clear_entry();
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            clear_entry();
            grbEditData.Enabled = true;
            _currentOperation = DataBaseOperation.Create;
            btnNewContact.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";
            if (txtFirstName.Text.Length == 0)
            {
                strMessage = "Please select a contact first";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _currentOperation = DataBaseOperation.Update;
                grbEditData.Enabled = true;
                btnNewContact.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";
            if (check_data_entry())
            {
                if (_currentOperation == DataBaseOperation.Create)
                {
                    if (check_contact_existance())
                    {
                        strMessage = "The Contact Already exists";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//if contact already exists
                    else
                    {
                        tbl_ContactTableAdapter.InsertNewContact(txtFirstName.Text.Trim(), txtLastname.Text.Trim(), txtEmail.Text.Trim(), txtPhoneHome.Text, txtPhoneWork.Text.Trim(), txtMobile.Text.Trim(), txtAddress.Text.Trim());
                        tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
                        clear_entry();
                        grbEditData.Enabled = false;
                        btnNewContact.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        strMessage = "One Record is added";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else if (_currentOperation == DataBaseOperation.Update)
                {
                    if (check_contact_existance(int.Parse(txtContactID.Text), txtFirstName.Text, txtLastname.Text))
                    {
                        strMessage = "The Contact Already exists";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//if contact is duplicated 
                    else
                    {
                        tbl_ContactTableAdapter.UpdateContact(txtFirstName.Text.Trim(), txtLastname.Text.Trim(), txtEmail.Text.Trim(), txtPhoneHome.Text, txtPhoneWork.Text.Trim(), txtMobile.Text.Trim(), txtAddress.Text.Trim(), int.Parse(txtContactID.Text));
                        tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
                        clear_entry();
                        grbEditData.Enabled = false;
                        btnNewContact.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        strMessage = "One Record is updated";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                strMessage = "Please at least enter First and last name";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _currentOperation = DataBaseOperation.Delete;
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";
            if (txtFirstName.Text.Length == 0)
            {
                strMessage = "Please select a contact first";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//if nothing is selected
            else
            {
                strMessage = "Are you sure that you want to remove the following record?";
                strMessage += "\n" + txtFirstName.Text + " " + txtLastname.Text;
                DialogResult res = MessageBox.Show(strMessage, strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    int r = tbl_ContactTableAdapter.DeleteContact(int.Parse(txtContactID.Text));
                    if (r > 0)
                    {
                        tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
                        clear_entry();
                        strMessage = "One record is removed";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }//if removed
                    else
                    {
                        strMessage = "It was not possible to remove record, please try again";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }//if Yes is clicked
            }//else if record is loaded
        }
        private bool check_contact_existance()
        {
            bool result = false;
            tbl_ContactTableAdapter.FillByFirstNameAndLastName(contactListDataDataSet.tbl_Contact, txtFirstName.Text.Trim(), txtLastname.Text.Trim());
            if (contactListDataDataSet.tbl_Contact.Rows.Count > 0)
            {
                result = true;
            }//if record already exists
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
            return result;
        }//check_contact_existance
        //-----------------------------------------------------------------------------------------
        private bool check_contact_existance(int contactID, string firstname, string lastname)
        {
            bool result = false;
            tbl_ContactTableAdapter.FillByFirstnameLastNameContactID(contactListDataDataSet.tbl_Contact, contactID, firstname, lastname);
            if (contactListDataDataSet.tbl_Contact.Rows.Count > 0)
            {
                result = true;
            }//if record already exists
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
            return result;
        }//check_contact_existance
      
        //-----------------------------------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";


            if ((txtFirstNameSearch.Text.Length == 0) && (txtLastNameSearch.Text.Length == 0))
            {
                strMessage = "Search is possible on First and Last name of the contact";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//if searchbox is empty
            else {
                if ((txtFirstNameSearch.Text.Length > 0) && (txtLastNameSearch.Text.Length == 0)){
                    tbl_ContactTableAdapter.Fill_SearchByFirstname(contactListDataDataSet.tbl_Contact,txtFirstNameSearch.Text); 
                }//if search is based on firstname
                else if ((txtFirstNameSearch.Text.Length == 0) && (txtLastNameSearch.Text.Length > 0))
                {
                    tbl_ContactTableAdapter.FillBy_SearchByLastName(contactListDataDataSet.tbl_Contact, txtLastNameSearch.Text);
                }//else if search is based on Lastname
                else if ((txtFirstNameSearch.Text.Length > 0) && (txtLastNameSearch.Text.Length > 0))
                {
                    tbl_ContactTableAdapter.FillBy_SearchByFirstnameAndLastName(contactListDataDataSet.tbl_Contact,txtFirstNameSearch.Text, txtLastNameSearch.Text);
                }//else if search is based on firstname and 


            }//else if data is entered
        }//btnSearch_Click
        //-----------------------------------------------------------------------------------------
        private void btnListAll_Click(object sender, EventArgs e)
        {
            clear_entry();
            grbEditData.Enabled = false;
            _currentOperation = DataBaseOperation.Read;
            btnNewContact.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            clear_entry();            
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
        }//btnListAll_Click

        private void grbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void grbEditData_Enter(object sender, EventArgs e)
        {

        }

        private void txtContactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContactID_TextChanged_1(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------
    }//Form
}//Visual_ContactList
