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
            // User user = new User();
            Authorized user = new Authorized();
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
                    user.Password = password_str;
                    user.Login = login_str;
                    user.ID = int.Parse(rdr["user_id"].ToString());
                    user.Permission = int.Parse(rdr["permission_int"].ToString());
                }
            }
            conn.Close();
            conn.Dispose();
            if (user.Permission == 1)
            {
                return new Authorized()
                {
                    ID = user.ID,
                    Password = user.Password,
                    Login = user.Login,
                    Permission = user.Permission
                };
            }
            else if (user.Permission == 2)
            {
                return new HotelAdmin()
                {
                    ID = user.ID,
                    Password = user.Password,
                    Login = user.Login,
                    Permission = user.Permission
                };
            }
            else if (user.Permission == 3)
            {
                return new HotelOwner()
                {
                    ID = user.ID,
                    Password = user.Password,
                    Login = user.Login,
                    Permission = user.Permission
                };
            }
            else if (user.Permission == 4)
            {
                return new Admin()
                {
                    ID = user.ID,
                    Password = user.Password,
                    Login = user.Login,
                    Permission = user.Permission
                };
            }
            else
            {
                return new Unauthorized();
            }
        }
    }
}