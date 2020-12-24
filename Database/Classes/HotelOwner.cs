using hotel_booking.SqlConn;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_booking
{
    public class HotelOwner : HotelAdmin
    {
        // methods
        public void ChangeAccess(object[] hotelfields)
        {
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UpdateUser", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = hotelfields[0];
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = hotelfields[1];
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = hotelfields[2];
            cmd.Parameters.Add("@Country", SqlDbType.Int).Value = hotelfields[3];
            cmd.Parameters.Add("@Permission", SqlDbType.Int).Value = hotelfields[4];
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, int.MaxValue).Value = hotelfields[5];
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar, int.MaxValue).Value = hotelfields[6];
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, int.MaxValue).Value = hotelfields[7];
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, int.MaxValue).Value = hotelfields[8];
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
