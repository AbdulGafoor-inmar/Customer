using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static MiddleTier.Class1;

namespace CustomerDataEntry
{
    public partial class FormCustomerDataEntry : Form
    {
        public FormCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void Hobbies_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void Country_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            try
            {
                customer objCustomer = new customer();
                objCustomer.CustomerName = txtCustomerName.Text;
                objCustomer.CountryName = cmbCountries.Text;

                string custName = txtCustomerName.Text;
                if (txtCustomerName.Text.Length == 0)
                {
                    MessageBox.Show("Customer Name is Compulsory");
                    return;
                }
                string Gender = "";
                string Hobbies = "";
                string Status = "";
                if (checkMale.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                objCustomer.Gender = Gender;
                if (checkPaint.Checked)
                {
                    Hobbies = "Painting";
                }
                else
                {
                    Hobbies = "Reading";
                }
                objCustomer.Hobbies = Hobbies;
                if (radioMarried.Checked)
                {
                    Status = "Married";
                }
                else
                {
                    Status = "Single";
                }
                objCustomer.Status = Status;
                string Address = txtAddress.Text;
                objCustomer.Address = txtAddress.Text;

                string country = cmbCountries.SelectedItem.ToString();
                objCustomer.Save();

                FormCustomerPreview fc = new FormCustomerPreview();
                fc.SetValues(custName, country, Gender, Hobbies, Status, Address);
                fc.ShowDialog();
                LoadCustomer();
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void FormCustomerDataEntry_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            customer objCustomer = new customer();
            dtgCustomer.DataSource = objCustomer.LoadCustomer().Tables[0];
        }
        //==========================
        int StrId = 0;
        //============================
        private void ClearData()
        {
            txtCustomerName.Text = "";
            cmbCountries.Text = "";
            checkMale.Checked = false;
            checkFemale.Checked = false;
            checkPaint.Checked = false;
            checkRead.Checked = false;
            radioMarried.Checked = false;
            radioSingle.Checked = false;
            txtAddress.Text = "";
        }
        private void DisplayCustomer(int Customercode)
        {
            customer objSql = new customer();
            DataSet objDataset = objSql.LoadCustomer(Customercode);
            StrId = Customercode;
            string strcustName = objDataset.Tables[0].Rows[0][1].ToString();
            string strCountryName = objDataset.Tables[0].Rows[0][2].ToString();
            string strGender = objDataset.Tables[0].Rows[0][3].ToString();
            string strHobbies = objDataset.Tables[0].Rows[0][4].ToString();
            string strStatus = objDataset.Tables[0].Rows[0][5].ToString();
            string strAddress = objDataset.Tables[0].Rows[0][6].ToString();
            txtCustomerName.Text = strcustName;
            cmbCountries.Text = strCountryName;
            if ((strGender.Length == 0) || (strGender == "Male"))
            {
                checkMale.Checked = true;
            }
            else
            {
                checkFemale.Checked = true;
            }
            if (strHobbies == "Painting")
            {
                checkPaint.Checked = true;

            }
            else
            {
                checkRead.Checked = true;
            }
            if (strStatus == "Married")
            {
                radioMarried.Checked = true;
            }
            else
            {
                radioSingle.Checked = true;
            }
            txtAddress.Text = strAddress;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string custName = txtCustomerName.Text;
            customer obj = new customer();
            obj.CustomerName = txtCustomerName.Text;
            obj.Delete();
            LoadCustomer();
            ClearData();
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StrId = Convert.ToInt32(dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
            DisplayCustomer(StrId);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string custName = txtCustomerName.Text;
                if (txtCustomerName.Text.Length == 0)
                {
                    MessageBox.Show("Customer Name is Compulsory");
                    return;
                }
                string Gender = "";
                string Hobbies = "";
                string Status = "";
                if (checkMale.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                if (checkPaint.Checked)
                {
                    Hobbies = "Painting";
                }
                else
                {
                    Hobbies = "Reading";
                }
                if (radioMarried.Checked)
                {
                    Status = "Married";
                }
                else
                {
                    Status = "Single";
                }
                string Address = txtAddress.Text;

                string country = cmbCountries.SelectedItem.ToString();


                FormCustomerPreview fc = new FormCustomerPreview();
                fc.SetValues(custName, country, Gender, Hobbies, Status, Address);
                fc.ShowDialog();
                customer obj = new customer();
                obj.CustomerName = txtCustomerName.Text;
                obj.CountryName = cmbCountries.Text;
                obj.Gender = Gender;
                obj.Hobbies = Hobbies;
                obj.Status = Status;
                obj.Address = txtAddress.Text;
                obj.StrId = StrId;
                obj.Update();
                LoadCustomer();
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
