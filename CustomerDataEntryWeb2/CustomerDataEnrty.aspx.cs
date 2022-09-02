using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Text;
using System.Data;
using static MiddleTier.Class1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerDataEntryWeb2
{
    public partial class CustomerDataEnrty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            customer objCustomer = new customer();
            GridCustomers.DataSource = objCustomer.LoadCustomer();
            GridCustomers.DataBind();
        }

        protected void GridCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearData();
            int Id = Convert.ToInt32(GridCustomers.Rows[GridCustomers.SelectedIndex].Cells[1].Text);
            DisplayCustomer(Id);
        }
        //==================
        int StrId = 0;
        //==================
        private void DisplayCustomer(int Customercode)
        {
            customer objSql = new customer();
            DataSet objDataset = objSql.LoadCustomer(Customercode);
            StrId = Convert.ToInt32(objDataset.Tables[0].Rows[0][0]);
            string strcustName = objDataset.Tables[0].Rows[0][1].ToString();
            string strCountryName = objDataset.Tables[0].Rows[0][2].ToString();
            string strGender = objDataset.Tables[0].Rows[0][3].ToString();
            string strHobbies = objDataset.Tables[0].Rows[0][4].ToString();
            string strStatus = objDataset.Tables[0].Rows[0][5].ToString();
            string strAddress = objDataset.Tables[0].Rows[0][6].ToString();
            txtcustName.Text = strcustName;
            ddlCountry.Text = strCountryName;
            if ((strGender.Length == 0) || (strGender == "Male"))
            {
                Male.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }
            if (strHobbies == "Painting")
            {
                Painting.Checked = true;

            }
            else
            {
                Reading.Checked = true;
            }
            if (strStatus == "Married")
            {
                Married.Checked = true;
            }
            else
            {
                Single.Checked = true;
            }
            txtAddress.Text = strAddress;

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string CustName=txtcustName.Text;
            string Country = ddlCountry.Text ;
            string Gender = "";
            string Hobbies = "";
            string Status = "";
            string Addres=txtAddress.Text;
            int StrId = 0;
            customer objCustomer = new customer();
            objCustomer.CustomerName = txtcustName.Text;
            objCustomer.CountryName = ddlCountry.Text;
            if (CustName.Length == 0)
            {
                MessageBox.Show("Customer Name is Compulsory");
                return;
            }
           
            if (Male.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            objCustomer.Gender = Gender;
            if (Painting.Checked)
            {
                Hobbies = "Painting";
            }
            else
            {
                Hobbies = "Reading";
            }
            objCustomer.Hobbies = Hobbies;
            if (Married.Checked)
            {
                Status = "Married";
            }
            else
            {
                Status = "Single";
            }
            objCustomer.Status = Status;
            objCustomer.Address = Addres;

            //FormCustomerPreview fc = new FormCustomerPreview();
            //fc.SetValues(custName, country, Gender, Hobbies, Status, Address);
            //fc.ShowDialog();

            
            /* obj.InsertCustomers(CustName,     
                                 Country,
                                 Gender,
                                 Hobbies,
                                 Status,
                                 Addres);*/
            objCustomer.Save();                    
            LoadCustomers();
            ClearData();
        }
        private void ClearData()
        {
            txtcustName.Text = "";
            ddlCountry.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            Painting.Checked = false;
            Reading.Checked = false;
            Married.Checked = false;
            Single.Checked = false;
            txtAddress.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int StrId = Convert.ToInt32(GridCustomers.Rows[GridCustomers.SelectedIndex].Cells[1].Text);
            string CustName = txtcustName.Text;
            string Country = ddlCountry.Text;
            string Gender = "";
            string Hobbies = "";
            string Status = "";
            string Addres = txtAddress.Text;

            if (Male.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            if (Painting.Checked)
            {
                Hobbies = "Painting";
            }
            else
            {
                Hobbies = "Reading";
            }
            if (Married.Checked)
            {
                Status = "Married";
            }
            else
            {
                Status = "Single";
            }
            customer obj = new customer();
            obj.CustomerName = txtcustName.Text;
            obj.CountryName = ddlCountry.Text;           
            obj.Gender = Gender;           
            obj.Hobbies = Hobbies;            
            obj.Status = Status;
            obj.Address = txtAddress.Text;
            obj.StrId = StrId;
            obj.Update();            
            LoadCustomers();
            ClearData();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            customer obj = new customer();
            obj.CustomerName = txtcustName.Text;
            obj.Delete();
            ClearData();
            LoadCustomers();
        }
    }
}