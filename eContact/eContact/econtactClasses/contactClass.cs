using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eContact.econtactClasses
{
    class contactClass
    {
        //getter setter
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            //object dt
            DataTable dt = new DataTable();
            try
            {
                //query
                string sql = "SELECT * FROM tbl_contact";
                //cmd
                SqlCommand cmd = new SqlCommand(sql, conn);
                //dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

               conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        public bool Insert(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql insert query
                string sql = "INSERT INTO tbl_contact(FirstName,LastName,ContactNumber,Address,Gender) VALUES (@FirstName,@LastName,@ContactNumber,@Address,@Gender)";
                //sql command using sql comm
                SqlCommand cmd = new SqlCommand(sql, conn);
                //parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
            }

            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Update(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNumber=@ContactNumber, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //parameters to add values
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(contactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = " DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
