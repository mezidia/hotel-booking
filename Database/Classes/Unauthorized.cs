using hotel_booking.SqlConn;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_booking
{
	public class Unauthorized : User
	{
		// methods
		public User SignUpLogIn(string login_str, string password_str)
		{
            User user = new User();
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
                    user.password_str = password_str;
                    user.login_str = login_str;
                    user.user_id = int.Parse(rdr["user_id"].ToString());
                }
            }
            return user;
        }
	}
}