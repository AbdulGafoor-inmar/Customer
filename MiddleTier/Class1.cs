using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess2;
using System.Data;
using System.Data.SqlClient;

namespace MiddleTier
{
    public class Class1
    {
        public class customer
        {
            private string _CustomerName = "";
            private string _CountryName = "";
            private string _Gender = "";
            private string _Hobbies = "";
            private string _Status = "";
            private string _Address = "";
            private int _StrId = 0;

            public string CustomerName
            {
                get { return _CustomerName; }
                set 
                { 
                    if(value.Length==0)
                    {
                        throw new Exception("Customer name is required");
                    }
                    if(value.Length>20)
                    {
                        throw new Exception("value cannot be greater than 20 characters");
                    }
                    _CustomerName = value;
                }
               
            }
            public string CountryName
            {
                get { return _CountryName; }
             set { _CountryName = value; }

            }
            public string Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }
            public string Hobbies 
            {
                get { return _Hobbies; }
                set { _Hobbies = value; }
            }
            public string Status
            {
                get { return _Status; }
                set { _Status = value; }

            }
            public string Address 
            {
                get { return _Address; }
                set { _Address = value; }

            }

            public int StrId { get => _StrId; set => _StrId = value; }

            public void Save()
            {
                clsSqlServer obj = new clsSqlServer();
                obj.InsertCustomers(_CustomerName,
                                    _CountryName,
                                    _Gender,
                                    _Hobbies,
                                    _Status,
                                    _Address);

            }
            public  void Delete()
            {
                clsSqlServer obj = new clsSqlServer();
                obj.DeleteCustomer(_CustomerName);
            }
            public void Update()
            {
                
                clsSqlServer obj = new clsSqlServer();
                obj.UpdateCustomers(_CustomerName,
                                    _CountryName,
                                    _Gender,
                                    _Hobbies,
                                    _Status,
                                    _Address,
                                    StrId);
            }
            public DataSet LoadCustomer()
            {
                clsSqlServer obj = new clsSqlServer();
                return obj.getCustomers();
            }
            public DataSet LoadCustomer(int CustomerName)
            {
                clsSqlServer obj = new clsSqlServer();
                return obj.getCustomers(CustomerName);
            }
        }
    }
}
