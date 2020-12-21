using System;
using System.Collections.Generic;
using System.Text;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_booking
{
	public class Admin : Authorized
	{
        //input:  User id, permission int
	//output: true if permission changed successfully or false if smt went wrong
        public bool ChangePermissions(int id, int permission)
		{
            bool state;
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ChangePermissions", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@UserdID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Permissions", SqlDbType.Int).Value = permission;

            // Выполнить процедуру.
            try
            {
                cmd.ExecuteNonQuery();
                state = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                state = false;
            }
            conn.Close();
            conn.Dispose();
            return state;
        }
	}
}
