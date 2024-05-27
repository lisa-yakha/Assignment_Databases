using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryExample;

namespace SQLBasicsExample
{
    public class InventoryData
    {
        #region Insert
        public bool InsertInventory(Models.Inventory inventory)
        {
            SqlConnection conn = new SqlConnection(Data.connstring);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT_Inventory", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ProductReference", inventory.ProductReference);
                cmd.Parameters.AddWithValue("Amount", inventory.Amount);

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

        #region Update
        public bool UpdateInventoryAmount(int id, int currentAmount)
        {
            SqlConnection conn = new SqlConnection(Data.connstring);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE_InventoryAmount", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("InventoryId",  id);
                cmd.Parameters.AddWithValue("Amount", currentAmount);


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
