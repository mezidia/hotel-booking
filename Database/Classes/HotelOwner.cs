using hotel_booking.SqlConn;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_booking
{
    public class HotelOwner : HotelAdmin
    {
        // methods
        public void ChangeAccess(int user_id, int country_id, int phoneNumber_int,
            string email_str, string login_str, string userName_str, 
            int age_int, string password_str, int permission_int)
        {
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UpdateUser", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = user_id;
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = phoneNumber_int;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = age_int;
            cmd.Parameters.Add("@Country", SqlDbType.Int).Value = country_id;
            cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = permission_int;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, int.MaxValue).Value = userName_str;
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar, int.MaxValue).Value = login_str;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, int.MaxValue).Value = email_str;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, int.MaxValue).Value = password_str;
            // Выполнить процедуру.
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public void RemoveHotel(int hotel_id)
        {
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("RemoveHotel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@hotel_id", SqlDbType.Int) { Value = hotel_id}
            };
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
    }
}