using hotel_booking.SqlConn;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_booking
{
    public class HotelOwner : HotelAdmin
    {
        // methods
        public void ChangeAccess()
        {

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
        }
    }
}