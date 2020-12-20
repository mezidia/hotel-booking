using hotel_booking.SqlConn;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_booking
{
	public class Unauthorized : User
	{
		// methods
		public object[] SignUpLogIn(string login_str, string password_str)
		{
            // User user = new User();
            object[] user= new object[3];
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("LogIn", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar, int.MaxValue).Value = login_str;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, int.MaxValue).Value = password_str;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    user[0] = password_str;
                    user[1] = login_str;
                    user[2] = int.Parse(rdr["user_id"].ToString());
                }
            }
            return user;
        }
	}
}