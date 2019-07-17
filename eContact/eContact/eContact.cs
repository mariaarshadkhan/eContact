using eContact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eContact
{
    public partial class eContact : Form
    {
        public eContact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Gendercb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(CIDtb.Text);
            c.FirstName = FNtb.Text;
            c.LastName = LNtb.Text;
            c.ContactNumber = CNtb.Text;
            c.Address = Addresstb.Text;
            c.Gender = Gendercb.Text;

            //update data in database
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Contact has been successfully Updated.");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Contact.Try Again");

            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(CIDtb.Text);
            bool success = c.Delete(c);
            if (success == true)
            {

                MessageBox.Show("Contacts Are Successfully Deleted ");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();

            }
            else {

                MessageBox.Show("Failed to delete");

            
            }
           
        }

        private void labelCID_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.FirstName = FNtb.Text;
            c.LastName = LNtb.Text;
            c.ContactNumber = CNtb.Text;
            c.Address = Addresstb.Text;
            c.Gender = Gendercb.Text;

            //inserting data into databasse
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact has been successfully Inserted");
                Clear();  
            }
            else
            {
                MessageBox.Show("Failed to add contact. Try Again.");
            }
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void eContact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }
        public void Clear()
        {
            CIDtb.Text = "";
            FNtb.Text = "";
            LNtb.Text = "";
            CNtb.Text = "";
            Addresstb.Text = "";
            Gendercb.Text = ""; 
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            CIDtb.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            FNtb.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            LNtb.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            CNtb.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            Addresstb.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            Gendercb.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();

        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void Searchtb_TextChanged(object sender, EventArgs e)
        {
            string keyword = Searchtb.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_contact where FirstName like %" + keyword + "%", conn);
            //OR LastName like %"+keyword+"% or Address like %"+keyword+ "%",conn);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dgvContactList.DataSource = dt1;
        }
    }
}
