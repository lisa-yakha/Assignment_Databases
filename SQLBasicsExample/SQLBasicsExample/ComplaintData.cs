using LibraryExample;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBasicsExample
{
    internal class ComplaintData
    {
        #region Insert
        public bool InsertNewProduct(Models.ComplaintForm complaint)
        {
            SqlConnection conn = new SqlConnection(Data.connstring);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Complaint", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Reference", complaint.Reference);
                cmd.Parameters.AddWithValue("IsUsed", complaint.IsUsed);
                cmd.Parameters.AddWithValue("DamageOnArrival", complaint.DamageOnArrival);
                cmd.Parameters.AddWithValue("IsWorking", complaint.IsWorking);
                cmd.Parameters.AddWithValue("DamageCaused", complaint.DamageCaused);
                cmd.Parameters.AddWithValue("Complaint", complaint.Complaint);
                cmd.Parameters.AddWithValue("DateOrdered", complaint.DateOrdered);
                cmd.Parameters.AddWithValue("Arrived", complaint.Arrived);
                cmd.Parameters.AddWithValue("DesiredSolution", complaint.DesiredSolution);


                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                conn.Close();

                return false;
            }
        }
        #endregion
    }
}
