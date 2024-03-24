using JobPortal.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace JobPortal.DB
{
    public class DBJob
    {

        string conn = "Data Source=AKSHADA\\MSSQLSERVER01;Initial Catalog=JobPortal;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";


        public string postJobData(ModalJob md)
        {

            SqlConnection sql = new SqlConnection(conn);
            sql.Open();
            SqlCommand cmd = new SqlCommand("proc_JobCreation", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyName", md.CompanyName.ToString());
            cmd.Parameters.AddWithValue("@MinExperience", md.MinExperience.ToString());
            cmd.Parameters.AddWithValue("@MaxExperience", md.MaxExperience.ToString());
            cmd.Parameters.AddWithValue("@Category", md.Category.ToString());
            cmd.Parameters.AddWithValue("@Salary", md.Salary.ToString());
            cmd.Parameters.AddWithValue("@Description", md.Description.ToString());
            cmd.Parameters.AddWithValue("@Type", "I");
            cmd.Parameters.Add("@Result", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            String Results = cmd.Parameters["@Result"].Value.ToString();
            sql.Close();
            return Results;
        }

        //public IEnumerable<ModalUser> getUserData()
        //{
        //    List<ModalUser> list = new List<ModalUser>();
        //    SqlConnection sql = new SqlConnection(conn);
        //    sql.Open();
        //    SqlCommand cmd = new SqlCommand("proc_UserRegistration", sql);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;          
        //    cmd.Parameters.AddWithValue("@Type", "S");
        //    SqlDataReader sd = cmd.ExecuteReader();
        //    while (sd.Read())
        //    {

        //        ModalUser md = new ModalUser();
        //        md.UserId = sd["UserId"].ToString();
        //        md.UserName = sd["UserName"].ToString();
        //        md.Password = sd["Password"].ToString();
        //        md.Email = sd["Email"].ToString();
        //        md.Role = sd["Role"].ToString();
        //        list.Add(md);             
        //    }
        //    sql.Close();
        //    return list.ToArray();
        //}

        //public IEnumerable<ModalUser> getUserDataWithId(int UserId)
        //{
        //    List<ModalUser> list = new List<ModalUser>();
        //    SqlConnection sql = new SqlConnection(conn);
        //    sql.Open();         
        //    SqlCommand cmd = new SqlCommand("proc_UserRegistration", sql);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@UserId", UserId);
        //    cmd.Parameters.AddWithValue("@Type", "S");
        //    SqlDataReader sd = cmd.ExecuteReader();
        //    while (sd.Read())
        //    {
        //        ModalUser md = new ModalUser();
        //        md.UserName = sd["UserName"].ToString();
        //        md.Password = sd["Password"].ToString();
        //        md.Email = sd["Email"].ToString();
        //        md.Role = sd["Role"].ToString();
        //        list.Add(md);
        //    }
        //    sql.Close();
        //    return list.ToArray();
        //}

    }
}
