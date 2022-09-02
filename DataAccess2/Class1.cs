using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DataAccess2
{
    public class clsSqlServer
    {
        public DataSet getCustomers()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand("Select * from Demo ", objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdaptar = new SqlDataAdapter(objCommand);
            objAdaptar.Fill(objDataset);

            objConnection.Close();
            return objDataset;
        }
        public DataSet getCustomers(int Customercode)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            string query = "Select * from Demo where Id = " + Customercode + "";
            SqlCommand objCommand = new SqlCommand(query, objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdaptar = new SqlDataAdapter(objCommand);
            objAdaptar.Fill(objDataset);

            objConnection.Close();
            return objDataset;
        }
    
        public bool InsertCustomers(string custName,
                                    string country,
                                    string Gender,
                                    string Hobbies,
                                    string Status,
                                    string Address)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            try
            {
                
                String query = "Insert into Demo values('" + custName + "','" + country + "','" + Gender + "','" + Hobbies + "','" + Status + "','" + Address + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Sucssesfully...!");
                }
                else
                {
                    MessageBox.Show("Failed....!");
                }
                
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
   
        public bool UpdateCustomers(string custName,
                                    string country,
                                    string Gender,
                                    string Hobbies,
                                    string Status,
                                    string Address,
                                    int StrId)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "Update Demo set custName='" + custName + "',Country='"
                                                        + country + "',Gender='"
                                                        + Gender + "',Hobbies='"
                                                        + Hobbies + "',Status='"
                                                        + Status + "',Address='"
                                                        + Address + "' where Id="
                                                        + StrId + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated Sucssesfully...!");
            }
            else
            {
                MessageBox.Show("Failed....!");
            }
            conn.Close();
            return true;
        }
        
        public bool DeleteCustomer(string custName)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand("delete from Demo where custName ='"
                                                    + custName + "'",
                                                    objConnection);
            // objCommand.ExecuteNonQuery();
            int a = objCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted Sucssesfully...!");
            }
            else
            {
                MessageBox.Show("Failed....!");
            }
            objConnection.Close();
            return true;
        }
    }

}
